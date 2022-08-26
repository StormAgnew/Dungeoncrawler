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

            Room r2 = new Room("You enter a room that's rather bright. Almost TOO bright.\n It's decorated with child-like decorations, from stuffed animals to dollies. In the corner of the room, you see a small creature holding one of the stuffed animals. It appears to be a little girl, hair draping down to her knees. She appears to have been crying, as she looks up at you. Her face is badly bruised, and her lip appears to have been broken open.");

            Room r3 = new Room("Puppy");

            Room r4 = new Room("Squirrel");

            Room r5 = new Room("Frog");

            Room r6 = new Room("Random Animal");

            Room[] rooms = { r1, r2, r3, r4, r5, r6};

            Random rand = new Random();

            Room room = rooms[rand.Next(rooms.Length)];
            return room;
        }
        //More rooms will be added. As well as more descriptions.
    }
}