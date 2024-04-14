using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static  class Helper
    {


        public static bool CheckBoolName( this string name)
        {
            if (name.Length >= 3 && char.IsUpper(name[0]) && !name.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckBoolSurName( this string name) 
        {
            if( name.Length>=3 && char.IsUpper(name[0]) && !name.Contains(" "))
            {
                return true ;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckBoolClassroomName( this string classroomName)
        {
            if( classroomName.Length ==5 && char.IsUpper(classroomName[0]) && char.IsUpper(classroomName[1]) && char.IsDigit(classroomName[2]) && char.IsDigit(classroomName[3]) && char.IsDigit(classroomName[4]))
            {
                return true ;
            }
            else
            {
                return false;
            }
        }

    }
}
