using Module6_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Module6_2  //CodeFirst Automatic
{
    class Program
    {
        static void Main(string[] args)
        {

            //Expl1();

            Expl2();

            //using (mcs db = new mcs())
            //{
            //    foreach (var stopReason in db.AccessTab)
            //    {
            //        Console.WriteLine(stopReason.TabId + "\t" + stopReason.GroupId + "\t" + stopReason.TabName);
            //    }
            //}
        }

        public static void Expl1()  // прямая загрузка
        {
            mcs db = new mcs();

            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));

            List<AccessTab> tabs =
                db.AccessTab.Include(c => c.AccessUsers).ToList();

            int t = 1;
            foreach (var i in tabs)
            {
                t++;
                Console.WriteLine(i.TabName);
                foreach (var j in i.AccessUsers)
                {
                    Console.WriteLine("\t -->" + j.UserId);
                }
            }

            Console.WriteLine("Count:" + t);
        }

       
        public static void Expl2() // явная загрузка
        {
            mcs db = new mcs();
            //загрузка одной вкладки
            AccessTab tab =
                db.AccessTab
                    .Where(w => w.TabId == 1)
                    .FirstOrDefault();

            // загрузка связанные данные с этой вкладки
            db.Entry(tab)
                .Collection(c => c.AccessUsers)
                .Load();

            Console.WriteLine(tab.TabName);
            foreach (var tabAccessUser in tab.AccessUsers)
            {
                Console.WriteLine("\t --> " + tabAccessUser.UserId);
            }
        }
    }
}
