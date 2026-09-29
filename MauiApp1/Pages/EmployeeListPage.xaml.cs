using MauiApp1.Models;
using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class EmployeeListPage : ContentPage
{
    public EmployeeListPage()
    {
        InitializeComponent();
        BindingContext = new EmployeeListViewModel();
    }

    private async void ListView_ItemTapped(object? sender, ItemTappedEventArgs e)
    {
        if (e.Item is not Employee employee)
            return;

        var page = new EmployeeDetailPage3
        {
            BindingContext = new EmployeeDetailViewModels3 { Employee = employee }
        };
        await Navigation.PushAsync(page);
    }
}