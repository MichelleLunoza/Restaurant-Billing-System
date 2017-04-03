using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowhound_Food_Avenue
{
    public interface IChowhound
    {
        void SaveData(ChowhoundInfo chowhoundInfo);
        void RegisterUser(ChowhoundInfo chowhoundInfo);
        bool GetUser(ChowhoundInfo chowhoundInfo);
        bool ForgetPass_RetrieveUser(ChowhoundInfo chowhoundInfo);
        void ChangePass(ChowhoundInfo chowhoundInfo);
        void Income(ChowhoundInfo chowhoundInfo);
        void RetrieveOrder_No(ChowhoundInfo chowhoundInfo);
    }
    
}
