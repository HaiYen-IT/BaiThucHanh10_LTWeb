using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Cau2.Models
{
    
    public class StudentList
    {
        private List<Student> StudentLst = new List<Student>()
        {
            new Student
            {
                StudentID = 1,
                StudentName = "Nguyễn Văn Nam",
                StudentBirthday = "01/01/1997",
                StudentPhone = "0979389024",
                studentEmail = "nam@gmail.com"
            },new Student
            {
                StudentID = 2,
                StudentName = "Nguyễn Văn Minh",
                StudentBirthday = "01/04/1997",
                StudentPhone = "0979389024",
                studentEmail = "minh@gmail.com"
            },new Student
            {
                StudentID = 3,
                StudentName = "Nguyễn Văn Sáng",
                StudentBirthday = "01/01/1997",
                StudentPhone = "0979389024",
                studentEmail = "sang@gmail.com"
            },new Student
            {
                StudentID = 4,
                StudentName = "Nguyễn Văn Bình",
                StudentBirthday = "08/01/1997",
                StudentPhone = "0979389024",
                studentEmail = "binh@gmail.com"
            }
        };
        public List<Student> StudentGetAll()
        {
            var students = StudentLst.Select(i => i);
            return students.ToList();
        }
    }
}