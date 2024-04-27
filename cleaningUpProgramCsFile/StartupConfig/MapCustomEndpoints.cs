namespace cleaningUpProgramCsFile.StartupConfig;

public static class MapCustomEndpoints
{
    public static WebApplication MapCheckerEndpoint(this WebApplication app)
    {
        app.MapGet("/ping", () => "pong");

        return app;
    }
}
