using Core.Models.Enum;
using Core.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        public int Id { get; set; }

        private static int _id;

        public string Name { get; set; }

        public string SurName { get; set; }

        public string ClassName { get; set; }

        public Student()
        {

        }

        public Student(string name, string surname, string className)
        {
            _id++;
            Id = _id;
            Name = name;
            SurName = surname;
            ClassName = className;

        }

        Student[] Students = new Student[] { };       

        public override string ToString()
        {
            return $" Id:{Id}\n Name:{Name}\n Surname:{SurName}\n ClassName:{ClassName}";
        }

       public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            
        }

        public Student[] ShowAllStudents()
        {
            return Students;
        }

        public Student[] FindClassName(string className)
        {
            Student[] findClassName = new Student[0];

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].ClassName==className)
                {
                    Array.Resize(ref findClassName, findClassName.Length + 1);
                    findClassName[findClassName.Length - 1] =  Students[i];
                }
            }
            return findClassName;
        }

        public Student[] Delete(int id)
        {
            Student[] deleteStudent = new Student[0];

           

            for (int i = 0; i < Students.Length; i++)
            {

                if (Students[i].Id != id)
                {
                    
                    Array.Resize(ref deleteStudent, deleteStudent.Length + 1);
                    deleteStudent[deleteStudent.Length - 1] = Students[i];

                   
                }
            }
            if( Students.Length < id-1)
            {
                throw new StudentFoundNotException("Telebe tapilmadi!");
            }

            Students=deleteStudent;
            return deleteStudent;

        }
    }
}
