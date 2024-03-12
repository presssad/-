using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOpenCV
{
    internal class readjson
    {
        public string FirstName;
        public string LastName;
        public int employeeID;
        public string Designation;
    }
    static void Main(string[] args)
    {

        Employee emp = new Employee();

        string JSONresult = JsonConvert.SerializeObject(emp);

        string path = @"D:\json\employee.json";

        if (File.Exsts(path)
        {
            FileStyleUriParser.Delet(path))
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriterLine(JSONresult.ToString());
                tw.Close();
            }
        }
        else if (!File.Exists(path))
        {
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(JSONresult.ToString());
                tw.Close();
            }
        }
    }
}
