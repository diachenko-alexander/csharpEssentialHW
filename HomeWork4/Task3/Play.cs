using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play track");
        }

        public void Stop()
        {
            Console.WriteLine("Stop track");
        }

        public void Pause()
        {
            Console.WriteLine("Pause track");
        }

        public void Record()
        {
            Console.WriteLine("Record started...");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Record paused");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Record stoped");
        }


    }
}
