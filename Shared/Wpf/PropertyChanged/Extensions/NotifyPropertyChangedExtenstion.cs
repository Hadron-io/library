using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Hadron.Shared.Wpf.PropertyChanged.Extensions
{
    public static class NotifyPropertyChangedExtenstion
    {
        //TODO: Add comment
        public static void Notify<T, TProp>(this T sender, PropertyChangedEventHandler handler, Expression<Func<TProp>> property)
            where T : INotifyPropertyChanged
        {
            if (property != null)
            {
                var member = property.Body as MemberExpression;
                if (member == null) throw new ArgumentException("Property must be a property", "property");

                sender.Notify(handler, member.Member.Name);
            }
        }

        //TODO: Add comment
        public static void Notify<T>(this T sender, PropertyChangedEventHandler handler, [CallerMemberName] string propertyName = "")
            where T : INotifyPropertyChanged
        {
            if (handler != null)
            {
                handler(sender, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
