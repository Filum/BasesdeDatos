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
using Oracle.DataAccess.Client;

namespace Proyecto_Bases_de_Datos
{
    /// <summary>
    /// Lógica de interacción para Seguridad.xaml
    /// </summary>
    public partial class Seguridad : Window
    {


        
        public Seguridad()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_menuS_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "create user "+txt_nomUsuario.Text+" identified by "+txt_contraUsuario.Text;
                OracleDataReader dr = comando.ExecuteReader();
                lbl_respuesta1.Foreground = Brushes.Green;
                lbl_respuesta1.Content = "Se creo correctamente el usuario " + txt_nomUsuario.Text;
                conn.Close();
            }
            catch
            {
                lbl_respuesta1.Foreground = Brushes.Red;
                lbl_respuesta1.Content = "No se pudo crear el usuario";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txt_nomRol.Text == "" && txt_contraRol.Text=="")
            {
                lbl_respuesta3.Foreground = Brushes.Red;
                lbl_respuesta3.Content = "No se ingresaron datos para crear un rol";
            }
            else
            {
                if (txt_nomRol.Text != "" && txt_contraRol.Text == "")
                {
                    try
                    {
                        OracleConnection conn = DataBase.Conexion();
                        conn.Open();
                        OracleCommand comando = new OracleCommand();
                        comando.Connection = conn;
                        comando.CommandText = "create role "+txt_nomRol.Text; 
                        OracleDataReader dr = comando.ExecuteReader();
                        lbl_respuesta3.Foreground = Brushes.Green;
                        lbl_respuesta3.Content = "Se creo correctamente el rol " + txt_nomRol.Text;
                        conn.Close();
                    }
                    catch
                    {
                        lbl_respuesta3.Foreground = Brushes.Red;
                        lbl_respuesta3.Content = "No se pudo crear el rol";
                    }
                }
                else
                {
                    try
                    {
                        OracleConnection conn = DataBase.Conexion();
                        conn.Open();
                        OracleCommand comando = new OracleCommand();
                        comando.Connection = conn;
                        comando.CommandText = "create role " + txt_nomRol.Text+ " identified by "+txt_contraRol.Text; 
                        OracleDataReader dr = comando.ExecuteReader();
                        lbl_respuesta3.Foreground = Brushes.Green;
                        lbl_respuesta3.Content = "Se creo correctamente el rol " + txt_nomRol.Text;
                        conn.Close();
                    }
                    catch
                    {
                        lbl_respuesta3.Foreground = Brushes.Red;
                        lbl_respuesta3.Content = "No se pudo crear el rol";
                    }
                }

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                OracleDataReader dr;

                if (cbox_connectU.IsChecked == true)
                {  
                    comando.CommandText = "GRANT CONNECT TO " + txt_grantUsuarios.Text;  
                    dr = comando.ExecuteReader();
                }
                

                if (cbox_resourceU.IsChecked == true)
                {
                    comando.CommandText = "GRANT RESOURCE TO " + txt_grantUsuarios.Text;  
                    dr = comando.ExecuteReader();
                }
                

                if (cbox_sessionU.IsChecked == true)
                {
                    comando.CommandText = "GRANT CREATE SESSION TO " + txt_grantUsuarios.Text; 
                    dr = comando.ExecuteReader();
                }
                

                if (cbox_sysdbaU.IsChecked == true)
                {
                    comando.CommandText = "GRANT SYSDBA TO " + txt_grantUsuarios.Text;
                    dr = comando.ExecuteReader();
                }
                

                if (cbox_allprivilegesU.IsChecked == true)
                {
                    comando.CommandText = "GRANT ALL PRIVILEGES TO " + txt_grantUsuarios.Text; 
                    dr = comando.ExecuteReader();
                }
               
                lbl_respuesta2.Foreground = Brushes.Green;
                lbl_respuesta2.Content = "Se asignaron los permisos correctamente a el usuario " + txt_grantUsuarios.Text;
                conn.Close();
            }
            catch
            {
                lbl_respuesta2.Foreground = Brushes.Red;
                lbl_respuesta2.Content = "No se pudieron asignar los permisos con exito";
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                OracleDataReader dr;

                if (cbox_connectR.IsChecked == true)
                {
                    comando.CommandText = "GRANT CONNECT TO " + txt_grantsRoles.Text; 
                    dr = comando.ExecuteReader();
                }


                if (cbox_resourcesR.IsChecked == true)
                {
                    comando.CommandText = "GRANT RESOURCE TO " + txt_grantsRoles.Text; 
                    dr = comando.ExecuteReader();
                }


                if (cbox_sessionR.IsChecked == true)
                {
                    comando.CommandText = "GRANT CREATE SESSION TO " + txt_grantsRoles.Text; 
                    dr = comando.ExecuteReader();
                }




                lbl_respuesta4.Foreground = Brushes.Green;
                lbl_respuesta4.Content = "Se asignaron los permisos correctamente a el rol " + txt_grantsRoles.Text;
                conn.Close();
            }
            catch
            {
                lbl_respuesta4.Foreground = Brushes.Red;
                lbl_respuesta4.Content = "No se pudieron asignar los permisos con exito";
            }

        }

        private void button_Click_4(object sender, RoutedEventArgs e)
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
                tabla_usuarios.ItemsSource = tabla.DefaultView;
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
                comando.CommandText = "select role from dba_roles"; 
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_roles.ItemsSource = tabla.DefaultView;
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
                
                if (txt_asignarol.Text != "" && txt_asignaUsuario.Text != "")
                {
                    OracleConnection conn = DataBase.Conexion();
                    conn.Open();
                    OracleCommand comando = new OracleCommand();
                    comando.Connection = conn;
                    comando.CommandText = "GRANT " + txt_asignarol.Text + " TO " + txt_asignaUsuario.Text;MessageBox.Show(comando.CommandText);
                    OracleDataReader dr = comando.ExecuteReader();
                    lbl_respuestaAsignacion.Foreground = Brushes.Green;
                    lbl_respuestaAsignacion.Content = "Se asigno el rol de " + txt_asignarol.Text + " a el usuario " + txt_asignaUsuario.Text + " correctamente";
                    conn.Close();

                }
                else
                {
                    lbl_respuestaAsignacion.Foreground = Brushes.Red;
                    lbl_respuestaAsignacion.Content = "Faltan seleccionar datos para la asignacion";
                }

            }
            catch
            {
                lbl_respuestaAsignacion.Foreground = Brushes.Red;
                lbl_respuestaAsignacion.Content = "Error al crear la asignacion";
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
                comando.CommandText = "select role from dba_roles"; 
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tablaAsignaRol.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }

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
                tablaAsignaUsuario.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)tablaAsignaRol.SelectedItem;
            string cellvalue = view.Row.ItemArray[0].ToString();
            txt_asignarol.Text= cellvalue;
            }
            catch
            {
                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)tablaAsignaUsuario.SelectedItem;
                string cellvalue = view.Row.ItemArray[0].ToString();
                txt_asignaUsuario.Text = cellvalue;
            }
            catch
            {
                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "select role from dba_roles";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_rol.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }

            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "SELECT username FROM dba_users ";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_schema.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)tabla_schema.SelectedItem;
                string cellvalue = view.Row.ItemArray[0].ToString();
                txt_schema.Text = cellvalue;
            }
            catch
            {
                MessageBox.Show("No hay datos seleccionados");
            }

            try
            {
                OracleConnection conn = DataBase.Conexion();
                conn.Open();
                OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "select table_name from all_tables where owner ='"+txt_schema.Text+"' order by table_name ";
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_tabla.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar datos de la tabla");
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)tabla_tabla.SelectedItem;
                string cellvalue = view.Row.ItemArray[0].ToString();
                txt_tabla.Text = cellvalue;
            }
            catch
            {
                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView view = (DataRowView)tabla_rol.SelectedItem;
                string cellvalue = view.Row.ItemArray[0].ToString();
                txt_permisorol.Text = cellvalue;
            }
            catch
            {
                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
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
                    comando.CommandText = "GRANT DELETE ON "+txt_schema.Text+"."+txt_tabla.Text+" TO "+txt_permisorol.Text;MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                if (cbox_select.IsChecked == true)
                {
                    comando.CommandText = "GRANT SELECT ON " + txt_schema.Text + "." + txt_tabla.Text + " TO " + txt_permisorol.Text; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                if (cbox_update.IsChecked == true)
                {
                    comando.CommandText = "GRANT UPDATE ON " + txt_schema.Text + "." + txt_tabla.Text + " TO " + txt_permisorol.Text; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }

                if (cbox_insert.IsChecked == true)
                {
                    comando.CommandText = "GRANT INSERT ON " + txt_schema.Text + "." + txt_tabla.Text + " TO " + txt_permisorol.Text; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                lbl_respuestapermisos.Foreground = Brushes.Green;
                lbl_respuestapermisos.Content = "Se asignaron los permisos correctamente a el rol " + txt_grantsRoles.Text;
                conn.Close();
            }
            catch
            {
                lbl_respuestapermisos.Foreground = Brushes.Red;
                lbl_respuestapermisos.Content = "No se pudieron asignar los permisos con exito";
            }

        }
    }
    
}
