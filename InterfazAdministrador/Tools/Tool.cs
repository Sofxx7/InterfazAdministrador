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
                Console.WriteLine($"Error convirtiendo base64 a Imagen: {ex.Message}");
                return null;
            }
        }

        public string numberToMonth(int monthNumber)
        {
            if (monthNumber < 1 || monthNumber > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(monthNumber), "El numero del mes debe ser entre 1 a 12.");
            }
            var mes = new DateTime(1, monthNumber, 1).ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
            return char.ToUpper(mes[0]) + mes.Substring(1);
        }
    }
}
