using Oracle.DataAccess.Client;
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "CREATE TABLESPACE " + txt_nombretablespace.Text + " DATAFILE 'C:/oraclexe/app/oracle/oradata/XE/" + txt_nombretablespace.Text+".dbf' SIZE "+txt_tamañotablespace.Text+"M ONLINE";
                OracleDataReader dr = comando.ExecuteReader();
                lbl_respuesta1.Foreground = Brushes.Green;
                lbl_respuesta1.Content = "Se creo el Tablespace  " + txt_nombretablespace.Text + " y el erchivo " + txt_nombretablespace.Text + ".DBF correctamente";
                conn.Close();
            }
            catch
            {
                lbl_respuesta1.Foreground = Brushes.Red;
                lbl_respuesta1.Content= "No se pudo crear el tablespace!";
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "CREATE TEMPORARY TABLESPACE " + txt_nombretemporal.Text + "_TEMP TEMPFILE 'C:/oraclexe/app/oracle/oradata/XE/" + txt_nombretemporal.Text + "_TEMP.dbf' SIZE " + txt_tamañotemporal.Text + "M AUTOEXTEND on";
                OracleDataReader dr = comando.ExecuteReader();
                lbl_respuesta2.Foreground = Brushes.Green;
                lbl_respuesta2.Content = "Se creo el Tablespace Temporal " + txt_nombretablespace.Text + "_TEMP y el erchivo " + txt_nombretablespace.Text + "_TEMP.DBF correctamente";
                conn.Close();
            }
            catch
            {
                lbl_respuesta2.Foreground = Brushes.Red;
                lbl_respuesta2.Content = "No se pudo crear el tablespace temporal";
            }
        }
    }
}
