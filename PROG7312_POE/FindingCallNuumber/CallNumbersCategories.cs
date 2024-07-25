using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE //.FindingCallNuumber
{
    public class CallNumbersCategories
    {

        private string name;
        private int code;
       // private Random randy;


        //-------------------------------------------------------------------------END OF CODE---------------------------------------------------//
        public CallNumbersCategories(string name, int code)
        {
            this.name = name;
            this.code = code;
        }


        private Random randy;
        public CallNumbersCategories()
        {
            randy = new Random();


        }

        public override string ToString()
        {
            return $"{name} {code}";
        }

        public string Name { get => name; set => name = value; }
        public int Code { get => code; set => code = value; }

        [Obsolete]
        public void CreateJsonFile()
        {

            CallNumbersCategories CNC1 = new CallNumbersCategories("Computer science, information & general works", 000);
            CallNumbersCategories CNC2 = new CallNumbersCategories("Bibliographies", 010);
            CallNumbersCategories CNC3 = new CallNumbersCategories("Library & Information Sciences", 020);
            CallNumbersCategories CNC4 = new CallNumbersCategories("Encyclopedias & Books of Facts", 030);
            CallNumbersCategories CNC5 = new CallNumbersCategories("Biographies", 040);
            CallNumbersCategories CNC6 = new CallNumbersCategories("Magazines, Journals, & Serials", 050);
            CallNumbersCategories CNC7 = new CallNumbersCategories("General Organizations & Museum Sciences", 060);
            CallNumbersCategories CNC8 = new CallNumbersCategories("News Media, Journalism, & Publishing", 070);
            CallNumbersCategories CNC9 = new CallNumbersCategories("General Collections", 080);
            CallNumbersCategories CNC10 = new CallNumbersCategories("Manuscripts & Rare Books", 090);

            CallNumbersCategories CNC11 = new CallNumbersCategories("Philosophy & Psychology", 100);
            CallNumbersCategories CNC12 = new CallNumbersCategories("Metaphysics", 110);
            CallNumbersCategories CNC13 = new CallNumbersCategories("Epistemology", 120);
            CallNumbersCategories CNC14 = new CallNumbersCategories("Parapsychology & Occultism", 130);
            CallNumbersCategories CNC15 = new CallNumbersCategories("Philosophical Schools", 140);
            CallNumbersCategories CNC16 = new CallNumbersCategories("Psychology", 150);
            CallNumbersCategories CNC17 = new CallNumbersCategories("Philosophical Logic", 160);
            CallNumbersCategories CNC18 = new CallNumbersCategories("Ethics", 170);
            CallNumbersCategories CNC19 = new CallNumbersCategories("Ancient, Medieval, & Eastern Philosophy", 180);
            CallNumbersCategories CNC20 = new CallNumbersCategories("Modern Western Philosophy", 190);

            CallNumbersCategories CNC21 = new CallNumbersCategories("Religion", 200);
            CallNumbersCategories CNC22 = new CallNumbersCategories("Philosophy & Theory of Religion", 210);
            CallNumbersCategories CNC23 = new CallNumbersCategories("The Bible", 220);
            CallNumbersCategories CNC24 = new CallNumbersCategories("Christianity", 230);
            CallNumbersCategories CNC25 = new CallNumbersCategories("Christian Moral & Devotional Theology", 240);
            CallNumbersCategories CNC26 = new CallNumbersCategories("Local Christian Church & Christian Religious Orders", 250);
            CallNumbersCategories CNC27 = new CallNumbersCategories("Christian Social and Ecclesiastical Theology", 260);
            CallNumbersCategories CNC28 = new CallNumbersCategories("History, Geographic Treatment, Biography of Christianity", 270);
            CallNumbersCategories CNC29 = new CallNumbersCategories("Denominations and sects of Christian church", 280);
            CallNumbersCategories CNC30 = new CallNumbersCategories("Non-Christian Religions", 290);

            CallNumbersCategories CNC31 = new CallNumbersCategories("Social sciences, sociology & anthropology", 300);
            CallNumbersCategories CNC32 = new CallNumbersCategories("Collections of General Statistics", 310);
            CallNumbersCategories CNC33 = new CallNumbersCategories("Political Science (Politics & Government)", 320);
            CallNumbersCategories CNC34 = new CallNumbersCategories("Economics", 330);
            CallNumbersCategories CNC35 = new CallNumbersCategories("Law", 340);
            CallNumbersCategories CNC36 = new CallNumbersCategories("Public Administration & Military Science", 350);
            CallNumbersCategories CNC37 = new CallNumbersCategories("Social Problems & Services; Associations", 360);
            CallNumbersCategories CNC38 = new CallNumbersCategories("Education", 370);
            CallNumbersCategories CNC39 = new CallNumbersCategories("Commerce, Communications, & Transportation", 380);
            CallNumbersCategories CNC40 = new CallNumbersCategories("Customs, Etiquette, Folklore", 390);

            CallNumbersCategories CNC41 = new CallNumbersCategories("Language", 400);
            CallNumbersCategories CNC42 = new CallNumbersCategories("Linguistics", 410);
            CallNumbersCategories CNC43 = new CallNumbersCategories("English & Old English (Anglo-Saxon)", 420);
            CallNumbersCategories CNC44 = new CallNumbersCategories("German and Related Languages", 430);
            CallNumbersCategories CNC45 = new CallNumbersCategories("French & Related Romance Languages", 440);
            CallNumbersCategories CNC46 = new CallNumbersCategories("Italian, Dalmatian, Romanian, Rhaetian, Sardinian, Corsican", 450);
            CallNumbersCategories CNC47 = new CallNumbersCategories("Spanish, Portuguese, Galician", 460);
            CallNumbersCategories CNC48 = new CallNumbersCategories("Latin & Related Italic Languages", 470);
            CallNumbersCategories CNC49 = new CallNumbersCategories("Classical & Modern Greek Languages", 480);
            CallNumbersCategories CNC50 = new CallNumbersCategories("Other Languages", 490);

            CallNumbersCategories CNC51 = new CallNumbersCategories("Natural sciences & Mathematics", 500);
            CallNumbersCategories CNC52 = new CallNumbersCategories("Mathematics", 510);
            CallNumbersCategories CNC53 = new CallNumbersCategories("Astronomy & Allied Sciences", 520);
            CallNumbersCategories CNC54 = new CallNumbersCategories("Physics", 530);
            CallNumbersCategories CNC55 = new CallNumbersCategories("Chemistry & Allied Sciences", 540);
            CallNumbersCategories CNC56 = new CallNumbersCategories("Earth Sciences & Geology", 550);
            CallNumbersCategories CNC57 = new CallNumbersCategories("Paleontology, Fossils & Prehistoric Life", 560);
            CallNumbersCategories CNC58 = new CallNumbersCategories("Biology", 570);
            CallNumbersCategories CNC59 = new CallNumbersCategories("Plants", 580);
            CallNumbersCategories CNC60 = new CallNumbersCategories("Animals (Zoology)", 590);

            CallNumbersCategories CNC61 = new CallNumbersCategories("Technology (Applied Sciences)", 600);
            CallNumbersCategories CNC62 = new CallNumbersCategories("Medicine & Health", 610);
            CallNumbersCategories CNC63 = new CallNumbersCategories("Engineering & Applied Operations", 620);
            CallNumbersCategories CNC64 = new CallNumbersCategories("Agriculture & Related Technologies", 630);
            CallNumbersCategories CNC65 = new CallNumbersCategories("Home & Family Management", 640);
            CallNumbersCategories CNC66 = new CallNumbersCategories("Management & Public Relations", 650);
            CallNumbersCategories CNC67 = new CallNumbersCategories("Chemical Engineering & Related Technologies", 660);
            CallNumbersCategories CNC68 = new CallNumbersCategories("Manufacturing", 670);
            CallNumbersCategories CNC69 = new CallNumbersCategories("Manufacture of Products for Specific Uses", 680);
            CallNumbersCategories CNC70 = new CallNumbersCategories("Construction of Buildings", 690);

            CallNumbersCategories CNC71 = new CallNumbersCategories("The Arts", 700);
            CallNumbersCategories CNC72 = new CallNumbersCategories("Area Planning & Landscape Architecture", 710);
            CallNumbersCategories CNC73 = new CallNumbersCategories("Architecture", 720);
            CallNumbersCategories CNC74 = new CallNumbersCategories("Sculpture, Ceramics, & Metalwork", 730);
            CallNumbersCategories CNC75 = new CallNumbersCategories("Graphic Arts & Decorative Arts", 740);
            CallNumbersCategories CNC76 = new CallNumbersCategories("Painting & Paintings", 750);
            CallNumbersCategories CNC77 = new CallNumbersCategories("Printmaking & Prints", 760);
            CallNumbersCategories CNC78 = new CallNumbersCategories("Photography, Computer Art, Cinematography, & Videography", 770);
            CallNumbersCategories CNC79 = new CallNumbersCategories("Music", 780);
            CallNumbersCategories CNC80 = new CallNumbersCategories("Recreational & Performing Arts; Sports, Games & Entertainment", 790);

            CallNumbersCategories CNC81 = new CallNumbersCategories("Literature, Rhetoric & Criticism", 800);
            CallNumbersCategories CNC82 = new CallNumbersCategories("American Literature in English", 810);
            CallNumbersCategories CNC83 = new CallNumbersCategories("English & Old English (Anglo-Saxon) Literatures", 820);
            CallNumbersCategories CNC84 = new CallNumbersCategories("German Literature & Literatures of Related Languages", 830);
            CallNumbersCategories CNC85 = new CallNumbersCategories(" French Literature & Literatures of Related Romance Languages", 840);
            CallNumbersCategories CNC86 = new CallNumbersCategories("Literatures of Italian, Dalmatian, Romanian, Rhaetian, Sardinian, Corsican Languages", 850);
            CallNumbersCategories CNC87 = new CallNumbersCategories("Literatures of Spanish, Portuguese, Galician Languages", 860);
            CallNumbersCategories CNC88 = new CallNumbersCategories("Latin Literature & Literatures of Related Italic Languages", 870);
            CallNumbersCategories CNC89 = new CallNumbersCategories("Classical Greek Literature & Literatures of Related Hellenic Languages", 880);
            CallNumbersCategories CNC90 = new CallNumbersCategories("Literatures of other Specific Languages and Language Families", 890);

            CallNumbersCategories CNC91 = new CallNumbersCategories("History, Geography, & Auxiliary Disciplines", 900);
            CallNumbersCategories CNC92 = new CallNumbersCategories("Geography & Travel", 910);
            CallNumbersCategories CNC93 = new CallNumbersCategories("Biography, Genealogy, & Insignia", 920);
            CallNumbersCategories CNC94 = new CallNumbersCategories("History of Ancient World", 930);
            CallNumbersCategories CNC95 = new CallNumbersCategories("History of Europe", 940);
            CallNumbersCategories CNC96 = new CallNumbersCategories("History of Asia", 950);
            CallNumbersCategories CNC97 = new CallNumbersCategories("History of Africa", 960);
            CallNumbersCategories CNC98 = new CallNumbersCategories("History of North America", 970);
            CallNumbersCategories CNC99 = new CallNumbersCategories("History of South America", 980);
            CallNumbersCategories CNC100 = new CallNumbersCategories("History of Australasia, Pacific Ocean Islands, Atlantic Ocean Islands, Arctic Islands, Antarctica, Extraterrestrial Worlds\r\n", 990);


            List<CallNumbersCategories> entries = new List<CallNumbersCategories>
            {
                CNC1,
                CNC2,
                CNC3,   
                CNC4,
                CNC5,
                CNC6,
                CNC7,
                CNC8,
                CNC9,
                CNC10,

                CNC11,
                CNC12,
                CNC13,
                CNC14,
                CNC15,
                CNC16,
                CNC17,
                CNC18,
                CNC19,
                CNC20,

                CNC21,
                CNC22,
                CNC23,
                CNC24,
                CNC25,
                CNC26,
                CNC27,
                CNC28,
                CNC29,
                CNC30,

                CNC31,
                CNC32,
                CNC33,
                CNC34,
                CNC35,
                CNC36,
                CNC37,
                CNC38,
                CNC39,
                CNC40,

                CNC41,
                CNC42,
                CNC43,
                CNC44,
                CNC45,
                CNC46,
                CNC47,
                CNC48,
                CNC49,
                CNC50,

                CNC51,
                CNC52,
                CNC53,
                CNC54,
                CNC55,
                CNC56,
                CNC57,
                CNC58,
                CNC59,
                CNC60,

                CNC61,
                CNC62,
                CNC63,
                CNC64,
                CNC65,
                CNC66,
                CNC67,
                CNC68,
                CNC69,
                CNC70,

                CNC71,
                CNC72,
                CNC73,
                CNC74,
                CNC75,
                CNC76,
                CNC77,
                CNC78,
                CNC79,
                CNC80,

                CNC81,
                CNC82,
                CNC83,
                CNC84,
                CNC85,
                CNC86,
                CNC87,
                CNC88,
                CNC89,
                CNC90,

                CNC91,
                CNC92,
                CNC93,
                CNC94,
                CNC95,
                CNC96,
                CNC97,
                CNC98,
                CNC99,
                CNC100,

                
            };

            using (StreamWriter writer = new StreamWriter("Categories.json", false))
            {
                JsonSerializer serialize = new JsonSerializer();
                serialize.Serialize(writer, entries);
            }


        }

        public List<CallNumbersCategories> ReadDataset()
        {
            try
            {

                string jsonData = "";
                using (StreamReader reader = new StreamReader("Categories.json"))
                {
                    jsonData = reader.ReadToEnd();
                }
                List<CallNumbersCategories> dataset = JsonConvert.DeserializeObject<List<CallNumbersCategories>>(jsonData);
                foreach (var item in dataset)
                {
                    Console.WriteLine(item);
                }

                return dataset;

            }
            //Exception handling
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to read dataset: {ex.Message}ex");
                throw;
            }
        }

        public List<CallNumbersCategories> GetRandomQA()
        {
            List<CallNumbersCategories> qaList = new List<CallNumbersCategories>();
            Tree<CallNumbersCategories> tree = PopulateTree();
            CallNumbersCategories c = new CallNumbersCategories();

            int randomTop = randy.Next(0, 10);
            int randomSecond = randy.Next(0, 4);
            int randomThird = randy.Next(0, 2);
            c = tree.Root.Children[randomTop].Children[randomSecond].Children[randomThird].Data;
            qaList.Add(c); // This value is the third level question.

            List<int> randomTopLevels = new List<int>();
            randomTopLevels.Add(randomTop); // Ensuring the correct top level for the question will be there.

            // Loop to get 3 other top levels.
            while (randomTopLevels.Count < 4)
            {
                int randomTopLevel = randy.Next(0, 10);

                if (!randomTopLevels.Contains(randomTopLevel))
                {
                    randomTopLevels.Add(randomTopLevel);
                }
            }

            randomTopLevels.Sort(); // Ordering the list by ascending value.

            // Getting the actual data for the random top level indices.
            foreach (int rnd in randomTopLevels)
            {
                c = tree.Root.Children[rnd].Data;
                qaList.Add(c);
            }

            // Getting the correct four second levels from the appropriate top level.
            for (int i = 0; i < 4; i++)
            {
                c = tree.Root.Children[randomTop].Children[i].Data;

                qaList.Add(c);
            }

            return qaList;
        }


        public (string message, bool correct) CheckAnswerTopLevel(CallNumbersCategories answer, CallNumbersCategories question)
        {
            string message;
            bool correct;

            // Checking if the user got the correct answer and telling them the correct answer if they didn't get it.
            if (question.code > answer.code && question.code < answer.code + 100)
            {
                correct = true;
                message = "Correct!";
            }
            else
            {
                int correctTopLevel = RoundToNearest(question.code - 50, 100); // Rounding to the nearest 100.
                correct = false;
                message = $"Incorrect! The correct top level classification was {correctTopLevel}.";
            }

            return (message, correct);
        }

        public (string message, bool correct) CheckAnswerSecondLevel(CallNumbersCategories answer, CallNumbersCategories question)
        {
            string message;
            bool correct;

            if (question.code > answer.code && question.code < answer.code + 10)
            {
                correct = true;
                message = "Correct!";
            }
            else
            {
                int correctSecondLevel = RoundToNearest(question.code - 5, 10); // Rounding to the nearest 10.
                correct = false;
                message = $"Incorrect! The correct second level classification was {correctSecondLevel}.";
            }

            return (message, correct);
        }

        public int RoundToNearest(int i, int nearest)
        {
            if (nearest <= 0 || nearest % 10 != 0)
                throw new ArgumentOutOfRangeException("nearest", "Must round to a positive multiple of 10");

            return (i + 5 * nearest / 10) / nearest * nearest;
        }



        /*
        public Tree<CallNumbersCategories> PopulateTree()
        {
            List<CallNumbersCategories> dataset = ReadDataset();

            Tree<CallNumbersCategories> tree = new Tree<CallNumbersCategories>();
            CallNumbersCategories root = new CallNumbersCategories("root", 9999);
            tree.Root = new DataTree<CallNumbersCategories>() { Data = root };

            int counter = 0;

            for (int i = 0; i < 10; i++)
            {
                // Creating the list of children if it does not exist, updating it if it does.
                if (tree.Root.Children is null)
                {
                    tree.Root.Children = new List<DataTree<CallNumbersCategories>>
            {
                new DataTree<CallNumbersCategories>() { Data = dataset.ElementAtOrDefault(counter), Parent = null }
            };
                }
                else
                {
                    tree.Root.Children.Add(new DataTree<CallNumbersCategories> { Data = dataset.ElementAtOrDefault(counter), Parent = null });
                }

                counter++;

                // Adding to second level.
                for (int j = 0; j < 4; j++)
                {
                    if (tree.Root.Children.ElementAtOrDefault(i)?.Children is null)
                    {
                        tree.Root.Children.ElementAtOrDefault(i).Children = new List<DataTree<CallNumbersCategories>>
                {
                    new DataTree<CallNumbersCategories>() { Data = dataset.ElementAtOrDefault(counter), Parent = tree.Root.Children.ElementAtOrDefault(i) }
                };
                    }
                    else
                    {
                        tree.Root.Children.ElementAtOrDefault(i).Children.Add(new DataTree<CallNumbersCategories> { Data = dataset.ElementAtOrDefault(counter), Parent = tree.Root.Children.ElementAtOrDefault(i) });
                    }

                    counter++;

                    // Adding to third level.
                    for (int k = 0; k < 2; k++)
                    {
                        if (tree.Root.Children.ElementAtOrDefault(i)?.Children.ElementAtOrDefault(j)?.Children is null)
                        {
                            tree.Root.Children.ElementAtOrDefault(i).Children.ElementAtOrDefault(j).Children = new List<DataTree<CallNumbersCategories>>
                    {
                        new DataTree<CallNumbersCategories>() { Data = dataset.ElementAtOrDefault(counter), Parent = tree.Root.Children.ElementAtOrDefault(i).Children.ElementAtOrDefault(j) },
                    };
                        }
                        else
                        {
                            tree.Root.Children.ElementAtOrDefault(i).Children.ElementAtOrDefault(j).Children.Add(new DataTree<CallNumbersCategories> { Data = dataset.ElementAtOrDefault(counter), Parent = tree.Root.Children.ElementAtOrDefault(i).Children.ElementAtOrDefault(j) });
                        }

                        counter++;
                    }
                }
            }
            return tree;
        }
        */

        public Tree<CallNumbersCategories> PopulateTree()
        {
            List<CallNumbersCategories> dataset = ReadDataset();

            Tree<CallNumbersCategories> tree = new Tree<CallNumbersCategories>();
            CallNumbersCategories root = new CallNumbersCategories("root", 9999);
            tree.Root = new DataTree<CallNumbersCategories>() { Data = root };

            int counter = 0;

            for (int i = 0; i < 10; i++)
            {
                // Creating the list of children if it does not exist, updating it if it does.
                if (tree.Root.Children is null)
                {
                    tree.Root.Children = new List<DataTree<CallNumbersCategories>>
            {
                new DataTree<CallNumbersCategories>() { Data = dataset.ElementAtOrDefault(counter), Parent = null }
            };
                }
                else
                {
                    tree.Root.Children.Add(new DataTree<CallNumbersCategories> { Data = dataset.ElementAtOrDefault(counter), Parent = null });
                }

                counter++;

                // Adding to second level.
                for (int j = 0; j < 4; j++)
                {
                    if (tree.Root.Children.ElementAtOrDefault(i)?.Children is null)
                    {
                        tree.Root.Children.ElementAtOrDefault(i).Children = new List<DataTree<CallNumbersCategories>>
                {
                    new DataTree<CallNumbersCategories>() { Data = dataset.ElementAtOrDefault(counter), Parent = tree.Root.Children.ElementAtOrDefault(i) }
                };
                    }
                    else
                    {
                        tree.Root.Children.ElementAtOrDefault(i).Children.Add(new DataTree<CallNumbersCategories> { Data = dataset.ElementAtOrDefault(counter), Parent = tree.Root.Children.ElementAtOrDefault(i) });
                    }

                    counter++;

                    // Adding to third level.
                    for (int k = 0; k < 2; k++)
                    {
                        if (tree.Root.Children.ElementAtOrDefault(i)?.Children.ElementAtOrDefault(j)?.Children is null)
                        {
                            tree.Root.Children.ElementAtOrDefault(i).Children.ElementAtOrDefault(j).Children = new List<DataTree<CallNumbersCategories>>
                    {
                        new DataTree<CallNumbersCategories>() { Data = dataset.ElementAtOrDefault(counter), Parent = tree.Root.Children.ElementAtOrDefault(i).Children.ElementAtOrDefault(j) },
                    };
                        }
                        else
                        {
                            tree.Root.Children.ElementAtOrDefault(i).Children.ElementAtOrDefault(j).Children.Add(new DataTree<CallNumbersCategories> { Data = dataset.ElementAtOrDefault(counter), Parent = tree.Root.Children.ElementAtOrDefault(i).Children.ElementAtOrDefault(j) });
                        }

                        counter++;
                    }
                }
            }

            return tree;
        }

    }
}


//-----------------------------------------------------------------------------------END OF CODE-------------------------------------------------------//