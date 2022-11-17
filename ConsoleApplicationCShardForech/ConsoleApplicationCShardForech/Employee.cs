using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCShardForech
{
    internal class Employee
    {
        //Atributos privados de la clase, siempre se recomiendan que sean privados
        private string _IDEmployee;
        private string _Name;
        private string _LastName;
        private long _Salary;
        private DateTime _ContractDate;

        //Constructores son siempre public
        public Employee(string iDEmployee, string name, string lastName, long salary, DateTime contractDate)
        {
            _IDEmployee = iDEmployee;
            _Name = name;
            _LastName = lastName;
            _Salary = salary;
            _ContractDate = contractDate;
        }
        public Employee()
        {
        }

        //Propiedades
        public string IDEmployee
        {
            get { return _IDEmployee; } set { _IDEmployee = value; } 
        }
        public string Name
        {
            get { return _Name; } set { _Name = value; }
        }
        public string LastName
        {
            get { return _LastName; } set { _LastName = value; }
        }
        public long Salary
        {
            get { return _Salary; } set { _Salary = value; }
        }
        public DateTime ContractDate
        {
            get { return _ContractDate; } set { _ContractDate = value; }
        }

        //Metodos
        public override string ToString()
        {
            return "ID Employee" + IDEmployee + "\n" 
                + "\tNombres...................." + _Name + "\n"
                + "\tApellidos.................." + _LastName + "\n"
                + "\tSalario...................." + _Salary + "\n"
                + "\tFecha de contratacion......" + _ContractDate + "\n";
        }
    }
}
