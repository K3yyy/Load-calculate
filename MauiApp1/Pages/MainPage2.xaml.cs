using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class MainPage2 : ContentPage
{
    public MainPage2()
    {
        InitializeComponent();
    }

    private async void EmployeeButton1_Clicked(object? sender, EventArgs e)
    {
        await Open(new EmployeeDetailViewModels2
        {
            EmployeeId = "1001",
            EmployeeName = "John Thomas",
            Email = "johnthomas@gmail.com",
            IsPartTime = true
        });
    }

    private async void EmployeeButton2_Clicked(object? sender, EventArgs e)
    {
        await Open(new EmployeeDetailViewModels2
        {
            EmployeeId = "1002",
            EmployeeName = "Peter",
            Email = "peter@gmail.com",
            IsPartTime = false
        });
    }

    private async void EmployeeButton3_Clicked(object? sender, EventArgs e)
    {
        await Open(new EmployeeDetailViewModels2
        {
            EmployeeId = "1003",
            EmployeeName = "Andraw",
            Email = "andraw@gmail.com",
            IsPartTime = true
        });
    }

    private Task Open(EmployeeDetailViewModels2 vm)
    {
        var page = new EmployeeDetailPage2 { BindingContext = vm };
        return Navigation.PushAsync(page);
    }
}