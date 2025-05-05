using Microsoft.Win32;
using OfficeOpenXml;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IList<ExcelPackage> _files;
        
        public MainWindow()
        {
            InitializeComponent();

            _files = new List<ExcelPackage>();
        }

        private void button_addFile_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() ?? false)
            {
                var package = new ExcelPackage(ofd.FileName);
                listBox_files.Items.Add(ofd.FileName);
            }
        }

        private void button_removeFile_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_files.SelectedItem == null)
            {
                e.Handled = true;
                return;
            }
            else
            {
                //_files.FirstOrDefault(item => item.File.)
            }
        }
    }
}