﻿#pragma checksum "..\..\FolderPicker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FCC9BB344223AC36EF239C26CB831EB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using FolderFile;
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


namespace FolderFile {
    
    
    /// <summary>
    /// FolderPicker
    /// </summary>
    public partial class FolderPicker : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\FolderPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_path;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\FolderPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbx_uo;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\FolderPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_change;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FolderPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_open;
        
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
            System.Uri resourceLocater = new System.Uri("/FolderFileLib;component/folderpicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FolderPicker.xaml"
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
            
            #line 9 "..\..\FolderPicker.xaml"
            ((FolderFile.FolderPicker)(target)).AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.Control_Drop));
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbx_path = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\FolderPicker.xaml"
            this.tbx_path.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbx_path_TextChanged);
            
            #line default
            #line hidden
            
            #line 23 "..\..\FolderPicker.xaml"
            this.tbx_path.LostFocus += new System.Windows.RoutedEventHandler(this.tbx_path_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbx_uo = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\FolderPicker.xaml"
            this.cbx_uo.Checked += new System.Windows.RoutedEventHandler(this.cbx_uo_Checked);
            
            #line default
            #line hidden
            
            #line 26 "..\..\FolderPicker.xaml"
            this.cbx_uo.Unchecked += new System.Windows.RoutedEventHandler(this.cbx_uo_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_change = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\FolderPicker.xaml"
            this.btn_change.Click += new System.Windows.RoutedEventHandler(this.Change_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_open = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\FolderPicker.xaml"
            this.btn_open.Click += new System.Windows.RoutedEventHandler(this.Open_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

