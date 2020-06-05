using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Enumeration;
using System.Linq;

namespace zahist
{
   
    
        struct Worker
        {
            public string surName;
            public string initials; //ініціали
            public char descharge; //розряд
            public string profession; //професія
            public char details;//кі-ть деталей на місяць
            public char salary;//зарплата


        }
        class Workers
        {
            List<Worker> workers;
            string filename;
            public Workers(string file)
            {
                if (!File.Exists(file))
                {
                    throw new FileNotFoundException();
                }
                filename = file;
                workers = new List<Worker>();
                LoadFile();
            }
        }
        private void LoadFile()
        {

            string[] words = File.AppendAllText(@filename).Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Workers.Add(new Worker
                {
                    surName = words[i++],
                    initials = words[i++],
                    descharge = Convert.ToChar(words[i++]),
                    profession = words[i++],
                    details = Convert.ToChar(words[i++]),
                 
                    salary = Convert.ToChar(words[i++])
                });
            }
        }
        public void Menu()
        {
            Workers = Workers.ToList();
            foreach (Worker st in workers)
            {
            double aver = (Convert.ToInt32(Convert.ToString(st.salary)));
            if (Convert.ToInt32(st.salary) == '3000')
            {
                Console.WriteLine($"Робітник з найбільшею зарплатнею -{0}{1}{2}, професію {4}, та ранг {3} ",Convert.ToString(st.surName), Convert.ToString(st.initials),
                    Convert.ToString(st.descharge),Convert.ToString(st.profession));
            }
            }
        }
    class Program
    { 
        static void Main(string[] args)
        {
            Workers st = new Workers("input.txt");
            st.Menu();
            Console.ReadKey();
        }
    }
}

