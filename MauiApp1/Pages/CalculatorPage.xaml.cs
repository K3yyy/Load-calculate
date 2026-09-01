namespace MauiApp1.Pages;

public partial class CalculatorPage : ContentPage
{
    private double _firstNumber = 0;
    private string _operator = "";
    private bool _isNewNumber = true;

    public CalculatorPage()
    {
        InitializeComponent();
    }

    private void OnNumberClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        string number = button.Text;

        if (_isNewNumber)
        {
            DisplayLabel.Text = number;
            _isNewNumber = false;
        }
        else
        {
            if (DisplayLabel.Text == "0")
                DisplayLabel.Text = number;
            else
                DisplayLabel.Text += number;
        }
    }

    private void OnOperatorClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        _firstNumber = double.Parse(DisplayLabel.Text);
        _operator = button.Text;
        _isNewNumber = true;
    }

    private void OnEqualsClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_operator)) return;

        double secondNumber = double.Parse(DisplayLabel.Text);
        double result = 0;

        switch (_operator)
        {
            case "+": result = _firstNumber + secondNumber; break;
            case "−": result = _firstNumber - secondNumber; break;
            case "×": result = _firstNumber * secondNumber; break;
            case "÷":
                if (secondNumber == 0)
                {
                    DisplayLabel.Text = "Error";
                    _isNewNumber = true;
                    return;
                }
                result = _firstNumber / secondNumber;
                break;
        }

        DisplayLabel.Text = result.ToString("G10");
        _operator = "";
        _isNewNumber = true;
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        DisplayLabel.Text = "0";
        _firstNumber = 0;
        _operator = "";
        _isNewNumber = true;
    }

    private void OnPlusMinusClicked(object sender, EventArgs e)
    {
        if (double.TryParse(DisplayLabel.Text, out double value))
        {
            value = -value;
            DisplayLabel.Text = value.ToString();
        }
    }

    private void OnPercentClicked(object sender, EventArgs e)
    {
        if (double.TryParse(DisplayLabel.Text, out double value))
        {
            value /= 100;
            DisplayLabel.Text = value.ToString();
        }
    }

    private void OnDecimalClicked(object sender, EventArgs e)
    {
        if (_isNewNumber)
        {
            DisplayLabel.Text = "0.";
            _isNewNumber = false;
        }
        else if (!DisplayLabel.Text.Contains("."))
        {
            DisplayLabel.Text += ".";
        }
    }
}