﻿#pragma checksum "D:\Windows10493\IoTCoreDefaultApp\CS\IoTCoreDefaultApp\UserControls\TopBarUC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "979C759D9035D4AF0304CD4997E8E9D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IoTCoreDefaultApp
{
    partial class TopBarUC : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // UserControls\TopBarUC.xaml line 42
                {
                    this.DeviceInfo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DeviceInfo).Click += this.DeviceInfo_Clicked;
                }
                break;
            case 2: // UserControls\TopBarUC.xaml line 57
                {
                    this.WebBrowser = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.WebBrowser).Click += this.WebBrowserButton_Clicked;
                }
                break;
            case 3: // UserControls\TopBarUC.xaml line 72
                {
                    this.CurrentTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // UserControls\TopBarUC.xaml line 74
                {
                    this.SettingsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SettingsButton).Click += this.SettingsButton_Clicked;
                }
                break;
            case 5: // UserControls\TopBarUC.xaml line 76
                {
                    this.ShutdownButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShutdownButton).Click += this.ShutdownButton_Clicked;
                }
                break;
            case 6: // UserControls\TopBarUC.xaml line 78
                {
                    this.ShutdownDropdown = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.Popup)this.ShutdownDropdown).Opened += this.ShutdownDropdown_Opened;
                }
                break;
            case 7: // UserControls\TopBarUC.xaml line 79
                {
                    this.ShutdownListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ShutdownListView).ItemClick += this.ShutdownListView_ItemClick;
                }
                break;
            case 8: // UserControls\TopBarUC.xaml line 84
                {
                    this.RestartOption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // UserControls\TopBarUC.xaml line 81
                {
                    this.ShutdownOption = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
