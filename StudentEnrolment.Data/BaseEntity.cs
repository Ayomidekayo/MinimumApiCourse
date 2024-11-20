namespace StudentEnrolment.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MordifiedBy { get; set; }
        public DateTime MordifiedDate { get; set; }
    }
}



public class Student
{
    public string FirstName { get; set; }
    public string LasttName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string IsNumber { get; set; }
    public string Picture { get; set; }
}

public class Course
{
    public int Title { get; set; }
    public string CreatedBy { get; set; }
}
public class Enrollment
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public virtual Student Student { get; set; }
    public virtual Student Student { get; set; }
}

