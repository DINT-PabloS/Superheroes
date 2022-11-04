using Superheroes.VistasModelo;
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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVN vm = new MainWindowVN();
        public MainWindow()
        {
            InitializeComponent();


            this.DataContext = vm;
            /*
             cantidadSupers = listaSupers.Count
             numeroSupers_TextBlock = heroe + "/" + cantidadSupers
             fondo_DockPanel.DataContext = listaSupers[heroe - 1]
             */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Image boton = (Image)sender;
            if (boton.Tag.ToString() == "-")
            {
                vm.Retroceder();
            }
            else
            {
                vm.Avanzar();
            }
        }
    }
}
