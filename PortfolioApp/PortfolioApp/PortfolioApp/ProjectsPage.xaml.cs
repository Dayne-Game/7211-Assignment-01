using System;
using System.Collections.Generic;
using PortfolioApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PortfolioApp
{
    public partial class ProjectsPage : ContentPage
    {
        public ProjectsPage()
        {
            InitializeComponent();
            LoadStandardMessages();
            LoadParagraphContent();
            LoadProjects();
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
            StandardMessages standard = new StandardMessages();
            Projects_Title.Text = standard.Main_Projects_Title;
            Brief_Title.Text = standard.Brief_Title;
            My_Projects_Title.Text = standard.My_Projects_Title;
        }

        public void LoadParagraphContent()
        {
            ParagraphContent paragraph = new ParagraphContent();
            Brief_Content_Paragraph.Text = paragraph.Projects_Brief_Paragraph;
        }

        public void LoadProjects()
        {
            Projects projects = new Projects();
            BOP_Text.Text = projects.BOP_Text;
            USB_Text.Text = projects.USB_Text;
            WWG_Text.Text = projects.WWG_Text;
            Github_Text.Text = projects.Github_Text;
        }

        public void LoadImages()
        {
            Images image = new Images();
            HeaderBackground_Image.Source = image.HeaderBackground;
            BackArrow_Image.Source = image.BackArrow_Image;
            BOP_Image.Source = image.BOP_Image;
            USB_Image.Source = image.USB_Image;
            WWG_Image.Source = image.WWG_Image;
            Github_Image.Source = image.Github_Image;
        }
    }
}
