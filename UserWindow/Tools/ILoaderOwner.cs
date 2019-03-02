using System.ComponentModel;

namespace CSharp_02.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        System.Windows.Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}