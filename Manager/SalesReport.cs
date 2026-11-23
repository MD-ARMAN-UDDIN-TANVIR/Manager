using System;

namespace Manager
{
    public class SalesReport
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public int OrderID { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string TransactionDate { get; set; }
        public string status { get; set; }

        public SalesReport()
        {
            TransactionID = 0;
            UserID = 0;
            OrderID = 0;
            TransactionType = "";
            Amount = 0;
            TransactionDate = "";
            status = "";
        }

        public SalesReport(int tid, int uid, int oid, string ttype, decimal amt, string tdate)
        {
            TransactionID = tid;
            UserID = uid;
            OrderID = oid;
            TransactionType = ttype;
            Amount = amt;
            TransactionDate = tdate;
            status = "";
        }

        public string getTransactionInfo()
        {
            string info = "";
            info = info + "Transaction ID: " + TransactionID;
            info = info + "\n";
            info = info + "User: " + UserID;
            info = info + "\n";
            info = info + "Order: " + OrderID;
            info = info + "\n";
            info = info + "Type: " + TransactionType;
            info = info + "\n";
            info = info + "Amount: " + Amount;
            info = info + "\n";
            return info;
        }

        public bool isTopUp()
        {
            if (TransactionType == "topup")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isRefund()
        {
            if (TransactionType == "refund")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getStatus()
        {
            if (Amount > 100)
            {
                status = "High";
            }
            else if (Amount > 50)
            {
                status = "Medium";
            }
            else
            {
                status = "Low";
            }
            return status;
        }
    }
}