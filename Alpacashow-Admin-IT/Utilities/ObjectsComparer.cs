
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alpacashow_Admin_SpecflowTests.Utilities
{
   public enum CompareMethod
   {
      ExactMatch,
      MustContainKeys,
      MustAtLeastContainExpectedKeysAndValues
   }

   public static class DynamicObjectsComparer
   { 
      /// <summary>
      /// This Class takes 2 dynamic objects to compair.
      /// </summary>
      /// <param name="expectedContent">Expected dynamic content.</param>
      /// <param name="actualContent">Actual dynamic content.</param>
      /// <returns>True or false</returns>
      public static bool CompareDynamicObjects(dynamic expectedContent, dynamic actualContent, CompareMethod compareMethod)
      {
         List<List<KeyValuePair<string, object>>> sortedExpectedContentList = SortContentList(expectedContent);
         List<List<KeyValuePair<string, object>>> sortedActualContentList = SortContentList(actualContent);

         var equalList = false;
         foreach (var expected in sortedExpectedContentList)
         {
            foreach (var actual in sortedActualContentList)
            {
               equalList = CompareLists(expected, actual, compareMethod);
            }
         }
         return equalList;
      }

      /// <summary>
      /// Sort List of Content.
      /// </summary>
      /// <param name="content">Dynamic subcontent.</param>
      /// <returns>Asending sorted List.</returns>
      private static List<List<KeyValuePair<string, object>>> SortContentList(dynamic content)
      {
         List<List<KeyValuePair<string, object>>> expectedContentList = new List<List<KeyValuePair<string, object>>>();
         foreach (var subContent in content)
         {
            expectedContentList.Add(SortKeyValues(subContent));
         }
         expectedContentList = expectedContentList.OrderBy(o => o[0].Value).ToList();
         return expectedContentList;
      }

      /// <summary>
      /// Sorts Lists of Key-Value pairs by Key. 
      /// </summary>
      /// <remarks>
      /// This only works now with Simple objects. Childclasses are not converted.
      /// </remarks>
      /// <param name="Content">Dynamic subcontent.</param>
      /// <returns>Asending sorted List of Key-Value pairs.</returns>
      private static List<KeyValuePair<string, object>> SortKeyValues(dynamic subcontent)
      {
         var keyValuePairList = new List<KeyValuePair<string, object>>();
         foreach (dynamic pair in subcontent)
         {
            var keyExists = ((Type)pair.GetType()).GetProperties().Any(p => p.Name.Equals("Key"));

            if (keyExists)
            {
               keyValuePairList.Add(new KeyValuePair<string, object>(pair.Key, pair.Value));
            }
            else
            {
               throw new Exception("No Key-Value pair found");
            }
         }

         keyValuePairList.OrderBy(x => x.Key).ThenBy(x => x.Value);
         return keyValuePairList;
      }

      private static bool CompareLists(List<KeyValuePair<string, object>> expectedContentList, List<KeyValuePair<string, object>> actualContentList, CompareMethod compareMethod)
      {
         var equal = false;

         switch (compareMethod)
         {
            case CompareMethod.ExactMatch:
               equal = ExactMatchOfKeyValueComparer(expectedContentList, actualContentList, equal);
               break;
            case CompareMethod.MustContainKeys:
               equal = ExactMatchOfKeyComparer(expectedContentList, actualContentList, equal);
               break;
            case CompareMethod.MustAtLeastContainExpectedKeysAndValues:
               equal = MatchOfAtleastKeyValueComparer(expectedContentList, actualContentList, equal);
               break;

         }
         return equal;
      }

      private static bool ExactMatchOfKeyValueComparer(List<KeyValuePair<string, object>> expectedContentList, List<KeyValuePair<string, object>> actualContentList, bool equal)
      {
         return expectedContentList.SequenceEqual(actualContentList);
      }

      private static bool ExactMatchOfKeyComparer(List<KeyValuePair<string, object>> expectedContentList, List<KeyValuePair<string, object>> actualContentList, bool equal)
      {
         foreach (var a in expectedContentList)
         {
            foreach (var b in actualContentList)
            {
               var equalKey = string.Equals(a.Key, b.Key);
               if (equalKey)
               {
                  equal = true;
               }
               else
               {
                  equal = false;
               }
            }
         }
         return equal;
      }

      private static bool MatchOfAtleastKeyValueComparer(List<KeyValuePair<string, object>> expectedContentList, List<KeyValuePair<string, object>> actualContentList, bool equal)
      {
         foreach (var a in expectedContentList)
         {
            foreach (var b in actualContentList)
            {
               var equalKey = string.Equals(a.Key, b.Key);
               var equalValue = string.Equals(a.Value, b.Value);
               if (equalKey && equalValue)
               {
                  equal = true;
               }
               else
               {
                  equal = false;
               }
            }
         }
         return equal;
      }
   }
}
