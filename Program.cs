namespace EmployeePayroll
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeeModel employeeModel = new EmployeeModel();

            employeeModel.EmployeeName = "Rita";
            employeeModel.PhoneNumber = "9898989889";
            employeeModel.Address = "13 street";
            employeeModel.Department = "Hr";
            employeeModel.Gender = 'F';
            employeeModel.BasicPay = 20000;
            employeeModel.Deduction = 200;
            employeeModel.TaxablePay = 2500;
            employeeModel.Tax = 1000;
            employeeModel.NetPay = 200;
            employeeModel.City = "Banglore";
            employeeModel.Country = "India";

            //employeeRepo.AddEmployee(employeeModel);
            employeeRepo.GetAllEmployee();
        }
    }
}