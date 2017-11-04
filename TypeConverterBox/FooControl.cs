namespace TypeConverterBox
{
    using System;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    public class FooControl : Control
    {
        public static readonly DependencyProperty DurationProperty = DependencyProperty.Register(
            nameof(Duration),
            typeof(TimeSpan),
            typeof(FooControl),
            new PropertyMetadata(default(TimeSpan)));

        [TypeConverter(typeof(CustomTimeSpanConverter))]
        public TimeSpan Duration
        {
            get => (TimeSpan)GetValue(DurationProperty);
            set => SetValue(DurationProperty, value);
        }
    }
}
