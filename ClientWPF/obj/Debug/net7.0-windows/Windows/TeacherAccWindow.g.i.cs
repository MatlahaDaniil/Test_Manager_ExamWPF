﻿#pragma checksum "..\..\..\..\Windows\TeacherAccWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59098A561B6C4774CEBDC873FBB548A6705E1F5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientWPF.Windows;
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


namespace ClientWPF.Windows {
    
    
    /// <summary>
    /// TeacherAccWindow
    /// </summary>
    public partial class TeacherAccWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\..\..\Windows\TeacherAccWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minus_btn;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Windows\TeacherAccWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Expand_btn;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Windows\TeacherAccWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close_btn;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Windows\TeacherAccWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse AccPhoto_elips;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientWPF;component/windows/teacheraccwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\TeacherAccWindow.xaml"
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
            
            #line 41 "..\..\..\..\Windows\TeacherAccWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MoveWindow_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Minus_btn = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\Windows\TeacherAccWindow.xaml"
            this.Minus_btn.Click += new System.Windows.RoutedEventHandler(this.Minus_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Expand_btn = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\Windows\TeacherAccWindow.xaml"
            this.Expand_btn.Click += new System.Windows.RoutedEventHandler(this.Expand_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Close_btn = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\Windows\TeacherAccWindow.xaml"
            this.Close_btn.Click += new System.Windows.RoutedEventHandler(this.Close_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AccPhoto_elips = ((System.Windows.Shapes.Ellipse)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
