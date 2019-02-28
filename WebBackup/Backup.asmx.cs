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
            BackupService backupService=new BackupService(ConfigurationManager.ConnectionStrings["Database"].ToString(),
                System.AppDomain.CurrentDomain.BaseDirectory+@"Backup");
            backupService.BackupDatabase("FwEmpty");
            return "Backup is Done";
        }
    }
}
