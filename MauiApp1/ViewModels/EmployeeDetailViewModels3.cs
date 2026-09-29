using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.Models;

namespace MauiApp1.ViewModels;

public partial class EmployeeDetailViewModels3 : ObservableObject
{
    [ObservableProperty]
    private Employee employee = new();
}