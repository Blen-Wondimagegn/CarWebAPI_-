namespace CarWebAPI.Models
{
 public class Car
 {
        internal int passengers;

        public long Id { get; set; }
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int NumberOfPassengers { get; set; }
 }
}