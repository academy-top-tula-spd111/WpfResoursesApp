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

namespace WpfResoursesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/MyResources.xaml") };

            // static resourse
            btn1.Background = (Brush)this.TryFindResource("magentaBrush");
            // dynamic resourse
            btn2.SetResourceReference(Button.BackgroundProperty, "magentaBrush");

            RadialGradientBrush radial = new();
            radial.GradientStops.Add(new GradientStop() { Color = Colors.Red, Offset = 0 });
            radial.GradientStops.Add(new GradientStop() { Color = Colors.Blue, Offset = 1 });


            this.Resources.Add("radialBrush", radial);
            this.Resources.Add("Products", new string[] { "Computers", "Notebooks", "Phones", "Refregerators" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.TryFindResource("magentaBrush") != null)
                this.Resources["magentaBrush"] = new SolidColorBrush(Colors.Yellow);
        }
    }
}
