using System.Threading.Tasks;
namespace Client.Pages
{
    public partial class SyncPractise
    {
        
        private string message = "";
        private bool isLoading = false;
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
            new Player{Id=1, Name="Sachin", Game="Cricketer"},
            new Player{Id=2, Name="Gopichand", Game="Hockey"},
            new Player{Id=3, Name="Sania", Game="Tanish"},
            new Player{Id=3, Name="PT Usha", Game="Atheletics"},


        };

    }

    public class Player
    {
        public int Id { get; set; }

        public String Name { get; set; }
        public String Game { get; set; }
    }
}
