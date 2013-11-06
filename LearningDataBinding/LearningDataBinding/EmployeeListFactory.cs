using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataBinding
{
    class EmployeeListFactory
    {
        private static string[] names = {"Adam", "Bartosz", "Cezary", "Damian", "Edgar" };
        private static string[] surnames = { "Zieliński", "Wąż", "Ułan", "Traczyk", "Starzyński", "Rejtan", "Potocki" };
        private static string[] titles = { "mgr", "inż.", "lic.", "insz", "dr", "dr hab.", "prof.", "mgr inż.", "gen. bryg.", "płk.", "o." };
        private static string[] departments = { "Sprzedaż", "Produkcja", "Administracja" };
        //abcdefghijklmnoprstuwz
        private int seed;

        public EmployeeListFactory(int seed)
        {
            this.seed = seed;
        }

        public List<Employee> CreateList(int n)
        {
            List<Employee> result = new List<Employee>();
            for (int i = 0; i < n; i++)
                result.Add(CreateEmployee(i));
            return result;
        }

        private Employee CreateEmployee(int i)
        {
            Employee e = new Employee();
            e.EmployeeNumber = i;
            e.FirstName = NameGenerator(i);
            e.LastName = SurnameGenerator(i);
            e.Title = TitleGenerator(i);
            e.Department = DepartmentGenerator(i);
            return e;
        }

        private string NameGenerator(int i)
        {
            return names[(seed + i) % names.Length];
        }
        private string SurnameGenerator(int i)
        {
            return surnames[(seed + i) % surnames.Length];
        }
        private string TitleGenerator(int i)
        {
            return titles[(seed + i) % titles.Length];
        }
        private string DepartmentGenerator(int i)
        {
            return departments[(seed + i) % departments.Length];
        }

    }
}
