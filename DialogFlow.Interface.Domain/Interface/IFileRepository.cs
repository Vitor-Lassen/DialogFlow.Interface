using DialogFlow.Interface.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Interface
{
    public interface IFileRepository
    {
        List<Intent> LoadDataFiles(string filePath);

        void SaveDataInFiles(List<Intent> intents);
    }
}
