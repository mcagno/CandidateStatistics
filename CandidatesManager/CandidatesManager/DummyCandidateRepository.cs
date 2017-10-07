using System.Collections.Generic;
using System.Linq;

namespace CandidatesManager
{
    public class DummyCandidateRepository : ICandidateRepository
    {
        public IEnumerable<string> GetEntries()
        {
            return RegisteredCandidatesSource1().Union(RegisteredCandidatesSource2());
        }

        public string[] RegisteredCandidatesSource1()
        {
            //"Lastname, firstname"
            var arrNames1 = new[]
            {
                "Carrie, Kirker",
                "Masako, Freas",
                "Collins, Bill",
                "Smith , Bart",
                "Allen,  Tim",
                "Courtney Tyrrell",
                "Gidget, Borey",
                "Holley, Witte",
                "Robby,  Payeur",
                "Deloise,, Carnegie",
                "Sherwood ,Dille, Tim",
                "Lea, Balfour",
                "Catharine, Capra",
                "Julian, Turman",
                "Hoa ,Wissing",
                "Shanika, Theriault",
                "Eloise ,Fielden",
                "Marylynn, Masterson",
                "Hyun, Gonser",
                "Sherlene , Tumlin",
                "Harley , Delosreyes",
                "Lillie, Stolp",
                "Fred, Noblin",
                "Tangela ,Leider",
                "Long, Bruner",
                "Gaynell, Jaquith",
                "Karey, Whitworth",
                "Arturo, Shanley"
            };
            return arrNames1;
        }
        public string[] RegisteredCandidatesSource2()
        {
            //"Lastname, firstname"
            var arrNames2 = new[]
            {
                "Viki, Sharer",
                "Jule, Goldblatt",
                "Mao, Aldana",
                "Lorretta, Roman",
                "Scarlet, Solis",
                "Carrie, Kirker",
                "Masako, Freas",
                "Mollie, Rabinowitz",
                "Marceline ,Polley",
                "Earlene, Spake",
                "Eduardo, Benda",
                "Robt, Enderle",
                "Antonio, Mchaney",
                "Tilda, Kahan",
                "Melva, Erby",
                "Latashia, Szewczyk",
                "Faustina, Emberton",
                "Vallie, Bordeau",
                "Janette, Husted",
                "Anglea, Haman",
                "Parker, Doggett",
                "Lael, Chiaramonte",
                "Marie, Spilman",
                "Alene, Dressel",
                "Pamela, Monsour",
                "Bao, Mcardle",
                "Zina, Aikens",
                "Gudrun ,Caughman",
                "Rebecca",
                "Beverlee, Oiler,",
                "Elnora, Meaders,",
                "Becky, Leathers",
                "Lola",
                "Teofila, Gullatt",
                "Jacquiline, Lowrey",
                "Alica, Pellerin",
                "Jodie, Redding",
                "Zoraida, Vallecillo,",
                "Tova, Goranson",
                "Wendolyn, Cicero",
                "Long ,,Pigford",
                "Gaynell, Jaquith",
                "Karey, Whitworth",
                "Arturo, Shanley",
                "Shirl, Clingan",
                "Latarsha, Hollins",
                "Alvera, Keenan",
                "Elisha, Lipps",
                "Sherlyn, Semmes",
                "Galina, Porras"
            };
            return arrNames2;
        }


    }
}