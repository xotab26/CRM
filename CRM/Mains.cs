using CRM.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Mains : Form
    {
        
        private ContextMenu m_menu;
        private Debug Debug = new Debug();
        private CRM.MySqlData.MySqlExecuteData.MyResultData mysql = new CRM.MySqlData.MySqlExecuteData.MyResultData();
        //client = CRM.MySqlData.MySqlExecuteData.SqlReturnDataset("select * from Client");
        //user = CRM.MySqlData.MySqlExecuteData.SqlReturnDataset("select * from User");
        //private object client = CRM.MySqlData.MySqlExecuteData.SqlReturnDataset("select * from Client");
        internal static string LogPatch = @"C:\" + "\\" + "Log" + ".txt";
        internal static bool debug = false;
        public Mains()
        {
            
            InitializeComponent();         
            Debug.Log("##################################Start#################################");
            #region Tray
            m_menu = new ContextMenu();            
            m_menu.MenuItems.Add(0, new MenuItem("Exit", new System.EventHandler(Exit_Click)));
            m_menu.MenuItems.Add(1, new MenuItem("Login", new System.EventHandler(Login_Click)));
            nTray.ContextMenu = m_menu;
            #endregion

            /*if (mysql.HasError == false)
            {                
                //MessageBox.Show(user.ResultData.DefaultView.Table.Rows[0]["ust"].ToString());
                //MessageBox.Show(user);
            }
            else
            {
                MessageBox.Show(mysql.ErrorText);
            }*/
        }       

        protected void Exit_Click(Object sender, System.EventArgs e)
        {
            Debug.Log("Debug: Exit");
            Close();
        }
        protected void Login_Click(Object sender, System.EventArgs e)
        {
            Debug.Log("Debug: Login");
            Debug.Message("Login");
        }
        private void nTray_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Minimized;

            this.Activate();
        }

        private void Mains_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
    
}
