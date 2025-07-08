using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using stats;
using pet;
using System.Text.Json;

namespace losos
{
    // je potreba predelat nacitani stare hry, hodit sem tu logiku z deserializace pet
    public class DeserilazitonResult
    {
        public Pet Pet { get; set; }
        public Stats Stats { get; set; }
        public string FileContent { get; set; }
        public DeserilazitonResult(Pet pet, Stats stats, string fileContent)
        {
            Pet = pet;
            Stats = stats;
            FileContent = fileContent;
        }
    }
    internal static class FileHelper
    {
        public static string GetPathToResources(string filename)
        {
            return Path.Combine(Application.StartupPath, "Resources", filename);
        }

        public static Bitmap[] SplitIcons(Bitmap source, int iconWidth)
        {
            int numberOfIcons = source.Width / iconWidth;
            Bitmap[] result = new Bitmap[numberOfIcons];
            for (int i = 0; i < numberOfIcons; i++)
            {
                Rectangle rect = new Rectangle(i * iconWidth, 0, iconWidth, source.Height);
                result[i] = source.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);
            }
            return result;
        }

        
        
    }
}
