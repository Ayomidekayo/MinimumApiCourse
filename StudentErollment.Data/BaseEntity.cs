namespace StudentEnrolment.Data
{
    public class BaseEntity
        {
            public int Id { get; set; }
            public string CreatedBy { get; set; }=string.Empty;
            public DateTime CreatedDate { get; set; }
            public string MordifiedBy { get; set; } = string.Empty;
            public DateTime MordifiedDate { get; set; }
        }
    }



