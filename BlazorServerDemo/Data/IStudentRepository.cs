using BlazorServerDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public interface IStudentRepository
    {
        List<Student> List();

        Student Get(int id);

        bool Add(Student student);

        bool Update(Student student);

        bool Delete(int id);
    }
}
