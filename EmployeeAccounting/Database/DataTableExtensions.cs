using EmployeeAccounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Database
{
    internal static class DataTableExtensions
    {
        public static DataTable ToDataTable(this IEnumerable<Division> data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("HeadDivision");
            table.Columns.Add("Manager");
            table.Columns.Add("Status");
            foreach (var item in data)
            {
                DataRow row = table.NewRow();
                row["Id"] = item.Id;
                row["Name"] = item.Name;
                row["HeadDivision"] = item.HeadDivision?.Name;
                row["Manager"] = item.Manager?.Name;
                row["Status"] = item.Status;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable ToDataTable(this IEnumerable<Employee> data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("PersonnelNumber");
            table.Columns.Add("Position");
            table.Columns.Add("Division");
            table.Columns.Add("Email");
            table.Columns.Add("PhoneNumber");
            table.Columns.Add("HireDate");
            table.Columns.Add("TerminationDate");
            table.Columns.Add("Status");
            foreach (var item in data)
            {
                DataRow row = table.NewRow();
                row["Id"] = item.Id;
                row["Name"] = item.Name;
                row["PersonnelNumber"] = item.PersonnelNumber;
                row["Position"] = item.Position;
                row["Division"] = item.Division.Name;
                row["Email"] = item.Email;
                row["PhoneNumber"] = item.PhoneNumber;
                row["HireDate"] = item.HireDate.Date;
                row["TerminationDate"] = item.FireDate?.Date;
                row["Status"] = item.Status;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
