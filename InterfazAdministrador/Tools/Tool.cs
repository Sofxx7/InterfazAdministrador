using System;
using System.Drawing;

namespace InterfazAdministrador.Tools
{
    internal class Tool
    {
        public Bitmap Base64ToImage(string base64String)
        {
            if (string.IsNullOrEmpty(base64String))
            {
                return null;
            }
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    return new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting Base64 to Image: {ex.Message}");
                return null;
            }
        }
    }
}
