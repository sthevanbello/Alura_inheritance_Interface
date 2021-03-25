using ByteBank.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    class BonificationManager
    {
        private double _totalBonification;
        public void Register(Employee employee)
        {
            _totalBonification += employee.GetBonification();
        }
        public void Register(Director director)
        {
            _totalBonification += director.GetBonification();
        }

        public double GetTotalBonification()
        {
            return _totalBonification;
        }
    }
}
