﻿
using StudentEnrolment.Data;

public class Enrollment:BaseEntity
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public virtual  Course Course { get; set; }
        public virtual Student Student { get; set; }
    }



