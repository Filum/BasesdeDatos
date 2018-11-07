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
    /// Lógica de interacción para Respaldos.xaml
    /// </summary>
    public partial class Respaldos : Window
    {
        public Respaldos()
        {
            InitializeComponent();

        }

        private void btn_menuS_Click(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
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
                comando.CommandText = " CREATE OR REPLACE DIRECTORY RESPALDO AS '" + txt_directorio.Text + "'";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = "GRANT READ, WRITE ON DIRECTORY RESPALDO TO SYSTEM";
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR AL ASIGNAR PERMISOS DE LECTURA Y ESCRITURA");
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            string strexp = "EXPDP SYSTEM/" + txt_contraseña.Text + "@XE FULL=Y DIRECTORY=RESPALDO DUMPFILE=" + txt_nombreArchivo.Text + ".DMP LOGFILE=EXPDP" + txt_nombreArchivo.Text + ".LOG;";
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.EnableRaisingEvents = true;
            p.StartInfo.CreateNoWindow = true;

            try
            {
                p.Start();
                p.StandardInput.WriteLine(strexp);
                p.StandardInput.WriteLine("Exit");
                p.WaitForExit(1000);
                MessageBox.Show("cerre el processo");
            }
            catch
            {
                MessageBox.Show("ERROR AL CREAR EL RESPALDO");
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cbox_tabla.Items.Clear();
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "SELECT TABLE_NAME FROM DBA_TABLES WHERE OWNER = '" + cbox_schema.SelectedItem.ToString() + "'";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                foreach (DataRow fila in tabla.Rows)
                {
                    cbox_tabla.Items.Add(Convert.ToString(fila["TABLE_NAME"]));
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
                cbox_schema.Items.Clear();

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
                    cbox_schema.Items.Add(Convert.ToString(fila["OWNER"]));

                }

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void cargarDatos1(object sender, EventArgs e)
        {
            try
            {
                cbox_schemaRecuperacion.Items.Clear();
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
                    cbox_schemaRecuperacion.Items.Add(Convert.ToString(fila["OWNER"]));
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void cargarDatos2(object sender, EventArgs e)
        {
            try
            {
                cbox_UsuarioRespaldo.Items.Clear();
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "select username from all_users";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    cbox_UsuarioRespaldo.Items.Add(Convert.ToString(fila["USERNAME"]));
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = " CREATE OR REPLACE DIRECTORY RESPALDO AS '" + txt_directorio.Text + "'";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = "GRANT READ, WRITE ON DIRECTORY RESPALDO TO " + cbox_schema.SelectedItem.ToString();
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR AL ASIGNAR PERMISOS DE LECTURA Y ESCRITURA");
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            string strexp = "EXPDP " + cbox_schema.SelectedItem.ToString() + "/" + txt_contraseña.Text + "@XE SCHEMAS=" + cbox_schema.SelectedItem.ToString() + " DIRECTORY=RESPALDO DUMPFILE=" + txt_nombreArchivo.Text + ".DMP LOGFILE=EXPDP" + txt_nombreArchivo.Text + ".LOG;";
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.EnableRaisingEvents = true;
            p.StartInfo.CreateNoWindow = true;

            try
            {
                p.Start();
                p.StandardInput.WriteLine(strexp);
                p.StandardInput.WriteLine("Exit");
                p.WaitForExit(1000);
                MessageBox.Show("cerre el processo");
            }
            catch
            {
                MessageBox.Show("ERROR AL CREAR EL RESPALDO");
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
                comando.CommandText = " CREATE OR REPLACE DIRECTORY RESPALDO AS '" + txt_directorio.Text + "'";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = "GRANT READ, WRITE ON DIRECTORY RESPALDO TO " + cbox_schema.SelectedItem.ToString();
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR AL ASIGNAR PERMISOS DE LECTURA Y ESCRITURA");
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            string strexp = "EXPDP " + cbox_schema.SelectedItem.ToString() + "/" + txt_contraseña.Text + "@XE TABLES=" + cbox_schema.SelectedItem.ToString() + "." + cbox_tabla.SelectedItem.ToString() + " DIRECTORY=RESPALDO DUMPFILE=" + txt_nombreArchivo.Text + ".DMP LOGFILE=EXPDP" + txt_nombreArchivo.Text + ".LOG;";
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.EnableRaisingEvents = true;
            p.StartInfo.CreateNoWindow = true;

            try
            {
                p.Start();
                p.StandardInput.WriteLine(strexp);
                p.StandardInput.WriteLine("Exit");
                p.WaitForExit(1000);
                MessageBox.Show("cerre el processo");
            }
            catch
            {
                MessageBox.Show("ERROR AL CREAR EL RESPALDO");
            }
        }

        private void cbox_schemaRecuperacion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cbox_tablaRecuperacion.Items.Clear();
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "SELECT TABLE_NAME FROM DBA_TABLES WHERE OWNER = '" + cbox_schemaRecuperacion.SelectedItem.ToString() + "'";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                foreach (DataRow fila in tabla.Rows)
                {
                    cbox_tablaRecuperacion.Items.Add(Convert.ToString(fila["TABLE_NAME"]));
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        

        private void button5_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = " CREATE OR REPLACE DIRECTORY RESPALDO AS '" + txt_directorioRecuperacion.Text + "'";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = "GRANT READ, WRITE ON DIRECTORY RESPALDO TO " + cbox_UsuarioRespaldo.SelectedItem.ToString();
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);
                comando.CommandText = "DROP TABLE " + cbox_schemaRecuperacion.SelectedItem.ToString() + "." + cbox_tablaRecuperacion.SelectedItem.ToString(); MessageBox.Show("TABLA BORRADA");
                dr = comando.ExecuteReader();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR AL ASIGNAR PERMISOS DE LECTURA Y ESCRITURA");
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            string strexp = "IMPDP " + cbox_UsuarioRespaldo.SelectedItem.ToString() + "/" + txt_contraseñaRecuperacion.Text + "@XE TABLES=" + cbox_schemaRecuperacion.SelectedItem.ToString() + "." + cbox_tablaRecuperacion.SelectedItem.ToString() + " DIRECTORY=RESPALDO DUMPFILE=" + txt_nombreArchivoRecuperacion.Text + ".DMP LOGFILE=IMPDP" + txt_nombreArchivoRecuperacion.Text + ".LOG"; MessageBox.Show(strexp);
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.EnableRaisingEvents = true;
            p.StartInfo.CreateNoWindow = true;

            try
            {
                p.Start();
                p.StandardInput.WriteLine(strexp);
                p.StandardInput.WriteLine("Exit");
                p.WaitForExit(1000);
                MessageBox.Show("TABLA RECUPERADA");
            }
            catch
            {
                MessageBox.Show("ERROR AL CREAR EL RESPALDO");

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

                comando.CommandText = " CREATE OR REPLACE DIRECTORY RESPALDO AS '" + txt_directorioRecuperacion.Text + "'";
                OracleDataReader dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);

                comando.CommandText = "GRANT READ, WRITE ON DIRECTORY RESPALDO TO " + cbox_schemaRecuperacion.SelectedItem.ToString();MessageBox.Show(comando.CommandText);
                dr = comando.ExecuteReader(); 

                comando.CommandText = "DROP USER HR CASCADE"; MessageBox.Show(comando.CommandText);
                dr = comando.ExecuteReader(); 

                comando.CommandText = "CREATE USER "+ cbox_UsuarioRespaldo.SelectedItem.ToString() + " IDENTIFIED BY "+txt_contraseñaRecuperacion.Text+" DEFAULT TABLESPACE USERS TEMPORARY TABLESPACE TEMP";//falta agregar para diferentes tablespace o diferentes temporarys
                dr = comando.ExecuteReader(); MessageBox.Show(comando.CommandText);

                comando.CommandText = "GRANT CONNECT , RESOURCE, DBA TO "+ cbox_UsuarioRespaldo.SelectedItem.ToString(); MessageBox.Show(comando.CommandText);
                dr = comando.ExecuteReader();

                comando.CommandText = "GRANT ALL PRIVILEGES TO " + cbox_UsuarioRespaldo.SelectedItem.ToString(); MessageBox.Show(comando.CommandText);
                dr = comando.ExecuteReader();
                
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR AL ASIGNAR PERMISOS DE LECTURA Y ESCRITURA");
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            string strexp = "IMPDP "+ cbox_schemaRecuperacion.SelectedItem.ToString() + "/"+txt_contraseñaRecuperacion.Text+"@XE SCHEMAS="+ cbox_schemaRecuperacion.SelectedItem.ToString() + " DIRECTORY=RESPALDO DUMPFILE="+txt_nombreArchivoRecuperacion.Text+".DMP LOGFILE=IMPDP"+ txt_nombreArchivoRecuperacion.Text + ".LOG"; MessageBox.Show(strexp);
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.EnableRaisingEvents = true;
            p.StartInfo.CreateNoWindow = true;

            try
            {
                p.Start();
                p.StandardInput.WriteLine(strexp);
                p.StandardInput.WriteLine("Exit");
                p.WaitForExit(1000);
                MessageBox.Show("TABLA RECUPERADA");
            }
            catch
            {
                MessageBox.Show("ERROR AL CREAR EL RESPALDO");

            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
