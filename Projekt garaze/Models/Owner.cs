namespace Projekt_garaze.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
        public List<Garage> Garages { get; set; }

    }
}
