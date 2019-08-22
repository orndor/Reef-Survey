using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Reef_Survey
{
    class Parse
    {
        string Path { get; set; }

        public List<string> region = new List<string>();
        List<string> subRegion = new List<string>();
        List<string> studyArea = new List<string>();
        List<string> surveyYear = new List<string>();
        List<string> batchCode = new List<string>();
        List<string> surveyIndex = new List<string>();
        List<string> surveyDate = new List<string>();
        List<string> latitude = new List<string>();
        List<string> longitude = new List<string>();
        List<string> management = new List<string>();
        List<string> structureType = new List<string>();
        List<string> family = new List<string>();
        List<string> scientificName = new List<string>();
        List<string> commonName = new List<string>();
        List<string> trophic = new List<string>();
        List<string> fishLength = new List<string>();
        public List<string> fishCount = new List<string>();

        public Parse(string path)
        {
            Path = path;
        }
        /*(List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>, List<string>)*/
        public void Csv()
        {
            bool arb = false;
            foreach (string line in File.ReadLines(Path))
            {
                int i = 0;
                if (arb == false)
                {
                    arb = true;
                    continue;
                }

                line.Trim();
                var dataArray = line.Split(",");
                try
                {
                    region.Add(dataArray[i]);
                    subRegion.Add(dataArray[i + 1]);
                    studyArea.Add(dataArray[i + 2]);
                    surveyYear.Add(dataArray[i + 3]);
                    batchCode.Add(dataArray[i + 4]);
                    surveyIndex.Add(dataArray[i + 5]);
                    surveyDate.Add(dataArray[i + 6]);
                    latitude.Add(dataArray[i + 7]);
                    longitude.Add(dataArray[i + 8]);
                    management.Add(dataArray[i + 9]);
                    structureType.Add(dataArray[i + 10]);
                    family.Add(dataArray[i + 11]);
                    scientificName.Add(dataArray[i + 12]);
                    commonName.Add(dataArray[i + 13]);
                    trophic.Add(dataArray[i + 14]);
                    fishLength.Add(dataArray[i + 15]);
                    fishCount.Add(dataArray[i + 16]);
                }

                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }
        /* string[] dataArray = data.Split(",");

         for (int i = 0; i < 1000; i += 17)
         {
             try
             {
                 region.Add(dataArray[i]);
                 subRegion.Add(dataArray[i + 1]);
                 studyArea.Add(dataArray[i + 2]);
                 surveyYear.Add(dataArray[i + 3]);
                 batchCode.Add(dataArray[i + 4]);
                 surveyIndex.Add(dataArray[i + 5]);
                 surveyDate.Add(dataArray[i + 6]);
                 latitude.Add(dataArray[i + 7]);
                 longitude.Add(dataArray[i + 8]);
                 management.Add(dataArray[i + 9]);
                 structureType.Add(dataArray[i + 10]);
                 family.Add(dataArray[i + 11]);
                 scientificName.Add(dataArray[i + 12]);
                 commonName.Add(dataArray[i + 13]);
                 trophic.Add(dataArray[i + 14]);
                 fishLength.Add(dataArray[i + 15]);
                 fishCount.Add(dataArray[i + 16]);


             }
             catch (IndexOutOfRangeException)
             {
                 Console.WriteLine("Completed parse.");
                 /*return (region, subRegion, studyArea, surveyYear,
                 batchCode, surveyIndex, surveyDate, latitude, longitude,
                 management, structureType, family, scientificName, commonName,
                 trophic, fishLength, fishCount);*/
        //}
        //}
        /*return (region, subRegion, studyArea, surveyYear,
                batchCode, surveyIndex, surveyDate, latitude, longitude,
                management, structureType, family, scientificName, commonName,
                trophic, fishLength, fishCount);*/
        //}

        public static void Print<T>(List<T> list)
        {
            int i = 0;
            foreach (T item in list)
            {
                i++;
                Console.WriteLine($" {i}: {item}");
            }
        }
    }
}
