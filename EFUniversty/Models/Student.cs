using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUniversty.Models;
public class Student:BaseClass
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Adress { get; set; }
    public string? Email { get; set; }
    public DateTime Birthdate { get; set; }
    public string?  Phone { get; set; }
    public int UniversityId { get; set; }
    public Universty Universty { get; set; }
}
