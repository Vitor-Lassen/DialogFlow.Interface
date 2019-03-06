using System;
using DialogFlow.Interface.Infrastructure.Repositories;

namespace DialogFlow.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileRepository fileRepository = new FileRepository();
            var intents = fileRepository.LoadDataFiles(@"C:\Users\vitor\Downloads\BOTEN_BROID.zip");

            fileRepository.SaveDataInFiles(intents);

        }
    }
}
