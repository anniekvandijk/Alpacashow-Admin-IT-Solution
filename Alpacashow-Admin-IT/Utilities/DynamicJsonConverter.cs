using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Alpacashow_Admin_SpecflowTests.Utilities
{
   class DynamicJsonConverter
   {
      public static IEnumerable<dynamic> CreateDynamicJsonSet(dynamic json)
      {
         dynamic dynamicJson = json;
         List<dynamic> jsonList = new List<dynamic>();
         var jsonIsObject = dynamicJson.GetType().Name.Equals("Object") || dynamicJson.GetType().Name.Equals("JObject");
         var jsonIsArray = dynamicJson.GetType().Name.Equals("Array") || dynamicJson.GetType().Name.Equals("JArray");

         if (jsonIsObject)
         {
            jsonList.Add(DynamicJsonInstance(json));
         }
         if (jsonIsArray)
         {
            foreach (var a in json)
            {
               jsonList.Add(DynamicJsonInstance(a));
            }
         }
         return jsonList;
      }

      private static ExpandoObject DynamicJsonInstance(dynamic json)
      {
         dynamic expando = new ExpandoObject();
         var dicExpando = (IDictionary<string, object>)expando;
         dynamic propName;
         dynamic propValue;

         foreach (var jsonObject in json)
         {
            propName = jsonObject.Name;
            var valueIsArray = jsonObject.Value.GetType().Name.Equals("Array") || jsonObject.Value.GetType().Name.Equals("JArray");
            if (valueIsArray)
            {
               StringBuilder builder = new StringBuilder();
               foreach (var a in jsonObject.Value)
               {
                  foreach (var b in a)
                  {
                     if (builder.Length != 0)
                     {
                        builder.Append(", ").Append(b.Value.Value);
                     }
                     else
                     {
                        builder.Append(b.Value.Value);
                     }
                  }

                  
               }
               propValue = builder.ToString();
            }
            else
            {
              propValue = CreateTypedValue(jsonObject.Value.Value);
            }
            dicExpando.Add(propName, propValue);
         }
         return (ExpandoObject)dicExpando;
      }

      private static object CreateTypedValue(string value)
      {
         int i;
         if (int.TryParse(value, out i))
            return i;

         double db;
         if (Double.TryParse(value, out db))
         {
            decimal d;
            if (Decimal.TryParse(value, out d) && d.Equals((decimal)db))
            {
               return db;
            }
            return d;
         }

         bool b;
         if (Boolean.TryParse(value, out b))
            return b;

         DateTime dt;
         if (DateTime.TryParse(value, out dt))
            return dt;

         return value;
      }
   }
}
