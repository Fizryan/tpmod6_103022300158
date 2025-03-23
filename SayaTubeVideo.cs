using System.Diagnostics;

namespace tpmod6_103022300158
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
    
        public SayaTubeVideo(string videoTitle)
        {
            Debug.Assert(videoTitle != null, "Judul video tidak boleh null");
            Debug.Assert(videoTitle.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter");

            id = GenerateRandomId();
            title = videoTitle;
            playCount = 0;
        }

        public void IncreasePlayCount(int countToAdd)
        {
            Debug.Assert(countToAdd <= 10000000, "Input penambahan play count tidak boleh melebihi 10.000.000");

            try
            {
                checked
                {
                    playCount += countToAdd;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("ERROR: Terjadi overflow pada play count!");
                Console.WriteLine(e.Message);
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine($"Videp ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }

        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }
    }
}
