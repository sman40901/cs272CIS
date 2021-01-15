using System;

namespace SectorCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskCluster cluster = new DiskCluster();
            Console.WriteLine(cluster.calculatePhysicalSize(2,4));
            Console.WriteLine(cluster.calculateSlackSpace(4096, 4195)); //9516
            Console.WriteLine(cluster.calculatePhysicalSize(512, 9516));
            Console.WriteLine(cluster.calculateSlackSpace(512, 9516));
            Console.ReadLine();
        }
    }
}
