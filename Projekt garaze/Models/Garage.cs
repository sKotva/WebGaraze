namespace Projekt_garaze.Models
{
    public class Garage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FreeSpace { get; set; }
        public int OccupiedSpace { get; set; }
        public List<Car> Cars { get; set; }
    }
}
