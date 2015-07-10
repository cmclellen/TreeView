using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.Common.Extensions
{
    public static class ObjectExtensions
    {
        public static T DeepCopy<T>(this T instance)
            where T : class
        {
            T result = default(T);
            if (instance != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    binFormatter.Serialize(ms, instance);
                    ms.Seek(0, SeekOrigin.Begin);
                    result = binFormatter.Deserialize(ms) as T;
                }
            }
            return result;
        }
    }
}
