namespace RAILWAY_SYSTEM.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
