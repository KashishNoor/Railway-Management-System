﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;

using RAILWAY_SYSTEM.Activation;
using RAILWAY_SYSTEM.Contracts.Services;
using RAILWAY_SYSTEM.Core.Contracts.Services;
using RAILWAY_SYSTEM.Core.Services;
using RAILWAY_SYSTEM.Helpers;
using RAILWAY_SYSTEM.Models;
using RAILWAY_SYSTEM.Notifications;
using RAILWAY_SYSTEM.Services;
using RAILWAY_SYSTEM.ViewModels;
using RAILWAY_SYSTEM.Views;

namespace RAILWAY_SYSTEM;

// To learn more about WinUI 3, see https://docs.microsoft.com/windows/apps/winui/winui3/.
public partial class App : Application
{
    // The .NET Generic Host provides dependency injection, configuration, logging, and other services.
    // https://docs.microsoft.com/dotnet/core/extensions/generic-host
    // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
    // https://docs.microsoft.com/dotnet/core/extensions/configuration
    // https://docs.microsoft.com/dotnet/core/extensions/logging
    public IHost Host
    {
        get;
    }

    public static T GetService<T>()
        where T : class
    {
        if ((App.Current as App)!.Host.Services.GetService(typeof(T)) is not T service)
        {
            throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.");
        }

        return service;
    }

    public static WindowEx MainWindow { get; } = new MainWindow();

    public static UIElement? AppTitlebar { get; set; }

    public App()
    {
        InitializeComponent();

        Host = Microsoft.Extensions.Hosting.Host.
        CreateDefaultBuilder().
        UseContentRoot(AppContext.BaseDirectory).
        ConfigureServices((context, services) =>
        {
            // Default Activation Handler
            services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();

            // Other Activation Handlers
            services.AddTransient<IActivationHandler, AppNotificationActivationHandler>();

            // Services
            services.AddSingleton<IAppNotificationService, AppNotificationService>();
            services.AddSingleton<ILocalSettingsService, LocalSettingsService>();
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddTransient<INavigationViewService, NavigationViewService>();

            services.AddSingleton<IActivationService, ActivationService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // Core Services
            services.AddSingleton<IFileService, FileService>();

            // Views and ViewModels
            services.AddTransient<RevenueViewModel>();
            services.AddTransient<RevenuePage>();
            services.AddTransient<Delete_ScheduleViewModel>();
            services.AddTransient<Delete_SchedulePage>();
            services.AddTransient<Update_ScheduleViewModel>();
            services.AddTransient<Update_SchedulePage>();
            services.AddTransient<Add_ScheduleViewModel>();
            services.AddTransient<Add_SchedulePage>();
            services.AddTransient<Delete_EmployeeViewModel>();
            services.AddTransient<Delete_EmployeePage>();
            services.AddTransient<Update_EmployeeViewModel>();
            services.AddTransient<Update_EmployeePage>();
            services.AddTransient<ADD_EMPLOYEEViewModel>();
            services.AddTransient<ADD_EMPLOYEEPage>();
            services.AddTransient<ViewFeedbackViewModel>();
            services.AddTransient<ViewFeedbackPage>();
            services.AddTransient<Task_AssesmentViewModel>();
            services.AddTransient<Task_AssesmentPage>();
            services.AddTransient<ViewTrainsViewModel>();
            services.AddTransient<ViewTrainsPage>();
            services.AddTransient<TrainSchedule_ManagementViewModel>();
            services.AddTransient<TrainSchedule_ManagementPage>();
            services.AddTransient<ManageEmployeesViewModel>();
            services.AddTransient<ManageEmployeesPage>();
            services.AddTransient<CheckProfileViewModel>();
            services.AddTransient<CheckProfilePage>();
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<SettingsPage>();
            services.AddTransient<EmployeesViewModel>();
            services.AddTransient<EmployeesPage>();
            services.AddTransient<PassengerViewModel>();
            services.AddTransient<PassengerPage>();
            services.AddTransient<AdminViewModel>();
            services.AddTransient<AdminPage>();
            services.AddTransient<LoginViewModel>();
            services.AddTransient<LoginPage>();
            services.AddTransient<SignupViewModel>();
            services.AddTransient<SignupPage>();
            services.AddTransient<ShellPage>();
            services.AddTransient<ShellViewModel>();

            // Configuration
            services.Configure<LocalSettingsOptions>(context.Configuration.GetSection(nameof(LocalSettingsOptions)));
        }).
        Build();

        App.GetService<IAppNotificationService>().Initialize();

        UnhandledException += App_UnhandledException;
    }

    private void App_UnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
    {
        // TODO: Log and handle exceptions as appropriate.
        // https://docs.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.application.unhandledexception.
    }

    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);

        App.GetService<IAppNotificationService>().Show(string.Format("AppNotificationSamplePayload".GetLocalized(), AppContext.BaseDirectory));

        await App.GetService<IActivationService>().ActivateAsync(args);
    }
}
