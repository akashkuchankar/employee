using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace employee
{
    public class Employee1
    {
        protected int id;
        protected string name;
        protected double basicsalary, hra, da, pf, netpaid;
        private static int count;
        public Employee1(string name, double basicsalary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.basicsalary = basicsalary;

        }
        public virtual void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary) - pf;
        }
        public static string TotalCount()
        {
            return $"Total count is count";
        }
        public override string ToString()
        {
            return $"employee details::: Id:{id} Name{name} Salary{netpaid}";

        }
    }
    public class Manager : Employee1
    {
        private double ta;
        public Manager(string name, double bs, double ta) : base(name, bs)
        {
            this.ta = ta;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + ta) - pf;

        }
        public override string ToString()
        {
            return $"Manager details :::Id: {id},  Name {name},  Salary {netpaid}";
        }

    }
    public class president : Employee1
    {
        private double ta;
        private double medical;
        public president(string name, double bs, double ta, double medical) : base(name, bs)
        {
            this.medical = medical;
            this.ta = ta;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + ta + medical) - pf;

        }
        public override string ToString()
        {
            return $"President details :::Id: {id},  Name {name},  Salary {netpaid}";
        }

    }
    public class SalesManager : Employee1
    {
        private double ta;
        private double unifrom;

        public SalesManager(string name, double bs, double ta, double unifrom) : base(name, bs)
        {
            this.unifrom = unifrom;
            this.ta = ta;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + ta + unifrom) - pf;

        }
        public override string ToString()
        {
            return $"President details :::Id: {id},  Name {name},  Salary {netpaid}";
        }

    }
}