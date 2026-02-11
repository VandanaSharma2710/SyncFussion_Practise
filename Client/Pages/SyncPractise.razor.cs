using System.Threading.Tasks;
namespace Client.Pages
{
    public partial class SyncPractise
    {
        
        private string message = "";
        private bool isLoading = false;
       

        public String Name = "";
        public int Age = 0;
        public String Game = "";
        public bool IsActive = false;

        private void onClick()
        {
            message = "Button clicked!";
        }

        private async Task showSpinner()
        {
            isLoading = true;
            await Task.Delay(1000);
            isLoading = false;
        }

        public List<Player> playerList = new()
        {
            new Player{Id=1, Name="Sachin", Age =45, Game="Cricketer",IsActive=false},
            new Player{Id=2, Name="Gopichand", Age =47, Game="Hockey",IsActive=false},
            new Player{Id=3, Name="Sania",Age =35, Game="Tanish", IsActive = false},
            new Player{Id=3, Name="PT Usha", Age =45,Game="Atheletics", IsActive = false},


        };

        private void saveInfo()
        {
            var newPlayer = new Player
            {
                Id = playerList.Count + 1,
                Name= Name,
                Age = Age,
                Game = Game,
                IsActive = IsActive
            };
            playerList.Add(newPlayer);

            //clear the form
            Name = "";
             Age = 0;
             Game = "";
             IsActive = false;  
        }
    }

    public class Player
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public int Age { get; set; }
        public String Game { get; set; }

        public bool IsActive { get; set; }

        
    }
}
