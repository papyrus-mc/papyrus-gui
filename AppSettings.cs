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
            this.config["checkForUpdatesOnStartup"] = false;
            this.config["variant"] = 0;
            this.config["world"] = @"C:/Users/%username%/AppData/Local/Packages/Microsoft.MinecraftUWP_8wekyb3d8bbwe/LocalState/games/com.mojang/minecraftWorlds/";
            this.config["output"] = "";
            
            // papyrus.cs config
            this.config_cs["executable"] = "";
            this.config_cs["limitXZ_enable"] = false;
            this.config_cs["limitXZ_X1"] = 0;
            this.config_cs["limitXZ_X2"] = 0;
            this.config_cs["limitXZ_Z1"] = 0;
            this.config_cs["limitXZ_Z2"] = 0;
            this.config_cs["limitY_enable"] = false;
            this.config_cs["limitY"] = 64;
            this.config_cs["heightmap_enable"] = true;
            this.config_cs["heightmap_j"] = 10000;
            this.config_cs["heightmap_divider"] = 20;
            this.config_cs["heightmap_offset"] = 64;
            this.config_cs["dimension"] = 0;
            this.config_cs["profile"] = "Default";
            this.config_cs["html_filename"] = "index.html";
            this.config_cs["image_format"] = "PNG";
            this.config_cs["image_quality"] = 100;
            this.config_cs["force_overwrite"] = false;
            this.config_cs["leaflet"] = false;
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
                        exePath = String.Format("\"{0}\" ", this.config_cs["executable"]);
                    }

                    String[] additionalArgs = new String[2];

                    if (this.config_cs["profile"].ToLower() != "default")
                    {
                        additionalArgs[0] = String.Format("--profile {0}", this.config_cs["profile"].ToLower());
                    }

                    if (this.config_cs["limitXZ_enable"])
                    {
                        additionalArgs[1] = String.Format("--limitx {0},{1} --limitz {2},{3}", this.config_cs["limitXZ_X1"], this.config_cs["limitXZ_X2"], this.config_cs["limitXZ_Z1"], this.config_cs["limitXZ_Z2"]);
                    }

                    arguments = String.Format(exePath + "-w \"{0}\" -o \"{1}\" --dim {2} -f {3} {4} --brillouin_j {5} --brillouin_divider {6} --brillouin_offset {7} --forceoverwrite {8} --use_leaflet_legacy {9} --htmlfile {10} {11} {12}", worldPath, outputPath, this.config_cs["dimension"], this.config_cs["image_format"].ToString().ToLower(), this.config_cs["image_quality"], this.config_cs["heightmap_j"], this.config_cs["heightmap_divider"], this.config_cs["heightmap_offset"], Convert.ToString(this.config_cs["force_overwrite"]).ToLower(), Convert.ToString(this.config_cs["leaflet"]).ToLower(), this.config_cs["html_filename"], additionalArgs[0], additionalArgs[1]);

                    break;

                case PapyrusVariant.PAPYRUSJS:
                    // Not available
                    break;
            }

            return arguments;
        }
    }
}
