namespace Logistic.Domain.Models
{
    public class Driver
    {
        private string id;
        private string name;
        private int experience;

        public string Id{ get; set; }
        public string Name { get; set; }    
        public int? Experience { get; set; }
        public override string ToString() => $"{Id} - {Name} - {Experience}";
    }
}
