using System;
using System.Globalization;

namespace ColorConverter
{
	public class RGB
	{

		public int r {
			get;
			private set;
		}
		public int g {
			get;
			private set;
		}
		public int b {
			get;
			private set;
		}

		public RGB(int r, int g, int b) {
			this.r = r;
			this.g = g;
			this.b = b;
		}


		public static RGB fromHex(string hexColor)
		{
			//Remove # if present
			if (hexColor.IndexOf('#') != -1)
				hexColor = hexColor.Replace("#", "");

			int red = 0;
			int green = 0;
			int blue = 0;

			if (hexColor.Length == 6)
			{
				//#RRGGBB
				red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
				green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
				blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);


			}
			else if (hexColor.Length == 3)
			{
				//#RGB
				red = int.Parse(hexColor[0].ToString() + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
				green = int.Parse(hexColor[1].ToString() + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
				blue = int.Parse(hexColor[2].ToString() + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
			}
			else {
				red = 255;
				green = 255;
				blue = 255;
			}


			return new RGB(red, green, blue);	
		}

	}
}

