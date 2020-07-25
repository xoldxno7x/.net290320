using System;
using System.Collections.Generic;
using System.Text;

namespace NewsComp
{
    internal static class NewspaperCalculator
    {
        internal static int CalcNumberOfChars(Newspaper n)
        {
            int sum = 0;

            foreach (Story st in n.GetStories())
            {
                sum += st.GetTitle().Length + st.GetBody().Length;

            }

            return sum;
        }
    }
}
