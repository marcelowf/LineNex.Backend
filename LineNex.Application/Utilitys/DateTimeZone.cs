namespace LineNex.Application.Utilitys
{
    public class DateTimeZone
    {
        public static DateTime HrBrasilia(DateTime prmDate)
        {
            TimeZoneInfo hrBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(prmDate, hrBrasilia);
        }
    }
}
