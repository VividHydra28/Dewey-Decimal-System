using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System;
//using System.Collections.Generic;
using System.IO;
//using System.Linq;
//using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
//using System.Threading.Tasks;
//using System.Text.Json;
//using System.Threading.Tasks;
//using System.IO;

namespace PROG7312_POE.IdentifyingAreas.Data
{
    public class JsonFileData
    {

        public static string IdentifyingAreasCallNo = "IdentifyingAreasCallNo.json";
        public static string IdentifyingAreasFile = "IdentifyingAreasLeaderboard.json";




        //-----------------------------------------------END OF VARIABLES--------------------------------------------------------------------------//


        public static bool CallNumFileExists()
        {
            if (File.Exists(IdentifyingAreasCallNo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void CreateCallNumFile()
        {
            // declare dictionary
            Dictionary<string, string> callNums = new Dictionary<string, string>();

            // populate dictionary
            callNums.Add("000", "General Knowledge");
            callNums.Add("100", "Philosophy & Psychology");
            callNums.Add("200", "Religion");
            callNums.Add("300", "Social Sciences");
            callNums.Add("400", "Language");
            callNums.Add("500", "Natural Sciences & Mathematics");
            callNums.Add("600", "Technology (Applied Sciences)");
            callNums.Add("700", "The Arts");
            callNums.Add("800", "Literature ");
            callNums.Add("900", "Geography & History");

            File.WriteAllText(IdentifyingAreasCallNo, JsonSerializer.Serialize(callNums));
        }

        // retrieve json file into dictionary 
        public static Dictionary<string, string> GetKeyValuePairs()
        {
            return System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(IdentifyingAreasCallNo));
        }

    }
}
