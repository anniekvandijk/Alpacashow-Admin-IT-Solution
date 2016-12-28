using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dynamitey.DynamicObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Alpacashow_Admin_SpecflowTests.Utilities
{
   public static class TableConverter
   {
      public static Table ChangeVerticalTableToHorizontal(Table tableToChange)
      {
         List<string> idList = new List<string>();
         foreach (var row in tableToChange.Rows)
         {
            idList.Add((string)TableHelpers.Id(row));

         }

         Table newTable = new Table(idList.ToArray());
         List<string> valuesList = new List<string>();
         foreach (var row in tableToChange.Rows)
         {
            valuesList.Add((string)TableHelpers.Value(row));

         }
         newTable.AddRow(valuesList.ToArray());
         return newTable;
      }

      public static Table ChangeVerticalTableToHorizontalWithNewHeader(Table tableToChange, string[] newHeader)
      {
         Table newTable = new Table(newHeader);
         List<string> valuesList = new List<string>();
         foreach (var row in tableToChange.Rows)
         {
            valuesList.Add((string)TableHelpers.Value(row));

         }
         newTable.AddRow(valuesList.ToArray());
         return newTable;
      }

      public static Table ChangeVerticalTableIds(Table tableToChange, string[] newIds)
      {
         List<string> idList = new List<string>();
         List<string> valuesList = new List<string>();
         foreach (var id in newIds)
         {
            idList.Add(id);
         }
         foreach (var row in tableToChange.Rows)
         {
            valuesList.Add((string)TableHelpers.Value(row));

         }
         Table convertedTable = new Table(tableToChange.Header.First(), tableToChange.Header.Last());
         if (idList.Count == valuesList.Count)
         {
            for (int i = 0; i < idList.Count; i++)
            {
               convertedTable.AddRow(idList[i], valuesList[i]);
            }
         }
         else
         {
            throw new Exception("Number of Id's and Values do not match");
         }
         return convertedTable;
      }

      public static Table ChangeHorizontalTableHeader(Table tableToChange, string[] newHeader)
      {
         Table convertedTable = new Table(newHeader);
         foreach (var row in tableToChange.Rows)
         {
            convertedTable.AddRow(row.Values.ToArray()); 
         }
         return convertedTable;
      }

      public static string VerticalTableToJson(Table tableToChange)
      {
         StringBuilder builder = new StringBuilder();
         List<string> list = new List<string>();
         foreach (var row in tableToChange.Rows)
         {
            if (row[0].Contains('.'))
            {
               var splitter = row[0].Split('.');
               if (list.Count == 0)
               {
                  if (builder.Length != 0)
                  {
                     builder.Append(',').Append(Environment.NewLine);
                  }
                  builder.Append('"').Append(splitter[0]).Append('"').Append(':');
                  builder.Append('[').Append(Environment.NewLine).Append('{')
                     .Append('"').Append(splitter[1]).Append('"').Append(':')
                     .Append('"').Append(row[1]).Append('"')
                     .Append('}').Append(Environment.NewLine);
                  list.Add(row[1]);
               }
               else
               {
                  builder.Append(',').Append('{')
                     .Append('"').Append(splitter[1]).Append('"').Append(':')
                     .Append('"').Append(row[1]).Append('"').Append('}').Append(Environment.NewLine);
                  list.Add(row[1]);
               }
            }
            else
            {
               if (builder.Length == 0)
               {
                  builder.Append("{").Append(Environment.NewLine);
                  builder.Append('"').Append(row[0]).Append('"').Append(':')
                     .Append('"').Append(row[1]).Append('"');
               }
               else
               {
                  if (list.Count != 0)
                  {
                     builder.Append(']');
                     list.Clear();
                  }
                  builder.Append(',').Append(Environment.NewLine);
                  builder.Append('"').Append(row[0]).Append('"').Append(':')
                     .Append('"').Append(row[1]).Append('"');
               }
            }
         }
         if (list.Count != 0)
         {
            builder.Append(']');
            list.Clear();
         }
         builder.Append("}");
         return builder.ToString();
      }
   }
}
