namespace RestServer.DTOs
{
    public class InconvenientDTO
    {
        public DateOnly? DateAct { get; set; }
        public string? State { get; set; }
        public int? DaysDelay { get; set; }
        public int ServiceRequesedId { get; set; }
        public bool Seen { get; set; }
        public string? Description { get; set; }
        public int? RequestID { get; set; }
    }
}
