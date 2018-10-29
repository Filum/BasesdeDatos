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
    /// 

    
    
        
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
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                //OracleCommand comando = new OracleCommand();
                //comando.Connection = conn;
                //comando.CommandText = "SELECT CEDULAJURIDICA FROM TBL_PROVEEDORES WHERE CEDULAJURIDICA = " + v_CedJur;
                //OracleDataReader dr = comando.ExecuteReader();
                MessageBox.Show("Se ha conectado correctamente con la base de Datos");
                Menu ventana = new Menu();
                ventana.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo establecer una conexión con la base de datos", "Error");
            }
                        
        }
    }
}
