﻿#pragma checksum "..\..\chat_admin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "482BBE63D919D1B7136B6BD08099933B2903E6A9BD5CEEEC4D3440E71A857098"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Messenger;
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


namespace Messenger {
    
    
    /// <summary>
    /// chat_admin
    /// </summary>
    public partial class chat_admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\chat_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MsgLB;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\chat_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox UsersLB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\chat_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendBTN;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\chat_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MsgTB;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\chat_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/Messenger;component/chat_admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\chat_admin.xaml"
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
            this.MsgLB = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.UsersLB = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.SendBTN = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\chat_admin.xaml"
            this.SendBTN.Click += new System.Windows.RoutedEventHandler(this.SendBTN_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MsgTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ExitBTN = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\chat_admin.xaml"
            this.ExitBTN.Click += new System.Windows.RoutedEventHandler(this.ExitBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

