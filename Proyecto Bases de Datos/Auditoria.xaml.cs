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
                string v_Conn = "DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=" + txt_usuario.Text + ";PASSWORD = " + txt_contraseña.Text + "";
                OracleConnection conn = new OracleConnection(v_Conn);
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "Select * from user_obj_audit_opts";
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

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                OracleDataReader dr;

                if (cbox_delete.IsChecked == true)
                {
                    comando.CommandText = "Audit delete on "+txt_tablayschema.Text+" by access"; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                if (cbox_select.IsChecked == true)
                {
                    comando.CommandText = "Audit select on " + txt_tablayschema.Text + " by access"; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                if (cbox_update.IsChecked == true)
                {
                    comando.CommandText = "Audit update on " + txt_tablayschema.Text + " by access"; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }

                if (cbox_insert.IsChecked == true)
                {
                    comando.CommandText = "Audit insert on " + txt_tablayschema.Text + " by access"; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }

                if (cbox_full.IsChecked == true)
                {
                    comando.CommandText = "Audit all on " + txt_tablayschema.Text + " by access"; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al enviar comandos");
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "Select name, value from v$parameter where name like 'audit_trail'";
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

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                OracleDataReader dr;

                if (cbox_delete.IsChecked == true)
                {
                    comando.CommandText = "NOAudit delete on " + txt_tablayschema.Text ; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                if (cbox_select.IsChecked == true)
                {
                    comando.CommandText = "NOAudit select on " + txt_tablayschema.Text ; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                if (cbox_update.IsChecked == true)
                {
                    comando.CommandText = "NOAudit update on " + txt_tablayschema.Text ; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }

                if (cbox_insert.IsChecked == true)
                {
                    comando.CommandText = "NOAudit insert on " + txt_tablayschema.Text ; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }

                if (cbox_full.IsChecked == true)
                {
                    comando.CommandText = "NOAudit all on " + txt_tablayschema.Text; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al enviar comandos");
            }
        }
    }
}
