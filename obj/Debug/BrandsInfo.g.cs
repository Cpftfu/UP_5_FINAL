﻿#pragma checksum "..\..\BrandsInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A54549C199B64FDD3D5D17C131FDFE1D942A8C56E7D2030399FF864A839A2402"
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
using UP_FINAL;


namespace UP_FINAL {
    
    
    /// <summary>
    /// BrandsInfo
    /// </summary>
    public partial class BrandsInfo : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\BrandsInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox changeNameOfBrandTxtBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\BrandsInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox changeTypeOfManufTxtBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\BrandsInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BrandDataGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\BrandsInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button for_add_br;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\BrandsInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button for_update_br;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\BrandsInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button for_delete_br;
        
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
            System.Uri resourceLocater = new System.Uri("/UP_FINAL;component/brandsinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BrandsInfo.xaml"
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
            this.changeNameOfBrandTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.changeTypeOfManufTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BrandDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.for_add_br = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\BrandsInfo.xaml"
            this.for_add_br.Click += new System.Windows.RoutedEventHandler(this.for_add_br_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.for_update_br = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\BrandsInfo.xaml"
            this.for_update_br.Click += new System.Windows.RoutedEventHandler(this.for_update_br_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.for_delete_br = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\BrandsInfo.xaml"
            this.for_delete_br.Click += new System.Windows.RoutedEventHandler(this.for_delete_br_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

