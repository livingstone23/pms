namespace PVM.TMU.Extensions;



public static class DateTimeExtensions
{

    public static string BeautifyDate(this DateTime datetime)
    {

        return datetime.ToString("dd MMMM yyy hh:mm tt");

    }

}