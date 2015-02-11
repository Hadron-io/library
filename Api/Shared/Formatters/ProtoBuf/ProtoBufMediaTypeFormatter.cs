using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace Hadron.Api.Shared.Formatters.ProtoBuf
{
    public class ProtoBufMediaTypeFormatter : MediaTypeFormatter
    {
        public ProtoBufMediaTypeFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/proto"));
        }

        public override bool CanReadType(Type type)
        {
            return type.Any<ProtoContractAttribute>();
        }

        public override bool CanWriteType(Type type)
        {
            return type.Any<ProtoContractAttribute>();
        }

        public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            return Task.Factory.StartNew(() => Serializer.NonGeneric.Deserialize(type, readStream));
        }

        public override Task WriteToStreamAsync(Type type, object value, Stream stream, HttpContent content, TransportContext transportContext)
        {
            return Task.Factory.StartNew(() => Serializer.Serialize(stream, value));
        }
    }
}
