using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class BillDatabase
    {
        private static BillDatabase instance;
        private List<BillData> database;

        private BillDatabase() {}

        public static BillDatabase Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDatabase();
                return instance;
            }
        }

        public List<BillData> Database
        {
            get
            {
                return database;
            }
        }
    }
}
