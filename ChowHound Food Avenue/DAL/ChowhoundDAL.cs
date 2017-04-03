using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Chowhound_Food_Avenue.UI;

namespace Chowhound_Food_Avenue
{
    internal class ChowhoundDAL : ChowhoundBLL
    {
        private string conStr = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();

        protected override void SaveDataDAL(ChowhoundInfo chowhoundInfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("SavedData", con))
                {
                    cmd.Parameters.Add("@Order_No", SqlDbType.NVarChar).Value = chowhoundInfo.Order_No;
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = chowhoundInfo.Date.ToString("d - MMM - yyyy hh:mm:ss");
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = chowhoundInfo.Username;
                    cmd.Parameters.Add("@BuffetMeal", SqlDbType.NVarChar).Value = chowhoundInfo.BuffetMeal;
                    cmd.Parameters.Add("@PlateOfTheDay", SqlDbType.NVarChar).Value = chowhoundInfo.PlateOfTheDay;
                    cmd.Parameters.Add("@Sisig", SqlDbType.NVarChar).Value = chowhoundInfo.Sisig;
                    cmd.Parameters.Add("@Dynamite", SqlDbType.NVarChar).Value = chowhoundInfo.Dynamite;
                    cmd.Parameters.Add("@BuffaloWings", SqlDbType.NVarChar).Value = chowhoundInfo.BuffaloWings;
                    cmd.Parameters.Add("@LechonKawali", SqlDbType.NVarChar).Value = chowhoundInfo.LechonKawali;
                    cmd.Parameters.Add("@PotatoFries", SqlDbType.NVarChar).Value = chowhoundInfo.PotatoFries;
                    cmd.Parameters.Add("@PotatoWedge", SqlDbType.NVarChar).Value = chowhoundInfo.PotatoWedge;
                    cmd.Parameters.Add("@CrispyPataWhole", SqlDbType.NVarChar).Value = chowhoundInfo.CrispyPataWhole;
                    cmd.Parameters.Add("@CrispyPataHalf", SqlDbType.NVarChar).Value = chowhoundInfo.CrispyPataHalf;
                    cmd.Parameters.Add("@Samyupsal", SqlDbType.NVarChar).Value = chowhoundInfo.Samyupsal;
                    cmd.Parameters.Add("@SanMigLightsBucket", SqlDbType.NVarChar).Value = chowhoundInfo.SanMigLightsBucket;
                    cmd.Parameters.Add("@SanMigLightsPerBottle", SqlDbType.NVarChar).Value = chowhoundInfo.SanMigLightsPerBottle;
                    cmd.Parameters.Add("@SMBPalePilsenBucket", SqlDbType.NVarChar).Value = chowhoundInfo.SMBPalePilsenBucket;
                    cmd.Parameters.Add("@SMBPalePilsenPerBottle", SqlDbType.NVarChar).Value = chowhoundInfo.SMBPalePilsenPerBottle;
                    cmd.Parameters.Add("@TotalMealOrder", SqlDbType.NVarChar).Value = chowhoundInfo.TotalMealOrder;
                    cmd.Parameters.Add("@TotalDrinks", SqlDbType.NVarChar).Value = chowhoundInfo.TotalDrinks;
                    cmd.Parameters.Add("@GrandTotal", SqlDbType.NVarChar).Value = chowhoundInfo.GrandTotal;
                    cmd.Parameters.Add("@Cash", SqlDbType.NVarChar).Value = chowhoundInfo.Cash;
                    cmd.Parameters.Add("@Change", SqlDbType.NVarChar).Value = chowhoundInfo.Change;


                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected override void RegisterUserDAL(ChowhoundInfo chowhoundInfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("RegisterUser", con))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = chowhoundInfo.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = chowhoundInfo.LastName;
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = chowhoundInfo.Username;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = chowhoundInfo.Password;
                    cmd.Parameters.Add("@SecurityCode", SqlDbType.NVarChar).Value = chowhoundInfo.SecurityCode;

                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected override bool GetUserDAL(ChowhoundInfo chowhoundInfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("GetUser", con))
                {

                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = chowhoundInfo.Username;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = chowhoundInfo.Password;


                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {

                            return true;
                        }
                    }
                    if (dr.HasRows == false)
                    {
                    }
                    return false;
                }
            }
        }

        protected override bool ForgetPass_RetrieveUserDAL(ChowhoundInfo chowhoundInfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("ForgetPassword", con))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = chowhoundInfo.Username;
                    cmd.Parameters.Add("@SecurityCode", SqlDbType.NVarChar).Value = chowhoundInfo.SecurityCode;

                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();


                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            return true;
                        }
                    }
                    if (dr.HasRows == false)
                    {

                    }
                    return false;
                }
            }
        }

        protected override void ChangePassDAL(ChowhoundInfo chowhoundInfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("NewPassCreated", con))
                {
                    cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = chowhoundInfo.Password;
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = chowhoundInfo.Username;
                    cmd.Parameters.Add("@SecurityCode", SqlDbType.NVarChar).Value = chowhoundInfo.SecurityCode;

                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

        }

        protected override void IncomeDAL(ChowhoundInfo chowhoundInfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("Income", con))
                {
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = chowhoundInfo.Date.ToString("d - MMM - yyyy hh:mm:ss");

                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected override void RetrieveOrder_NoDAL(ChowhoundInfo chowhoundInfo)
        {
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("RetrieveOrderNo", con))
                {
                    cmd.Parameters.Add("@Order_No", SqlDbType.NVarChar).Value = chowhoundInfo.Order_No;


                    con.Open();
                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                        }
                    }
                }
            }
        }
    }
}

