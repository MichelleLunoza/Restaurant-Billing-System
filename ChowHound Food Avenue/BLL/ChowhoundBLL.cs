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

        internal bool GetUser(ChowhoundInfo chowhoundInfo)
        {
            return GetUserDAL(chowhoundInfo);
        }

        internal bool ForgetPass_RetrieveUser(ChowhoundInfo chowhoundInfo)
        {
            return ForgetPass_RetrieveUserDAL(chowhoundInfo);
        }

        internal void ChangePass(ChowhoundInfo chowhoundInfo)
        {
            ChangePassDAL(chowhoundInfo);
        }

        internal void Income(ChowhoundInfo chowhoundInfo)
        {
            IncomeDAL(chowhoundInfo);
        }


        internal void RetrieveOrder_No(ChowhoundInfo chowhoundInfo)
        {
            RetrieveOrder_NoDAL(chowhoundInfo);
        }

  
           protected abstract void SaveDataDAL(ChowhoundInfo chowhoundInfo);
           protected abstract void RegisterUserDAL(ChowhoundInfo chowhoundInfo);
           protected abstract bool GetUserDAL(ChowhoundInfo chowhoundInfo);
           protected abstract bool ForgetPass_RetrieveUserDAL(ChowhoundInfo chowhoundInfo);
           protected abstract void ChangePassDAL(ChowhoundInfo chowhoundInfo);
           protected abstract void IncomeDAL(ChowhoundInfo chowhoundInfo);
           protected abstract void RetrieveOrder_NoDAL(ChowhoundInfo chowhoundInfo);
          
    }
}
