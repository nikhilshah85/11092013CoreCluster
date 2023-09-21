using System;
using System.Collections.Generic;

namespace employeeManagement_MVC.Models.EF;

public partial class EmployeeDetailsTraining
{
    public int? EmpNo { get; set; }

    public string? EmpName { get; set; }

    public double? EmpSalary { get; set; }

    public string? EmpDesignation { get; set; }

    public bool? EmpIsPermanent { get; set; }
}
