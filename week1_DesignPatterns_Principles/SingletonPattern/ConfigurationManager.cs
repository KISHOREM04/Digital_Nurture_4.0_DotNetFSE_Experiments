using System;
using System.Collections.Generic;

public class ConfigurationManager
{
    private static ConfigurationManager? instance;
    private static readonly object lockObj = new();

    private Dictionary<string, string> settings;

    private ConfigurationManager()
    {
        Console.WriteLine("ConfigurationManager initialized.");
        settings = new Dictionary<string, string>
        {
            { "AppName", "MyApplication" },
            { "Version", "1.0.0" },
            { "Environment", "Production" }
        };
    }

    public static ConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
            }
        }
        return instance;
    }

    public string? GetSetting(string key)
    {
        return settings.ContainsKey(key) ? settings[key] : null;
    }

    public void SetSetting(string key, string value)
    {
        settings[key] = value;
    }
}
