using TestGittHub_Repasitory.Enums;

namespace TestGittHub_Repasitory
{
    public class Company
    {
        public PositionEnum Worker_position { get; set; }
        public double Working_hours_st { get; set; }
        public double Working_hours_end { get; set; }
        public DateTime? CreateDate { get; set; }
        public List<Employer> Emploee { get; set; } = new List<Employer>();

    }
}
