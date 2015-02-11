using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Hadron.Api.Shared.Formatters.ProtoBuf
{
    public static class ProtoBufFormatterExtensions
    {
        /// <summary>
        /// Sends a POST request as an asynchronous operation, with a specified value serialized as ProtoBuf bytes.
        /// </summary>
        /// 
        /// <returns>
        /// A task object representing the asynchronous operation.
        /// </returns>
        /// <param name="client">The client used to make the request.</param><param name="requestUri">The URI the request is sent to.</param><param name="value">The value to write into the entity body of the request.</param><typeparam name="T">The type of object to serialize.</typeparam>
        public static Task<HttpResponseMessage> PostAsProtoAsync<T>(this HttpClient client, string requestUri, T value)
        {
            return client.PostAsProtoAsync(requestUri, value, CancellationToken.None);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation, with a specified value serialized as ProtoBuf bytes. 
        /// Includes a cancellation token to cancel the request.
        /// </summary>
        /// 
        /// <returns>
        /// A task object representing the asynchronous operation.
        /// </returns>
        /// <param name="client">The client used to make the request.</param><param name="requestUri">The URI the request is sent to.</param><param name="value">The value to write into the entity body of the request.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><typeparam name="T">The type of object to serialize.</typeparam>
        public static Task<HttpResponseMessage> PostAsProtoAsync<T>(this HttpClient client, string requestUri, T value, CancellationToken cancellationToken)
        {
            return client.PostAsync(requestUri, value, new ProtoBufMediaTypeFormatter(), cancellationToken);
        }

        #region PUT

        /// <summary>
        /// Sends a PUT request as an asynchronous operation, with a specified value serialized as ProtoBuf bytes.
        /// </summary>
        /// 
        /// <returns>
        /// A task object representing the asynchronous operation.
        /// </returns>
        /// <param name="client">The client used to make the request.</param><param name="requestUri">The URI the request is sent to.</param><param name="value">The value to write into the entity body of the request.</param><typeparam name="T">The type of object to serialize.</typeparam>
        public static Task<HttpResponseMessage> PutAsProtoAsync<T>(this HttpClient client, string requestUri, T value)
        {
            return client.PutAsProtoAsync<T>(requestUri, value, CancellationToken.None);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation, with a specified value serialized as ProtoBuf bytes. Includes a cancellation token to cancel the request.
        /// </summary>
        /// 
        /// <returns>
        /// A task object representing the asynchronous operation.
        /// </returns>
        /// <param name="client">The client used to make the request.</param><param name="requestUri">The URI the request is sent to.</param><param name="value">The value to write into the entity body of the request.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation. </param><typeparam name="T">The type of object to serialize.</typeparam>
        public static Task<HttpResponseMessage> PutAsProtoAsync<T>(this HttpClient client, string requestUri, T value, CancellationToken cancellationToken)
        {
            return client.PutAsync<T>(requestUri, value, new ProtoBufMediaTypeFormatter(), cancellationToken);
        }

        #endregion
    }
}
