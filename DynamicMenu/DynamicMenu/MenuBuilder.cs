using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMenu
{
    public class MenuBuilder
    {
        protected class MenuNode
        {
            public int nodeid { get; set; }
            public int parentid { get; set; }
            public string nodename { get; set; }
            public string nodetype { get; set; }
            public bool haschild { get; set; }
        }
        protected static List<MenuNode> menunodes = new List<MenuNode>();
        public MenuBuilder()
        {
            string qeuryString = ""
                + "            with recursive r as ("
                + "            select m.nodeid,m.parentid,m.nodename,m.nodetype,1 as level,(p.parentid is not null) as haschild"
                + "            from tovvp.fox_sys_menu m"
                + "               left join (select distinct parentid from tovvp.fox_sys_menu) p on (p.parentid=m.nodeid)"
                + "            where m.parentid=0"
                + "            union all"
                + "            select m.nodeid,m.parentid,m.nodename,m.nodetype,r.level+1 as level,(p.parentid is not null) as haschild "
                + "            from tovvp.fox_sys_menu m"
                + "                join r on (m.parentid=r.nodeid)"
                + "                left join (select distinct parentid from tovvp.fox_sys_menu) p on (p.parentid=m.nodeid)"
                + "           )"
                + "select * from r;";

            //System.Data.DataTable dt = DatabaseManager.doQuery(new Npgsql.NpgsqlCommand("select nodeid,parentid,nodename,nodetype from tovvp.fox_sys_menu;"));
            try
            {
                System.Data.DataTable dt = DatabaseManager.doQuery(new Npgsql.NpgsqlCommand(qeuryString));


                foreach (System.Data.DataRow row in dt.Rows)
                {
                    menunodes.Add(new MenuNode
                    {
                        nodeid = (int)row["nodeid"],
                        parentid = (int)row["parentid"],
                        nodename = row["nodename"].ToString(),
                        nodetype = row["nodetype"].ToString(),
                        haschild = (bool)row["haschild"]
                    });
                }

                var rootNodes = from menunode in menunodes
                                where menunode.parentid == 0
                                orderby menunode.nodeid ascending
                                select menunode;
            }
            catch (Exception) { }
        }
    }
}
