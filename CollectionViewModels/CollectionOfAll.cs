using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital.Models;

namespace Hospital.CollectionViewModels
{
    public class CollectionOfAll
    {
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
    }
}