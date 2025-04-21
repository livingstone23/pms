namespace Infraestructure;



/// <summary>
/// Sección de constantes para la aplicación
/// </summary>
public class Constants
{
    
    public const string DEFAULT_PASSWORD = "NeedReset%123";


    public const string STATUS_OPEN = "OPEN";
    public const string STATUS_NEW = "NEW";
    public const string STATUS_CLOSED = "CLOSED";


    public const string ROLE_ADMIN_ID = "48395B9B-4F2A-4E8C-8D3B-0A1E5F7B9C6D";
    public const string ROLE_USER_ID = "A4F5E8B2-3C6D-4E8C-8D3B-0A1E5F7B9C6D";


    public const string ROLE_ADMIN = "Admin";
    public const string ROLE_USER = "User";


    public static readonly Dictionary<string, string> UserRoles = new Dictionary<string, string>
    {
        { ROLE_ADMIN_ID, ROLE_ADMIN },
        { ROLE_USER_ID, ROLE_USER }
    };


    public const string DEFAULT_AVATAR = "avatar.png";


}
