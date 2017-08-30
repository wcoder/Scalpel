using Android.App;
using Android.OS;
using Com.Jakewharton.Scalpel;

namespace Scalpel.SampleApp
{
	[Activity(Label = "Scalpel.SampleApp", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var scalpelView = FindViewById<ScalpelFrameLayout>(Resource.Id.scalpel);

			scalpelView.LayerInteractionEnabled = true;
			scalpelView.SetDrawIds(true);
			scalpelView.SetDrawViews(true);
		}
	}
}

