﻿#pragma checksum "..\..\..\Windows\Continue.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB4D8E0F541731D665B37EEF0DC90B2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Oregon_Trail.Windows;
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


namespace Oregon_Trail.Windows {
    
    
    /// <summary>
    /// Continue
    /// </summary>
    public partial class Continue : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Windows\Continue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button game1Button;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\Continue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button game2Button;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\Continue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button game3Button;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\Continue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock game1Desc;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\Continue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock game2Desc;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\Continue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock game3Desc;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\Continue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousPage;
        
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
            System.Uri resourceLocater = new System.Uri("/Oregon Trail;component/windows/continue.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Continue.xaml"
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
            this.game1Button = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\Continue.xaml"
            this.game1Button.Click += new System.Windows.RoutedEventHandler(this.game1Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.game2Button = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.game3Button = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.game1Desc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.game2Desc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.game3Desc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PreviousPage = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Windows\Continue.xaml"
            this.PreviousPage.Click += new System.Windows.RoutedEventHandler(this.PreviousPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
