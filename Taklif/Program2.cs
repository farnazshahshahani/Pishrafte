using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Teacher
    {
        private string id;
        private string name;
        private string lastname;
        private int hours;
        private int payperonhoure;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public int Payperhour
        {
            get { return payperonhoure; }
            set
            {
                if (value > 0)
                {
                    payperonhoure = value;
                }
            }
        }
        public Teacher() { }
        public Teacher(string id, string name, string lastname, int hours, int payperhour)
        {
            id = Id;
            name = Name;
            lastname = Lastname;
            hours = Hours;
            payperhour = Payperhour;
        }
        public long payment()
        {
            return hours * payperonhoure;
        }
    }
    public class Program2
    {
        
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("1", "ali", "abasi", 20, 1000);
            long pay = teacher.payment();
            Console.WriteLine(pay);
        }
    }
}