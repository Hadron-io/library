using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Hadron.Shared.Wpf.PropertyChanged.Extensions
{
    public static class SetNotifyPropertyChangedExtenstion
    {
        //TODO: Add comment
        public static void SetAndNotify<T, TProp>(this T sender, PropertyChangedEventHandler handler, ref TProp field, TProp value, Expression<Func<TProp>> property)
            where T : INotifyPropertyChanged
        {
            bool newValue = SetField(ref field, value);

            if (newValue)
            {
                sender.Notify(handler, property);
            }
        }

        //TODO: Add comment
        public static void SetAndNotify<T, TProp>(this T sender, PropertyChangedEventHandler handler, ref TProp field, TProp value, [CallerMemberName] string propertyName = "")
    where T : INotifyPropertyChanged
        {
            bool newValue = SetField(ref field, value);

            if (newValue)
            {
                sender.Notify(handler, propertyName);
            }
        }

        //TODO: Add comment
        private static bool SetField<T>(ref T field, T value)
        {
            if (!object.Equals(field, value))
            {
                field = value;
                return true;
            }

            return false;
        }

    }
}
