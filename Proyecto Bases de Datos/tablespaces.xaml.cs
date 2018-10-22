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
using Oracle.DataAccess.Client;

namespace Proyecto_Bases_de_Datos
{
    /// <summary>
    /// Lógica de interacción para tablespaces.xaml
    /// </summary>
    public partial class tablespaces : Window
    {
        Conexion c = new Conexion();
        public tablespaces()
        {
            InitializeComponent();
        }

        private void creartablespace_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/XE;DBA PRIVILEGE=SYSDBA;PERSIST SECURITY INFO=True;USER ID=SYS;PASSWORD=" + "root");
            conn.Open();
            OracleCommand comando = new OracleCommand();
            comando.Connection = conn;
            comando.CommandText = "CREATE TABLESPACE " + txb_nombretablespace.Text + " DATAFILE 'C:/oraclexe/app/oracle/oradata/XE/" + txb_nombretablespace.Text+".dbf' SIZE "+tbx_tamañotablespace.Text+"M ONLINE";
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            MessageBox.Show("Tablespace" + txb_nombretablespace.Text+"creado correctamente");
            MessageBox.Show(""+comando.CommandText);
            conn.Close();
            Console.WriteLine(comando.CommandText);
        }

        private void creartemporal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
