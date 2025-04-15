namespace PVM.TMU.Extensions;

public static class ValueExtensions
{

    public static int? ToNullableInteger(this string value)
    {
        int result;
        bool isSuccess = int.TryParse(value, out result);

        if (isSuccess)
        {
            return result;
        }

        return null;

    }

}