namespace MauiApp1.Pages;      // ← must match your project name

public partial class TemperaturePage : ContentPage
{
    public TemperaturePage()
    {
        InitializeComponent();
    }

    private void OnCtoFClicked(object sender, EventArgs e)
    {
        if (double.TryParse(TempEntry.Text, out double celsius))
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            ResultLabel.Text = $"{celsius:F1} °C = {fahrenheit:F1} °F";
            ResultLabel.TextColor = Color.FromArgb("#4ECDC4");
        }
        else
        {
            ResultLabel.Text = "Please enter a valid number";
            ResultLabel.TextColor = Colors.OrangeRed;
        }
    }

    private void OnFtoCClicked(object sender, EventArgs e)
    {
        if (double.TryParse(TempEntry.Text, out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            ResultLabel.Text = $"{fahrenheit:F1} °F = {celsius:F1} °C";
            ResultLabel.TextColor = Color.FromArgb("#FF6B6B");
        }
        else
        {
            ResultLabel.Text = "Please enter a valid number";
            ResultLabel.TextColor = Colors.OrangeRed;
        }
    }
}