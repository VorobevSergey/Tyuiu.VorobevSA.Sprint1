using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VorobevSA.Sрrint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            char[] text = value.ToCharArray();
            int k = 0;
            for (int i = 0; i < value.Length; i++)
                if (Char.IsLetter(text[i])) k++;
        }
    }
}
