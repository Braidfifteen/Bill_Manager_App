using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class BillData
    {
        private IOutput output;
        private string name = "N/A";
        private double totalAmountOwed = 0.0;
        private double monthlyAmountOwed = 0.0;
        private DateTime monthlyDueDate;
        bool monthlyDuePayed;

        public BillData(string name, double totalAmount, double monthlyOwed, DateTime dueDate) : this()
        {
            this.name = name;
            totalAmountOwed = totalAmount;
            monthlyAmountOwed = monthlyOwed;
            monthlyDueDate = dueDate;
        }

        public BillData(string name, double totalAmount, double monthlyOwed) : this()
        {
            this.name = name;
            totalAmountOwed = totalAmount;
            monthlyAmountOwed = monthlyOwed;
        }

        public BillData(string name, double monthlyOwed) : this()
        {
            this.name = name;
            monthlyAmountOwed = monthlyOwed;
        }

        public BillData()
        {
            output = new PrintBillInfo(this);
        }

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

        public void PrintBill()
        {
            output.Print();
        }
    }

    class PrintBillInfo : IOutput
    {
        private BillData bill;

        public PrintBillInfo(BillData bill)
        {
            this.bill = bill;
        }

        public void Print()
        {
            printBillName();
            printMonthlyAmount();
        }

        private void printBillName()
        {
            Console.WriteLine("Bill Name: {0}", bill.Name);
            Console.WriteLine();
        }

        private void printMonthlyAmount()
        {
            Console.WriteLine("Monthly Amount Due: {0}", bill.MonthlyAmountOwed());
            Console.WriteLine();
        }
    }
}
