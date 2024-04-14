using Core.Models.Enum;
using Core.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Classroom
    {

        public int Id { get; set; }

        private static int _id;

        public string ClassName { get; set; }


        public ClassType ClassroomType { get; set; }

        Classroom[] Classrooms = new Classroom[] { };

        public Classroom()
        {
            
        }


        public Classroom(string className, ClassType classType)
        {
            _id++;
            Id = _id;
            ClassName = className;
            ClassroomType = classType;

            if (classType == ClassType.Backend)
            {
                Array.Resize(ref Classrooms, 20);
            }
            else if (classType == ClassType.Frontend)
            {
                Array.Resize(ref Classrooms, 15);
            }


        }

        public override string ToString()
        {
            return $" Id:{Id}\n Name:{ClassName}\n ClassType:{ClassroomType}";
   
        }

        
        public void ClassroomAdd(Classroom classroom, ClassType classType)
        {
            Array.Resize(ref Classrooms, Classrooms.Length + 1);
            Classrooms[Classrooms.Length - 1] = classroom;

        }

        public Classroom[] ShowAllClass()
        {
            return Classrooms;
        }

      
    }
}
