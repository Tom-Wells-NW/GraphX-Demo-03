using Fss.Graph.Demo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Graph.Demo.Library.Helpers
{
    public class DesignGraphDataHelper
    {
        static DesignGraphDataHelper()
        {
            DataSource = GenerateDataSource(10);
        }

        #region static code
        private static List<DataVertex> DataSource { get; set; }

        private static List<DataVertex> GenerateDataSource(int count)
        {
            var result = new List<DataVertex>();
            var displayValues = GetAlphaNumericSequence(count);
            for (var i = 0; i < count; i++)
            {
                result.Add(new DataVertex { ID = i, Text = displayValues[i] });
            }
            return result;
        }

        public static List<string> GetPhoneticAlphabet()
        {
            var result = new List<string>
            {
                "Alpha",
                "Bravo",
                "Charlie",
                "Delta",
                "Echo",
                "Foxtrot",
                "Golf",
                "Hotel",
                "Idaho",
                "Juliet",
                "Kilo",
                "Lima",
                "Mike",
                "November",
                "Oscar",
                "Papa",
                "Quebec",
                "Romeo",
                "Sierra",
                "Tango",
                "Uniform",
                "Victor",
                "Wiskey",
                "X-Ray",
                "Yankee",
                "Zulu"
            };

            return result;
        }

        public static List<string> GetAlphaSequence(int count)
        {
            var alpha = new List<string>
            {
                "_","A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
            
            var result = (from first in alpha.Skip(1).Take(26)
                          from second in alpha.Skip(1).Take(26)
                          from third in alpha.Skip(1).Take(3)
                          select third+first+second).Take(count).ToList();

            return result;
        }

        public static List<string> GetAlphaNumericSequence(int count)
        {
            var alpha = new List<string>
            {
                "_","A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
            var numeric = new List<string>
            {
                "0","1", "2", "3", "4", "5", "6", "7", "8", "9"
            };
            var result = (from first in numeric.Skip(1).Take(10)
                          from second in numeric.Skip(1).Take(10)
                          from third in numeric.Skip(1).Take(10)
                          from fourth in alpha.Skip(1).Take(3)
                          select fourth + first + second + third).Take(count).ToList();

            return result;
        }

        public static void ResetDataSource(int count)
        {
            DataSource = GenerateDataSource(count);
        }

        #endregion static code


        public NodeGraph GenerateDesignGraph()
        {
            return GenerateDesignGraph(50);
        }

        public NodeGraph GenerateDesignGraph(int count)
        {
            if (DataSource.Count < count) ResetDataSource(count);
            //if (DataSource.Count < count) 
            var result = new NodeGraph();

            Random rand = new Random();
            try
            {
                //Create and add vertices using some DataSource for ID's
                foreach (var item in DataSource.Take(count))
                    result.AddVertex(new DataVertex() { ID = item.ID, Text = item.Text });

                var vlist = result.Vertices.ToList();
                //Generate random edges for the vertices
                foreach (var vertex1 in vlist)
                {
                    //if (rand.Next(0, count) > count/10) continue;
                    var vertex2 = vlist[rand.Next(0, result.VertexCount - 1)];
                    result.AddEdge(new DataEdge(vertex1, vertex2, 1)
                    { Text = string.Format("{0} -> {1}", vertex1, vertex2) }); ;
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
