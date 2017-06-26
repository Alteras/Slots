using System;
namespace ProbabilityProject
{
    public class Math
    {
        public Math()
        {
            
        }
		private static readonly object syncLock = new object();

        public int ReturnRandom(int min, int max)
        {
            lock (syncLock)
            {
                return new Random().Next(min, max);
            }
        }
    }
}
