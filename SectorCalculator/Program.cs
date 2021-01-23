using System;

namespace SectorCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskCluster cluster = new DiskCluster();
            
            cluster.calculateSpaceSize(4096, 4195);
            cluster.calculateSpaceSize(32768, 4195);
            cluster.calculateSpaceSize(2048, 4096);
            cluster.calculateSpaceSize(32768, 513);
            cluster.calculateSpaceSize(32768, 80000);
            cluster.calculateSpaceSize(512, 7680);
            cluster.calculateSpaceSize(512, 15360);
            cluster.calculateSpaceSize(32768, 4534);
            cluster.calculateRamSlack(4195);

            Console.ReadLine();
        }
    }
}
