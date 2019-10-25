using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker freeversion = new DocumentWorker();
            freeversion.OpenDocument();
            freeversion.EditDocument();
            freeversion.SaveDocument();
            Console.WriteLine("Вы пользуетесь бесплатной версией продукта, если хотите пользоваться версией Pro или Expert" +
                "введите соответствующий ключ : pro или expert ");

            if (Console.ReadLine() == "pro")
            {
                DocumentWorker proversion = new ProDocumentWorker();
                proversion.OpenDocument();
                proversion.EditDocument();
                proversion.SaveDocument();
            }
            else if (Console.ReadLine () == "expert")
            {
                DocumentWorker expertversion = new ExpertDocumentWorker();
                expertversion.OpenDocument();
                expertversion.EditDocument();
                expertversion.SaveDocument();
            }
            else if ()
            {

            }
        }
    }
}
