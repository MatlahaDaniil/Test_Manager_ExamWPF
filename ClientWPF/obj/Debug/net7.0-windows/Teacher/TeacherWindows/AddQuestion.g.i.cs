﻿#pragma checksum "..\..\..\..\..\Teacher\TeacherWindows\AddQuestion.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "868D7B1641C06BA2EA50396EF529FBFFC6361860"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientWPF.Teacher.TeacherWindows;
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


namespace ClientWPF.Teacher.TeacherWindows {
    
    
    /// <summary>
    /// AddQuestion
    /// </summary>
    public partial class AddQuestion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\..\Teacher\TeacherWindows\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Question_txb;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Teacher\TeacherWindows\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveQuestion_btn;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\..\Teacher\TeacherWindows\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Answer;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientWPF;component/teacher/teacherwindows/addquestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Teacher\TeacherWindows\AddQuestion.xaml"
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
            this.Question_txb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SaveQuestion_btn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\Teacher\TeacherWindows\AddQuestion.xaml"
            this.SaveQuestion_btn.Click += new System.Windows.RoutedEventHandler(this.SaveQuestion_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Add_Answer = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\..\..\Teacher\TeacherWindows\AddQuestion.xaml"
            this.Add_Answer.Click += new System.Windows.RoutedEventHandler(this.Add_Answer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

