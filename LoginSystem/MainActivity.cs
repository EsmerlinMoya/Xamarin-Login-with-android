using Android.App;
using Android.Widget;
using Android.OS;

namespace LoginSystem
{
	[Activity (Label = "LoginSystem", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		private Button mbtnsignup;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			mbtnsignup = FindViewById<Button> (Resource.Id.BtnSignUp);

			mbtnsignup.Click += (object sender, System.EventArgs args) => {

				//Pull Up Dialog
				FragmentTransaction transaction = FragmentManager.BeginTransaction();
				Dialog_SignUp signup = new Dialog_SignUp();
				signup.Show(transaction,"Dialog Fragment");
			};

		}
	}
}