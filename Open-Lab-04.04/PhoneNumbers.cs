using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            string first = String.Join("", numbers[0..3]);
            string second = String.Join("", numbers[3..6]);
            string third = String.Join("", numbers[6..10]);
           
            return "(" + first + ")" + " " + second + "-" + third; 
        }
    }
}
