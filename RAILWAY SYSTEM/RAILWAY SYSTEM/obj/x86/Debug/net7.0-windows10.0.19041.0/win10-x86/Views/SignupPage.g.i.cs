// Updated by XamlIntelliSenseFileGenerator 4/29/2024 3:21:12 PM
#pragma checksum "D:\Railway-Management-System\RAILWAY SYSTEM\RAILWAY SYSTEM\Views\SignupPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B5F344A86BEA8E7A94546D0C5D762B7A5C5AD489C7D095F4CB8B54A2911C7324"
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
    partial class SignupPage : global::Microsoft.UI.Xaml.Controls.Page
    {
#pragma warning restore 0649
#pragma warning restore 0169
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2310")]
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;

            global::System.Uri resourceLocator = new global::System.Uri("ms-appx:///Views/SignupPage.xaml");
            global::Microsoft.UI.Xaml.Application.LoadComponent(this, resourceLocator, global::Microsoft.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
        }

        partial void UnloadObject(global::Microsoft.UI.Xaml.DependencyObject unloadableObject);

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2310")]
        private interface ISignupPage_Bindings
        {
            void Initialize();
            void Update();
            void StopTracking();
            void DisconnectUnloadedObject(int connectionId);
        }

        private interface ISignupPage_BindingsScopeConnector
        {
            global::System.WeakReference Parent
            {
                get; set;
            }
            bool ContainsElement(int connectionId);
            void RegisterForElementConnection(int connectionId, global::Microsoft.UI.Xaml.Markup.IComponentConnector connector);
        }

        internal global::Microsoft.UI.Xaml.Controls.Grid ContentArea;
        internal global::Microsoft.UI.Xaml.Controls.Image signup;
        internal global::Microsoft.UI.Xaml.Controls.TextBox userText1;
        internal global::Microsoft.UI.Xaml.Controls.TextBox userText;
        internal global::Microsoft.UI.Xaml.Controls.TextBox userMail;
        internal global::Microsoft.UI.Xaml.Controls.PasswordBox Pass;
        internal global::Microsoft.UI.Xaml.Controls.PasswordBox ConfirmPass;
        internal global::Microsoft.UI.Xaml.Controls.DropDownButton type;
        internal global::Microsoft.UI.Xaml.Controls.Button SignUp_Button;
        internal global::Microsoft.UI.Xaml.Controls.TeachingTip Error;
#pragma warning restore 0649
#pragma warning restore 0169
    }
}


