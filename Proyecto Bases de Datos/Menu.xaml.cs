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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_seguridad_Click(object sender, RoutedEventArgs e)
        {
            Seguridad s = new Seguridad();
            s.Show();
            this.Close();
        }

        private void btn_respaldos_Click(object sender, RoutedEventArgs e)
        {
            Respaldos res = new Respaldos();
            res.Show();
            this.Close();
        }

        private void btn_performance_Click(object sender, RoutedEventArgs e)
        {
            Performance per = new Performance();
            per.Show();
            this.Close();
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_auditoria_Click(object sender, RoutedEventArgs e)
        {
            Auditoria au = new Auditoria();
            au.Show();
            this.Close();
        }

        private void btn_BD_Click(object sender, RoutedEventArgs e)
        {
            BD bd = new BD();
            bd.Show();
            this.Close();
        }

        private void btn_tunning_Click(object sender, RoutedEventArgs e)
        {
            Tunning tu = new Tunning();
            tu.Show();
            this.Close();
        }
    }
}
