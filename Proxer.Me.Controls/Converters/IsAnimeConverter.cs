﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Proxer.Me.Controls.Converters
{
	public class IsAnimeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			return value.ToString() == "anime" ? true : false;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return null;
		}
	}
}
