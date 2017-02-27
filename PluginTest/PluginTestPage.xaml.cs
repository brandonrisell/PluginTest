using System;
using Plugin.Share;
using Plugin.Share.Abstractions;
using Xamarin.Forms;

namespace PluginTest
{
    public partial class PluginTestPage : ContentPage
    {
        public PluginTestPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            var sharePlugin = CrossShare.Current;
            var message = new ShareMessage() { Text = "Share Plugin!", Title = "Testing" };
            sharePlugin.Share(message);
        }
    }
}
