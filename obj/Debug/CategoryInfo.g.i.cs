﻿#pragma checksum "..\..\CategoryInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B6AEF5237ECDE35414121027D2B5C747A86BF6B36A9BB71B81C3D74F0BBD966B"
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
    /// CategoryInfo
    /// </summary>
    public partial class CategoryInfo : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\CategoryInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox changeCategoryNameTxtBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CategoryInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CategoriesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\CategoryInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button for_add_emp;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\CategoryInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button for_update_emp;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CategoryInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button for_delete_emp;
        
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
            System.Uri resourceLocater = new System.Uri("/UP_FINAL;component/categoryinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CategoryInfo.xaml"
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
            this.changeCategoryNameTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CategoriesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.for_add_emp = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\CategoryInfo.xaml"
            this.for_add_emp.Click += new System.Windows.RoutedEventHandler(this.for_add_emp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.for_update_emp = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\CategoryInfo.xaml"
            this.for_update_emp.Click += new System.Windows.RoutedEventHandler(this.for_update_emp_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.for_delete_emp = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\CategoryInfo.xaml"
            this.for_delete_emp.Click += new System.Windows.RoutedEventHandler(this.for_delete_emp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
