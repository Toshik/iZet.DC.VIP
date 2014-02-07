using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using iZet.DC.VIP.Annotations;
using iZet.DC.VIP.Attributes;
using iZet.DC.VIP.Helpers;

namespace iZet.DC.VIP.Models
{
    public class BaseModel<T> : INotifyPropertyChanged
        where T: BaseModel<T>
    {
        
        #region Instance
        private static T instance;
        public static T Instance
        {
            get
            {
                return instance ?? (instance = ObjectHelper.InstantinateClass<T>());
            }
        }

        protected BaseModel()
        {
            
        }
        #endregion

        #region INotifyPropertyChanged members

        /// <summary>
        /// Indicates RaisePropertyChanged injection point 
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        protected static void Raise() { }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var e = PropertyChanged;
            if (e != null)
                e(this, new PropertyChangedEventArgs(propertyName)); // you may provide different dispatch login 
        }
        #endregion
    }
}
