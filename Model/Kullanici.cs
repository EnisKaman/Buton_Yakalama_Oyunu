using System;

namespace Model
{
    public class Kullanici
    {
		
		private string ad;

		public string Ad
		{
			get { return ad; }
			set { ad = value.ToUpper(); }
		}

		private string soyad;

		public string Soyad
		{
			get { return soyad; }
			set { soyad = value.ToUpper(); }
		}
		private int sure;

		public int Sure
		{
			get { return sure; }
			set { sure = value; }
		}

	}
}
