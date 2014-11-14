using System;
using Xamarin.Forms;
using MonoTouch.UIKit;
using Xamarin.Forms.Platform.iOS;
using System.Drawing;
using GithubUserSearcher.Contols;
using GithubUsersSearcher.iOS.Controls;

[assembly: ExportRendererAttribute(typeof(CircleImage), typeof(CircleImageRenderer))]
namespace GithubUsersSearcher.iOS.Controls
{

	public class CircleImageRenderer : ViewRenderer<CircleImage,UIView>
	{
		UIImageView imageView;
		protected override void OnElementChanged(ElementChangedEventArgs<CircleImage> e)
		{
			base.OnElementChanged(e);

			var rbv = e.NewElement;
			if (rbv != null) {

				var mainView = new UIView();

				imageView = new UIImageView (UIImage.FromBundle(rbv.FileSource));
				imageView.Frame = new RectangleF 
					(0, 0, (float)rbv.WidthRequest, (float)rbv.HeightRequest);
				imageView.Layer.CornerRadius = imageView.Frame.Size.Width / 2;
				if (rbv.HasBorder) {
					imageView.Layer.BorderColor = rbv.BorderColor.ToCGColor();
					imageView.Layer.BorderWidth = 2;
				}
				imageView.ClipsToBounds = true;

				mainView.Add (imageView);

				SetNativeControl(mainView);
			}
		}

		protected override void OnElementPropertyChanged
		(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == CircleImage.HasBorderProperty.PropertyName) {
				if (Element.HasBorder) {
					imageView.Layer.BorderWidth = 2;
					imageView.Layer.BorderColor = this.Element.BorderColor.ToCGColor ();
				} else {
					imageView.Layer.BorderWidth = 0;
				}
			}
		}
	}
}