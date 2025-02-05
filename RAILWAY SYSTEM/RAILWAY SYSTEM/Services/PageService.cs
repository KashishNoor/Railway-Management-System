﻿using CommunityToolkit.Mvvm.ComponentModel;

using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.Contracts.Services;
using RAILWAY_SYSTEM.ViewModels;
using RAILWAY_SYSTEM.Views;

namespace RAILWAY_SYSTEM.Services;

public class PageService : IPageService
{
    private readonly Dictionary<string, Type> _pages = new();

    public PageService()
    {
        Configure<SignupViewModel, SignupPage>();
        Configure<LoginViewModel, LoginPage>();
        Configure<AdminViewModel, AdminPage>();
        Configure<PassengerViewModel, PassengerPage>();
        Configure<EmployeesViewModel, EmployeesPage>();
        Configure<SettingsViewModel, SettingsPage>();
        Configure<CheckProfileViewModel, CheckProfilePage>();
        Configure<ManageEmployeesViewModel, ManageEmployeesPage>();
        Configure<TrainSchedule_ManagementViewModel, TrainSchedule_ManagementPage>();
        Configure<ViewTrainsViewModel, ViewTrainsPage>();
        Configure<Task_AssesmentViewModel, Task_AssesmentPage>();
        Configure<ViewFeedbackViewModel, ViewFeedbackPage>();
        Configure<ADD_EMPLOYEEViewModel, ADD_EMPLOYEEPage>();
        Configure<Update_EmployeeViewModel, Update_EmployeePage>();
        Configure<Delete_EmployeeViewModel, Delete_EmployeePage>();
        Configure<Add_ScheduleViewModel, Add_SchedulePage>();
        Configure<Update_ScheduleViewModel, Update_SchedulePage>();
        Configure<Delete_ScheduleViewModel, Delete_SchedulePage>();
        Configure<RevenueViewModel, RevenuePage>();
    }

    public Type GetPageType(string key)
    {
        Type? pageType;
        lock (_pages)
        {
            if (!_pages.TryGetValue(key, out pageType))
            {
                throw new ArgumentException($"Page not found: {key}. Did you forget to call PageService.Configure?");
            }
        }

        return pageType;
    }

    private void Configure<VM, V>()
        where VM : ObservableObject
        where V : Page
    {
        lock (_pages)
        {
            var key = typeof(VM).FullName!;
            if (_pages.ContainsKey(key))
            {
                throw new ArgumentException($"The key {key} is already configured in PageService");
            }

            var type = typeof(V);
            if (_pages.ContainsValue(type))
            {
                throw new ArgumentException($"This type is already configured with key {_pages.First(p => p.Value == type).Key}");
            }

            _pages.Add(key, type);
        }
    }
}
