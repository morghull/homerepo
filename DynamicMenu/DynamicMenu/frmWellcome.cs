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
        private const int Xwid = 8;
        private const int tab_margin = 5;
        private Graphics g;
        public frmWellcome()
        {
            InitializeComponent();

            //DataTable dt = DatabaseManager.doQuery(new Npgsql.NpgsqlCommand("select nodeid,parentid,nodename,nodetype from tovvp.fox_sys_menu;"));
            //MenuBuilder mb = new MenuBuilder();

            testTabControl.SizeMode = TabSizeMode.Fixed;
            testTabControl.DrawItem += (s, e) =>
            {
                //This code will render a "x" mark at the end of the Tab caption.
                g = e.Graphics;
                e.Graphics.DrawString("x", e.Font, Brushes.Gray, e.Bounds.Right - 17, e.Bounds.Top + 3);
                e.Graphics.DrawString(this.testTabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
                e.Graphics.DrawRectangle(new Pen(Brushes.Gray), e.Bounds.Right - 18, e.Bounds.Top + 6, 12, 12);
                e.DrawFocusRectangle();


                //Brush box_brush;
                //Pen box_pen = (Pen)Pens.Gray.Clone();
                //box_pen.Width = 1.8F;
                //box_brush = Brushes.Silver;
                //box_pen = Pens.Gray;

                //Rectangle tab_rect = this.testTabControl.GetTabRect(e.Index);
                //RectangleF layout_rect = new RectangleF(
                //                tab_rect.Left + tab_margin,
                //                tab_rect.Top + tab_margin,
                //                tab_rect.Width - 2 * tab_margin,
                //                tab_rect.Height - 2 * tab_margin);
                //e.Graphics.FillRectangle(box_brush,
                //    layout_rect.Right - Xwid,
                //    layout_rect.Top,
                //    Xwid,
                //    Xwid);
                //e.Graphics.DrawRectangle(box_pen,
                //    e.Bounds.Right - 18,
                //    e.Bounds.Top + 6,
                //    12,
                //    12);
                //e.Graphics.DrawLine(box_pen,
                //    e.Bounds.Right - 14,
                //    e.Bounds.Top + 7,
                //    e.Bounds.Right - 7,
                //    e.Bounds.Top + 14);
                //e.Graphics.DrawLine(box_pen,
                //    layout_rect.Right - Xwid,
                //    layout_rect.Top + Xwid,
                //    layout_rect.Right,
                //    layout_rect.Top);
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
            testTabControl.MouseHover += (s, e) =>
            {
                var pos = this.testTabControl.PointToClient(Cursor.Position);
                for (int i = 0; i < this.testTabControl.TabPages.Count; i++)
                {
                    Rectangle r = testTabControl.GetTabRect(i);
                    //Getting the position of the "x" mark.
                    Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 15, 15);
                    if (closeButton.Contains(pos))
                    {
                        var g = this.testTabControl.TabPages[i].CreateGraphics();
                        g.DrawRectangle(new Pen(Brushes.Red), this.testTabControl.TabPages[i].Bounds.Right - 18, this.testTabControl.TabPages[i].Bounds.Top + 6, 12, 12);
                    }
                }
            };

        }
    }
}
