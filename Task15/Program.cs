using Core.Models;
using Core.Models.Enum;
using Core.Models.Exceptions;
using System.Net.Http.Headers;
namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student= new Student();
      
            Classroom classroom = new Classroom();

            

            int choice;
            bool result;
            string className;
            string name;
            string surname;


            do
            {
                Console.WriteLine("Menu:\n1.Classroom yarat." +
                                  "\n2.Student yarat." +
                                  "\n3.Hamisini goster." +
                                  "\n4.Secilmis sinifdeki telebelere ekrana cixart." +
                                  "\n5.Telebe sil." +
                                  "\n0.Proqrami bitir.");
                choice= Convert.ToInt32(Console.ReadLine());


                if (choice == 1)
                {
                    

                    Console.WriteLine("ClassType -i secin:\n" +
                                      "1.Backend\n" +
                                      "2.Frontend");

                    int check = Convert.ToInt32(Console.ReadLine());


                    if (check == 1)
                    {
                        do
                        {
                            Console.WriteLine("Classrom adini daxil edin:");
                            classroom.ClassName = Console.ReadLine();

                            result = Helper.CheckBoolClassroomName(classroom.ClassName);

                        }
                        while (!result);

                        Classroom newClassroom = new Classroom(classroom.ClassName,ClassType.Backend);

                        classroom.ClassroomAdd(newClassroom,ClassType.Backend);
                    }
                    else if (check == 2)
                    {
                        do
                        {
                            Console.WriteLine("Classrom adini daxil edin:");
                            classroom.ClassName = Console.ReadLine();

                            result = Helper.CheckBoolClassroomName(classroom.ClassName);

                        }
                        while (!result);


                        Classroom newClassroom = new Classroom(classroom.ClassName,ClassType.Frontend);

                        classroom.ClassroomAdd(newClassroom,ClassType.Frontend);

                    }

                    Console.WriteLine("Classrom yaradildi!");


                }
                else if (choice == 2)
                {
                   
                    do
                    {
                        Console.WriteLine("Student adini daxil edin:");
                        name = Console.ReadLine();

                        result = Helper.CheckBoolName(name);
                    }
                    while (!result);

                    do
                    {
                        Console.WriteLine("Student soyadini daxil edin:");
                        surname = Console.ReadLine();

                        result = Helper.CheckBoolSurName(surname);
                    }
                    while (!result);


                    do
                    {
                        Console.WriteLine("Qrup adini daxil edin:");
                        className = Console.ReadLine();

                        result = Helper.CheckBoolClassroomName(className);
                    }
                    while (!result);

                    Student newStudent = new Student(name, surname, className);
                    student.AddStudent(newStudent);

                    
                    if (classroom.ClassName != className)
                    {
                        throw new ClassFoundNotException("sinif tapilmadi!");
                    }
                        
                        Console.WriteLine("Telebe yaradildi!");
                   
                }

                else if (choice == 3)
                {
                    int select;
                    do
                    {
                        Console.WriteLine("1.Butun sinifleri ekrana cixart.\n2.Butun telebeleri ekrana cixart.\n0.Esas menyuya qayit.");
                        select=Convert.ToInt32(Console.ReadLine());

                        if (select == 1)
                        {
                            for (int i = 0; i< classroom.ShowAllClass().Length; i++)
                            {
                                Console.WriteLine(classroom.ShowAllClass()[i]);
                                Console.WriteLine("----------------------------");
                            }
                        }
                        else if (select == 2)
                        {
                            for(int i = 0; i< student.ShowAllStudents().Length; i++)
                            {
                                Console.WriteLine(student.ShowAllStudents()[i]);
                                Console.WriteLine("------------------------------");
                            }
                        }
                    }
                    while( select != 0);

                }

                else if (choice == 4)
                {

                    Console.WriteLine("Sinifin adini daxil edin:");
                     className= Console.ReadLine();

                    for (int i = 0;i< student.FindClassName(className).Length; i++)
                    {
                        
                        Console.WriteLine(student.FindClassName(className)[i]);
                        Console.WriteLine("------------------------");

                    }

                }

                else if (choice == 5)
                {
                    Console.WriteLine("Silmek istediyiniz telebenin id-ni daxil edin:");
                    int id=Convert.ToInt32(Console.ReadLine());

                    for(int i = 0; i< student.Delete(id).Length; i++)
                    {
                        Console.WriteLine(student.Delete(id)[i]);
                        Console.WriteLine("--------------------------");
                    }

                }
                

            }
            while( choice != 0 );

            Console.WriteLine("Proqram bitdi!");
        }
    }
}
