using Reef.Model;
using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.EntityFrameworkCore;
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
                string[] temp = new string[17];
                try
                {
                    //substitue db references from these list values
                    //db.Region.Add(dataArray[i]);


                    using (var db = new ReefSurvey())
                    {


                        db.Locations.Add(new Location { RegionName = dataArray[i] });
                        db.Locations.Add(new Location { SubRegionName = dataArray[i + 1] });
                        db.Locations.Add(new Location { StudyArea = dataArray[i + 2] });
                        db.Surveys.Add(new Survey { SurveyYear = int.Parse(dataArray[i + 3]) });
                        db.Surveys.Add(new Survey { BatchCode = int.Parse(dataArray[i + 4]) });
                        db.Surveys.Add(new Survey { SurveyIndex = int.Parse(dataArray[i + 5]) });
                        db.Surveys.Add(new Survey { SurveyYear = int.Parse(dataArray[i + 6]) });
                        db.Locations.Add(new Location { Latitude = Convert.ToDouble(dataArray[i + 7]) });
                        db.Locations.Add(new Location { Longitude = Convert.ToDouble(dataArray[i + 8]) });
                        db.Locations.Add(new Location { Management = dataArray[i + 9] });
                        //db..Add(dataArray[i + 10]);
                        db.Fish.Add(new Fish { FamilyName = dataArray[i + 11] });
                        db.Fish.Add(new Fish { ScientificName = dataArray[i + 12] });
                        db.Fish.Add(new Fish { CommonName = dataArray[i + 13] });
                        db.Fish.Add(new Fish { Trophic = dataArray[i + 14] });
                        db.Schools.Add(new Schools { FishLength = int.Parse(dataArray[i + 15]) });
                        db.Schools.Add(new Schools { FishCount = int.Parse(dataArray[i + 16]) });
                    }
                }

                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }
        
    }
}
