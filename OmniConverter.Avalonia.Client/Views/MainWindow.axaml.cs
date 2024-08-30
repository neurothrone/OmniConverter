using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using OmniConverter.Core;

namespace OmniConverter.Avalonia.Client.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        Console.WriteLine($"Click! Celsius: {Celsius.Text}");

        if (double.TryParse(Celsius.Text, out var temperatureC))
        {
            var temperatureF = TemperatureConverter.CelsiusToFahrenheit(temperatureC);
            Fahrenheit.Text = temperatureF.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}