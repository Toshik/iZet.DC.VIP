using System;

namespace iZet.DC.VIP.Attributes
{
    /// <summary>
    /// Enables automatic RaisePropertyChanged transformation for class or property
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class MagicAttribute : Attribute { }
}