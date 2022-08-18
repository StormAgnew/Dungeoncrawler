namespace RoomLibrary
{
    public class Room
    {
        //string[] colors = {"Red", "Purple", "Yellow"};   
        private string _floor;
       

        public string Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }
       
        
        public Room(string floor)
        {
            Floor = floor;
        }    
        

        public override string ToString()
        {
            return $"{Floor}"; 
        }

        public static Room GetRoom()
        {
            Room r1 = new Room("You enter a very dark and dingy room. Spiders are skittering across the floor, and a drabbed figure is sitting in the corner.\n\n It looks in your direction, but... you don't see its face. A ear-piercing scream shatters the silence, as the figure suddenly appears in front of you.");
            return r1;
        }

    }
}