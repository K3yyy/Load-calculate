using System.ComponentModel;

namespace MauiApp1.ViewModels;

public class EmployeeDetailViewModels1 : INotifyPropertyChanged
{
    private string employeeId = string.Empty;
    private string employeeName = string.Empty;
    private string email = string.Empty;
    private bool isPartTime;

    public string EmployeeId
    {
        get => employeeId;
        set { employeeId = value; Notify(nameof(EmployeeId)); }
    }

    public string EmployeeName
    {
        get => employeeName;
        set { employeeName = value; Notify(nameof(EmployeeName)); }
    }

    public string Email
    {
        get => email;
        set { email = value; Notify(nameof(Email)); }
    }

    public bool IsPartTime
    {
        get => isPartTime;
        set { isPartTime = value; Notify(nameof(IsPartTime)); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void Notify(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}