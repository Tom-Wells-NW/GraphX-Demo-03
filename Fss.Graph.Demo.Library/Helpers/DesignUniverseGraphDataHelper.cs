using Fss.Graph.Demo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Graph.Demo.Library.Helpers
{
    public class DesignUniverseGraphDataHelper
    {

        static DesignUniverseGraphDataHelper()
        {
            DataSource = GenerateDataSource(10);
        }

        #region static code
        private static List<UniverseVertex> DataSource { get; set; }

        private static List<UniverseVertex> GenerateDataSource(int count)
        {
            var result = new List<UniverseVertex>();
            var displayValues = GetUniverseList();
            var max = Math.Min(count, displayValues.Count);
            for (var i = 0; i < max; i++)
            {
                result.Add(new UniverseVertex { ID = i + 100, Text = displayValues[i] });
            }
            return result;
        }

        public static List<string> GetUniverseList()
        {
            var result = new List<string>
            {
                "Foundation Universe",
                "Uplift Universe",
                "Citizen of the Galaxy",
                "Starman Jones",
                "Starship Troopers",
                "Time Enough for Love",
                "Time for the Stars",
                "Tunnel in the Sky",
                "Dune Universe",
                "Firefly Universe"
            };

            return result;
        }


        public static void ResetDataSource(int count)
        {
            DataSource = GenerateDataSource(count);
        }

        #endregion static code

        public UniverseGraph GenerateDesignGraph(int count)
        {
            if (DataSource.Count < count) ResetDataSource(count);
            //if (DataSource.Count < count) 
            var result = new UniverseGraph();

            Random rand = new Random();
            try
            {
                //Create and add vertices using some DataSource for ID's
                foreach (var item in DataSource.Take(count))
                    result.AddVertex(new UniverseVertex() { ID = item.ID, Text = item.Text });

                var vlist = result.Vertices.ToList();
                //Generate random edges for the vertices
                int c = 0;
                foreach (var vertex1 in vlist)
                {
                    //if (rand.Next(0, count) > count/10) continue;
                    var vertex2 = vlist[rand.Next(0, result.VertexCount - 1)];
                    result.AddEdge(new UniverseEdge(vertex1, vertex2, 1)
                    { Text = string.Format("{0} -> {1}", vertex1, vertex2) });

                    if (c % 5 == 0)
                    {
                        var vertex3 = vlist[rand.Next(0, result.VertexCount - 1)];
                        result.AddEdge(new UniverseEdge(vertex1, vertex3, 0.5)
                        { Text = string.Format("{0} -> {1}", vertex1, vertex2) });
                    }
                    c++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
