using Newtonsoft.Json;
using System.IO;

namespace Tic_Tac_Toe
{
    public class Serializer
    {
        public void Serialize(int game, int win)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "stats.json");

            StatsModel stats;

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                stats = JsonConvert.DeserializeObject<StatsModel>(json);
                stats.Games += game;
                stats.Wins += win;
            }
            else
            {
                stats = new StatsModel {Games = 1};
            }



            using (StreamWriter sw = new StreamWriter(path, false))
            {
                string serializedStats = JsonConvert.SerializeObject(stats);
                sw.Write(serializedStats);
            }
        }
        public StatsModel GetStats()
        {
            StatsModel stats = new StatsModel();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "stats.json");
            if (File.Exists(path))
            {
                using (StreamReader file = File.OpenText(path))
                {
                    string json = file.ReadToEnd();
                    stats = JsonConvert.DeserializeObject<StatsModel>(json);
                }
            }

            return stats;
        }
    }
}
