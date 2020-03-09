using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using System.Data;
using System.Configuration;
namespace DAL
{//数据访问层，主要是存放对数据库的访问。也就是数据库的增删改查等操作。
    //DAL就是书写sql语句操作数据库，
    //（就拿登录窗体来说，我们在登录时要输入账号和密码，点击登录时就要与数据库里的数据进行对比，
    //只有验证一致才能登陆成功。这时就要书写sql语句取出数据库里的数据与你在输入框输入的数据进行对比）
    public class userDAL
    {
        //实例化DBbase 对象  
        DBbase db = new DBbase();

        //用户登录的方法  
        public int userLogin(string name, string psw)
        {
            string strsql = "select * from UserInfo where username = '" + name + "' and password = '" + psw + "'";
            return db.returnRowCount(strsql);
        }
        //用户注册的方法
        public int userRegister(string name, string psw)
        {
            string strsql = "insert into UserInfo(username,password) values('" + name + "','" + psw + "')";
            return db.ExecuteNoneQuery(strsql);
        }
    }
}
