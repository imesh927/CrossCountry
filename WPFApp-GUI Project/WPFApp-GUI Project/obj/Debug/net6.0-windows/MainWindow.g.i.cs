﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6BB4044F856A802A0D55C08B808027AA9F55F15B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace WPFApp_GUI_Project {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRegistor;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonLogin;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxUsername;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBoxPassword;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFApp-GUI Project;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.buttonRegistor = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.buttonRegistor.Click += new System.Windows.RoutedEventHandler(this.buttonRegistor_Click);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.buttonRegistor.MouseEnter += new System.Windows.Input.MouseEventHandler(this.buttonRegistor_MouseEnter);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.buttonRegistor.MouseLeave += new System.Windows.Input.MouseEventHandler(this.buttonRegistor_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonLogin = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.buttonLogin.Click += new System.Windows.RoutedEventHandler(this.buttonLogin_Click);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.buttonLogin.MouseEnter += new System.Windows.Input.MouseEventHandler(this.buttonLogin_MouseEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.buttonLogin.MouseLeave += new System.Windows.Input.MouseEventHandler(this.buttonLogin_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBoxUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.textBoxUsername.MouseEnter += new System.Windows.Input.MouseEventHandler(this.textBoxUsername_MouseEnter);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.textBoxUsername.MouseLeave += new System.Windows.Input.MouseEventHandler(this.textBoxUsername_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.passwordBoxPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.passwordBoxPassword.MouseEnter += new System.Windows.Input.MouseEventHandler(this.passwordBoxPassword_MouseEnter);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.passwordBoxPassword.MouseLeave += new System.Windows.Input.MouseEventHandler(this.passwordBoxPassword_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

