﻿#pragma checksum "..\..\..\View\Mbutton.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "27A85FF94B6C54EF2FE3890CCD365714"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using BD_Terminal.View;
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


namespace BD_Terminal.View {
    
    
    /// <summary>
    /// Mbutton
    /// </summary>
    public partial class Mbutton : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\View\Mbutton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse OutEill;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\Mbutton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label InLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\Mbutton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse EventEill;
        
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
            System.Uri resourceLocater = new System.Uri("/BD_Terminal;component/view/mbutton.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Mbutton.xaml"
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
            this.OutEill = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 2:
            this.InLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.EventEill = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 14 "..\..\..\View\Mbutton.xaml"
            this.EventEill.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OutEill_MouseEnter);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\View\Mbutton.xaml"
            this.EventEill.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OutEill_MouseLeave);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\View\Mbutton.xaml"
            this.EventEill.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OutEill_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\View\Mbutton.xaml"
            this.EventEill.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OutEill_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
