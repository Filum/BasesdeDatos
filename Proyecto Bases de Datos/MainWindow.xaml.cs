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
using Oracle.DataAccess.Client;
using System.Data;


namespace Proyecto_Bases_de_Datos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void conectar_Click(object sender, RoutedEventArgs e)
        {


            try
            {

                OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=DELRAM;PASSWORD ="+ tbx_contraseña.Text);
                conn.Open();
                MessageBox.Show("conectado correctamente a la base de datos");
                Conexion contraseña = new Conexion();
                contraseña.contraseña = tbx_contraseña.Text;
                tablespaces tab = new tablespaces();
                tab.Show();
                this.Close();
                conn.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo establecer una conexión con la base de datos","Error");
            }


            
        }
    }
}
