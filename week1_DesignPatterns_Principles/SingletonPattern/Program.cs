using System;

class Program
{
    static void Main(string[] args)
    {
        var config1 = ConfigurationManager.GetInstance();
        Console.WriteLine("App Name: " + config1.GetSetting("AppName"));
        Console.WriteLine("Environment: " + config1.GetSetting("Environment"));

        var config2 = ConfigurationManager.GetInstance();
        config2.SetSetting("Environment", "Development");

        Console.WriteLine("Updated Environment: " + config1.GetSetting("Environment"));

        if (config1 == config2)
        {
            Console.WriteLine("Both config1 and config2 refer to the same instance.");
        }
        else
        {
            Console.WriteLine("Different instances were created.");
        }
    }
}
