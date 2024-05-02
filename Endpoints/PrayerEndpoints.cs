namespace MAPI.Endpoints
{
    public static class PrayerEndpoints
    {
        public static void MapPrayerEndpoints(this WebApplication app)
        {
            //Base URL
            var group = app.MapGroup("api/prayer");
            group.MapGet("", GetPrayers).WithName("GetPrayerTimes").WithOpenApi();
        }

        public static string GetPrayers()
        {
            return "Hello, World!";
        }
    }
}
