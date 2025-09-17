namespace CMCS.Models
{
    public class Approval
    {
        public int Id { get; set; }
        public string Decision { get; set; } = ""; // Approved / Rejected
        public string Comments { get; set; } = "";
    }
}
