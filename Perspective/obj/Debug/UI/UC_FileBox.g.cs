﻿#pragma checksum "..\..\..\UI\UC_FileBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0EC51FA0A6DC6778562EB3346E5F1C9BC5362F52962D5D535BC9B6C39D3E2450"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using Perspective.UI;
using Perspective.ValueConverters;
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


namespace Perspective.UI {
    
    
    /// <summary>
    /// UC_FileBox
    /// </summary>
    public partial class UC_FileBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 118 "..\..\..\UI\UC_FileBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElement;
        
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
            System.Uri resourceLocater = new System.Uri("/Mobius Link v1.0.6;component/ui/uc_filebox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\UC_FileBox.xaml"
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
            
            #line 88 "..\..\..\UI\UC_FileBox.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Tbtn_Checked_Click);
            
            #line default
            #line hidden
            
            #line 91 "..\..\..\UI\UC_FileBox.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Tbtn_DoubleClick_Click);
            
            #line default
            #line hidden
            
            #line 92 "..\..\..\UI\UC_FileBox.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.tbtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 93 "..\..\..\UI\UC_FileBox.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.tbtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 96 "..\..\..\UI\UC_FileBox.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.Tbtn_UnChecked_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mediaElement = ((System.Windows.Controls.MediaElement)(target));
            
            #line 118 "..\..\..\UI\UC_FileBox.xaml"
            this.mediaElement.MediaEnded += new System.Windows.RoutedEventHandler(this.mediaElement_MediaEnded);
            
            #line default
            #line hidden
            
            #line 118 "..\..\..\UI\UC_FileBox.xaml"
            this.mediaElement.MediaOpened += new System.Windows.RoutedEventHandler(this.mediaElement_MediaOpened);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 163 "..\..\..\UI\UC_FileBox.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

