  namespace Pokedex.Models
 {
 
    public class Pokemon
    {   
      
        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public int weight { get; set; } = 0;
        public int height { get; set; } = 0;          
        public Sprites sprites { get; set; } = new Sprites ();
        public List<Stat> stats { get; set; } = new List<Stat>();
        public List<Type> types { get; set; } = new List<Type>();
        
    }
 }