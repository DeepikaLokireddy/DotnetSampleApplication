namespace PostsApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Projects> Projects { get; set; }
        public string Designation { get; set; }


    }

    public class Projects
    {
        public string projectName { get; set; }
    }
}
