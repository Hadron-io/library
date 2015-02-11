using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Hadron.Shared.Wpf.PropertyChanged.Extensions;

namespace Hadron.Shared.Wpf.PropertyChanged
{
    public abstract class NotifyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //TODO: Add comment
        protected virtual void SetAndNotify<T>(ref T field, T value, Expression<Func<T>> property)
        {
            this.SetAndNotify(PropertyChanged, ref field, value, property);
        }

        //TODO: Add comment
        protected virtual void SetAndNotify<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            this.SetAndNotify(PropertyChanged, ref field, value, propertyName);
        }

        //TODO: Add comment
        protected virtual void Notify<T>(Expression<Func<T>> property)
        {
            this.Notify(PropertyChanged, property);
        }

        //TODO: Add comment
        protected virtual void Notify([CallerMemberName] string propertyName = "")
        {
            this.Notify(PropertyChanged, propertyName);
        }
    }
}
