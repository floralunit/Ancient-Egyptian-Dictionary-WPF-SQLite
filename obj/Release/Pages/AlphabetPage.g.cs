﻿#pragma checksum "..\..\..\Pages\AlphabetPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1AA0306A0123E3B0D792FD125095FC06581AC1CC479E629768430F8F862528A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EgyptianDictionary_SQLite.Pages;
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


namespace EgyptianDictionary_SQLite.Pages {
    
    
    /// <summary>
    /// PhonogramPage
    /// </summary>
    public partial class PhonogramPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Pages\AlphabetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearchUnicode;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\AlphabetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearchGardiner;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\AlphabetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearchTransliteration;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\AlphabetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSearh;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\AlphabetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEdit;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\AlphabetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSave;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\AlphabetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridCursor;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Pages\AlphabetPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewPhonogram;
        
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
            System.Uri resourceLocater = new System.Uri("/EgyptianDictionary-SQLite;component/pages/alphabetpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AlphabetPage.xaml"
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
            this.TBSearchUnicode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBSearchGardiner = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBSearchTransliteration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BSearh = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Pages\AlphabetPage.xaml"
            this.BSearh.Click += new System.Windows.RoutedEventHandler(this.BSearh_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BEdit = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Pages\AlphabetPage.xaml"
            this.BEdit.Click += new System.Windows.RoutedEventHandler(this.BEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BSave = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\AlphabetPage.xaml"
            this.BSave.Click += new System.Windows.RoutedEventHandler(this.BSave_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 54 "..\..\..\Pages\AlphabetPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 55 "..\..\..\Pages\AlphabetPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 56 "..\..\..\Pages\AlphabetPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.GridCursor = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.LViewPhonogram = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

