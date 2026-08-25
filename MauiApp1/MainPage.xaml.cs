namespace LoanCalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        // Validate inputs
        if (!double.TryParse(LoanAmountEntry.Text, out double principal) || principal <= 0)
        {
            DisplayAlert("Error", "Please enter a valid Loan Amount", "OK");
            return;
        }

        if (!double.TryParse(InterestRateEntry.Text, out double annualRate) || annualRate < 0)
        {
            DisplayAlert("Error", "Please enter a valid Interest Rate", "OK");
            return;
        }

        if (!double.TryParse(LoanTermEntry.Text, out double years) || years <= 0)
        {
            DisplayAlert("Error", "Please enter a valid Loan Term", "OK");
            return;
        }

        // Calculate
        double monthlyRate = annualRate / 100 / 12;
        int numberOfPayments = (int)(years * 12);

        double monthlyPayment;
        double totalPayment;
        double totalInterest;

        if (monthlyRate == 0)
        {
            // No interest case
            monthlyPayment = principal / numberOfPayments;
            totalPayment = principal;
            totalInterest = 0;
        }
        else
        {
            // Standard amortization formula
            double factor = Math.Pow(1 + monthlyRate, numberOfPayments);
            monthlyPayment = principal * (monthlyRate * factor) / (factor - 1);
            totalPayment = monthlyPayment * numberOfPayments;
            totalInterest = totalPayment - principal;
        }

        // Display results
        MonthlyPaymentLabel.Text = $"${monthlyPayment:N2}";
        TotalInterestLabel.Text = $"${totalInterest:N2}";
        TotalPaymentLabel.Text = $"${totalPayment:N2}";
    }
}