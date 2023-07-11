﻿using System;
namespace BestBUY_Dapper
{
	public interface IDepartmentRepository
	{
		public IEnumerable<Department> GetAllDepartments();
		public void InsertDepartment(string newDepartmentName);

	}

}

