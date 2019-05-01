using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
     public    class ChildClass : ParentClass



     {
         public void CallMyBankDetails()
         {
            
            base.CallMyMoney(100000, " £ ");
            base.SetMyAccount(" Bunmi MoneySpeaking ");
        }


     }
}
