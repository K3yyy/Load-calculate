using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class EmployeeDetailPage : ContentPage
{
    public EmployeeDetailPage()
    {
        InitializeComponent();
        BindingContext = new EmployeeDetailViewModels
        {
            EmployeeId = "1001",
            EmployeeName = "John Thomas",
            Email = "johnthomas@gmail.com",
            IsPartTime = true
        };
    }
}