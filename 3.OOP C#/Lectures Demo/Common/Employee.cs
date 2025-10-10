using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Employee
    {
        #region Attributes
        public int Id;
        private string Name;
        private decimal salary;
        private decimal deduction; // Derived Attribute
        private decimal hambozo;
        #endregion

        // Encapsulation x
        // Separate Data Definition [ Attributes ] From Its Use [ Getter  Setter , Properety ]
        // 1. Attribute Private
        // 2. Apply Encapulation [ Getter Setter Approach , Property Approach ]

        #region Applying Encapsulation Using Old Approach Getter Setter 

        public string? GetName()
        {
            return Name;
        }

        public void SetName(string? name)
        {
            Name = name?.Length > 10 ?
            name.Substring(0, 10) : name;
        }

        #endregion

        #region Applying Encapsulation Using New Approach Property
        // More Recommendetion 
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value < 10000 ? 100000 : value;
            } // saved key word to set value to property  
        }

        #endregion

        #region Properties
        // 1. Full Property --> there is a logic 
        // 2. Automatic Property --> no logic
        // 3. Indexer 
        public int Age
        {
            get;
            set;
        }
        // Full Property 
        public decimal Deduction // Read Only Property
        {
            get { return Salary * 0.1M; }
        }
        // Automatic Property
        public string Hamda
        {
            get;
            set;
        }
        // PropFull => Full Property
        public decimal Hambozo
        {
            get { return hambozo; }
            set { hambozo = value; }
        }
        #endregion

        #region Constructors
        public Employee(int id, string? name, decimal salary, int age)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Age = age;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id = {Id} \n Name = {Name} \n Salary = {Salary}";
        }
        #endregion

    }
}
