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
                comando.CommandText = "CREATE TABLESPACE " + txt_nombretablespace.Text + " DATAFILE 'C:/oraclexe/app/oracle/oradata/XE/" + txt_nombretablespace.Text + ".dbf' SIZE " + txt_tamañotablespace.Text + "M ONLINE";
                OracleDataReader dr = comando.ExecuteReader();
                lbl_respuesta1.Foreground = Brushes.Green;
                lbl_respuesta1.Content = "Se creo el Tablespace  " + txt_nombretablespace.Text + " y el erchivo " + txt_nombretablespace.Text + ".DBF correctamente";
                conn.Close();
            }
            catch
            {
                lbl_respuesta1.Foreground = Brushes.Red;
                lbl_respuesta1.Content = "No se pudo crear el tablespace!";
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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = " select file_name from dba_data_files;";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_tablespaces.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)tabla_tablespaces.SelectedItem;
                string cellvalue = view.Row.ItemArray[0].ToString();
                txt_tablespaceseleccionado.Text = cellvalue;
            }
            catch
            {
                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (txt_tablespaceseleccionado.Text != "" && txt_tamaño.Text != "")
                {
                    OracleConnection conn = DataBase.Conexion();
                    conn.Open();
                    OracleCommand comando = new OracleCommand();
                    comando.Connection = conn;
                    comando.CommandText = "ALTER DATABASE DATAFILE '"+txt_tablespaceseleccionado.Text+"' RESIZE "+txt_tamaño.Text+"M"; MessageBox.Show(comando.CommandText);
                    OracleDataReader dr = comando.ExecuteReader();
                    lbl_respuesta.Foreground = Brushes.Green;
                    lbl_respuesta.Content = "Se agrandó el tablespace " +txt_tablespaceseleccionado.Text+".DBF a "+txt_tamaño.Text+"M";
                    conn.Close();

                }
                else
                {
                    lbl_respuesta.Foreground = Brushes.Red;
                    lbl_respuesta.Content = "Faltan seleccionar datos para la asignacion";
                }
            }
            catch
            {
                lbl_respuesta.Foreground = Brushes.Red;
                lbl_respuesta.Content = "Error al crear la asignacion";
            }
        }

        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = " SELECT tablespace_name FROM dba_tablespaces where segment_space_management ='AUTO'";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_tablespaces1.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void button3_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)tabla_tablespaces1.SelectedItem;
                string cellvalue = view.Row.ItemArray[0].ToString();
                txt_tablespaceseleccionado1.Text = cellvalue;
            }
            catch
            {
                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "ALTER TABLESPACE "+txt_tablespaceseleccionado1.Text+ " ADD DATAFILE 'C:/OracleXE/app/oracle/oradata/XE/"+txt_nombretablespaceNUEVO.Text+".DBF' size "+txt_tamañotablespaceNUEVO.Text+"M";
                OracleDataReader dr = comando.ExecuteReader();
                lbl_respuesta3.Foreground = Brushes.Green;
                lbl_respuesta3.Content = "Se agregó el DataFile " + txt_nombretablespaceNUEVO.Text + ".DBF de tamaño " + txt_tamañotablespaceNUEVO.Text + "M al tablespace "+txt_tablespaceseleccionado1.Text+".DBF";
                conn.Close();
            }
            catch
            {
                lbl_respuesta3.Foreground = Brushes.Red;
                lbl_respuesta3.Content = "No se pudo asignar el Datafile al tablespce";
            }
        }
    }
}
