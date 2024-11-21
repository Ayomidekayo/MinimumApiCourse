using StudentEnrolment.Data;

public class Student:BaseEntity
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IsNumber { get; set; }
        public string Picture { get; set; }
    }



