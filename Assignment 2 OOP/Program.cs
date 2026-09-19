using Common;

namespace Session_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 6: array of 3 Employees - a DBA, a Guest, and a third one
            // with full permissions (treated here as another DBA, since DBA
            // is the highest privilege level defined in the SecurityLevel enum).
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(
                1, "Ali", SecurityLevel.DBA, 15000,
                new HiringDate(15, 3, 2020), Gender.M);

            EmpArr[1] = new Employee(
                2, "Mona", SecurityLevel.Guest, 5000,
                new HiringDate(1, 6, 2023), Gender.F);

            EmpArr[2] = new Employee(
                3, "Sami", SecurityLevel.DBA, 20000,
                new HiringDate(10, 1, 2019), Gender.M);

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
