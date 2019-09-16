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
            result.Add(new UniverseObjectModel(105, 100, "Asperta", "Planet"));
            result.Add(new UniverseObjectModel(106, 100, "Aurora", "Planet"));
            result.Add(new UniverseObjectModel(107, 100, "Baronn", "Planet"));
            result.Add(new UniverseObjectModel(108, 100, "Bonde", "Planet"));
            result.Add(new UniverseObjectModel(109, 100, "Cil", "Planet"));
            result.Add(new UniverseObjectModel(110, 100, "Cinna", "Planet"));
            result.Add(new UniverseObjectModel(111, 100, "Comporellon", "Planet"));
            result.Add(new UniverseObjectModel(112, 100, "Daribow", "Prefect"));
            result.Add(new UniverseObjectModel(113, 100, "Derowd", "Planet"));
            result.Add(new UniverseObjectModel(114, 100, "Eos", "Planet"));
            result.Add(new UniverseObjectModel(115, 100, "Erythro", "Moon"));
            result.Add(new UniverseObjectModel(116, 100, "Euterpe", "Planet"));
            result.Add(new UniverseObjectModel(117, 100, "Fictional planets", "Planet"));
            result.Add(new UniverseObjectModel(118, 100, "Florina", "Planet"));
            result.Add(new UniverseObjectModel(119, 100, "Fomalhaut", "Planet"));
            result.Add(new UniverseObjectModel(120, 100, "Four Kingdoms", "System of Planets"));
            result.Add(new UniverseObjectModel(121, 100, "Gia", "Planet"));
            result.Add(new UniverseObjectModel(122, 100, "Gamma Andromeda", "Star System"));
            result.Add(new UniverseObjectModel(123, 100, "Getorin", "Planet"));
            result.Add(new UniverseObjectModel(124, 100, "Glyptal IV", "Planet"));
            result.Add(new UniverseObjectModel(125, 100, "Haven", "Planet"));
            result.Add(new UniverseObjectModel(126, 100, "Helicon", "Planet"));
            result.Add(new UniverseObjectModel(127, 100, "Hesperos", "Planet"));
            result.Add(new UniverseObjectModel(128, 100, "Horleggor", "Planet"));
            result.Add(new UniverseObjectModel(129, 100, "Ifni", "Planet"));
            result.Add(new UniverseObjectModel(130, 100, "Iss", "Planet"));
            result.Add(new UniverseObjectModel(131, 100, "Jennisek", "Planet"));
            result.Add(new UniverseObjectModel(132, 100, "Kalgan", "Planet"));
            result.Add(new UniverseObjectModel(133, 100, "Konom", "Planet"));
            result.Add(new UniverseObjectModel(134, 100, "Korell", "Planet"));
            result.Add(new UniverseObjectModel(135, 100, "Libair", "Planet"));
            result.Add(new UniverseObjectModel(136, 100, "Livia", "Planet"));
            result.Add(new UniverseObjectModel(137, 100, "Locris", "Planet"));
            result.Add(new UniverseObjectModel(138, 100, "Lyonesse", "Planet"));
            result.Add(new UniverseObjectModel(139, 100, "Lystena", "Planet"));
            result.Add(new UniverseObjectModel(140, 100, "Mandress", "Planet"));
            result.Add(new UniverseObjectModel(141, 100, "Melpomenia", "Planet"));
            result.Add(new UniverseObjectModel(142, 100, "Mnemon", "Planet"));
            result.Add(new UniverseObjectModel(143, 100, "Mores", "Planet"));
            result.Add(new UniverseObjectModel(144, 100, "Nebula Kingdoms", "System of Planets"));
            result.Add(new UniverseObjectModel(145, 100, "Neotrantor", "Planet"));
            result.Add(new UniverseObjectModel(146, 100, "Nexon", "Planet"));
            result.Add(new UniverseObjectModel(147, 100, "Nishaya", "Planet"));
            result.Add(new UniverseObjectModel(148, 100, "Ophiuchus", "Planet"));
            result.Add(new UniverseObjectModel(149, 100, "Orsha II", "Planet"));
            result.Add(new UniverseObjectModel(150, 100, "Pallas", "Planet"));
            result.Add(new UniverseObjectModel(151, 100, "Radole", "Planet"));
            result.Add(new UniverseObjectModel(152, 100, "Rhampora", "Planet"));
            result.Add(new UniverseObjectModel(153, 100, "Rhea", "Planet"));
            result.Add(new UniverseObjectModel(154, 100, "Rhodia", "Planet"));
            result.Add(new UniverseObjectModel(155, 100, "Rigel", "Planet"));
            result.Add(new UniverseObjectModel(156, 100, "Rossem", "Planet"));
            result.Add(new UniverseObjectModel(157, 100, "Salinn", "Planet"));
            result.Add(new UniverseObjectModel(158, 100, "Santanni", "Planet"));
            result.Add(new UniverseObjectModel(159, 100, "Sarip", "Planet"));
            result.Add(new UniverseObjectModel(160, 100, "Sark", "Planet"));
            result.Add(new UniverseObjectModel(161, 100, "Sayshell", "Planet"));
            result.Add(new UniverseObjectModel(162, 100, "Sirius", "Planet"));
            result.Add(new UniverseObjectModel(163, 100, "Siwenna", "Planet"));
            result.Add(new UniverseObjectModel(164, 100, "Smitheus", "Planet"));
            result.Add(new UniverseObjectModel(165, 100, "Smushyk", "Planet"));
            result.Add(new UniverseObjectModel(166, 100, "Smyrno", "Planet"));
            result.Add(new UniverseObjectModel(167, 100, "Solaria", "Planet"));
            result.Add(new UniverseObjectModel(168, 100, "Synnax", "Planet"));
            result.Add(new UniverseObjectModel(169, 100, "Tazenda", "System of Planets"));
            result.Add(new UniverseObjectModel(170, 100, "Terel", "Planet"));
            result.Add(new UniverseObjectModel(171, 100, "Terminus", "Planet"));
            result.Add(new UniverseObjectModel(172, 100, "Trantor", "Planet"));
            result.Add(new UniverseObjectModel(173, 100, "Vega", "Planet"));
            result.Add(new UniverseObjectModel(174, 100, "Vincetori", "Planet"));
            result.Add(new UniverseObjectModel(175, 100, "Voreg", "Planet"));
            result.Add(new UniverseObjectModel(176, 100, "Wanda", "Planet"));
            result.Add(new UniverseObjectModel(177, 100, "Wencory", "Planet"));
            result.Add(new UniverseObjectModel(178, 100, "Zoranel", "Planet"));


            result.Add(new UniverseObjectModel(179, 101, "Calafia", "Planet"));
            result.Add(new UniverseObjectModel(180, 101, "Cathrhennlin", "Planet"));
            result.Add(new UniverseObjectModel(181, 101, "Deemi", "Planet"));
            result.Add(new UniverseObjectModel(182, 101, "Garth", "Planet"));
            result.Add(new UniverseObjectModel(183, 101, "Horst", "Planet"));
            result.Add(new UniverseObjectModel(184, 101, "Jijo", "Planet"));
            result.Add(new UniverseObjectModel(185, 101, "Jophekka", "Planet"));
            result.Add(new UniverseObjectModel(186, 101, "Juthtath", "Planet"));
            result.Add(new UniverseObjectModel(187, 101, "Kazzkark", "Planet"));
            result.Add(new UniverseObjectModel(188, 101, "Kithrup", "Planet"));
            result.Add(new UniverseObjectModel(189, 101, "NuDawn", "Planet"));
            result.Add(new UniverseObjectModel(190, 101, "Oakka", "Planet"));
            result.Add(new UniverseObjectModel(191, 101, "Omnivarium", "Planet"));
            result.Add(new UniverseObjectModel(192, 101, "Tanith", "Planet"));
            result.Add(new UniverseObjectModel(193, 101, "Urchachka", "Planet"));



            result.Add(new UniverseObjectModel(194, 102, "Akka", "Planet"));
            result.Add(new UniverseObjectModel(195, 102, "Far - Star", "Planet"));
            result.Add(new UniverseObjectModel(196, 102, "Finster", "Planet"));
            result.Add(new UniverseObjectModel(197, 102, "Hekate", "Planet"));
            result.Add(new UniverseObjectModel(198, 102, "Jubbul", "Planet"));
            result.Add(new UniverseObjectModel(199, 102, "Losian", "Planet"));
            result.Add(new UniverseObjectModel(200, 102, "Lotarf", "Planet"));
            result.Add(new UniverseObjectModel(201, 102, "Mars", "Planet"));
            result.Add(new UniverseObjectModel(202, 102, "Proxima", "Planet"));
            result.Add(new UniverseObjectModel(203, 102, "Riff", "Planet"));
            result.Add(new UniverseObjectModel(204, 102, "Shiva III", "Planet"));
            result.Add(new UniverseObjectModel(205, 102, "Terra(Earth)", "Planet"));
            result.Add(new UniverseObjectModel(206, 102, "Thaf Beta VI", "Planet"));
            result.Add(new UniverseObjectModel(207, 102, "Thoth IV", "Planet"));
            result.Add(new UniverseObjectModel(208, 102, "Ultima Thule", "Planet"));
            result.Add(new UniverseObjectModel(209, 102, "Woolamurra", "Planet"));


            result.Add(new UniverseObjectModel(210, 103, "Beta Corvi III", "Planet"));
            result.Add(new UniverseObjectModel(211, 103, "Epsilon Ceti IV", "Planet"));
            result.Add(new UniverseObjectModel(212, 103, "Epsilon Gemini V", "Planet"));
            result.Add(new UniverseObjectModel(213, 103, "Gamma Leonis VI(b)", "Planet"));
            result.Add(new UniverseObjectModel(214, 103, "Garson's Planet", "Planet"));
            result.Add(new UniverseObjectModel(215, 103, "Hespera", "Planet"));
            result.Add(new UniverseObjectModel(216, 103, "Mars", "Planet"));
            result.Add(new UniverseObjectModel(217, 103, "Paldron", "Planet"));


            result.Add(new UniverseObjectModel(218, 104, "Terra(Earth)", "Planet"));
            result.Add(new UniverseObjectModel(219, 104, "Faraway", "Planet"));
            result.Add(new UniverseObjectModel(220, 104, "Hesperus", "Planet"));
            result.Add(new UniverseObjectModel(221, 104, "Iskander", "Planet"));
            result.Add(new UniverseObjectModel(222, 104, "Klendathu", "Planet"));
            result.Add(new UniverseObjectModel(223, 104, "Planet P", "Planet"));
            result.Add(new UniverseObjectModel(224, 104, "Sanctuary", "Planet"));
            result.Add(new UniverseObjectModel(225, 104, "Sheol", "Planet"));


            result.Add(new UniverseObjectModel(226, 105, "Blessed", "Planet"));
            result.Add(new UniverseObjectModel(227, 105, "Fatima", "Planet"));
            result.Add(new UniverseObjectModel(228, 105, "Felicity", "Planet"));
            result.Add(new UniverseObjectModel(229, 105, "Landfall", "Planet"));
            result.Add(new UniverseObjectModel(230, 105, "New Beginnings", "Planet"));
            result.Add(new UniverseObjectModel(231, 105, "Ormuzd", "Planet"));
            result.Add(new UniverseObjectModel(232, 105, "Secundus", "Planet"));
            result.Add(new UniverseObjectModel(233, 105, "Tertius", "Planet"));
            result.Add(new UniverseObjectModel(234, 105, "Valhalla", "Planet"));
            result.Add(new UniverseObjectModel(235, 105, "Pitcairn Island", "Moon"));


            result.Add(new UniverseObjectModel(236, 106, "Capella VIII", "Planet"));
            result.Add(new UniverseObjectModel(237, 106, "Ceres", "Planet"));
            result.Add(new UniverseObjectModel(238, 106, "Constance", "Planet"));
            result.Add(new UniverseObjectModel(239, 106, "Elysia", "Planet"));
            result.Add(new UniverseObjectModel(240, 106, "Ganymede", "Planet"));
            result.Add(new UniverseObjectModel(241, 106, "Inferno", "Planet"));
            result.Add(new UniverseObjectModel(242, 106, "Jupiter", "Planet"));
            result.Add(new UniverseObjectModel(243, 106, "Mars", "Planet"));
            result.Add(new UniverseObjectModel(244, 106, "Pluto", "Planet"));
            result.Add(new UniverseObjectModel(245, 106, "Venus", "Planet"));
            result.Add(new UniverseObjectModel(246, 106, "Whistle Stop", "Planet"));



            result.Add(new UniverseObjectModel(247, 107, "Byer's Planet", "Planet"));
            result.Add(new UniverseObjectModel(248, 107, "Heavenly Mountains", "Planet"));
            result.Add(new UniverseObjectModel(249, 107, "Mithra", "Planet"));
            result.Add(new UniverseObjectModel(250, 107, "New Canaan", "Planet"));
            result.Add(new UniverseObjectModel(251, 107, "Ratoon", "Planet"));
            result.Add(new UniverseObjectModel(252, 107, "Spica IV", "Planet"));
            result.Add(new UniverseObjectModel(253, 107, "Tangaroa", "Planet"));
            result.Add(new UniverseObjectModel(254, 107, "Territa", "Planet"));
            result.Add(new UniverseObjectModel(255, 107, "Thule", "Planet"));



            result.Add(new UniverseObjectModel(256, 108, "Al Dhanab", "Planet"));
            result.Add(new UniverseObjectModel(257, 108, "Arrakis", "Planet"));
            result.Add(new UniverseObjectModel(258, 108, "Bela Tegeuse", "Planet"));
            result.Add(new UniverseObjectModel(259, 108, "Buzzell", "Planet"));
            result.Add(new UniverseObjectModel(260, 108, "Caladan", "Planet"));


            result.Add(new UniverseObjectModel(261, 108, "Chapterhouse", "Planet"));
            result.Add(new UniverseObjectModel(262, 108, "Chusuk", "Planet"));
            result.Add(new UniverseObjectModel(263, 108, "Corrin", "Planet"));
            result.Add(new UniverseObjectModel(264, 108, "Ecaz", "Planet"));
            result.Add(new UniverseObjectModel(265, 108, "Gamont", "Planet"));
            result.Add(new UniverseObjectModel(266, 108, "Gangishree", "Planet"));
            result.Add(new UniverseObjectModel(267, 108, "Gansireed", "Planet"));
            result.Add(new UniverseObjectModel(268, 108, "Giedi Prime", "Planet"));
            result.Add(new UniverseObjectModel(269, 108, "Ginaz", "Planet"));
            result.Add(new UniverseObjectModel(270, 108, "Grumman", "Planet"));
            result.Add(new UniverseObjectModel(271, 108, "Hagal", "Planet"));
            result.Add(new UniverseObjectModel(272, 108, "Harmonthep", "Planet"));
            result.Add(new UniverseObjectModel(273, 108, "III Delta Kaising", "Planet"));
            result.Add(new UniverseObjectModel(274, 108, "Ipyr", "Planet"));
            result.Add(new UniverseObjectModel(275, 108, "IV Anbus", "Planet"));
            result.Add(new UniverseObjectModel(276, 108, "Ix", "Planet"));
            result.Add(new UniverseObjectModel(277, 108, "Junction", "Planet"));
            result.Add(new UniverseObjectModel(278, 108, "Kaitain", "Planet"));
            result.Add(new UniverseObjectModel(279, 108, "Kolhar", "Planet"));
            result.Add(new UniverseObjectModel(280, 108, "Lampadas", "Planet"));
            result.Add(new UniverseObjectModel(281, 108, "Lankiveil", "Planet"));
            result.Add(new UniverseObjectModel(282, 108, "Lernaeus", "Planet"));
            result.Add(new UniverseObjectModel(283, 108, "Muritan", "Planet"));
            result.Add(new UniverseObjectModel(284, 108, "Naraj", "Planet"));
            result.Add(new UniverseObjectModel(285, 108, "Palma", "Planet"));
            result.Add(new UniverseObjectModel(286, 108, "Parmentier", "Planet"));
            result.Add(new UniverseObjectModel(287, 108, "Poritrin", "Planet"));
            result.Add(new UniverseObjectModel(288, 108, "Richese", "Planet"));
            result.Add(new UniverseObjectModel(289, 108, "Romo", "Planet"));
            result.Add(new UniverseObjectModel(290, 108, "Rossak", "Planet"));
            result.Add(new UniverseObjectModel(291, 108, "Salusa Secundus", "Planet"));
            result.Add(new UniverseObjectModel(292, 108, "Sikun", "Planet"));
            result.Add(new UniverseObjectModel(293, 108, "Synchrony", "Planet"));
            result.Add(new UniverseObjectModel(294, 108, "Tleilax", "Planet"));
            result.Add(new UniverseObjectModel(295, 108, "Tupile", "Planet"));
            result.Add(new UniverseObjectModel(296, 108, "Wallach IX", "Planet"));
            result.Add(new UniverseObjectModel(297, 108, "Zanovar", "Planet"));


            result.Add(new UniverseObjectModel(298, 109, "Aberdeen", "Planet"));
            result.Add(new UniverseObjectModel(299, 109, "Angel", "Planet"));
            result.Add(new UniverseObjectModel(300, 109, "Ariel", "Planet"));
            result.Add(new UniverseObjectModel(301, 109, "Athens", "Planet"));
            result.Add(new UniverseObjectModel(302, 109, "Beaumonde", "Planet"));
            result.Add(new UniverseObjectModel(303, 109, "Bellerophon", "Planet"));
            result.Add(new UniverseObjectModel(304, 109, "Bernadette", "Planet"));
            result.Add(new UniverseObjectModel(305, 109, "Beylix", "Planet"));
            result.Add(new UniverseObjectModel(306, 109, "Boros", "Planet"));
            result.Add(new UniverseObjectModel(307, 109, "Deadwood", "Planet"));
            result.Add(new UniverseObjectModel(308, 109, "Dyton", "Moon"));
            result.Add(new UniverseObjectModel(309, 109, "Ezra", "Planet"));
            result.Add(new UniverseObjectModel(310, 109, "Greenleaf", "Planet"));
            result.Add(new UniverseObjectModel(311, 109, "Harvest", "Planet"));
            result.Add(new UniverseObjectModel(312, 109, "Haven", "Planet"));
            result.Add(new UniverseObjectModel(313, 109, "Hera", "Planet"));
            result.Add(new UniverseObjectModel(314, 109, "Higgins' Moon", "Moon"));
            result.Add(new UniverseObjectModel(315, 109, "Highgate", "Planet"));
            result.Add(new UniverseObjectModel(316, 109, "Ita", "Moon"));
            result.Add(new UniverseObjectModel(317, 109, "Jiangyin", "Planet"));
            result.Add(new UniverseObjectModel(318, 109, "Kerry", "Planet"));
            result.Add(new UniverseObjectModel(319, 109, "Liann Jiun", "Planet"));
            result.Add(new UniverseObjectModel(320, 109, "Lilac", "Moon"));
            result.Add(new UniverseObjectModel(321, 109, "Londinium", "Planet"));
            result.Add(new UniverseObjectModel(322, 109, "Miranda", "Planet"));
            result.Add(new UniverseObjectModel(323, 109, "Muir", "Planet"));
            result.Add(new UniverseObjectModel(324, 109, "New Melbourne", "Planet"));
            result.Add(new UniverseObjectModel(325, 109, "Newhall", "Planet"));
            result.Add(new UniverseObjectModel(326, 109, "Osiris", "Planet"));
            result.Add(new UniverseObjectModel(327, 109, "Paquin", "Planet"));
            result.Add(new UniverseObjectModel(328, 109, "Parth", "Moon"));
            result.Add(new UniverseObjectModel(329, 109, "Pelorum", "Planet"));
            result.Add(new UniverseObjectModel(330, 109, "Persephone", "Planet"));
            result.Add(new UniverseObjectModel(331, 109, "Regina", "Planet"));
            result.Add(new UniverseObjectModel(332, 109, "Salisbury", "Planet"));
            result.Add(new UniverseObjectModel(333, 109, "Santo", "Planet"));
            result.Add(new UniverseObjectModel(334, 109, "Shadow", "Planet"));
            result.Add(new UniverseObjectModel(335, 109, "Sihnon", "Planet"));
            result.Add(new UniverseObjectModel(336, 109, "Silverhold", "Moon"));
            result.Add(new UniverseObjectModel(337, 109, "St.Albans", "Planet"));
            result.Add(new UniverseObjectModel(338, 109, "Three Hills", "Planet"));
            result.Add(new UniverseObjectModel(339, 109, "Triumph", "Planet"));
            result.Add(new UniverseObjectModel(340, 109, "Verbena", "Planet"));
            result.Add(new UniverseObjectModel(341, 109, "Whitefall", "Moon"));
            result.Add(new UniverseObjectModel(342, 109, "Whittier", "Planet"));


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

        private static string GetShortTypeName(Type t)
        {
            var s = t.ToString();
            var index = s.LastIndexOf(".");
            var result = s.Substring(index + 1, s.Length - (index + 1));
            return result;
        }
    }
}
