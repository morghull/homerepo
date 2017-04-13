using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicMenu
{
    public partial class frmWellcome : Form
    {
        public frmWellcome()
        {
            InitializeComponent();

            //DataTable dt = DatabaseManager.doQuery(new Npgsql.NpgsqlCommand("select nodeid,parentid,nodename,nodetype from tovvp.fox_sys_menu;"));
            //MenuBuilder mb = new MenuBuilder();

            testTabControl.SizeMode = TabSizeMode.Fixed;
            testTabControl.DrawItem += (s, e) =>
            {
                //This code will render a "x" mark at the end of the Tab caption. 
                e.Graphics.DrawString("x", e.Font, Brushes.Gray, e.Bounds.Right - 15, e.Bounds.Top + 4);
                e.Graphics.DrawString(this.testTabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
                e.DrawFocusRectangle();
            };
            testTabControl.MouseDown += (s, e) =>
            {
                //Looping through the controls.
                for (int i = 0; i < this.testTabControl.TabPages.Count; i++)
                {
                    Rectangle r = testTabControl.GetTabRect(i);
                    //Getting the position of the "x" mark.
                    Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 15, 15);
                    if (closeButton.Contains(e.Location))
                    {
                        //if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                            this.testTabControl.TabPages.RemoveAt(i);
                            break;
                       // }
                    }
                }
            };

        }
    }
}
