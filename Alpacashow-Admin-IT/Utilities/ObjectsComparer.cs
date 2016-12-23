using System;
using System.Collections.Generic;
using System.Linq;

namespace Alpacashow_Admin_SpecflowTests.Utilities
{
   public enum CompareMethod
   {
      ExactMatch,
      MustAtLeastContainExpectedValues,
      MustAtLeastContainExpectedRecords,
      MustAtLeastContainExpectedValuesAndRecords
   }

   public static class ObjectsComparer
   {
      /// <summary>
      /// This Class takes 2 dynamic objects to compair.
      /// </summary>
      /// <param name="expectedContent">Expected dynamic content.</param>
      /// <param name="actualContent">Actual dynamic content.</param>
      /// <returns>True if List are exact match, else false</returns>
      public static bool CompareDynamicObjects(dynamic expectedContent, dynamic actualContent, CompareMethod compareMethod)
      {
         var equalList = false;
         // check if content is object
         var expectedContentIsObject = expectedContent.GetType().Name.Equals("Object") || expectedContent.GetType().Name.Equals("JObject");
         var actualContentIsObject = actualContent.GetType().Name.Equals("Object") || actualContent.GetType().Name.Equals("JObject");

         if (expectedContentIsObject == true && actualContentIsObject == true)
         {
            List<KeyValuePair<string, object>> expectedContentList = ConvertDynamicPairsList(expectedContent);
            List<KeyValuePair<string, object>> actualContentList = ConvertDynamicPairsList(actualContent);
            equalList = CompareLists(expectedContentList, actualContentList, compareMethod);
         }
         if (expectedContentIsObject == false && actualContentIsObject == true)
         {
            foreach (var expCont in expectedContent)
            {
               List<KeyValuePair<string, object>> expectedContentList = ConvertDynamicPairsList(expCont);
               List<KeyValuePair<string, object>> actualContentList = ConvertDynamicPairsList(actualContent);
               equalList = CompareLists(expectedContentList, actualContentList, compareMethod);
            }
         }
         if (expectedContentIsObject == true && actualContentIsObject == false)
         {
            List<KeyValuePair<string, object>> expectedContentList = ConvertDynamicPairsList(expectedContent);
            foreach (var actCont in actualContent)
            {
               List<KeyValuePair<string, object>> actualContentList = ConvertDynamicPairsList(actCont);
               equalList = CompareLists(expectedContentList, actualContentList, compareMethod);
            }
         }
         if (expectedContentIsObject == false && actualContentIsObject == false)
         {
            foreach (var expCont in expectedContent)
            {
               List<KeyValuePair<string, object>> expectedContentList = ConvertDynamicPairsList(expCont);
               foreach (var actCont in actualContent)
               {
                  List<KeyValuePair<string, object>> actualContentList = ConvertDynamicPairsList(actCont);
                  equalList = CompareLists(expectedContentList, actualContentList, compareMethod);
               }
            }
         }

         return equalList;
      }

      private static bool CompareLists(List<KeyValuePair<string, object>> expectedContentList, List<KeyValuePair<string, object>> actualContentList, CompareMethod compareMethod)
      {
         var equal = false;

         switch (compareMethod)
         {
            case CompareMethod.ExactMatch:
               equal = expectedContentList.SequenceEqual(actualContentList);
               break;
         }
         return equal;
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
            var nameExists = ((Type) pair.GetType()).GetProperties().Any(p => p.Name.Equals("Name"));

            if (keyExists)
            {
               keyValuePairList.Add(new KeyValuePair<string, object>(pair.Key, pair.Value));
            }
            else if (nameExists)
            {
               keyValuePairList.Add(new KeyValuePair<string, object>(pair.Name, pair.Value));
            }
            else
            {
                  throw new Exception("No Key-Value, Name-Value or Path-Value found");
            }
         }

         keyValuePairList.OrderBy(x => x.Key).ThenBy(x => x.Value);
         return keyValuePairList;
      }
   }
}
