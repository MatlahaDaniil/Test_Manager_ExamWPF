﻿#pragma checksum "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15097CEE6C5509122FD44FE053B046F23905F8B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientWPF.Teacher.Pages;
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


namespace ClientWPF.Teacher.Pages {
    
    
    /// <summary>
    /// CreateTestPage
    /// </summary>
    public partial class CreateTestPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TestName_txb;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Subject_txb;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NumClass_txb;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTestInfo_btn;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddQuestion_btn;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ls_View;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ClientWPF;component/teacher/pages/createtestpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TestName_txb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Subject_txb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.NumClass_txb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.AddTestInfo_btn = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
            this.AddTestInfo_btn.Click += new System.Windows.RoutedEventHandler(this.AddTestInfo_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddQuestion_btn = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\..\..\Teacher\Pages\CreateTestPage.xaml"
            this.AddQuestion_btn.Click += new System.Windows.RoutedEventHandler(this.AddQuestion_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ls_View = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

