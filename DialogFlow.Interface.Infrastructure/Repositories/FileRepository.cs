using DialogFlow.Interface.Domain.Interface;
using DialogFlow.Interface.Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DialogFlow.Interface.Infrastructure.Repositories
{
    public class FileRepository :IFileRepository
    {
        string  _workPath;
        

        public FileRepository()
        {
            _workPath = @"C:\DialogFlow\";
        }
        public List<Intent> LoadDataFiles(string filePath)
        {
            List<Intent> intents = new List<Intent>();
            DirectoryInfo directoryInfo = new DirectoryInfo(_workPath);
            if (!directoryInfo.Exists)
                directoryInfo.Create();

            //  System.IO.Compression.ZipFile.ExtractToDirectory(filePath, _workPath);


            var files = System.IO.Directory.GetFiles($@"{_workPath}\intents");
            foreach (var fileName in files)
            {
                if (!fileName.Contains("_usersays_"))
                {
                    var content = File.ReadAllText(fileName);
                    
                    Intent intent = Newtonsoft.Json.JsonConvert.DeserializeObject<Intent>(content);

                    intents.Add(intent);
                }                    
            }

            return intents;
        }

        public void SaveDataInFiles(List<Intent> intents)
        {
            JsonSerializerSettings jsonSerializerSettings= new JsonSerializerSettings()
                                                           { NullValueHandling = NullValueHandling.Ignore };
            foreach (var intent in intents) {
                string data = JsonConvert.SerializeObject(intent, Formatting.Indented,  jsonSerializerSettings);
                using (StreamWriter streamWriter = 
                       new StreamWriter($@"{_workPath}\intents\{intent.Name}.json", false, Encoding.ASCII))
                {
                    streamWriter.Write(data);
                    streamWriter.Dispose();
                }
            }
        }
    }
}
