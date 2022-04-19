using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//ms
using System.Runtime.Serialization.Formatters.Binary;//binary formatter
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HelperLiabrary
{
    public static class Extensions
    {
  public static byte[] DoBinarySerialization(this object obj)
        {
            byte[] DataConverted = new byte[1024];
            MemoryStream ms = new MemoryStream();
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                DataConverted = ms.GetBuffer();
               
            }
            catch (SqlException ew)
            {
                MessageBox.Show(ew.Message);
            }
            finally
            {
                ms.Close();
            }
            return DataConverted;

        }
        public static object DeserializeObject(this byte[] datatodeserialize  )
        {
            object obj = null;
            MemoryStream ms = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                ms = new MemoryStream(datatodeserialize);
                obj = formatter.Deserialize(ms);

            }
            catch (Exception)
            { 
                
               
                throw;
            }
            finally
            {
                ms.Close();
            }
            return obj;


        }

    }
}
