using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._09._2024_Smirnov_Andreew_wpf_sqlite.Class
{
    public class User
    {
        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
