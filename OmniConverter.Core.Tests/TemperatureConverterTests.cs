namespace OmniConverter.Core.Tests;

public class TemperatureConverterTests
{
    [Fact]
    public void CelsiusToFahrenheitConversionReturnsCorrectValue()
    {
        // Arrange
        const double celsius = 25d;
        const double expectedFahrenheit = 77d;

        // Act
        var actualFahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.Equal(expectedFahrenheit, actualFahrenheit);
    }

    [Fact]
    public void CelsiusToKelvinConversionReturnsCorrectValue()
    {
        // Arrange
        const double celsius = 25d;
        const double expectedKelvin = 298.15;

        // Act
        var actualKelvin = TemperatureConverter.CelsiusToKelvin(celsius);

        // Assert
        Assert.Equal(expectedKelvin, actualKelvin);
    }

    [Fact]
    public void FahrenheitToCelsiusConversionReturnsCorrectValue()
    {
        // Arrange
        const double fahrenheit = 32d;
        const double expectedCelsius = 0d;

        // Act
        var actualCelsius = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.Equal(expectedCelsius, actualCelsius);
    }

    [Fact]
    public void FahrenheitNegativeValueToCelsiusConversionReturnsCorrectValue()
    {
        // Arrange
        const double fahrenheit = -90d;
        const double expectedCelsius = -67.7778;
        const double tolerance = 0.0001;

        // Act
        var actualCelsius = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.InRange(actualCelsius, expectedCelsius - tolerance, expectedCelsius + tolerance);
    }

    [Fact]
    public void FahrenheitToKelvinConversionReturnsCorrectValue()
    {
        // Arrange
        const double fahrenheit = 32d;
        const double expectedKelvin = 273.15;

        // Act
        var actualKelvin = TemperatureConverter.FahrenheitToKelvin(fahrenheit);

        // Assert
        Assert.Equal(expectedKelvin, actualKelvin);
    }

    [Fact]
    public void KelvinToCelsiusConversionReturnsCorrectValue()
    {
        // Arrange
        const double kelvin = 0d;
        const double expectedCelsius = -273.15;

        // Act
        var actualCelsius = TemperatureConverter.KelvinToCelsius(kelvin);

        // Assert
        Assert.Equal(expectedCelsius, actualCelsius);
    }

    [Fact]
    public void KelvinToFahrenheitConversionReturnsCorrectValue()
    {
        // Arrange
        const double kelvin = 373.15;
        const double expectedFahrenheit = 212d;

        // Act
        var actualFahrenheit = TemperatureConverter.KelvinToFahrenheit(kelvin);

        // Assert
        Assert.Equal(expectedFahrenheit, actualFahrenheit);
    }
}