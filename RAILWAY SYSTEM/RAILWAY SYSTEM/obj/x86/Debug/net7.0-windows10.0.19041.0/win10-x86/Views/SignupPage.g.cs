﻿#pragma checksum "D:\Railway-Management-System\RAILWAY SYSTEM\RAILWAY SYSTEM\Views\SignupPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B5F344A86BEA8E7A94546D0C5D762B7A5C5AD489C7D095F4CB8B54A2911C7324"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RAILWAY_SYSTEM.Views
{
    partial class SignupPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(global::Microsoft.UI.Xaml.Controls.TeachingTip obj, global::Microsoft.UI.Xaml.FrameworkElement value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.FrameworkElement) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.FrameworkElement), targetNullValue);
                }
                obj.Target = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SignupPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISignupPage_Bindings
        {
            private global::RAILWAY_SYSTEM.Views.SignupPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TeachingTip obj11;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj11TargetDisabled = false;

            public SignupPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 28 && columnNumber == 179)
                {
                    isobj11TargetDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 11: // Views\SignupPage.xaml line 28
                        this.obj11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ISignupPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::RAILWAY_SYSTEM.Views.SignupPage>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::RAILWAY_SYSTEM.Views.SignupPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_SignUp_Button(obj.SignUp_Button, phase);
                    }
                }
            }
            private void Update_SignUp_Button(global::Microsoft.UI.Xaml.Controls.Button obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\SignupPage.xaml line 28
                    if (!isobj11TargetDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(this.obj11, obj, null);
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\SignupPage.xaml line 9
                {
                    this.ContentArea = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // Views\SignupPage.xaml line 12
                {
                    this.signup = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                }
                break;
            case 4: // Views\SignupPage.xaml line 13
                {
                    this.userText1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 5: // Views\SignupPage.xaml line 14
                {
                    this.userText = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 6: // Views\SignupPage.xaml line 15
                {
                    this.userMail = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 7: // Views\SignupPage.xaml line 16
                {
                    this.Pass = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.PasswordBox>(target);
                }
                break;
            case 8: // Views\SignupPage.xaml line 17
                {
                    this.ConfirmPass = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.PasswordBox>(target);
                }
                break;
            case 9: // Views\SignupPage.xaml line 18
                {
                    this.type = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.DropDownButton>(target);
                }
                break;
            case 10: // Views\SignupPage.xaml line 27
                {
                    this.SignUp_Button = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.SignUp_Button).Click += this.Signup_Click;
                }
                break;
            case 11: // Views\SignupPage.xaml line 28
                {
                    this.Error = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                }
                break;
            case 12: // Views\SignupPage.xaml line 21
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element12 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element12).Click += this.P_Click;
                }
                break;
            case 13: // Views\SignupPage.xaml line 22
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element13).Click += this.E_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\SignupPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    SignupPage_obj1_Bindings bindings = new SignupPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

