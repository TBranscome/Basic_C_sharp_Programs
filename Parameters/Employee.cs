using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Employee<T> : Person //Make the Employee class take a generic type parameter
    {
        public int Id { get; set; }
        public List<T> things;//Added property with generic list data type 
       
    }
}
