﻿#pragma checksum "..\..\MenuMapa.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "417D6FD186A2AC13FEB39B707CFCA5942F6CB610BF50E8AB496C4269C93CDED0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AplicacionAutobuses;
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


namespace AplicacionAutobuses {
    
    
    /// <summary>
    /// MenuMapa
    /// </summary>
    public partial class MenuMapa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\MenuMapa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BotonHamburguesa;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MenuMapa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser webBrowser;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MenuMapa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MenuCanvas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AplicacionAutobuses;component/menumapa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuMapa.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BotonHamburguesa = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\MenuMapa.xaml"
            this.BotonHamburguesa.Click += new System.Windows.RoutedEventHandler(this.MenuHamburguesaClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.webBrowser = ((System.Windows.Controls.WebBrowser)(target));
            return;
            case 3:
            this.MenuCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            
            #line 45 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonMenu_MouseEnter);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonMenu_MouseLeave);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IrAMapa);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 52 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonMenu_MouseEnter);
            
            #line default
            #line hidden
            
            #line 52 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonMenu_MouseLeave);
            
            #line default
            #line hidden
            
            #line 52 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IrAInicio);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 58 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonMenu_MouseEnter);
            
            #line default
            #line hidden
            
            #line 58 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonMenu_MouseLeave);
            
            #line default
            #line hidden
            
            #line 58 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IrAParadas);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 64 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonMenu_MouseEnter);
            
            #line default
            #line hidden
            
            #line 64 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonMenu_MouseLeave);
            
            #line default
            #line hidden
            
            #line 64 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IrAFavoritos);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 70 "..\..\MenuMapa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IrAInfo);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

