namespace OmniConverter.Core;

public static class TemperatureConverter
{
    /// <summary>
    /// Converts a temperature from Celsius to Fahrenheit.
    /// </summary>
    /// <param name="temperature">The temperature in degrees Celsius.</param>
    /// <returns>The temperature converted to degrees Fahrenheit.</returns>
    /// <remarks>
    /// The formula to convert Celsius to Fahrenheit is:
    /// <code>
    /// °F = (9 / 5) * °C + 32
    /// </code>
    /// </remarks>
    public static double CelsiusToFahrenheit(double temperature)
    {
        return (9d / 5d) * temperature + 32d;
    }

    /// <summary>
    /// Converts a temperature from Celsius to Kelvin.
    /// </summary>
    /// <param name="temperature">The temperature in degrees Celsius.</param>
    /// <returns>The temperature converted to Kelvin.</returns>
    /// <remarks>
    /// The formula to convert Celsius to Kelvin is:
    /// <code>
    /// K = °C + 273.15
    /// </code>
    /// </remarks>
    public static double CelsiusToKelvin(double temperature)
    {
        return temperature + 273.15;
    }

    /// <summary>
    /// Converts a temperature from Fahrenheit to Celsius.
    /// </summary>
    /// <param name="temperature">The temperature in degrees Fahrenheit.</param>
    /// <returns>The temperature converted to degrees Celsius.</returns>
    /// <remarks>
    /// The formula to convert Fahrenheit to Celsius is:
    /// <code>
    /// °C = (°F - 32) * 5 / 9
    /// </code>
    /// </remarks>
    public static double FahrenheitToCelsius(double temperature)
    {
        return (temperature - 32d) * 5d / 9d;
    }

    /// <summary>
    /// Converts a temperature from Fahrenheit to Kelvin.
    /// </summary>
    /// <param name="temperature">The temperature in degrees Fahrenheit.</param>
    /// <returns>The temperature converted to Kelvin.</returns>
    /// <remarks>
    /// The formula to convert Fahrenheit to Kelvin is:
    /// <code>
    /// K = (°F − 32) × 5 / 9 + 273.15
    /// </code>
    /// </remarks>
    public static double FahrenheitToKelvin(double temperature)
    {
        return (temperature - 32d) * 5d / 9d + 273.15;
    }

    /// <summary>
    /// Converts a temperature from Kelvin to Celsius.
    /// </summary>
    /// <param name="temperature">The temperature in Kelvin.</param>
    /// <returns>The temperature converted to degrees Celsius.</returns>
    /// <remarks>
    /// The formula to convert Kelvin to Celsius is:
    /// <code>
    /// °C = K - 273.15
    /// </code>
    /// </remarks>
    public static double KelvinToCelsius(double temperature)
    {
        return temperature - 273.15;
    }

    /// <summary>
    /// Converts a temperature from Kelvin to Fahrenheit.
    /// </summary>
    /// <param name="temperature">The temperature in Kelvin.</param>
    /// <returns>The temperature converted to degrees Fahrenheit.</returns>
    /// <remarks>
    /// The formula to convert Kelvin to Fahrenheit is:
    /// <code>
    /// °F = (K – 273.15) × 9 / 5 + 32
    /// </code>
    /// </remarks>
    public static double KelvinToFahrenheit(double temperature)
    {
        return (temperature - 273.15) * 9d / 5d + 32d;
    }
}