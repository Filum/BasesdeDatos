using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para Auditoria.xaml
    /// </summary>
    public partial class Auditoria : Window
    {
        public Auditoria()
        {
            InitializeComponent();
        }

        private void btn_menuS_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "Select name, value from v$parameter where name like 'audit_trail' ";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_datos.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar datos de la tabla");
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = " Alter system set audit_trail =DB scope = spfile";
                OracleDataReader dr = comando.ExecuteReader();
                conn.Close();
                MessageBox.Show("Comando enviado");
            }
            catch
            {
                MessageBox.Show("Error enviar el comando");
            }
        }
    }
}
