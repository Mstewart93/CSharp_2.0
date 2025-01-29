namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int DateOfBirth { get; set; }    
        public Int32 CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public Int32 SpeedingTickets { get; set; }
        public string CoverageType { get; set; }

        public decimal Quote {  get; set; }


            
           


    }
}
