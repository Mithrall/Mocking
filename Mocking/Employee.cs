using System;

namespace Mocking {
    public class Employee {
        public Employee() {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Wage { get; set; }

        internal double CalculateWeeklySalary(int hours, int wage) {
            return hours * wage;
        }
    }
}