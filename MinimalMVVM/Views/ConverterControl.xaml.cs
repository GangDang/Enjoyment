using System.IO;
using System.Windows;
using System.Windows.Input;

namespace MinimalMVVM.Views
{
    public partial class ConverterControl
    {
        public static readonly RoutedCommand Open = new RoutedCommand("Open", typeof(ConverterControl));
        public static readonly RoutedCommand DetailInfo = new RoutedCommand("DetailInfo", typeof(ConverterControl));
        public ConverterControl()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(Open, delegate (object obj, ExecutedRoutedEventArgs e) { MessageBox.Show("open"); }));
            CommandBindings.Add(new CommandBinding(DetailInfo, delegate (object obj, ExecutedRoutedEventArgs e) { MessageBox.Show("Info"); }));

            FileInfo[] fileInfos = new DirectoryInfo(@"C:\Users\zhangdafeng\Desktop\ObjectAttachFile\").GetFiles("*.*");
            this.DataFileName.ItemsSource = fileInfos;
        }

    }
}
