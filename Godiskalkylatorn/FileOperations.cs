using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Godiskalkylatorn
{
    static class FileOperations
    {

        public static void Serialize(object objectToSerialize, string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, objectToSerialize);
            }
        }
        public static object Deserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                return formatter.Deserialize(fStream);
            }
        }
    }
}
