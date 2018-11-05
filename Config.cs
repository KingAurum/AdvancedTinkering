using System;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace AdvancedTinkering
{
    public static class Config
    {
        public static bool ThrowingDamageBoomerang = true;
        public static bool ChangeToolDamageType = true;

        //The file will be stored in "Terraria/ModLoader/Mod Configs/Example Mod.json"
        static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "Advanced Tinkering.json");

        static Preferences Configuration = new Preferences(ConfigPath);

        public static void Load()
        {
            //Reading the config file
            bool success = ReadConfig();

            if (!success)
            {
                ErrorLogger.Log("Failed to read Example Mod's config file! Recreating config...");
                CreateConfig();
            }
        }

        //Returns "true" if the config file was found and successfully loaded.
        static bool ReadConfig()
        {
            if (Configuration.Load())
            {
                Configuration.Get("ThrowingDamageBoomerang", ref ThrowingDamageBoomerang);
                Configuration.Get("ChangeToolDamageType", ref ChangeToolDamageType);
                return true;
            }
            return false;
        }

        //Creates a config file. This will only be called if the config file doesn't exist yet or it's invalid. 
        static void CreateConfig()
        {
            Configuration.Clear();
            Configuration.Put("ThrowingDamageBoomerang", ThrowingDamageBoomerang);
            Configuration.Put("ChangeToolDamageType", ChangeToolDamageType);
            Configuration.Save();
        }
    }
}