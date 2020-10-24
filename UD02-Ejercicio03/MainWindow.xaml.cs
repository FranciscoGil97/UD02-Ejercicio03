using System.Windows;
using System.Windows.Media;


namespace UD02_Ejercicio03
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpacidadRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)altaRadioBoton.IsChecked)
                imagen.Opacity = 1;
            else
                imagen.Opacity = (bool)mediaRadioBoton.IsChecked ? 0.6 : 0.3;
        }

        private void AjusteRadioBoton_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rellenoRadioBoton.IsChecked)
                imagen.Stretch = Stretch.Fill;
            else if ((bool)uniformeRadioBoton.IsChecked)
                imagen.Stretch = Stretch.Uniform;
            else if ((bool)rellenoUniformeRadioBoton.IsChecked)
                imagen.Stretch = Stretch.UniformToFill;
            else
                imagen.Stretch = Stretch.None;

        }
    }
}
