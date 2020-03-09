using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
namespace 登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //实例化model层中的userinfo类用于传递数据
        UserInfo m_userInfo = new UserInfo();
        //实例化BLL层
        userBLL b_userAccess = new userBLL();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {//登录按钮触发事件
            //将用户输入的账号密码，赋值给userInfo类 username,psw属性
            m_userInfo.username = txt_name.Text.Trim().ToString();
            m_userInfo.password = txt_pwd.Text.Trim().ToString();
            if(txt_name.Text==""||txt_pwd.Text=="")
            {//用户名和密码不能有一个为空
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                //如果BLL层中的userlogin调用返回记录条数大于 1，则账号密码正确
                if (b_userAccess.userLogin(m_userInfo) > 0)
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {//注册按钮触发事件
            //将用户输入的账号密码，赋值给userInfo类 username,psw属性
            m_userInfo.username = txt_name.Text.Trim().ToString();
            m_userInfo.password = txt_pwd.Text.Trim().ToString();
            if (txt_name.Text == "" || txt_pwd.Text == "")
            {//用户名和密码不能有一个为空
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                //如果BLL层中的userlogin调用返回记录条数大于 1，则账号密码正确
                if (b_userAccess.userRegister(m_userInfo) > 0)
                {
                    MessageBox.Show("注册成功");
                }
                else
                {
                    MessageBox.Show("注册失败");
                }
            }
        }

    }
}
