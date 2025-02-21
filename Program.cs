using Efcore2.Context;
using Efcore2.Enitities;

namespace Efcore2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AppDpContext context = new AppDpContext();

            //try
            //{

            //}
            //finally
            //{
            //    context.Dispose();
            //}

            //using (AppDpContext context = new AppDpContext())
            //{
            //    //
            //}

            using AppDpContext context = new AppDpContext();


            #region insert
            var employee = new Employee()
            {
                Name = "Ahmed ali",
                Salary = 12000,
                Address = "cario",
                Age = 25
            };
            ////context.Add(employee);
            //context.Employee.Add(employee);
            //Console.WriteLine(context.Entry(employee).State);

            ////var Result = context.SaveChanges();
            ////Console.WriteLine(Result);

            //employee.Name = "Omar";
            //Console.WriteLine(context.Entry(employee).State);
            //var Result = context.SaveChanges();
            //Console.WriteLine(Result);

            #endregion
            #region Read
            //var result = context.Employee.Where(E => E.Id == 40).FirstOrDefault();
            //var result = context.Employee.FirstOrDefault(E => E.Id == 40);

            //Console.WriteLine(result);

            //var result = context.Employee;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Update


            //var result = context.Employee.FirstOrDefault(E => E.Id == 40);
            //Console.WriteLine(context.Entry(result).State);
            //result.Name = "OmarAhmed";
            //Console.WriteLine(context.Entry(result).State);
            //context.Update(result);
            //Console.WriteLine(context.Entry(result).State);
            #endregion


            #region delete


            //context.Remove();
            ////context.Employee.Remove();
            // var result =    context.Employee.FirstOrDefault(E => E.Id == 40); ;
            //context.Employee.Remove(result);
            //context.SaveChanges();
            #endregion


            //Department department = new Department();
            //department.Id;

            Employee employee1 = new Employee();
            Department department = new Department();


        }
    }
}
