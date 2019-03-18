using System.IO;
using FilmsWPF.Model;
using Newtonsoft.Json;

namespace FilmsWPF.ViewModel
{
    public class AboutViewModel
    {
        private string _path = @"..\..\Files\about_data.json";
        public string AboutText { get; set; }

        public AboutViewModel()
        {
            var json = JsonConvert
                .DeserializeObject<AboutModel>(File.ReadAllText(_path));

            AboutText = json.aboutText;
        }
    }
}
