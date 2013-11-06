using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataBinding
{
    class ListEmployee : List<Employee> {
        public ListEmployee(List<Employee> l) : base(l) { }
        public ListEmployee() : base() { }
        public ListEmployee(int capicity) : base(capicity) { }
    }
}
