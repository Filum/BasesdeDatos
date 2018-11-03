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
                        comando.CommandText = "create role "+txt_nomRol.Text; MessageBox.Show(comando.CommandText);
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
                    comando.CommandText = "GRANT CONNECT TO " + txt_grantUsuarios.Text;  MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }
                

                if (cbox_resourceU.IsChecked == true)
                {
                    comando.CommandText = "GRANT RESOURCE TO " + txt_grantUsuarios.Text;  MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }
                

                if (cbox_sessionU.IsChecked == true)
                {
                    comando.CommandText = "GRANT CREATE SESSION TO " + txt_grantUsuarios.Text; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }
                

                if (cbox_sysdbaU.IsChecked == true)
                {
                    comando.CommandText = "GRANT SYSDBA TO " + txt_grantUsuarios.Text; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }
                

                if (cbox_allprivilegesU.IsChecked == true)
                {
                    comando.CommandText = "GRANT ALL PRIVILEGES TO " + txt_grantUsuarios.Text; MessageBox.Show(comando.CommandText);
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
                    comando.CommandText = "GRANT CONNECT TO " + txt_grantsRoles.Text; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                if (cbox_resourcesR.IsChecked == true)
                {
                    comando.CommandText = "GRANT RESOURCE TO " + txt_grantsRoles.Text; MessageBox.Show(comando.CommandText);
                    dr = comando.ExecuteReader();
                }


                if (cbox_sessionR.IsChecked == true)
                {
                    comando.CommandText = "GRANT CREATE SESSION TO " + txt_grantsRoles.Text; MessageBox.Show(comando.CommandText);
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
                comando.CommandText = "select username from all_users"; MessageBox.Show(comando.CommandText);
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_usuarios.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                lbl_respuesta4.Foreground = Brushes.Red;
                lbl_respuesta4.Content = "No se pudieron asignar los permisos con exito";
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
                comando.CommandText = "select role from dba_roles"; MessageBox.Show(comando.CommandText);
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                tabla_roles.ItemsSource = tabla.DefaultView;
                conn.Close();
            }
            catch
            {
                lbl_respuesta4.Foreground = Brushes.Red;
                lbl_respuesta4.Content = "No se pudieron asignar los permisos con exito";
            }
        }
    }
    
}
