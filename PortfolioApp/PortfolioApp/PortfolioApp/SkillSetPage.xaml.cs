using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace PortfolioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillSetPage : ContentPage
    {
        public SkillSetPage()
        {
            InitializeComponent();
            LoadStandardMessages();
            LoadSkills();
            LoadParagraphContent();
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
            StandardMessages Standard = new StandardMessages();
            My_Skills.Text = Standard.Main_Skills_Title;
            About_Interests.Text = Standard.About_Interests_Title;
            Skills.Text = Standard.Skills_Title;
        }

        public void LoadSkills()
        {
            Skills skill = new Skills();
            HTML_CSS_Text.Text = skill.HTML_CSS_Title;
            HTML_CSS_Progress.Progress = skill.HTML_CSS_Progress_Value;
            Javascript_Text.Text = skill.Javascript_Title;
            Javascript_Progress.Progress = skill.Javascript_Progress_Value;
            Swift_Text.Text = skill.Swift_Title;
            Swift_Progress.Progress = skill.Swift_Progress_Value;
            CSharp_Text.Text = skill.CSharp_Title;
            CSharp_Progress.Progress = skill.CSharp_Progress_Value;
        }

        public void LoadParagraphContent()
        {
            ParagraphContent content = new ParagraphContent();
            About_Interests_Content.Text = content.About_Interests_Paragraph;
        }

        public void LoadImages()
        {
            Images image = new Images();
            HeaderBackground_Image.Source = image.HeaderBackground;
            BackArrow_Image.Source = image.BackArrow_Image;
            HTML_Image.Source = image.HTML_Image;
            Javascript_Image.Source = image.Javascript_Image;
            Swift_Image.Source = image.Swift_Image;
            CSharp_Image.Source = image.CSharp_Image;
        }
    }
}