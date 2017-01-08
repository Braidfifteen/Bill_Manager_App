using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class BillData
    {
        private string name;
        private double totalAmountOwed;
        private double monthlyAmountOwed;
        private DateTime monthlyDueDate;
        bool monthlyDuePayed;

        public BillData(string name, double totalAmount, double monthlyOwed, DateTime dueDate)
        {
            this.name = name;
            totalAmountOwed = totalAmount;
            monthlyAmountOwed = monthlyOwed;
            monthlyDueDate = dueDate;
        }

        public BillData(string name, double totalAmount, double monthlyOwed)
        {
            this.name = name;
            totalAmountOwed = totalAmount;
            monthlyAmountOwed = monthlyOwed;
        }

        public BillData(string name, double monthlyOwed)
        {
            this.name = name;
            monthlyAmountOwed = monthlyOwed;
        }

        public BillData() {}

        public string Name { get { return name; } set { name = value; } }

        public void TotalAmountOwed(double amount)
        {
            totalAmountOwed = amount;
        }

        public string TotalAmountOwed()
        {
            return string.Format("{0:C}", totalAmountOwed);
        }

        public void MonthlyAmountOwed(double amount)
        {
            monthlyAmountOwed = amount;
        }

        public string MonthlyAmountOwed()
        {
            return string.Format("{0:C}", monthlyAmountOwed);
        } 
    }
}
