#region  Join Operators : Join
using System;

using AppDbContext context = new AppDbContext();
var Result = context.Employees.Join(context.Departments,
E => E.DeptId,
    D => D.Id,
    (E, D) => new
    {
        EmpId = E.Id,
        EmpName = E.Name,
        DeptId = D.Id,
        DeptName = D.Name
    });

foreach (var item in Result)
{
    Console.WriteLine(item);
}

#endregion

#region Tracking Vs NoTracking
// Tracking [Default]

using AppDbContext context = new AppDbContext();

var employee = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 2);

Console.WriteLine(context.Entry(employee).State); // Detached

employee.Name = "Ali"; // Local

Console.WriteLine(context.Entry(employee).State); // Local

context.SaveChanges(); // Remotely

// Console.WriteLine(employee.Name);


#endregion

#region Local Vs Remote

using AppDbContext context = new AppDbContext();

context.Employees.Load();

context.Employees.Local.Any();
context.Employees.Local.Any();
context.Employees.Local.Any();
context.Employees.Local.Any();
context.Employees.Local.Any();
context.Employees.Local.Any();
context.Employees.Local.Any();
context.Employees.Local.Any();
context.Employees.Local.Any();
context.Employees.Local.Any();


#endregion