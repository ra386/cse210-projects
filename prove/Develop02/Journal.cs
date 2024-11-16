using System;
using System.Formats.Asn1;
using System.IO;
namespace Develop02
{
    public class Journal
    {
        public List<Entries>_entries;
        public Journal()
        {
            _entries = new List<Entries>();
        }
        public void AddEntry(Entries entry)
        {
            _entries.Add(entry);
        }

        public void SaveFile(string FileName)
        {
            using ( StreamWriter writer = new StreamWriter(FileName) )
            foreach(var entry in _entries)
            {
                writer.WriteLine($"{entry._Date}, {entry._PromptText}, {entry._Response}");
            }
        }
        public void DisplayEntries()
        {
            foreach( var entry in _entries)
            {
                Console.WriteLine($"{entry._Date}, {entry._PromptText}, {entry._Response}");
                
            }
        } 

         
              public void LoadFromFile(string filename)
              {
                 _entries.Clear();
                 using (StreamReader reader = new StreamReader(filename))
                {
                      string line;
                      while ((line = reader.ReadLine()) != null)
                          {
                              string[] parts = line.Split(',');   
                             if (parts.Length == 3)
                     {
                
                              if (DateTime.TryParse(parts[0].Trim(), out DateTime date))
                         {
                    
                             string promptText = parts[1].Trim();
                             string response = parts[2].Trim();
                             _entries.Add(new Entries(date, promptText, response));
                         }
                     }
                       }
                  }
                }
        
   }
 }
