using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BrowserSimulator
{
    /// <summary>
    /// Interaction logic for BrowserWindow.xaml
    /// </summary>
    public partial class BrowserWindow : Window
    {
        public BrowserWindow()
        {
            InitializeComponent();
            HideScriptErrors(WebBrowser);
        }

        private void HideScriptErrors(WebBrowser webBrowser)
        {
            var webBrowserField = typeof(WebBrowser).GetField("_axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (webBrowserField == null)
            {
                return;
            }

            var objComWebBrowser = webBrowserField.GetValue(webBrowser);
            if (objComWebBrowser == null)
            {
                WebBrowser.Loaded += (o, s) => HideScriptErrors(webBrowser); //// In case we are to early
                return;
            }

            objComWebBrowser.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, objComWebBrowser, new object[] { true });
        }
    }
}
