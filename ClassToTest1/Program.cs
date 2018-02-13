using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassToTest1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Reservation
    {
        private User m_MadeBy { get; set; }

        public bool CanByCanceldBy(User i_User)
        {
            bool IsCancel = false;
            if (i_User.IsAdmin)
            {
                IsCancel = true;
            }

            if (m_MadeBy == i_User)
            {
                IsCancel = true;
            }

            return IsCancel;
        }
        
        public int returnMax(int a , int b )
        {

            if (a > b)
                return a;
            if (b > a)
                return b;
            if (a == b)
                return a + b;
            return a;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }

    public class MathEX
    {
        public int  Add(int i_A , int i_B)
        {
            return i_A + i_B;
        }

        public int Mul(int i_A, int i_B)
        {
            return i_A * i_B;
        }

        public int Dec(int i_A, int i_B)
        {
            return i_A - i_B;
        }
    }


}
