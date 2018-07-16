using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module6;
using Module6.Model;


namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (mcsContext db = new mcsContext())
            {
                foreach (var stopReason in db.TablesStopReasons)
                {
                    Console.WriteLine(stopReason.intStopReason + "\t" + stopReason.strReason);
                }
            }
        }
    }
}
