using InterfazAdministrador.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterfazAdministrador.Service
{
    internal class FaceDetectionService
    {
        private const string url = "http://localhost:5000";

        private static readonly HttpClient client = new HttpClient();

        public async Task<bool> AgregarCaraEmpleado(string idEmpleado, Bitmap cara)
        {
            try
            {
                string base64Image = ConvertImageToBase64(cara);

                var dto = new AgregarDto
                {
                    image = base64Image,
                    id_empleado = idEmpleado
                };

                var json = JsonConvert.SerializeObject(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url + "/add_face", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        private string ConvertImageToBase64(Bitmap image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}
