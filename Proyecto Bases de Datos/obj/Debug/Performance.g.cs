#pragma checksum "..\..\Performance.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FE5548FA9BCE6A258EB8E97B54093D0AD1AB412A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_Bases_de_Datos;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Proyecto_Bases_de_Datos
{


    /// <summary>
    /// Performance
    /// </summary>
    public partial class Performance : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\Performance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_menuT;

#line default
#line hidden


#line 59 "..\..\Performance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_estadisticas1;

#line default
#line hidden


#line 60 "..\..\Performance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_estadisticas_2;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto Bases de Datos;component/performance.xaml", System.UriKind.Relative);

#line 1 "..\..\Performance.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.btn_menuT = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\Performance.xaml"
                    this.btn_menuT.Click += new System.Windows.RoutedEventHandler(this.btn_menuS_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.txb_select = ((System.Windows.Controls.TextBox)(target));

#line 30 "..\..\Performance.xaml"
                    this.txb_select.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);

#line default
#line hidden
                    return;
                case 3:
                    this.btn_crear_index = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\Performance.xaml"
                    this.btn_crear_index.Click += new System.Windows.RoutedEventHandler(this.Button_Click_crear_index);

#line default
#line hidden
                    return;
                case 4:
                    this.btn_fin_tunning = ((System.Windows.Controls.Button)(target));

#line 33 "..\..\Performance.xaml"
                    this.btn_fin_tunning.Click += new System.Windows.RoutedEventHandler(this.Button_Click_finalizarT);

#line default
#line hidden
                    return;
                case 5:
                    this.index = ((System.Windows.Controls.Label)(target));
                    return;
                case 6:
                    this.txb_index = ((System.Windows.Controls.TextBox)(target));

#line 35 "..\..\Performance.xaml"
                    this.txb_index.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.btn_estadisticas1 = ((System.Windows.Controls.Button)(target));

#line 59 "..\..\Performance.xaml"
                    this.btn_estadisticas1.Click += new System.Windows.RoutedEventHandler(this.Button_Click_estadisticas1);

#line default
#line hidden
                    return;
                case 8:
                    this.btn_estadisticas_2 = ((System.Windows.Controls.Button)(target));

#line 60 "..\..\Performance.xaml"
                    this.btn_estadisticas_2.Click += new System.Windows.RoutedEventHandler(this.Button_Click_estadisticas2);

#line default
#line hidden
                    return;
                case 9:
                    this.tabla_estadisticas_1 = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 10:
                    this.tabla_estadisticas_2 = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 11:
                    this.cb_tabla_2 = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 12:
                    this.cb_schema_2 = ((System.Windows.Controls.ComboBox)(target));

#line 67 "..\..\Performance.xaml"
                    this.cb_schema_2.Initialized += new System.EventHandler(this.cargarDatos_actualizar);

#line default
#line hidden

#line 67 "..\..\Performance.xaml"
                    this.cb_schema_2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_schema2_SelectionChanged);

#line default
#line hidden
                    return;
                case 13:
                    this.txb_schema_1 = ((System.Windows.Controls.TextBox)(target));

#line 68 "..\..\Performance.xaml"
                    this.txb_schema_1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txb_schema_1_TextChanged);

#line default
#line hidden
                    return;
                case 14:

#line 69 "..\..\Performance.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_VER_1);

#line default
#line hidden
                    return;
                case 15:
                    this.txb_label_1 = ((System.Windows.Controls.TextBox)(target));

#line 72 "..\..\Performance.xaml"
                    this.txb_label_1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txb_schema_1_TextChanged);

#line default
#line hidden
                    return;
                case 16:
                    this.btn_tablaeindice = ((System.Windows.Controls.Button)(target));

#line 85 "..\..\Performance.xaml"
                    this.btn_tablaeindice.Click += new System.Windows.RoutedEventHandler(this.Button_Click_tabla_indice);

#line default
#line hidden
                    return;
                case 17:
                    this.btn_borrar = ((System.Windows.Controls.Button)(target));

#line 86 "..\..\Performance.xaml"
                    this.btn_borrar.Click += new System.Windows.RoutedEventHandler(this.Button_Click_borrar_estadisticas);

#line default
#line hidden
                    return;
                case 18:
                    this.btn_tabla = ((System.Windows.Controls.Button)(target));

#line 87 "..\..\Performance.xaml"
                    this.btn_tabla.Click += new System.Windows.RoutedEventHandler(this.Button_Click_tabla);

#line default
#line hidden
                    return;
                case 19:
                    this.btn_indices = ((System.Windows.Controls.Button)(target));

#line 88 "..\..\Performance.xaml"
                    this.btn_indices.Click += new System.Windows.RoutedEventHandler(this.Button_Click_indices);

#line default
#line hidden
                    return;
                case 20:
                    this.cb_tabla_3 = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 21:
                    this.cb_schema_3 = ((System.Windows.Controls.ComboBox)(target));

#line 92 "..\..\Performance.xaml"
                    this.cb_schema_3.Initialized += new System.EventHandler(this.cargarDatos_2);

#line default
#line hidden

#line 92 "..\..\Performance.xaml"
                    this.cb_schema_3.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_schema_3_SelectionChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

