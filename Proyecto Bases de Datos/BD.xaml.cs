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
    /// Lógica de interacción para BD.xaml
    /// </summary>
    public partial class BD : Window
    {
        public BD()
        {
            InitializeComponent();
        }

        private void btn_menuS_Click(object sender, RoutedEventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Close();
        }
    }
}
