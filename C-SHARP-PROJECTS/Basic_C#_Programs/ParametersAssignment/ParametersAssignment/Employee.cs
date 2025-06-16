using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        // Generic list matching the generic type of the class
        public List<T> Things { get; set; }
    }
}
