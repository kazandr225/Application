using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application
{
    public class MaskEmployees
    {
        public MaskEmployees(Employee mask)
        {
            id = mask.id_Employee;
            Surname = mask.Surname;
            Name = mask.Name;
            Patronymic = mask.Patronymic;
            Image = Convert.ToString(mask.img);
        }

        public int id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Image { get; set; }

    }
}