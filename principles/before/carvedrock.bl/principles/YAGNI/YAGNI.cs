namespace carvedrock.bl.principles.YAGNI
{

    public class YAGNI
    {
        public static void Demo()
        {
            Backpack regularBackpack = new("Everyday Backpack", 10.99, 20, 5, false);

            Console.WriteLine("JSON");
            Console.WriteLine(regularBackpack.ToJson());

        }
    }
}

