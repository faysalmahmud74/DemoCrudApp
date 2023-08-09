using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidDemo.Models;

namespace MidDemo
{
    public class EmployeeRepo
    {
        public int AddEmployee(EmployeeModel model)
        {
            using (var context = new ecomEntities())
            {
                employee s = new employee();

                s.name = model.name;
                s.age = model.age;
                s.dob = model.dob;
                s.email = model.email;
                s.gender = model.gender;
                s.email = model.email;
                s.phone = model.phone;
                s.address = model.address;
                s.nationality = model.nationality;
                s.type = model.type;
                s.product = model.product;


                context.employee.Add(s);
                context.SaveChanges();

                return s.eid;
            }
        }
        //
        public List<EmployeeModel> GetAllData()
        {
            using (var context = new ecomEntities())
            {
                var result = context.employee.Select(x => new EmployeeModel()
                {
                    eid = x.eid,
                    name = x.name,
                    age = x.age,
                    dob = x.dob,
                    email = x.email,
                    gender = x.gender,
                    phone = x.phone,
                    address = x.address,
                    nationality = x.nationality,
                    type = x.type
                }
                ).ToList();
                return result;

            }
        }

        public EmployeeModel GetDetails(int id)
        {
            using (var context = new ecomEntities())
            {
                var result = context.employee.Where(x => x.eid == id).Select(x => new EmployeeModel()
                {
                name = x.name,
                age = x.age,
                dob = x.dob,
                email = x.email,
                gender = x.gender,
                phone = x.phone,
                address = x.address,
                nationality = x.nationality,
                type = x.type,
            }
                ).FirstOrDefault();

            return result;
        }
    }


    public bool UpdateData(int id, EmployeeModel model)
    {
        using (var context = new ecomEntities())
        {
            var employee = context.employee.FirstOrDefault(x => x.eid == id);
            if (employee != null)
            {
                employee.name = model.name;
                employee.age = model.age;
                employee.dob = model.dob;
                employee.email = model.email;
                employee.gender = model.gender;
                employee.email = model.email;
                employee.phone = model.phone;
                employee.address = model.address;
                employee.nationality = model.nationality;
                employee.type = model.type;
                employee.product = model.product;
                }

            context.SaveChanges();

            return true;
        }
    }

    public bool DeleteData(int id)
    {
        using (var context = new ecomEntities())
        {
            var employee = context.employee.FirstOrDefault(x => x.eid == id);
            if (employee != null)
            {
                context.employee.Remove(employee);
                context.SaveChanges();
                return true;
            }

            return false;
        }
    }

}
}