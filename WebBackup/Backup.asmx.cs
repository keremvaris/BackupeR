using System.Configuration;
using System.Web;
using System.Web.Services;

namespace WebBackup
{
    /// <summary>
    /// Summary description for Backup
    /// </summary>
    [WebService(Namespace = "http://keremvaris.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Backup : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetBackup()
        {
            //Database sizin web configinizde ki connection stringin adı
            BackupService backupService=new BackupService(ConfigurationManager.ConnectionStrings["CONNECTION_KEYNAME"].ToString(),
                System.AppDomain.CurrentDomain.BaseDirectory+@"Backup");
            //
            backupService.BackupDatabase("DATABASE_NAME");
            return "Backup is Done";
        }
    }
}
