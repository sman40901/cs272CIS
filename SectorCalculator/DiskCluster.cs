﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SectorCalculator
{
    public class DiskCluster
    {
        public double calculatePhysicalSize(double clusterSize, double fileSize)
        {
            // determine if cluster required is whole number or fraction
            // if required cluster is fraction round it up to next number
            return Math.Ceiling(fileSize / clusterSize);
            /*
            double reqCluster = fileSize / clusterSize;

            // determine if cluster required is whole number or fraction
            if (reqCluster % 1 == 0.0)
            {
                return reqCluster;
            }
            // if required cluster is fraction round it up to next number
            return (reqCluster - (reqCluster % 1)) + 1;
            */
        }

        public double calculateSlackSpace(double clusterSize, double fileSize)
        {
            double reqCLuster = calculatePhysicalSize(clusterSize, fileSize);
            return (clusterSize * reqCLuster) - fileSize;
        }
    }
}