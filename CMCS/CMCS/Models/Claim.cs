namespace CMCS.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string ClaimPeriod { get; set; } = "";
        public double TotalHours { get; set; }
        public decimal Rate { get; set; }
        public string Status { get; set; } = "Submitted";
        public List<ClaimItem> Items { get; set; } = new();
        public List<SupportingDocument> Documents { get; set; } = new();
    }
}
