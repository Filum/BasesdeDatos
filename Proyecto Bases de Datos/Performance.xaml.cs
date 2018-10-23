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
using System.Windows.Shapes;

namespace Proyecto_Bases_de_Datos
{
    /// <summary>
    /// Lógica de interacción para Performance.xaml
    /// </summary>
    public partial class Performance : Window
    {
        public Performance()
        {
            InitializeComponent();
        }

        private void btn_menuS_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Close();
        }
    }
}
