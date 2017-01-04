using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace Alpacashow_Admin_SpecflowTests.Actions
{
    class ShoweventsActions
    {
        public static void CreateShowevents(Table table)
        {
            var actEnv = (string) FeatureContext.Current["active-environment"];
            var filePath = "";
            if (actEnv == "Local")
            {
                filePath =
                    $"D:/Java/alpacashow-admin-app/alpacashow-admin-backend/target/classes/csv/SHOWEVENTS.csv";
            }

            StringBuilder csvBuilder = new StringBuilder();

            csvBuilder.AppendLine("NAAM; DATUM; SLUITDATUM; LOCATIE; JURY; SHOWTYPEN");

            foreach (var row in table.Rows)
            {
                var showTypen = row[5].ToUpper().Replace(", ", ",").Replace(" ", "_");
                csvBuilder.AppendLine(row[0] + ";" + row[1] + ";" + row[2] + ";" + row[3] + ";" +
                                      row[4] + ";" + showTypen);
            }
            var csvFile = csvBuilder.ToString();

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            File.AppendAllText(filePath, csvFile);
        }
    }
}
