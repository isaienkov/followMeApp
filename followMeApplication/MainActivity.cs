using Android.App;
using Android.Widget;
using Android.OS;

namespace followMeApplication
{
	[Activity (Label = "followMeApplication", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			Button signInButton = FindViewById<Button> (Resource.Id.butSignIn);
			Button signUpButton = FindViewById<Button> (Resource.Id.butSignUp);

			signInButton.Click += delegate {
				SetContentView (Resource.Layout.Autorization);
			};

		}
	}
}


