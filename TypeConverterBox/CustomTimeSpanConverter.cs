namespace TypeConverterBox
{
    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public class CustomTimeSpanConverter : TimeSpanConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string text)
            {
                var match = Regex.Match(text, @"(?<ms>\d+) ms");
                if (match.Success)
                {
                    return TimeSpan.FromMilliseconds(int.Parse(match.Groups["ms"].Value));
                }
            }

            return base.ConvertFrom(context, culture, value);
        }
    }
}