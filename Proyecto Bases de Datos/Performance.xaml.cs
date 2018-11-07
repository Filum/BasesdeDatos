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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "select username from all_users";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void cb_schema_performance_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "SELECT TABLE_NAME FROM DBA_TABLES WHERE OWNER = '" + cb_schema_performance.SelectedItem.ToString() + "'";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                foreach (DataRow fila in tabla.Rows)
                {
                    cb_schema_performance.Items.Add(Convert.ToString(fila["TABLE_NAME"]));
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        

        private void cb_schema2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cb_tabla.Items.Clear();
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "SELECT TABLE_NAME FROM DBA_TABLES WHERE OWNER = '" + cb_schema2.SelectedItem.ToString() + "'";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                foreach (DataRow fila in tabla.Rows)
                {
                    cb_tabla.Items.Add(Convert.ToString(fila["TABLE_NAME"]));
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }
        private void cargarDatos(object sender, EventArgs e)
        {
            try
            {
                cb_schema2.Items.Clear();
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "select distinct owner from dba_objects";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    cb_schema2.Items.Add(Convert.ToString(fila["OWNER"]));
                }

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void cb_tabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_crear_index(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "DELETE PLAN_TABLE;";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = "EXPLAIN PLAN FOR"+ txb_select.Text;
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = " SELECT   SUBSTR (LPAD(' ', LEVEL-1) || OPERATION || ' (' || OPTIONS || ')',1,30 ) 'OPERACION',   OBJECT_NAME 'OBJETO' , TO_DATE(TIMESTAMP)FROM PLAN_TABLE START WITH ID = 0 CONNECT BY PRIOR ID = PARENT_ID; " ;
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = "CREATE INDEX " + txb_index.Text;
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR AL CREAR EL TUNNING");
            }
        }

        private void Button_Click_finalizarT(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "DELETE PLAN_TABLE;";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = "EXPLAIN PLAN FOR" + txb_select.Text;
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = " SELECT   SUBSTR (LPAD(' ', LEVEL-1) || OPERATION || ' (' || OPTIONS || ')',1,30 ) 'OPERACION',   OBJECT_NAME 'OBJETO' , TO_DATE(TIMESTAMP)FROM PLAN_TABLE START WITH ID = 0 CONNECT BY PRIOR ID = PARENT_ID; ";
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR AL CREAR EL TUNNING");
            }
        }

        private void Button_Click_tabla_indice(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "ANALYZE TABLE "+cb_schema4.SelectedItem.ToString()+" COMPUTE STATISTICS;";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Button_Click_indices(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "ANALYZE TABLE " + cb_schema4.SelectedItem.ToString() + " COMPUTE STATISTICS FOR ALL INDEXES;";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Button_Click_tabla(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "ANALYZE TABLE " + cb_schema4.SelectedItem.ToString() + " COMPUTE STATISTICS FOR TABLE;";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Button_Click_borrar_estadisticas(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "ANALYZE TABLE " + cb_schema4.SelectedItem.ToString() + " COMPUTE STATISTICS FOR TABLE;";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Button_Click_estadisticas1(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = " EXEC dbms_stats.gather_schema_stats ('"+cb_schema_performance.SelectedItem.ToString()+"', cascade => true);";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR AL ASIGNAR PERMISOS DE LECTURA Y ESCRITURA");
            }
        }

        private void cb_schema_3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cb_schema4.Items.Clear();
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "SELECT TABLE_NAME FROM DBA_TABLES WHERE OWNER = '" + cb_schema_3.SelectedItem.ToString() + "'";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                foreach (DataRow fila in tabla.Rows)
                {
                    cb_schema4.Items.Add(Convert.ToString(fila["TABLE_NAME"]));
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void Button_Click_estadisticas2(object sender, RoutedEventArgs e)
        {

        }
    }
}
