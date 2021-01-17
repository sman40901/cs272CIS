using System;

namespace SectorCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskCluster cluster = new DiskCluster();
            /*
            Console.WriteLine(cluster.calculatePhysicalSize(2,4));
            Console.WriteLine(cluster.calculateSlackSpace(4096, 4195)); //9516
            Console.WriteLine(cluster.calculatePhysicalSize(512, 9516));
            Console.WriteLine(cluster.calculateSlackSpace(512, 9516));*/


            /*
            Console.WriteLine(cluster.calculateSlackSpace(4096, 4195));

            Console.WriteLine(cluster.calculatePhysicalSize(32768, 4195));
            Console.WriteLine(cluster.calculateSlackSpace(32768, 4195));

            Console.WriteLine(cluster.calculatePhysicalSize(4096, 2048));
            Console.WriteLine(cluster.calculateSlackSpace(4096, 2048));

            */
            calculate(4096, 4195);
            calculate(32768, 4195);
            calculate(2048, 4096);
            calculate(32768, 513);
            calculate(32768, 80000);
            Console.ReadLine();
        }

        public static void calculate(double clusterSize, double logicalFileSize)
        {
            DiskCluster cluster = new DiskCluster();
            Console.WriteLine("******");
            Console.WriteLine("Logical File Size = " + logicalFileSize);
            Console.WriteLine("Cluster Size = " + clusterSize);
            Console.WriteLine("Physical File Size = " + cluster.calculatePhysicalSize(clusterSize, logicalFileSize));
            Console.WriteLine("Slack Space = " + cluster.calculateSlackSpace(clusterSize, logicalFileSize));
            Console.WriteLine("******" );

        }
    }
}
