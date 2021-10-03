using CSharpMortgage2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpMortgage2.Helpers
{
    public class LoanHelper
    {
        public Loan GetPayments(Loan loan)
        {

            //Calculate my monthly Payment
            loan.Payment = CalcPayment(loan.Amount, loan.Rate, loan.Term);
            //Create loop from 1 to the term
            var balance = loan.Amount;
            var totalInterest = 0.0m;
            var monthlyInterest = 0.0m;
            var monthlyPrincipal = 0.0m;
            var monthlyRate = CalcMonthlyRate(loan.Rate);
            //Calculate a payement schedule
            for (int i = 0; i < length; i++)
            {

            }
            //Push payments in the loan

            //return the loan to the veiw

            return loan;
        }

        private decimal CalcPayment(decimal amount, decimal rate, int term)
        {
            var monthlyRate = CalcMonthlyRate(rate);
            var rateD = Convert.ToDouble(monthlyRate);
            var amountD = Convert.ToDouble(amount);

            var paymentD = (amountD * rateD) / (1 - Math.Pow(1 + rateD, -term));

            return Convert.ToDecimal(paymentD);
        }

        private decimal CalcMonthlyRate(decimal rate)
        {
            return rate / 1200;
        }

    }
}
