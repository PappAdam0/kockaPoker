using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kockaPoker
{
    class Dobas
    {
        int[] kockak = new int[5];
        public Dobas(int k1, int k2, int k3, int k4, int k5)
        {
            kockak[0] = k1;
            kockak[1] = k2;
            kockak[2] = k3;
            kockak[3] = k4;
            kockak[4] = k5;

        }

        public void EgyDobas()
        {
            Random vel = new Random();

            for (int i = 0; i < kockak.Length; i++)
            {
                kockak[i] = vel.Next(1,6);
            }
            
        }

        public void Kiiras()
        {
            foreach (var i in kockak)
            {
                Console.Write($"{i} ");
            }
        }

        public string Erteke()
        {
            Dictionary<int, int> eredmenyek = new Dictionary<int, int>();
            string r = " ";
            for (int i  = 0; i <= 6; i ++)
            {
                eredmenyek.Add(i, 0);
            }
            foreach (var i in kockak)
            {
                eredmenyek[i]++;
            }

            if (eredmenyek.ContainsValue(5))
            {
                r=  "Nagypóker";
            }
            else if (eredmenyek.ContainsValue(4))
            {
                r= "Póker";
            }
            else if (eredmenyek.ContainsValue(2) && eredmenyek.ContainsValue(3))
            {
                r = "Full";
            }
            else if (eredmenyek.ContainsValue(3))
            {
                r= "Drill";
            }
            else if (eredmenyek.ContainsValue(2))
            {
                r= "Pár";
            }
           

            return r;
        }
           
    }
}
