using System;
using System.Collections.Generic;
using System.Linq;
using ImpromptuInterface.InvokeExt;

namespace Alpacashow_Admin_SpecflowTests.Utilities
{
   public static class ObjectsComparer
   {
      /// <summary>
      /// This Class takes 2 dynamic objects to compair.
      /// </summary>
      /// <param name="expectedContent">Expected dynamic content.</param>
      /// <param name="actualContent">Actual dynamic content.</param>
      /// <returns>True if List are exact match, else false</returns>
      public static bool DynamicObjectsComparer(dynamic expectedContent, dynamic actualContent)
      {
         var isEqual = false;
         foreach (dynamic expCont in expectedContent)
         {
            List<KeyValuePair<string, object>> expContentList = ConvertDynamicPairsList(expCont);

            var equalList = false;
            foreach (dynamic actCont in actualContent)
            {
               List<KeyValuePair<string, object>> actContentList = ConvertDynamicPairsList(actCont);

               equalList = expContentList.SequenceEqual(actContentList);
               if (equalList)
               {
                  break;
               }
            }

            if (!equalList)
            {
               isEqual = false;
               break;
            }
            else
            {
               isEqual = true;
            }
         }
         return isEqual;
      }

      /// <summary>
      /// Sorts Lists of Key-Value pairs by Key. 
      /// </summary>
      /// <remarks>
      /// This only works now with Simple objects. Childclasses are not converted.
      /// </remarks>
      /// <param name="Content">Dynamic content.</param>
      /// <returns>Asending sorted List of Key-Value pairs.</returns>
      private static List<KeyValuePair<string, object>> ConvertDynamicPairsList(dynamic content)
      {
         var keyValuePairList = new List<KeyValuePair<string, object>>();
         foreach (var pair in content)
         {
            var keyExists = ((Type)pair.GetType()).GetProperties().Any(p => p.Name.Equals("Key"));
            var nameExists = ((Type)pair.GetType()).GetProperties().Any(p => p.Name.Equals("Name"));
            var valueExists = ((Type)pair.GetType()).GetProperties().Any(p => p.Name.Equals("Value"));

            if (keyExists && valueExists)
            {
               keyValuePairList.Add(new KeyValuePair<string, object>(pair.Key, pair.Value));
            }
            else if (nameExists && valueExists)
            {
               keyValuePairList.Add(new KeyValuePair<string, object>(pair.Name, pair.Value));
            }
            else
            {
               throw new Exception("No Key-Value or Name-Value found");
            }
         }

         keyValuePairList.OrderBy(x => x.Key).ThenBy(x => x.Value);
         return keyValuePairList;
      }
   }
}
