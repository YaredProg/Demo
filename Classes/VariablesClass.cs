using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Classes
{
    internal class VariablesClass
    {
        public static int userId,BookId;
        public static string userName, userPassword, userJob;
        public static string RegNum, Title, Description, AuthorName, Price,Category;
        public static DateTime YearOfPublication;
        public static Image PicBook,PicUser;
        public static bool backupProcess;
        public static bool updatePermission, insertPermission, printPermission, usersPermission, settingsPermission, MonitorPermission;

    }
}
