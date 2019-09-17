using System;
using System.Collections.Generic;
using PortfolioApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Essentials;

namespace PortfolioApp
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            LoadStandardMessages();
            LoadImages();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var safeInsets = On<iOS>().SafeAreaInsets();
            safeInsets.Top = -44;
            Padding = safeInsets;
        }

        private void BackToHomeScreen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        public void LoadStandardMessages()
        {
            StandardMessages SM = new StandardMessages();
            Contact_Title.Text = SM.Contact_Title;
            Name_Title.Text = SM.Name_Title;
            Email_Title.Text = SM.Email_Title;
            Subject_Title.Text = SM.Subject_Title;
            Message_Title.Text = SM.Message_Title;
            Get_In_Touch_Title.Text = SM.Get_In_Touch_Title;
            Send_Btn.Text = SM.Send_Button_Text;
        }

        public void LoadImages()
        {
            Images image = new Images();
            HeaderBackground_Image.Source = image.HeaderBackground;
            BackArrow_Image.Source = image.BackArrow_Image;
        }

        private async void Send_Email_Clicked(object sender, EventArgs e)
        {
            List<string> MyEmailAddress = new List<string>();
            MyEmailAddress.Add("daynegame024@gmail.com");

            var Subject = $"{Name_Entry.Text}, {Email_Entry.Text} - {Subject_Entry.Text}";
            var message = new EmailMessage(Subject, Mesage_Entry.Text);
            message.To = MyEmailAddress;

            await Email.ComposeAsync(message);
        }
    }
}
