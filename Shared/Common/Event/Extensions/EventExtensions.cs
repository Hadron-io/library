using System;

namespace Hadron.Shared.Common.Event.Extensions
{
    public static class EventExtensions
    {
        public static void Raise(this EventHandler handler, object sender, EventArgs eventArgs)
        {
            if (handler != null)
            {
                handler(sender, eventArgs);
            }
        }

        public static void Raise<T>(this EventHandler<T> handler, object sender, T eventArgs)
        {
            if (handler != null)
            {
                handler(sender, eventArgs);
            }
        }
    }
}
