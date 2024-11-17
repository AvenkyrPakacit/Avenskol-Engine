using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Avenskol_Construction_Kit.Utilities
{
    public static class Serializer
    {
        public static void ToFIle<T>(T instance, string path)
        {
            try
            {
                var fs = new FileStream(path, FileMode.Create);
                var Serializer = new DataContractSerializer(typeof(T));
                Serializer.WriteObject(fs, instance);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //TODO: log errors
            }
        }
        public static T FromFIle<T>(string path)
        {
            try
            {
                var fs = new FileStream(path, FileMode.Open);
                var Serializer = new DataContractSerializer(typeof(T));
                T Instance = (T) Serializer.ReadObject(fs);
                return Instance;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //TODO: log errors
                return default(T);
            }
        }
    }
}
