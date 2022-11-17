using System;
using System.Collections.Generic;

namespace EntityFrameworkProgram2.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? Address { get; set; }

    public string? EmpMail { get; set; }
}
