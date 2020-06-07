using System;
using System.Collections.Generic;

namespace papyrus_gui
{
    public class AppSettings
    {
        public Dictionary<string, dynamic> config = new Dictionary<string, dynamic>();
        public Dictionary<string, dynamic> config_cs = new Dictionary<string, dynamic>();

        public AppSettings()
        {
            // Global config
            config["checkForUpdatesOnStartup"] = false;
            config["variant"] = 0;
            config["world"] = @"C:/Users/%username%/AppData/Local/Packages/Microsoft.MinecraftUWP_8wekyb3d8bbwe/LocalState/games/com.mojang/minecraftWorlds/";
            config["output"] = "";
            
            // papyrus.cs config
            config_cs["executable"] = "";
            config_cs["limitXZ_enable"] = false;
            config_cs["limitXZ_X1"] = 0;
            config_cs["limitXZ_X2"] = 0;
            config_cs["limitXZ_Z1"] = 0;
            config_cs["limitXZ_Z2"] = 0;
            config_cs["ingame_coords"] = true;
            config_cs["limitY_enable"] = false;
            config_cs["limitY"] = 64;
            config_cs["heightmap_enable"] = true;
            config_cs["heightmap_j"] = 10000;
            config_cs["heightmap_divider"] = 20;
            config_cs["heightmap_offset"] = 64;
            config_cs["dimension"] = 0;
            config_cs["profile"] = "Default";
            config_cs["html_filename"] = "index.html";
            config_cs["image_format"] = "PNG";
            config_cs["image_quality"] = 100;
            config_cs["force_overwrite"] = false;
        }

        public string GetArguments(PapyrusVariant variant, bool includeExePath, string worldPath, string outputPath)
        {
            string exePath = "";
            string arguments = "";

            switch (variant)
            {
                case PapyrusVariant.PAPYRUSCS:
                    if (includeExePath)
                    {
                        exePath = String.Format("\"{0}\" ", System.IO.Path.GetFullPath(config_cs["executable"]));
                    }

                    String[] additionalArgs = new String[2];

                    if (config_cs["profile"].ToLower() != "default")
                    {
                        additionalArgs[0] = String.Format("--profile {0}", config_cs["profile"].ToLower());
                    }

                    if (config_cs["limitXZ_enable"])
                    {
                        int divider = config_cs["ingame_coords"] ? 16 : 1;
                        additionalArgs[1] = String.Format("--limitx {0},{1} --limitz {2},{3}", config_cs["limitXZ_X1"] / divider, config_cs["limitXZ_X2"] / divider, config_cs["limitXZ_Z1"] / divider, config_cs["limitXZ_Z2"] / divider);
                    }

                    arguments = String.Format(exePath + "-w \"{0}\" -o \"{1}\" --dim {2} -f {3} {4} --brillouin_j {5} --brillouin_divider {6} --brillouin_offset {7} --forceoverwrite {8} --htmlfile {9} {10} {11}", worldPath, outputPath, config_cs["dimension"], config_cs["image_format"].ToString().ToLower(), config_cs["image_quality"], config_cs["heightmap_j"], config_cs["heightmap_divider"], config_cs["heightmap_offset"], Convert.ToString(config_cs["force_overwrite"]).ToLower(), config_cs["html_filename"], additionalArgs[0], additionalArgs[1]).Trim();

                    break;

                case PapyrusVariant.PAPYRUSJS:
                    // Not available
                    break;
            }

            return arguments;
        }
    }
}
