using Cw2.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cw2
{
    class ReadFile
    {

        static List<Student> studentList = new List<Student>();

        public static List<Student> ReadStudentsFromFile(String file)
        {

            if (File.Exists(file) == false)
            {
                throw new FileNotFoundException("Plik nie istnieje");

            }

            using (var stream = new StreamReader(file))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] student = line.Split(',');


                    if (student.Length < 9)
                    {
                        WriteToLog.WriteStudnetsToLog(line+" - brak parametru");
                    }
                    else
                    {
                        var st = new Student
                        {
                            FirsName = student[0],
                            LastName = student[1],
                            studies = new Studies { UniversityName = student[2], UniversityMode = student[3] },
                            Index = "s" + student[4],
                            BirthDate = ChangeDate(student[5]),
                            Email = student[6],
                            NameMother = student[7],
                            NameFather = student[8]

                        };
                        studentList.Add(st);

                    }

                };
            }

            return studentList;
            
        }
        public static string ChangeDate(string date)
        {
            string readyDate;
            string[] dateToChange = date.Split("-");
            readyDate = dateToChange[1] + "." + dateToChange[2] + "." + dateToChange[0];
            return readyDate;

        }


    }
}
