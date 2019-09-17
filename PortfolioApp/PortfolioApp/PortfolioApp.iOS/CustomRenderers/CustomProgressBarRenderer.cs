using System;
using CoreGraphics;
using PortfolioApp.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ProgressBar), typeof(CustomProgressBarRenderer))]
namespace PortfolioApp.iOS.CustomRenderers
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            var X = 1.0f;
            var Y = 7.0f;

            CGAffineTransform transform = CGAffineTransform.MakeScale(X, Y);
            this.Transform = transform;
        }
    }
}
