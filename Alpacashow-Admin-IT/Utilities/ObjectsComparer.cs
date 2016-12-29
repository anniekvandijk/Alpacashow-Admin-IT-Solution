
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alpacashow_Admin_SpecflowTests.Utilities
{
   public enum CompareMethod
   {
      ExactMatch,  // All Objects must be there with the same key-value pairs.
      MustContainExpected, // At least de expected objects must be there with the same key-value pairs.
      MustContainKeys,
   }

   public static class DynamicObjectsComparer
   {
      private static List<List<KeyValuePair<string, object>>> sortedExpectedContentList;
      private static List<List<KeyValuePair<string, object>>> sortedActualContentList;
      /// <summary>
      /// This Class takes 2 dynamic objects to compair.
      /// </summary>
      /// <param name="expectedContent">Expected dynamic content.</param>
      /// <param name="actualContent">Actual dynamic content.</param>
      /// <returns>True or false</returns>
      public static bool CompareDynamicObjects(dynamic expectedContent, dynamic actualContent, CompareMethod compareMethod)
      {
         sortedExpectedContentList = SortContentList(expectedContent);
         sortedActualContentList = SortContentList(actualContent);

         var equalList = false;
         switch (compareMethod)
         {
            case CompareMethod.ExactMatch:
               equalList = ExactMatch(sortedExpectedContentList, sortedActualContentList);
               break;
            case CompareMethod.MustContainExpected:
               equalList = MustContainExpected(sortedExpectedContentList, sortedActualContentList);
               break;

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
         List<List<KeyValuePair<string, object>>> contentList = new List<List<KeyValuePair<string, object>>>();
         foreach (var subContent in content)
         {
            contentList.Add(SortKeyValues(subContent));
         }
         return contentList.OrderBy(o => o[0].Value).ToList();
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

      private static bool ExactMatch(List<List<KeyValuePair<string, object>>> expectedContentList,
         List<List<KeyValuePair<string, object>>> actualContentList)
      {
         var equalList = false;
         if (expectedContentList.Count != actualContentList.Count)
         {
            equalList = false;
         }
         else
         {
            for (int x = 0; x < expectedContentList.Count; x++)
            {
               equalList = expectedContentList[x].SequenceEqual(actualContentList[x]);
               if (!equalList)
               {
                  equalList = false;
                  break;
               }
            }
         }
         return equalList;
      }

      private static bool MustContainExpected(List<List<KeyValuePair<string, object>>> expectedContentList,
   List<List<KeyValuePair<string, object>>> actualContentList)
      {
         var equalList = false;
         foreach (var expContent in expectedContentList)
         {
            foreach (var actContent in actualContentList)
            {
               equalList = expContent.SequenceEqual(actContent);
               if (equalList)
               {
                  break;
               }
            }
         }

         return equalList;
      }

      public static string GetDiffrences()
      {
         StringBuilder builder = new StringBuilder();
         builder.Append("Verwacht:").AppendLine();
         foreach (var expectedContent in sortedExpectedContentList)
         {
            foreach (var contentline in expectedContent)
            {
               builder.Append(contentline);
               builder.AppendLine();
            }
            builder.AppendLine();
         }
         builder.Append("Resultaat:").AppendLine();
         foreach (var actualContent in sortedActualContentList)
         {
            foreach (var contentline in actualContent)
            {
               builder.Append(contentline);
               builder.AppendLine();
            }
            builder.AppendLine();

         }

         return builder.ToString();
      }
   }
}
