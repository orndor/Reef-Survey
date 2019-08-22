using Reef.Model;
using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Reef_Survey
{
    public class Parse
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

                        var theLocation = new Location { RegionName = dataArray[i], SubRegionName = dataArray[i + 1], StudyArea = dataArray[i + 2], Latitude = Convert.ToDouble(dataArray[i + 7]), Longitude = Convert.ToDouble(dataArray[i + 8]), Management = dataArray[i + 9] };
                        db.Locations.Add(theLocation);


                        var theSurvey = new Survey { Location = theLocation, SurveyDate = dataArray[i + 3], BatchCode = dataArray[i + 4], SurveyIndex = int.Parse(dataArray[i + 5]), SurveyYear = dataArray[i + 6] };
                        db.Surveys.Add(theSurvey);

                      
                        //db..Add(dataArray[i + 10]);
                        var theFish = new Fish { Survey = theSurvey, FamilyName = dataArray[i + 11], ScientificName = dataArray[i + 12], CommonName = dataArray[i + 13], Trophic = dataArray[i + 14] };
                        db.Fish.Add(theFish);

                        var theSchools = new Schools { Fish = theFish, FishLength = double.Parse(dataArray[i + 15]), FishCount = double.Parse(dataArray[i + 16]) };
                        db.Schools.Add(theSchools);
                       
                        var count = db.SaveChanges();                    }
                }

                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }
        
    }
}
