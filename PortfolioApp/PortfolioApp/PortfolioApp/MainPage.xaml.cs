using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Essentials;

namespace PortfolioApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadCredentials();
            LoadSocialMedia();
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

        private void SkillSetPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillSetPage());
        }

        private void ProjectPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProjectsPage());
        }

        private void GoToContactPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }

        private void OpenTwitter_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://twitter.com/Dano_Gamo", BrowserLaunchMode.SystemPreferred);
        }

        private void OpenFacebook_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.facebook.com/DanoGamo", BrowserLaunchMode.SystemPreferred);
        }

        private void OpenInstagram_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/daynewfgame/", BrowserLaunchMode.SystemPreferred);
        }

        public void LoadCredentials()
        {
            Credentials Cred = new Credentials();
            Name.Text = Cred.Name;
            Tagline.Text = Cred.Tagline;
        }

        public void LoadSocialMedia()
        {
            SocialMedia SM = new SocialMedia();

            TwitterTitle.Text = SM.Twitter;
            TwitterUsername.Text = SM.Twitter_Username;

            FacebookTitle.Text = SM.Facebook;
            FacebookUsername.Text = SM.Facebook_Username;

            InstagramTitle.Text = SM.Instagram;
            InstagramUsername.Text = SM.Instagram_Username;
        }

        public void LoadStandardMessages()
        {
            StandardMessages Standard = new StandardMessages();
            SocialMediaTitle.Text = Standard.Social_Media_Title;
            Contact_Button.Text = Standard.Contact_Me_Text;
        }

        public void LoadImages()
        {
            Images image = new Images();
            HeaderBackground_Image.Source = image.HeaderBackground;
            Profile_Image.Source = image.Profile_Image;
            Twitter_Image.Source = image.Twitter_Image;
            Facebook_Image.Source = image.Facebook_Image;
            Instagram_Image.Source = image.Instagram_Image;
        } 
    }
}
