using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace DAL
{
    public interface IDataHandler
    {
        DataSet ReadData(string tableName);
        bool InsertNewUser(ArrayList input);

        bool UpdateUserPassword(ArrayList input);

    }
}
