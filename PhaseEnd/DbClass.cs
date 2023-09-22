using PhaseEnd.Models;

namespace PhaseEnd
{
    public class DbClass
    {
        static Phase4DbContext db;
        public DbClass()
        {
            db = new Phase4DbContext();
        }
        public UserInfo AddUser(UserInfo userInfo)
        {
            db.UserInfos.Add(userInfo);
            db.SaveChanges();
            return userInfo;
        }
    }
}
