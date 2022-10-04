using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace User.PluginSdkDemo
{
    /// <summary>
    /// Settings class, make sure it can be correctly serialized using JSON.net
    /// </summary>
    public class DataPluginDemoSettings : INotifyPropertyChanged
    {
        public bool Setting1 { get; set; } = false;
        public bool Setting2 { get; set; } = true;

        public int CPUWarning { get; set; } = 0;
        public int GPUWarning { get; set; } = 0;

        // These settings are made accesssible to the user via the UI
        // They are binded to toggle switches in SettingsControlDemo.xaml
        // Settings are saved in C:\Program Files (x86)\SimHub\PluginsData\Common\PLuginNane.json whe the plugin closes

        #region Property supporting UI refresh from code
        /*
        private string _FilePath;
        public string FilePath
        {
            get => _FilePath;
            set => SetField(ref _FilePath, value);
        }
        */
        #endregion

        #region Utilities methods to refresh the UI see https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=netframework-4.7.2

        protected void OnPropertyChanged(string propertyName)
          => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
