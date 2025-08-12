
class Program
{
    public class Companies
    {
        public int id;
        public string company;

        public string def;
        public string keyword;

    }

    static void Main(string[] args)
    {
        var companies = new List<Companies>
        {
            new Companies { id = 1, company = "dogo",       def = "dogo is a shoes company",    keyword = "bags, travel, accessories" },


            new Companies { id = 2, company = "zara",     def = "dress and   crop company ",     keyword = "dress, skirt, shorts, shoes" },

            new Companies { id = 3, company = "mavi denim", def = "jeans and denim company",     keyword = "jeans, denim, jacket" },
            new Companies { id = 4, company = "b bag ",     def = "travel bags compny",         keyword = "bags, luggage, suitcase, travel" },
        };



        foreach (var item in companies)
        {
            Console.WriteLine($"id: {item.id} | company : {item.company}  | definition: {item.def} | keywords: {item.keyword}");

        }

        Console.WriteLine();

        for (int i = 0; i < 10; i++)

        {
            Console.Write("word or sentence: ");
            var searched = Console.ReadLine();

            if (searched == null || searched == "")
            {
                Console.WriteLine("\nno inpplease enter a word\n");
                continue;
            }

             string[] words = searched.ToLower().Split(' ');



            bool found = false;


           foreach (var item in companies)
{
    string comp = item.company.ToLower();
    string def  = item.def.ToLower();
    string key  = item.keyword.ToLower();

    foreach (var w in words)
    {
        if (w == "" || w.Length <= 2) continue; 

        if (comp.Contains(w) || def.Contains(w) || key.Contains(w))
        {
            if (!found)
            {
                Console.WriteLine("\nfound companies:");
                found = true;
            }
            
                Console.WriteLine("{");
                Console.WriteLine($"  id        : {item.id}");
                Console.WriteLine($"  company   : {item.company}");
                Console.WriteLine($"  definition: {item.def}");
                Console.WriteLine($"  keywords  : {item.keyword}");
                Console.WriteLine("}");
            break; 
        }
    }
}
            if (found == false)

            {
                Console.WriteLine("\nnot  found");
            }

            Console.WriteLine();
        }
    }
    
}
