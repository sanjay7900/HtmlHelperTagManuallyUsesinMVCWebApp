using HtmlHelperTagPractice.Models;

namespace HtmlHelperTagPractice.Depandancy
{
    public class StudentOperations
    {
        private List<Students> students=new List<Students>()
        {
            new Students{Id = 1, Name ="Sanjay Singh",Section="C",Branch="B.Tech", Gender="Male"}
        };
        public void AddStudent(Students student)
        {
            students.Add(student);  
        }
        public List<Students> GetAllStudents()
        {
            return students;
        }
        public bool DeleteStudents(int id)
        {
            var stu = students.Where(s => s.Id == id).FirstOrDefault(); 
            if(stu != null)
            {
                students.Remove(stu);
                return true;    
            }
            else
            {
                return false;
            }

        }
        public void EditStudents(Students student)
        {
            var stu = students.Where((s) => s.Id == student.Id).FirstOrDefault();   
            if(stu != null)
            {
                stu.Branch = student.Branch;
                stu.Name = student.Name;    
                stu.Gender=student.Gender;
                stu.Section = student.Section;  

            }

        }
        public Students getById(int Id)
        {
            return students.Where(s => s.Id == Id).FirstOrDefault();
        }
    }
}
