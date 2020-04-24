using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3_1
{
    class Dataset:Prototype
    {
        private List<List<string>> data; //list of lists of strings

        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype Clone()
        {
            Dataset deepCopy = (Dataset)this.MemberwiseClone();

            List<List<string>> dataCopy = new List<List<string>>();
            foreach(List<string> liststring in data)
            {
                List<string> list = new List<string>();
                foreach(string s in liststring)
                {
                    list.Add(s);
                }
                dataCopy.Add(list);
            }
            deepCopy.data = dataCopy;

            return deepCopy;
        }
    }
}
