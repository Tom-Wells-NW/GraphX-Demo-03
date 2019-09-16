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
            var universes = GetUniverseList();
            
            foreach(var universe in universes)
            {
                result.Add(new UniverseVertex { ID = universe.Id, Text = universe.Name, Model = universe });
            }
            return result;
        }

        public static List<UniverseModel> GetUniverseList()
        {
            var result = new List<UniverseModel>
            {
                new UniverseModel(100, "Asimov",    "Foundation Universe"),
                new UniverseModel(101, "Brin",      "Uplift Universe"),
                new UniverseModel(102, "Heinlein",  "Citizen of the Galaxy"),
                new UniverseModel(103, "Heinlein",  "Starman Jones"),
                new UniverseModel(104, "Heinlein",  "Starship Troopers"),
                new UniverseModel(105, "Heinlein",  "Time Enough for Love"),
                new UniverseModel(106, "Heinlein",  "Time for the Stars"),
                new UniverseModel(107, "Heinlein",  "Tunnel in the Sky"),
                new UniverseModel(108, "Herbert",   "Dune Universe"),
                new UniverseModel(109, "Whedon",    "Firefly Universe")
            };

            return result;
        }

        public static List<UniverseObjectModel> GetUniverseObjects()
        {
            var result = new List<UniverseObjectModel>();

            result.Add(new UniverseObjectModel(100, 100, "61 Cygni", "Star System"));
            result.Add(new UniverseObjectModel(101, 100, "Alpha", "Planet"));
            result.Add(new UniverseObjectModel(102, 100, "Anacreon", "Planet"));
            result.Add(new UniverseObjectModel(103, 100, "Arcturus", "Planet"));
            result.Add(new UniverseObjectModel(104, 100, "Askone", "Planet"));

            result.Add(new UniverseObjectModel(179, 101, "Calafia", "Planet"));
            result.Add(new UniverseObjectModel(180, 101, "Cathrhennlin", "Planet"));
            result.Add(new UniverseObjectModel(181, 101, "Deemi", "Planet"));
            result.Add(new UniverseObjectModel(182, 101, "Garth", "Planet"));
            result.Add(new UniverseObjectModel(183, 101, "Horst", "Planet"));

            result.Add(new UniverseObjectModel(194, 102, "Akka", "Planet"));
            result.Add(new UniverseObjectModel(195, 102, "Far - Star", "Planet"));
            result.Add(new UniverseObjectModel(196, 102, "Finster", "Planet"));
            result.Add(new UniverseObjectModel(197, 102, "Hekate", "Planet"));
            result.Add(new UniverseObjectModel(198, 102, "Jubbul", "Planet"));

            result.Add(new UniverseObjectModel(210, 103, "Beta Corvi III", "Planet"));
            result.Add(new UniverseObjectModel(211, 103, "Epsilon Ceti IV", "Planet"));
            result.Add(new UniverseObjectModel(212, 103, "Epsilon Gemini V", "Planet"));
            result.Add(new UniverseObjectModel(213, 103, "Gamma Leonis VI(b)", "Planet"));
            result.Add(new UniverseObjectModel(214, 103, "Garson's Planet", "Planet"));

            result.Add(new UniverseObjectModel(218, 104, "Terra(Earth)", "Planet"));
            result.Add(new UniverseObjectModel(219, 104, "Faraway", "Planet"));
            result.Add(new UniverseObjectModel(220, 104, "Hesperus", "Planet"));
            result.Add(new UniverseObjectModel(221, 104, "Iskander", "Planet"));
            result.Add(new UniverseObjectModel(222, 104, "Klendathu", "Planet"));


            result.Add(new UniverseObjectModel(226, 105, "Blessed", "Planet"));
            result.Add(new UniverseObjectModel(227, 105, "Fatima", "Planet"));
            result.Add(new UniverseObjectModel(228, 105, "Felicity", "Planet"));
            result.Add(new UniverseObjectModel(229, 105, "Landfall", "Planet"));
            result.Add(new UniverseObjectModel(230, 105, "New Beginnings", "Planet"));

            result.Add(new UniverseObjectModel(236, 106, "Capella VIII", "Planet"));
            result.Add(new UniverseObjectModel(237, 106, "Ceres", "Planet"));
            result.Add(new UniverseObjectModel(238, 106, "Constance", "Planet"));
            result.Add(new UniverseObjectModel(239, 106, "Elysia", "Planet"));
            result.Add(new UniverseObjectModel(240, 106, "Ganymede", "Planet"));

            result.Add(new UniverseObjectModel(247, 107, "Byer's Planet", "Planet"));
            result.Add(new UniverseObjectModel(248, 107, "Heavenly Mountains", "Planet"));
            result.Add(new UniverseObjectModel(249, 107, "Mithra", "Planet"));
            result.Add(new UniverseObjectModel(250, 107, "New Canaan", "Planet"));
            result.Add(new UniverseObjectModel(251, 107, "Ratoon", "Planet"));

            result.Add(new UniverseObjectModel(256, 108, "Al Dhanab", "Planet"));
            result.Add(new UniverseObjectModel(257, 108, "Arrakis", "Planet"));
            result.Add(new UniverseObjectModel(258, 108, "Bela Tegeuse", "Planet"));
            result.Add(new UniverseObjectModel(259, 108, "Buzzell", "Planet"));
            result.Add(new UniverseObjectModel(260, 108, "Caladan", "Planet"));

            result.Add(new UniverseObjectModel(298, 109, "Aberdeen", "Planet"));
            result.Add(new UniverseObjectModel(299, 109, "Angel", "Planet"));
            result.Add(new UniverseObjectModel(300, 109, "Ariel", "Planet"));
            result.Add(new UniverseObjectModel(301, 109, "Athens", "Planet"));
            result.Add(new UniverseObjectModel(302, 109, "Beaumonde", "Planet"));


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

            var result = new UniverseGraph();
            var universeObjects = GetUniverseObjects();



            Random rand = new Random();
            try
            {

                var root = new UniverseVertex() { ID = 1, Text = "root", Model = "Root" };
                result.AddVertex(root);


                //Create and add vertices using some DataSource for ID's
                foreach (var universe in DataSource.Take(count))
                {

                    var parent = new UniverseVertex() { ID = universe.ID, Text = universe.Text, Model = universe };
                    result.AddVertex(parent);

                    result.AddEdge(new UniverseEdge(root, parent, 1) { Text = string.Format("{0} -> {1}", root.Text, parent.Text) });

                    var thisUniversesObjects = universeObjects.Where(o => o.UniverseId == universe.ID);
                    foreach(var universObject in thisUniversesObjects)
                    {
                        var child = new UniverseVertex() { ID = universObject.Id, Text = universObject.ObjectName, Model = universObject };
                        result.AddVertex(child);
                        result.AddEdge(new UniverseEdge(parent, child, 1) { Text = string.Format("{0} -> {1}", parent.Text, child.Text) });
                    }
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
