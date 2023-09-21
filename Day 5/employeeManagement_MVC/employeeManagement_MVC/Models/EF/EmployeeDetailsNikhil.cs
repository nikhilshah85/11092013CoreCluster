using System;
using System.Collections.Generic;

namespace employeeManagement_MVC.Models.EF;

public partial class EmployeeDetailsNikhil
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesignation { get; set; }

    public int? EmpSalary { get; set; }

    public bool? EmpIsPermenant { get; set; }
}
