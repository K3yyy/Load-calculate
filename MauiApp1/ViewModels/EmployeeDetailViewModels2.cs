using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels;

public partial class EmployeeDetailViewModels2 : ObservableObject
{
    [ObservableProperty]
    private string employeeId = string.Empty;

    [ObservableProperty]
    private string employeeName = string.Empty;

    [ObservableProperty]
    private string email = string.Empty;

    [ObservableProperty]
    private bool isPartTime;
}