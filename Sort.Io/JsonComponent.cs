using System.Diagnostics;
using System.Runtime.Serialization.Json;

namespace Sort.Io
{
    //Class to interaction with json file
    internal class JsonComponent<T>
    {
        #region Ctor
        public JsonComponent(string fileName) =>           
            FileName = fileName;
        #endregion

        #region Variables
        public string FileName { get; private set; }
        public bool Empty => new FileInfo(FileName).Length == 0; //Determines whether the json file is empty
        #endregion

        #region File access methods
        //Read the array from json file
        public T? Read()
        {
            DataContractJsonSerializer formatter = new(typeof(T));

            using (var file = new FileStream(FileName, FileMode.Open))
            {
                if (file.Length > 0)
                {
                    return (T)formatter.ReadObject(file)!;
                }
                else
                {
                    return default;
                }
            }
        }

        //Write the array to json file
        public void Write(T item)
        {
            DataContractJsonSerializer formatter = new(typeof(T));

            using (var file = new FileStream(FileName, FileMode.Create))
            {
                formatter.WriteObject(file, item);
            }
        }

        //Delete contents of the json file
        public void Clear()
        {
            using (new FileStream(FileName, FileMode.Truncate)) { }
        }

        //Open json file in notepad.exe
        internal void Open()
        {
            Process process = new();
            process.StartInfo.FileName = "notepad.exe";
            process.StartInfo.Arguments = FileName;
            process.Start();
            process.WaitForExit();
        }
        #endregion
    }
}