using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowhound_Food_Avenue
{
    public abstract class ChowhoundBLL
    {
        internal void SaveData(ChowhoundInfo chowhoundInfo)
        {
            SaveDataDAL(chowhoundInfo);
        }

     
        internal void RegisterUser(ChowhoundInfo chowhoundInfo)
        {
            RegisterUserDAL(chowhoundInfo);
        }

        internal void GetUser(ChowhoundInfo chowhoundInfo)
        {
            GetUserDAL(chowhoundInfo);
        }

        internal void RetrieveUser(ChowhoundInfo chowhoundInfo)
        {
            RetrieveUserDAL(chowhoundInfo);
        }

           protected abstract void SaveDataDAL(ChowhoundInfo chowhoundInfo);
           protected abstract void RegisterUserDAL(ChowhoundInfo chowhoundInfo);
           protected abstract void GetUserDAL(ChowhoundInfo chowhoundInfo);
           protected abstract void RetrieveUserDAL(ChowhoundInfo chowhoundInfo);

         
    }
}
