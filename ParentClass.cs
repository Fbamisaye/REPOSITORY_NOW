using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
     public class ParentClass


     {
         private int MyMoney;
         protected string MyBankAccount;
         protected string UkPounds;

         private int SetMyMoney(int setMoney)
         {
             MyMoney = setMoney;
             return MyMoney;
         }

         protected void CallMyMoney(int param)
         {
             SetMyMoney(param);
         }

         protected void CallMyMoney(int param, int param2)
         {
             MyMoney = param + param2;
             SetMyMoney(MyMoney);
         }
         protected void CallMyMoney(int param,string currency)
         {
             UkPounds = currency;
             MyMoney = param;
             SetMyMoney(MyMoney);
         }

        protected void SetMyAccount(string accountName)
         {
             MyBankAccount = accountName;
         }

         public void DeclareMyBankingDetails()
         {
             Console.WriteLine("My account name is {0} " +
                               " and my balance is {1} &" + 
                                   " I only deal in{2} ", MyBankAccount, MyMoney, UkPounds);
         }


     }
}
