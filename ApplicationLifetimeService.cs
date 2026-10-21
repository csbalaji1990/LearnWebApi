public class ApplicationLifetimeService
{
    public ApplicationLifetimeService(
        IHostApplicationLifetime lifetime)
    {
        lifetime.ApplicationStarted.Register(() =>
        {
            Console.WriteLine("Application started");
        });

        lifetime.ApplicationStopping.Register(() =>
        {
            Console.WriteLine("Application is stopping");
        });

        lifetime.ApplicationStopped.Register(() =>
        {
            Console.WriteLine("Application stopped");
        });
    }
}