using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string imagePath = "Img/foto1.jpg";
            string absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            FlowDocument flowDocument = (FlowDocument)FindResource("Document1Key");
            flowDocument.DataContext = new { ImageSource = new BitmapImage(new Uri(absolutePath)) };
            flowDocumentReader.Document = flowDocument;

            imagePath = "Img/foto2.jpg";
            absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            flowDocument = (FlowDocument)FindResource("Document2Key");
            flowDocument.DataContext = new { ImageSource = new BitmapImage(new Uri(absolutePath)) };
            flowDocumentReader.Document = flowDocument;

            imagePath = "Img/foto3.jpg";
            absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            flowDocument = (FlowDocument)FindResource("Document3Key");
            flowDocument.DataContext = new { ImageSource = new BitmapImage(new Uri(absolutePath)) };
            flowDocumentReader.Document = flowDocument;

            imagePath = "Img/foto4.jpg";
            absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            flowDocument = (FlowDocument)FindResource("Document4Key");
            flowDocument.DataContext = new { ImageSource = new BitmapImage(new Uri(absolutePath)) };
            flowDocumentReader.Document = flowDocument;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedItem = listBox.SelectedItem as ListBoxItem;
            if (selectedItem != null)
            {
                string selectedDocument = selectedItem.Content.ToString();
                FlowDocument document = null;

                switch (selectedDocument)
                {
                    case "Вкусный украинский борщ":
                        document = (FlowDocument)FindResource("Document1Key");
                        break;
                    case "Вареники":
                        document = (FlowDocument)FindResource("Document2Key");
                        break;
                    case "Галушки":
                        document = (FlowDocument)FindResource("Document3Key");
                        break;
                    case "Котлета по-киевски":
                        document = (FlowDocument)FindResource("Document4Key");
                        break;
                }

                if (document != null)
                {
                    flowDocumentReader.Document = document;
                }
            }
        }

    }
}
