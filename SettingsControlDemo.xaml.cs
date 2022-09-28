using System.Windows.Controls;

namespace User.PluginSdkDemo
{
    /// <summary>
    /// Logique d'interaction pour SettingsControlDemo.xaml
    /// </summary>
    public partial class SettingsControlDemo : UserControl
    {
        public SystemMonitorPlugin Plugin { get; }

        public SettingsControlDemo()
        {
            InitializeComponent();
        }

        public SettingsControlDemo(SystemMonitorPlugin plugin) : this()
        {
            this.Plugin = plugin;
        }

        private void RadioButton_Checked(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void SHToggleButton_Checked(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void RadioButton_IsEnabledChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
