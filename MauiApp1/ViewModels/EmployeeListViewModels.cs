using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;

namespace MauiApp1.ViewModels;

public partial class EmployeeListViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Employee> employees = new();

    [ObservableProperty]
    private Employee employee = new();

    [RelayCommand]
    private void Add()
    {
        Employees.Add(Employee);
        Employee = new Employee();
    }
}