using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class userBLL
    {
        userDAL d_userAccess = new userDAL();
        public int userLogin(UserInfo m_userInfo)//把model层的值传过来进行比对
        {
            return d_userAccess.userLogin(m_userInfo.username, m_userInfo.password);//如果有返回值则登录成功
        }
        public int userRegister(UserInfo m_userInfo)//把model层的值传过来进行插入数据库
        {
            return d_userAccess.userRegister(m_userInfo.username, m_userInfo.password);//如果有返回值则登录成功
        }
    }
}
