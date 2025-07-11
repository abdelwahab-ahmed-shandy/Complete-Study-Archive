namespace Hospital.Models
{
    public class CompleteAppintment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AppintmentDate { get; set; }
        public DateTimeKind AppintmentTime { get; set; }
    }
}
