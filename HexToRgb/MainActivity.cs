using Android.App;
using Android.Widget;
using Android.OS;
using ColorConverter;
using Android.Graphics.Drawables;

namespace HexToRgb
{
	[Activity(Label = "HexToRgb", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		Button convertButton;
		EditText hexColorEditText;
		TextView redtextView;
		TextView greenTextView;
		TextView bluetextView;
		ImageView backgroundImageView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			convertButton = FindViewById<Button>(Resource.Id.convertButton);
			hexColorEditText = FindViewById<EditText>(Resource.Id.hexColorEditText);
			redtextView = FindViewById<TextView>(Resource.Id.redtextView);
			greenTextView = FindViewById<TextView>(Resource.Id.greenTextView);
			bluetextView = FindViewById<TextView>(Resource.Id.bluetextView);
			backgroundImageView = FindViewById<ImageView>(Resource.Id.backgroundImageView);


			convertButton.Click+= ConvertButton_Click;

		}

		void ConvertButton_Click(object sender, System.EventArgs e)
		{

			//Android.Graphics.Color my_colour = new Android.Graphics.Color(255,0,0);
			//Drawable drawableCircle = Resources.GetDrawable(Resources.GetIdentifier("rgb_color", "drawable", PackageName));
			GradientDrawable gradientDrawable = (GradientDrawable) backgroundImageView.Background.Current;

			RGB colour = RGB.fromHex(hexColorEditText.Text);
			Android.Graphics.Color my_colour = new Android.Graphics.Color(colour.r, colour.g, colour.b);
			gradientDrawable.SetColor(my_colour);

			redtextView.Text = colour.r.ToString();
			greenTextView.Text = colour.g.ToString();
			bluetextView.Text = colour.b.ToString();

		}
	}
}


