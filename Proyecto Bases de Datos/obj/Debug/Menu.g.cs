#pragma checksum "..\..\Menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8780B8C1F436E437F7C31B3B364C4EFEA8074EAA"
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
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 34 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_BD;

#line default
#line hidden


#line 36 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_auditoria;

#line default
#line hidden


#line 37 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_respaldos;

#line default
#line hidden


#line 38 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_seguridad;

#line default
#line hidden


#line 59 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_salir;

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
            System.Uri resourceLocater = new System.Uri("/Proyecto Bases de Datos;component/menu.xaml", System.UriKind.Relative);

#line 1 "..\..\Menu.xaml"
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
                    this.btn_BD = ((System.Windows.Controls.Button)(target));

#line 34 "..\..\Menu.xaml"
                    this.btn_BD.Click += new System.Windows.RoutedEventHandler(this.btn_BD_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.btn_performance = ((System.Windows.Controls.Button)(target));

#line 35 "..\..\Menu.xaml"
                    this.btn_performance.Click += new System.Windows.RoutedEventHandler(this.btn_performance_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btn_auditoria = ((System.Windows.Controls.Button)(target));

#line 36 "..\..\Menu.xaml"
                    this.btn_auditoria.Click += new System.Windows.RoutedEventHandler(this.btn_auditoria_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btn_respaldos = ((System.Windows.Controls.Button)(target));

#line 37 "..\..\Menu.xaml"
                    this.btn_respaldos.Click += new System.Windows.RoutedEventHandler(this.btn_respaldos_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btn_seguridad = ((System.Windows.Controls.Button)(target));

#line 38 "..\..\Menu.xaml"
                    this.btn_seguridad.Click += new System.Windows.RoutedEventHandler(this.btn_seguridad_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.btn_salir = ((System.Windows.Controls.Button)(target));

#line 59 "..\..\Menu.xaml"
                    this.btn_salir.Click += new System.Windows.RoutedEventHandler(this.btn_salir_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btn_performance;
    }
}

