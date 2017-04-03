using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowhound_Food_Avenue
{
    public class Chowhound : IChowhound
    {
        private ChowhoundBLL bll = new ChowhoundDAL();

        public Chowhound()
        {
        }

        public void SaveData(ChowhoundInfo chowhoundInfo)
        {
            bll.SaveData(chowhoundInfo);
        }

        public void RegisterUser(ChowhoundInfo chowhoundInfo)
        {
            bll.RegisterUser(chowhoundInfo);
        }


        public bool GetUser(ChowhoundInfo chowhoundInfo)
        {
            return bll.GetUser(chowhoundInfo);
        }


        public bool ForgetPass_RetrieveUser(ChowhoundInfo chowhoundInfo)
        {
           return  bll.ForgetPass_RetrieveUser(chowhoundInfo);
        }


        public void ChangePass(ChowhoundInfo chowhoundInfo)
        {
            bll.ChangePass(chowhoundInfo);
        }


        public void Income(ChowhoundInfo chowhoundInfo)
        {
            bll.Income(chowhoundInfo);
        }


        public void RetrieveOrder_No(ChowhoundInfo chowhoundInfo)
        {
            bll.RetrieveOrder_No(chowhoundInfo);
        }
    }
}
        
