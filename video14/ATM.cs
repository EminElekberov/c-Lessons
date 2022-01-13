using System;
namespace video14
{
    public class ATM
    {
        public event Action<double, double> BalanceFinished;
        public event Action<double, double, DateTime> TransferSuuccessFuly;
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
            }
        }
        public ATM(double Balanceamount)
        {
            Balance = Balanceamount;

        }
        public void WithDraw(double amount)
        {
            if (Balance>=amount)
            {
                Balance -= amount;
                if (TransferSuuccessFuly!=null)
                {
                    TransferSuuccessFuly.Invoke(amount, Balance, DateTime.Now);
                }
                return;
            }
            else
            {
                if (BalanceFinished!=null)
                {
                    BalanceFinished.Invoke(amount,Balance);
                }
            }
        }

    }
}
