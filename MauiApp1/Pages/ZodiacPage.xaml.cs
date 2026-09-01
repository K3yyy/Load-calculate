namespace MauiApp1.Pages;

public partial class ZodiacPage : ContentPage
{
    private readonly (string Sign, string Birthstone, string Luck)[] ZodiacData =
    {
        ("Aries ♈", "Diamond", "Bold energy surrounds you. Take action on ideas you've delayed."),
        ("Taurus ♉", "Emerald", "Stability and comfort are coming. Enjoy the simple pleasures."),
        ("Gemini ♊", "Pearl", "Communication will open new doors. Speak your mind freely."),
        ("Cancer ♋", "Ruby", "Home and family bring warmth. Trust your intuition today."),
        ("Leo ♌", "Peridot", "Your confidence shines. Leadership opportunities appear."),
        ("Virgo ♍", "Sapphire", "Attention to detail pays off. Organize and you will succeed."),
        ("Libra ♎", "Opal", "Balance and harmony are key. Seek beauty in relationships."),
        ("Scorpio ♏", "Topaz", "Deep transformation is possible. Embrace intensity."),
        ("Sagittarius ♐", "Turquoise", "Adventure calls. Expand your horizons and travel (even mentally)."),
        ("Capricorn ♑", "Garnet", "Hard work brings long-term rewards. Stay disciplined."),
        ("Aquarius ♒", "Amethyst", "Innovation and friendship light your path. Think differently."),
        ("Pisces ♓", "Aquamarine", "Creativity and empathy flow. Dream big and trust the universe.")
    };

    public ZodiacPage()
    {
        InitializeComponent();
    }

    private void OnRevealClicked(object sender, EventArgs e)
    {
        string phone = PhoneEntry.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(phone) || phone.Any(c => !char.IsDigit(c) && c != '+' && c != ' '))
        {
            DisplayAlert("Oops", "Please enter a valid phone number (digits only).", "OK");
            return;
        }

        int sum = phone.Where(char.IsDigit).Sum(c => c - '0');
        int index = sum % 12;
        if (index == 0) index = 12;
        index--;

        var data = ZodiacData[index];

        ZodiacLabel.Text = data.Sign;
        BirthstoneLabel.Text = $"Birthstone: {data.Birthstone}";
        LuckLabel.Text = data.Luck;

        ResultFrame.IsVisible = true;
    }
}