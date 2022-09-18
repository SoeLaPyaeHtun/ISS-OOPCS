using System;

namespace OldQuestionOne
{
    class Program
    {
        static string[,] AllRecords = new string[,]
        {
            { "11235929", "Loh Ying Hui", "2021-11-03 17:33:12", "2021-11-03 19:28:02", "Hall B" },
            { "11236832", "Chang Wen Ming", "2021-11-02 09:02:23", "2021-11-02 10:32:42", "Hall C" },
            { "11236375", "Ang Zheng De", "2021-11-03 18:02:23", "2021-11-03 20:34:29", "Hall B" },
            { "11236956", "Say Zi Rui", "2021-11-03 11:25:33", "2021-11-03 13:08:31", "Hall A" },
            { "11236236", "Vaneet Sura", "2021-11-03 16:25:29", "2021-11-03 18:53:19", "Hall B" },
        };


        // TO BE COMPLETED
        private static string[] GetRecord(string inId)
        {
            string[] result = new string[5];
           
            for(int i = 0; i < AllRecords.GetLength(0); i++)
            {
                if(inId == AllRecords[i, 0])
                {
                    for (int j = 0; j < AllRecords.GetLength(1); j++)
                    {
                        result[j] = AllRecords[i, j];
                    }
                    return result;
                }
              
            }
            return null;
        }

        // TO BE COMPLETED
        private static bool WasAtTheSameLocation(string inCandidateLocation, string inTargetLocation)
        {
            if(inCandidateLocation == inTargetLocation)
            {
                return true;
            }

            return false;
        }



        // TO BE COMPLETED
        // Hint: you can compare time with ">", "<", "<=" and ">=" operators between DateTime objects.
        private static bool DidActivityOverlap(DateTime inCandidateEntryTime, DateTime inCandidateExitTime,
        DateTime inTargetEntryTime, DateTime inTargetExitTime)
        {
            if(inCandidateEntryTime <= inTargetExitTime && inTargetEntryTime <= inCandidateExitTime)
            {
                return true;
            }

            return false;
        }




        // TO BE COMPLETED
        // Hint: you should use the above methods WasAtTheSameLocation() and DidActivityOverlap() to check if the person is a close contact with the target person.
        private static void PrintLinkedIds(string targetId, DateTime targetEntryTime, DateTime targetExitTime, string targetLocation)
        {
            for(int i = 0; i < AllRecords.GetLength(0); i++)
            {
                if (WasAtTheSameLocation(AllRecords[i,4], targetLocation) && DidActivityOverlap(GetTimeFromTimeStampString(AllRecords[i,2]),
                    GetTimeFromTimeStampString(AllRecords[i, 3]),targetEntryTime,targetExitTime) && targetId != AllRecords[i,0])
                {
                    Console.WriteLine($"{targetId} is linked with {AllRecords[i, 0]}");
                }
            }
        }

        // This method converts from a formatted time string (in records) to a DateTime object.
        private static DateTime GetTimeFromTimeStampString(string inTimeStampString)
        {
            return DateTime.ParseExact(inTimeStampString, "yyyy-MM-dd HH:mm:ss",
            null);
        }

        // Main method is given
        static void Main(string[] args)
        {
            Console.WriteLine("Please type target person's Id:");
            string targetId = Console.ReadLine();
            string[] targetRecord = GetRecord(targetId);
            if (targetRecord == null)
            {
                Console.WriteLine("You have provided an invalid id.");
                return;
            }

            DateTime targetEntryTime = GetTimeFromTimeStampString(targetRecord[2]);
            DateTime targetExitTime = GetTimeFromTimeStampString(targetRecord[3]);
            string targetLocation = targetRecord[4];
            PrintLinkedIds(targetId, targetEntryTime, targetExitTime, targetLocation);
            Console.WriteLine("\nType any key to exit.");
            Console.ReadLine();
        }
    }

}