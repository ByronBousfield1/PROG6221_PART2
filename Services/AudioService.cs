using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;

namespace CyberAwarenessBot.Services
{
    public static class AudioService
    {
    
        public static async Task PlayGreetingAsync(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) return;

               
                await Task.Delay(2000);

                using var player = new SoundPlayer(filePath);
                player.Play();
            }
            catch (Exception)
            {
               
            }
        }
    }
}