using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolaBami2019Sol
{
    public class Grandkid : ChildAbstract
    {
        public override void AddMe(int numOne, double numTwo)
        {
            addResult = numOne + numTwo;

        }
    }
}
