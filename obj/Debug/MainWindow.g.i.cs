﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2EDB4CEEF4366E552CAF3C0249BFD4666DCFFF595B13B96640C813914DEC18AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TextRedactor;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace TextRedactor {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox docBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOpenFile;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSaveFile;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonNewFile;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fonts;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker colorPicker;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image bold_ico;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image italic_ico;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image underline_ico;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image upper_ico;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image lower_ico;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontSize;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btm;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelShowFileName;
        
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
            System.Uri resourceLocater = new System.Uri("/TextRedactor;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.docBox = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.docBox.SelectionChanged += new System.Windows.RoutedEventHandler(this.docBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MainWindow.xaml"
            this.docBox.LostFocus += new System.Windows.RoutedEventHandler(this.docBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonOpenFile = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\MainWindow.xaml"
            this.buttonOpenFile.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenFile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonSaveFile = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\MainWindow.xaml"
            this.buttonSaveFile.Click += new System.Windows.RoutedEventHandler(this.ButtonSaveFile_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonNewFile = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\MainWindow.xaml"
            this.buttonNewFile.Click += new System.Windows.RoutedEventHandler(this.ButtonNewFile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.fonts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 108 "..\..\MainWindow.xaml"
            this.fonts.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.fonts_MouseUp);
            
            #line default
            #line hidden
            
            #line 108 "..\..\MainWindow.xaml"
            this.fonts.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.fonts_MouseDown);
            
            #line default
            #line hidden
            
            #line 108 "..\..\MainWindow.xaml"
            this.fonts.MouseEnter += new System.Windows.Input.MouseEventHandler(this.fonts_MouseEnter);
            
            #line default
            #line hidden
            
            #line 108 "..\..\MainWindow.xaml"
            this.fonts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.fonts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.colorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 116 "..\..\MainWindow.xaml"
            this.colorPicker.MouseEnter += new System.Windows.Input.MouseEventHandler(this.colorPicker_MouseEnter);
            
            #line default
            #line hidden
            
            #line 116 "..\..\MainWindow.xaml"
            this.colorPicker.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.colorPicker_MouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bold_ico = ((System.Windows.Controls.Image)(target));
            
            #line 117 "..\..\MainWindow.xaml"
            this.bold_ico.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.bold_ico_MouseUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.italic_ico = ((System.Windows.Controls.Image)(target));
            
            #line 125 "..\..\MainWindow.xaml"
            this.italic_ico.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.italic_ico_MouseUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.underline_ico = ((System.Windows.Controls.Image)(target));
            
            #line 131 "..\..\MainWindow.xaml"
            this.underline_ico.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.underline_ico_MouseUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.upper_ico = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.lower_ico = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            this.cmbFontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 149 "..\..\MainWindow.xaml"
            this.cmbFontSize.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.cmbFontSize_TextChanged));
            
            #line default
            #line hidden
            return;
            case 13:
            this.btm = ((System.Windows.Controls.Image)(target));
            
            #line 150 "..\..\MainWindow.xaml"
            this.btm.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btm_MouseUp);
            
            #line default
            #line hidden
            return;
            case 14:
            this.LabelShowFileName = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

