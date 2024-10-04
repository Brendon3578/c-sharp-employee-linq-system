using EmployeeLinqManagementSystem.Entities;

namespace EmployeeLinqManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "employees-data.csv";
            string relativePath = Path.Combine(currentDir, $@"..\..\..\Data\{fileName}");
            string fullPath = Path.GetFullPath(relativePath);

            var employeesList = new List<Employee>();

            var csvFileInfo = new FileInfo(fullPath);

            if (!csvFileInfo.Exists)
            {
                var error = "Csv file not found!";
                Console.WriteLine($"[error] {error}");
                throw new FileNotFoundException(error);
            }

            using (StreamReader reader = new(csvFileInfo.OpenRead()))
            {
                // ignore first line
                reader.ReadLine();
                Console.WriteLine("> Rows of the CSV File:");
                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine()?.Split(';');
                    if (row == null) break;
                    var name = row[0];
                    var email = row[1];
                    var salary = decimal.Parse(row[2]);
                    var department = row[3];

                    var employee = new Employee(name, email, salary, department);

                    employeesList.Add(employee);
                    Console.WriteLine(employee);
                }
            }

            var employeesWithBigSalary =
                employeesList
                    .Where(e => e.Salary > 6000)
                    .OrderBy(p => p.Name)
                    .Select(p => new { p.Email, p.Salary });

            Console.WriteLine("\n[@] Employess with salary greater than $ 6000");
            foreach (var item in employeesWithBigSalary)
            {
                Console.WriteLine(item);
            }

            var employeesSum =
                (from e in employeesList
                 where e.Name.ToLower()[0].Equals('m')
                 select e.Salary).Sum();

            // var employeesSum = employeesList.Where((e) => e.Name.ToLower()[0].Equals('m')).Select(e => e.Salary).Sum();

            Console.WriteLine($"\n[@] The sum of employees with first letter m is {employeesSum:f2}");


            var employeesByDepartment =
                from e in employeesList
                orderby e.Name
                group e by e.Department;

            // var employeesByDepartment = employeesList.OrderBy(e => e.Name).GroupBy(e => e.Department);

            Console.WriteLine("\n[@] Grouping employees by department");

            foreach (IGrouping<string, Employee> group in employeesByDepartment)
            {
                Console.WriteLine($"\n-- [Category: {group.Key}] --");

                foreach (var e in group)
                {
                    Console.WriteLine(new { e.Name, e.Salary });
                }
            }

        }
    }
}
