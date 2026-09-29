using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void EmployeeButton1_Clicked(object? sender, EventArgs e)
    {
        await Open(new EmployeeDetailViewModels1
        {
            EmployeeId = "1001",
            EmployeeName = "John Thomas",
            Email = "johnthomas@gmail.com",
            IsPartTime = true
        });
    }

    private async void EmployeeButton2_Clicked(object? sender, EventArgs e)
    {
        await Open(new EmployeeDetailViewModels1
        {
            EmployeeId = "1002",
            EmployeeName = "Peter",
            Email = "peter@gmail.com",
            IsPartTime = false
        });
    }

    private async void EmployeeButton3_Clicked(object? sender, EventArgs e)
    {
        await Open(new EmployeeDetailViewModels1
        {
            EmployeeId = "1003",
            EmployeeName = "Andraw",
            Email = "andraw@gmail.com",
            IsPartTime = true
        });
    }

    private Task Open(EmployeeDetailViewModels1 vm)
    {
        var page = new EmployeeDetailPage1 { BindingContext = vm };
        return Navigation.PushAsync(page);
    }
}