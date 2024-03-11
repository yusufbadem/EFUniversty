using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUniversty.Models;
public class Universty:BaseClass
{
    public string Name { get; set; }
    public int CityId { get; set; }
    public City Cities { get; set; }
}
