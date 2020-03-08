using System;
using System.Linq;
using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace Labs.Apps.B2C
{
    public partial class LogoutPage : ContentPage
    {
        private readonly AuthenticationResult _authenticationResult;

        public LogoutPage(AuthenticationResult result)
        {
            InitializeComponent();

            _authenticationResult = result;
        }

        protected override void OnAppearing()
        {
            if (_authenticationResult != null)
            {
                messageLabel.Text = _authenticationResult.Account.Username != "unknown" ? $"Welcome {_authenticationResult.Account.Username}" : $"UserId: {_authenticationResult.Account.Username}";
            }

            base.OnAppearing();
        }

        private async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            var accounts = (await App.AuthenticationClient.GetAccountsAsync()).ToArray();

            while (accounts.Any())
            {
                await App.AuthenticationClient.RemoveAsync(accounts.First());
                
                accounts = (await App.AuthenticationClient.GetAccountsAsync()).ToArray();
            }

            await Navigation.PopAsync();
        }
    }
}

