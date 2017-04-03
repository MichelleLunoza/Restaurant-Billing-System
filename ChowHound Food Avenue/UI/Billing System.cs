using Chowhound_Food_Avenue.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Chowhound_Food_Avenue
{
    public partial class Billing_System : Form
    {
        public static class Cultures
        {
            public static readonly CultureInfo Philippines = CultureInfo.GetCultureInfo("en-PH");
        }
        public Billing_System()
        {
            InitializeComponent();
        }

        public  string user
        {
            get { return usernameL.Text; }
            set { usernameL.Text = value; }
        }

        //Declaration of Variables
        public int BuffetMealsubtotal, PlateoftheDaysubtotal, Sisigsubtotal, Dynamitesubtotal, BuffaloWingssubtotal, LechonKawalisubtotal, SpicyCheesyPotatoFsubtotal, SpicyCheesPotatoWsubtotal, CrispyPataHalfsubtotal, CrispyPataWholesubtotal, Samyupsalsubtotal;
        public int SMLBucketsubtotal, SMLBottlesubtotal, SMBBucketsubtotal, SMBBottlesubtotal;
        public int Cash, i;
        public int GrandTotal, MealTotalOrder, DrinksTotalOrder;

        //Calculation Method 
        public void MenuGrandTotal()
        {
            if (BuffetcheckBox.Checked == true)
            {
                if (int.TryParse(BuffetQtyText.Text, out i))
                {
                    int buffetprice = 199;
                    int Buffetqty = int.Parse(BuffetQtyText.Text);
                    BuffetMealsubtotal = buffetprice * Buffetqty;
                    BuffetLabel.Text = BuffetMealsubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    BuffetMealsubtotal = 0;
                    string Buffetqty = String.Empty;
                    BuffetQtyText.Text = Buffetqty.ToString();
                    BuffetLabel.Text = BuffetMealsubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (PlateoftheDaycheckBox.Checked == true)
            {
                if (int.TryParse(PlateQtyText.Text, out i))
                {
                    int plateprice = 125;
                    int Plateqty = int.Parse(PlateQtyText.Text);
                    PlateoftheDaysubtotal = plateprice * Plateqty;
                    PlateLabel.Text = PlateoftheDaysubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    PlateoftheDaysubtotal = 0;
                    string Plateqty = String.Empty;
                    PlateQtyText.Text = Plateqty.ToString();
                    PlateLabel.Text = PlateoftheDaysubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (SisigCheck.Checked == true)
            {
                if (int.TryParse(SisigQtytext.Text, out i))
                {
                    int sisigprice = 125;
                    int Sisigqty = int.Parse(SisigQtytext.Text);
                    Sisigsubtotal = sisigprice * Sisigqty;
                    SisigLabel.Text = Sisigsubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    Sisigsubtotal = 0;
                    string Sisigqty = String.Empty;
                    SisigQtytext.Text = Sisigqty.ToString();
                    SisigLabel.Text = Sisigsubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (DynamiteCheck.Checked == true)
            {
                if (int.TryParse(DynamiteQtytext.Text, out i))
                {
                    int dynamiteprice = 125;
                    int Dynamiteqty = int.Parse(DynamiteQtytext.Text);
                    Dynamitesubtotal = dynamiteprice * Dynamiteqty;
                    DynamiteLabel.Text = Dynamitesubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    Dynamitesubtotal = 0;
                    string Dynamiteqty = String.Empty;
                    DynamiteQtytext.Text = Dynamiteqty.ToString();
                    DynamiteLabel.Text = Dynamitesubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (BuffaloCheck.Checked == true)
            {
                if (int.TryParse(BuffaloWingsQtytext.Text, out i))
                {
                    int buffaloprice = 125;
                    int Buffaloqty = int.Parse(BuffaloWingsQtytext.Text);
                    BuffaloWingssubtotal = buffaloprice * Buffaloqty;
                    BuffaloLabel.Text = BuffaloWingssubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    BuffaloWingssubtotal = 0;
                    string Buffaloqty = String.Empty;
                    BuffaloWingsQtytext.Text = Buffaloqty.ToString();
                    BuffaloLabel.Text = BuffaloWingssubtotal.ToString("C", Cultures.Philippines);
                }
            }

        if (LechonCheck.Checked == true)
            {
                if (int.TryParse(LechonKQtytext.Text, out i))
                {
                    int lechonprice = 125;
                    int Lechonqty = int.Parse(LechonKQtytext.Text);
                    LechonKawalisubtotal = lechonprice * Lechonqty;
                    LechonLabel.Text = LechonKawalisubtotal.ToString("C", Cultures.Philippines);

                }
                else
                {
                    LechonKawalisubtotal = 0;
                    string Lechonqty = String.Empty;
                    LechonKQtytext.Text = Lechonqty.ToString();
                    LechonLabel.Text = LechonKawalisubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (PotatoFriesCheck.Checked == true)
            {
                if (int.TryParse(SCPFQTYtext.Text, out i))
                {
                    int pfriesprice = 125;
                    int PFriesqty = int.Parse(SCPFQTYtext.Text);
                    SpicyCheesyPotatoFsubtotal = pfriesprice * PFriesqty;
                    SCPFriesLabel.Text = SpicyCheesyPotatoFsubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    SpicyCheesyPotatoFsubtotal = 0;
                    string PFriesqty = String.Empty;
                    SCPFQTYtext.Text = PFriesqty.ToString();
                    SCPFriesLabel.Text = SpicyCheesyPotatoFsubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (PotatoWedgeCheck.Checked == true)
            {
                if (int.TryParse(SCPWQtyText.Text, out i))
                {
                    int pwedgeprice = 125;
                    int PWedgeqty = int.Parse(SCPWQtyText.Text);
                    SpicyCheesPotatoWsubtotal = pwedgeprice * PWedgeqty;
                    SCPWedgeLabel.Text = SpicyCheesPotatoWsubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    SpicyCheesPotatoWsubtotal = 0;
                    string PWedgeqty = String.Empty;
                    SCPWQtyText.Text = PWedgeqty.ToString();
                    SCPWedgeLabel.Text = SpicyCheesPotatoWsubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (CrispyHalfCheck.Checked == true)
            {
                if (int.TryParse(CrispyPHalfQtytext.Text, out i))
                {
                    int chalfprice = 250;
                    int CHalfqty = int.Parse(CrispyPHalfQtytext.Text);
                    CrispyPataHalfsubtotal = chalfprice * CHalfqty;
                    CPHalfLabel.Text = CrispyPataHalfsubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    CrispyPataHalfsubtotal = 0;
                    string CHalfqty = String.Empty;
                    CrispyPHalfQtytext.Text = CHalfqty.ToString();
                    CPHalfLabel.Text = CrispyPataHalfsubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (SamyupsalCheck.Checked == true)
            {
                if (int.TryParse(SamyupsalQtyText.Text, out i))
                {
                    int samyupsalprice = 100;
                    int Samyupsalqty = int.Parse(SamyupsalQtyText.Text);
                    Samyupsalsubtotal = samyupsalprice * Samyupsalqty;
                    SamyupsalLabel.Text = Samyupsalsubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    Samyupsalsubtotal = 0;
                    string Samyupsalqty = String.Empty;
                    SamyupsalQtyText.Text = Samyupsalqty.ToString();
                    SamyupsalLabel.Text = Samyupsalsubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (SnMigBucketChkBox.Checked)
            {
                if (int.TryParse(SnMigBucketQtyText.Text, out i))
                {
                    int smlbucketprice = 320;
                    int SMLBucketqty = int.Parse(SnMigBucketQtyText.Text);
                    SMLBucketsubtotal = smlbucketprice * SMLBucketqty;
                    SMLBucketLabel.Text = SMLBucketsubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    SMLBucketsubtotal = 0;
                    string SMLBucketqty = String.Empty;
                    SnMigBucketQtyText.Text = SMLBucketqty.ToString();
                    SMLBucketLabel.Text = SMLBucketsubtotal.ToString("C", Cultures.Philippines);
                }
                
            }

            if (SnMigBottleChkBox.Checked == true)
            {
                if (int.TryParse(SnMigBottleQtyText.Text, out i))
                {
                    int smlbottleprice = 60;
                    int SMLBottleqty = int.Parse(SnMigBottleQtyText.Text);
                    SMLBottlesubtotal = smlbottleprice * SMLBottleqty;
                    SMLBottleLabel.Text = SMLBottlesubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    SMLBottlesubtotal = 0;
                    string SMLBottleqty = String.Empty;
                    SnMigBottleQtyText.Text = SMLBottleqty.ToString();
                    SMLBottleLabel.Text = SMLBottlesubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (SMBBucketChkBox.Checked == true)
            {
                if (int.TryParse(SMBBucketQtyText.Text, out i))
                {
                    int smbbucketprice = 270;
                    int SMBBucketqty = int.Parse(SMBBucketQtyText.Text);
                    SMBBucketsubtotal = smbbucketprice * SMBBucketqty;
                    SMBBucketLabel.Text = SMBBucketsubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    SMBBucketsubtotal = 0;
                    string SMBBucketqty = String.Empty;
                    SMBBucketQtyText.Text = SMBBucketqty.ToString();
                    SMBBucketLabel.Text = SMBBucketsubtotal.ToString("C", Cultures.Philippines);
                }
            }

            if (SMBBottleChkBox.Checked == true)
            {
                if (int.TryParse(SMBBottleQtyText.Text, out i))
                {
                    int smbbottleprice = 50;
                    int SMBBottleqty = int.Parse(SMBBottleQtyText.Text);
                    SMBBottlesubtotal = smbbottleprice * SMBBottleqty;
                    SMBBottleLabel.Text = SMBBottlesubtotal.ToString("C", Cultures.Philippines);
                }
                else
                {
                    SMBBottlesubtotal = 0;
                    string SMBBottleqty = String.Empty;
                    SMBBottleQtyText.Text = SMBBottleqty.ToString();
                    SMBBottleLabel.Text = SMBBottlesubtotal.ToString("C", Cultures.Philippines);
                }
            }

            MealTotalOrder = BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal;
            MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);


            DrinksTotalOrder = SMLBucketsubtotal + SMLBottlesubtotal + SMBBucketsubtotal + SMBBottlesubtotal;
            DrinksTotalLabel.Text = DrinksTotalOrder.ToString("C", Cultures.Philippines);

            GrandTotal = MealTotalOrder + DrinksTotalOrder;
            GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
        }
        
        public void Change()
        {
            int Change;
            //Change
            try
            {
                Cash = int.Parse(CashText.Text);
                Change = (Cash - GrandTotal);
                ChangeLabel.Text = Change.ToString("C", Cultures.Philippines);
            }
            catch
            {

            }
        }

        public void CashText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Int32.Parse(CashText.Text) < GrandTotal)
                {
                    MessageBox.Show("The amount you entered is lower than the bill, please enter higher amount");
                    CashText.Clear();

                }
                else
                {
                    Change();
                }
            }
        }

        private void Billing_System_Load(object sender, EventArgs e)
        {
            BuffetQtyText.Focus();
        }
     

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ChowhoundInfo info = new ChowhoundInfo()
                {
                    Order_No = OrderNumText.Text,
                    Username = usernameL.Text,
                    Date = dateTimePicker1.Value,
                    BuffetMeal = BuffetLabel.Text,
                    PlateOfTheDay = PlateLabel.Text,
                    Sisig = SisigLabel.Text,
                    Dynamite = DynamiteLabel.Text,
                    BuffaloWings = BuffaloLabel.Text,
                    LechonKawali = LechonLabel.Text,
                    PotatoFries = SCPFriesLabel.Text,
                    PotatoWedge = SCPWedgeLabel.Text,
                    CrispyPataWhole = CPWholeLabel.Text,
                    CrispyPataHalf = CPHalfLabel.Text,
                    Samyupsal = SamyupsalLabel.Text,
                    SanMigLightsBucket = SMLBucketLabel.Text,
                    SanMigLightsPerBottle = SMLBottleLabel.Text,
                    SMBPalePilsenBucket = SMBBucketLabel.Text,
                    SMBPalePilsenPerBottle = SMBBottleLabel.Text,
                    TotalMealOrder = MenuTotalLabel.Text,
                    TotalDrinks = DrinksTotalLabel.Text,
                    GrandTotal = GrandTotalLabel.Text,
                    Cash = CashText.Text,
                    Change = ChangeLabel.Text
                };
                IChowhound app = new Chowhound();
                app.SaveData(info);
                MessageBox.Show("Successfully Saved");

                ResetAll();

                int counter = int.Parse(OrderNumText.Text);
                counter += 1;
                OrderNumText.Text = "000" + counter.ToString();
                counter++;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region ResetAll
        public void ResetAll()
        {
            dateTimePicker1.ResetText();
            SnMigBucketQtyText.Clear();
            SnMigBottleQtyText.Clear();
            SMBBucketQtyText.Clear();
            SMBBottleQtyText.Clear();
            BuffetQtyText.Clear();
            PlateQtyText.Clear();
            SisigQtytext.Clear();
            DynamiteQtytext.Clear();
            BuffaloWingsQtytext.Clear();
            LechonKQtytext.Clear();
            SCPFQTYtext.Clear();
            SCPWQtyText.Clear();
            CrispyPHalfQtytext.Clear();
            CrispyPwholeQtytext.Clear();
            SamyupsalQtyText.Clear();

            SMLBucketLabel.Text = "";
            SMLBottleLabel.Text = "";
            SMBBucketLabel.Text = "";
            SMBBottleLabel.Text = "";
            BuffetLabel.Text = "";
            PlateLabel.Text = "";
            SisigLabel.Text = "";
            DynamiteLabel.Text = "";
            BuffaloLabel.Text = "";
            LechonLabel.Text = "";
            SCPFriesLabel.Text = "";
            SCPWedgeLabel.Text = "";
            CPHalfLabel.Text = "";
            CPWholeLabel.Text = "";
            SamyupsalLabel.Text = "";
            MenuTotalLabel.Text = "";
            DrinksTotalLabel.Text = "";
            GrandTotalLabel.Text = "";
            CashText.Text = "";
            ChangeLabel.Text = "";

            SnMigBucketChkBox.Checked = false;
            SnMigBottleChkBox.Checked = false;
            SMBBottleChkBox.Checked = false;
            SMBBucketChkBox.Checked = false;
            BuffetcheckBox.Checked = false;
            PlateoftheDaycheckBox.Checked = false;
            SisigCheck.Checked = false;
            DynamiteCheck.Checked = false;
            BuffaloCheck.Checked = false;
            LechonCheck.Checked = false;
            PotatoFriesCheck.Checked = false;
            PotatoWedgeCheck.Checked = false;
            CrispyHalfCheck.Checked = false;
            CrispyWholeCheck.Checked = false;
            SamyupsalCheck.Checked = false;

        }
        #endregion

        #region Enable All
        //Enable all buttons once Edit button was clicked
        public void Enabled()
        {
            BuffetcheckBox.Enabled = true;
            PlateoftheDaycheckBox.Enabled = true;
            SisigCheck.Enabled = true;
            DynamiteCheck.Enabled = true;
            BuffaloCheck.Enabled = true;
            LechonCheck.Enabled = true;
            PotatoFriesCheck.Enabled = true;
            PotatoWedgeCheck.Enabled = true;
            CrispyHalfCheck.Enabled = true;
            CrispyWholeCheck.Enabled = true;
            SamyupsalCheck.Enabled = true;
            SnMigBottleChkBox.Enabled = true;
            SnMigBucketChkBox.Enabled = true;
            SMBBottleChkBox.Enabled = true;
            SMBBucketChkBox.Enabled = true;

            BuffetQtyText.ReadOnly = true;
            PlateQtyText.ReadOnly = true;
            SisigQtytext.ReadOnly = true;
            DynamiteQtytext.ReadOnly = true;
            BuffaloWingsQtytext.ReadOnly = true;
            LechonKQtytext.ReadOnly = true;
            SCPFQTYtext.ReadOnly = true;
            SCPWQtyText.ReadOnly = true;
            CrispyPHalfQtytext.ReadOnly = true;
            CrispyPwholeQtytext.ReadOnly = true;
            SamyupsalQtyText.ReadOnly = true;
            SnMigBucketQtyText.ReadOnly = true;
            SnMigBottleQtyText.ReadOnly = true;
            SMBBucketQtyText.ReadOnly = true;
            SMBBottleQtyText.ReadOnly = true;
            CashText.Enabled = true;

            SMLBucketLabel.Text = "";
            SMLBottleLabel.Text = "";
            SMBBucketLabel.Text = "";
            SMBBottleLabel.Text = "";
            BuffetLabel.Text = "";
            PlateLabel.Text = "";
            SisigLabel.Text = "";
            DynamiteLabel.Text = "";
            BuffaloLabel.Text = "";
            LechonLabel.Text = "";
            SCPFriesLabel.Text = "";
            SCPWedgeLabel.Text = "";
            CPHalfLabel.Text = "";
            CPWholeLabel.Text = "";
            SamyupsalLabel.Text = "";

            CashText.Text = "";
            ChangeLabel.Text = "";
        }
        #endregion

        #region EditMethod
        public void EditMethod()
        {
            BuffetcheckBox.Enabled = true;
            PlateoftheDaycheckBox.Enabled = true;
            SisigCheck.Enabled = true;
            DynamiteCheck.Enabled = true;
            BuffaloCheck.Enabled = true;
            LechonCheck.Enabled = true;
            PotatoFriesCheck.Enabled = true;
            PotatoWedgeCheck.Enabled = true;
            CrispyHalfCheck.Enabled = true;
            CrispyWholeCheck.Enabled = true;
            SamyupsalCheck.Enabled = true;
            SnMigBottleChkBox.Enabled = true;
            SnMigBucketChkBox.Enabled = true;
            SMBBottleChkBox.Enabled = true;
            SMBBucketChkBox.Enabled = true;

            SMLBucketLabel.Text = "";
            SMLBottleLabel.Text = "";
            SMBBucketLabel.Text = "";
            SMBBottleLabel.Text = "";
            BuffetLabel.Text = "";
            PlateLabel.Text = "";
            SisigLabel.Text = "";
            DynamiteLabel.Text = "";
            BuffaloLabel.Text = "";
            LechonLabel.Text = "";
            SCPFriesLabel.Text = "";
            SCPWedgeLabel.Text = "";
            CPHalfLabel.Text = "";
            CPWholeLabel.Text = "";
            SamyupsalLabel.Text = "";

            CashText.Text = "";
            ChangeLabel.Text = "";
        }
        #endregion

        //reset button

        private void button2_Click(object sender, EventArgs e)
        {
            ResetAll();
            Enabled();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditMethod();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport salesReport = new SalesReport();
            {
                this.Hide();
                salesReport.Show();
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            {
                this.Hide();
                inventory.Show();
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Are you sure you want to cancel the order?", "Cancel Order", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                ResetAll();
                MessageBox.Show("Order has been cancelled.", "Notice");
                Enabled();
            }
            else if (DialogResult == DialogResult.No)
            {

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "\n                        Chowhound Food Avenue";
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(title, printFont, System.Drawing.Brushes.Black, 10, 10);

            string address = "\n\n                        Mataas na Kahoy, Batangas";
            System.Drawing.Font addfont = new System.Drawing.Font("Arial", 23, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(address, addfont, System.Drawing.Brushes.Black, 10, 10);

            string date = "\n\n\n\n" + dateTimePicker1.Value.ToString(" d - MMM - yyyy hh:mm:ss");
            System.Drawing.Font datefont = new System.Drawing.Font("Arial", 23, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(date, datefont, System.Drawing.Brushes.Black, 10, 10);

            string PQS = "\n\n\n\n\n\n Product                                        Quantity           Subtotal";
            System.Drawing.Font PQSfont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(PQS, PQSfont, System.Drawing.Brushes.Black, 10, 10);

            string SMLbucket = "\n\n\n\n\n\n\n\n SMLBucket @ P 320.00: " + "\t\t    " + SnMigBucketQtyText.Text + "\t\t " + SMLBucketLabel.Text;
            System.Drawing.Font Bucket = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(SMLbucket, Bucket, System.Drawing.Brushes.Black, 10, 10);

            string SMLbottle = "\n\n\n\n\n\n\n\n\n SMLPerBottle @ P 60.00: " + "\t    " + SnMigBottleQtyText.Text + "\t\t " + SMLBottleLabel.Text;
            System.Drawing.Font Bottle = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(SMLbottle, Bottle, System.Drawing.Brushes.Black, 10, 10);

            string SMBbucket = "\n\n\n\n\n\n\n\n\n\n SMBBucket @ P 270.00: " + "\t\t    " + SMBBucketQtyText.Text + "\t\t " + SMBBucketLabel.Text;
            System.Drawing.Font Bucket1 = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(SMBbucket, Bucket1, System.Drawing.Brushes.Black, 10, 10);

            string SMBperbottle = "\n\n\n\n\n\n\n\n\n\n\n SMBPerBottle @ P 50.00: " + "\t    " + SMBBottleQtyText.Text + "\t\t " + SMBBottleLabel.Text;
            System.Drawing.Font PerBottle = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(SMBperbottle, PerBottle, System.Drawing.Brushes.Black, 10, 10);

            string BuffetMeal = "\n\n\n\n\n\n\n\n\n\n\n\n BuffetMeal @ P 199.00: " + "\t\t    " + BuffetQtyText.Text + "\t\t " + BuffetLabel.Text;
            System.Drawing.Font BMeal = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(BuffetMeal, BMeal, System.Drawing.Brushes.Black, 10, 10);

            string PlateDay = "\n\n\n\n\n\n\n\n\n\n\n\n\n PlateoftheDay @ P 125.00: " + "\t    " + PlateQtyText.Text + "\t\t " + PlateLabel.Text;
            System.Drawing.Font PDay = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(PlateDay, PDay, System.Drawing.Brushes.Black, 10, 10);

            string Sisig = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n Sisig @ P 125.00: " + "\t\t    " + SisigQtytext.Text + "\t\t " + SisigLabel.Text;
            System.Drawing.Font SisigFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(Sisig, SisigFont, System.Drawing.Brushes.Black, 10, 10);

            string Dynamite = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n Dynamite(6pcs) @ P 125.00: " + "\t    " + DynamiteQtytext.Text + "\t\t " + DynamiteLabel.Text;
            System.Drawing.Font dynamiteFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(Dynamite, dynamiteFont, System.Drawing.Brushes.Black, 10, 10);

            string BuffaloWings = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n BuffaloWings(6pcs) @ P 125.00: " + "\t    " + BuffaloWingsQtytext.Text + "\t\t " + BuffaloLabel.Text;
            System.Drawing.Font BWingsFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(BuffaloWings, BWingsFont, System.Drawing.Brushes.Black, 10, 10);

            string LechonKawali = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n LechonKawali @ P 125.00: " + "\t    " + LechonKQtytext.Text + "\t\t " + LechonLabel.Text;
            System.Drawing.Font LKawaliFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(LechonKawali, LKawaliFont, System.Drawing.Brushes.Black, 10, 10);

            string SCPF = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n SCPotatoFries @ P 125.00: " + "\t    " + SCPFQTYtext.Text + "\t\t " + SCPFriesLabel.Text;
            System.Drawing.Font SCPFFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(SCPF, SCPFFont, System.Drawing.Brushes.Black, 10, 10);

            string SCPW = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n SCPotatoWedge @ P 125.00: " + "\t    " + SCPWQtyText.Text + "\t\t " + SCPWedgeLabel.Text;
            System.Drawing.Font SCPWFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(SCPW, SCPWFont, System.Drawing.Brushes.Black, 10, 10);

            string CrispyPataW = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n CrispyPata(W) @ P 450.00: " + "\t    " + CrispyPwholeQtytext.Text + "\t\t " + CPWholeLabel.Text;
            System.Drawing.Font CPataWFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(CrispyPataW, CPataWFont, System.Drawing.Brushes.Black, 10, 10);

            string CrispyPataH = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n CrispyPata(H) @ P 250.00: " + "\t    " + CrispyPHalfQtytext.Text + "\t\t " + CPHalfLabel.Text;
            System.Drawing.Font CPataHFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(CrispyPataH, CPataHFont, System.Drawing.Brushes.Black, 10, 10);

            string samyupsal = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n Samyupsal @ P 100.00: " + "\t\t    " + SamyupsalQtyText.Text + "\t\t " + SamyupsalLabel.Text;
            System.Drawing.Font samyupsalFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(samyupsal, samyupsalFont, System.Drawing.Brushes.Black, 10, 10);

            string menutotal = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n Menu_Total: " + MenuTotalLabel.Text;
            System.Drawing.Font menuFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(menutotal, menuFont, System.Drawing.Brushes.Black, 10, 10);

            string drinkstotal = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n Drinks_Total: " + DrinksTotalLabel.Text;
            System.Drawing.Font drinksFont = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(drinkstotal, drinksFont, System.Drawing.Brushes.Black, 10, 10);

            string text = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n TOTAL: " + GrandTotalLabel.Text;
            System.Drawing.Font content = new System.Drawing.Font("Arial", 22, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(text, content, System.Drawing.Brushes.Black, 10, 10);

            string cash = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n Cash_Rendered: " + CashText.Text;
            System.Drawing.Font cashtext = new System.Drawing.Font("Arial", 23, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(cash, cashtext, System.Drawing.Brushes.Black, 10, 10);

            string change = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n CHANGE: " + ChangeLabel.Text;
            System.Drawing.Font changetext = new System.Drawing.Font("Arial", 23, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(change, changetext, System.Drawing.Brushes.Black, 10, 10);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        
        #region //Enabling and Disabling Quantity Textbox through Checkbox
        private void BuffetcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BuffetcheckBox.Checked == true)
            {
                BuffetQtyText.ReadOnly = false;

            }
            else
            {
                BuffetQtyText.ReadOnly = true;
                BuffetQtyText.Clear();
                BuffetLabel.Text = "";
                BuffetMealsubtotal = 0;
                MealTotalOrder = BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void PlateoftheDaycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PlateoftheDaycheckBox.Checked == true)
            {
                PlateQtyText.ReadOnly = false;
            }
            else
            {
                PlateQtyText.ReadOnly = true;
                PlateQtyText.Clear();
                PlateLabel.Text = "";
                PlateoftheDaysubtotal = 0;
                MealTotalOrder = PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal + BuffetMealsubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }

        }

        private void SisigCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SisigCheck.Checked == true)
            {
                SisigQtytext.ReadOnly = false;
            }
            else
            {
                SisigQtytext.ReadOnly = true;
                SisigQtytext.Clear();
                SisigLabel.Text = "";
                Sisigsubtotal = 0;
                MealTotalOrder = Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void DynamiteCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DynamiteCheck.Checked == true)
            {
                DynamiteQtytext.ReadOnly = false;
            }
            else
            {
                DynamiteQtytext.ReadOnly = true;
                DynamiteQtytext.Clear();
                DynamiteLabel.Text = "";
                Dynamitesubtotal = 0;
                MealTotalOrder = Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void BuffaloCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BuffaloCheck.Checked == true)
            {
                BuffaloWingsQtytext.ReadOnly = false;
            }
            else
            {
                BuffaloWingsQtytext.ReadOnly = true;
                BuffaloWingsQtytext.Clear();
                BuffaloLabel.Text = "";
                BuffaloWingssubtotal = 0;
                MealTotalOrder = BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void LechonCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LechonCheck.Checked == true)
            {
                LechonKQtytext.ReadOnly = false;
            }
            else
            {
                LechonKQtytext.ReadOnly = true;
                LechonKQtytext.Clear();
                LechonLabel.Text = "";
                LechonKawalisubtotal = 0;
                MealTotalOrder = LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void PotatoFriesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PotatoFriesCheck.Checked == true)
            {
                SCPFQTYtext.ReadOnly = false;
            }
            else
            {
                SCPFQTYtext.ReadOnly = true;
                SCPFQTYtext.Clear();
                SCPFriesLabel.Text = "";
                SpicyCheesyPotatoFsubtotal = 0;
                MealTotalOrder = SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void PotatoWedgeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PotatoWedgeCheck.Checked == true)
            {
                SCPWQtyText.ReadOnly = false;
            }
            else
            {
                SCPWQtyText.ReadOnly = true;
                SCPWQtyText.Clear();
                SCPWedgeLabel.Text = "";
                SpicyCheesPotatoWsubtotal = 0;
                MealTotalOrder = SpicyCheesPotatoWsubtotal + CrispyPataHalfsubtotal + CrispyPataWholesubtotal + Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void CrispyWholeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CrispyWholeCheck.Checked == true)
            {
                CrispyPwholeQtytext.ReadOnly = false;
            }
            else
            {
                CrispyPwholeQtytext.ReadOnly = true;
                CrispyPwholeQtytext.Clear();
                CPWholeLabel.Text = "";
                CrispyPataWholesubtotal = 0;
                MealTotalOrder = CrispyPataWholesubtotal + CrispyPataHalfsubtotal + Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void CrispyHalfCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CrispyHalfCheck.Checked == true)
            {
                CrispyPHalfQtytext.ReadOnly = false;

            }
            else
            {
                CrispyPHalfQtytext.ReadOnly = true;
                CrispyPHalfQtytext.Clear();
                CPHalfLabel.Text = "";
                CrispyPataHalfsubtotal = 0;
                MealTotalOrder = CrispyPataHalfsubtotal + Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataWholesubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void SamyupsalCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SamyupsalCheck.Checked == true)
            {
                SamyupsalQtyText.ReadOnly = false;
            }
            else
            {
                SamyupsalQtyText.ReadOnly = true;
                SamyupsalQtyText.Clear();
                SamyupsalLabel.Text = "";
                Samyupsalsubtotal = 0;
                MealTotalOrder = Samyupsalsubtotal + BuffetMealsubtotal + PlateoftheDaysubtotal + Sisigsubtotal + Dynamitesubtotal + BuffaloWingssubtotal + LechonKawalisubtotal + SpicyCheesyPotatoFsubtotal + SpicyCheesPotatoWsubtotal + CrispyPataWholesubtotal + CrispyPataHalfsubtotal;
                MenuTotalLabel.Text = MealTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

       
        private void SnMigBucketChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SnMigBucketChkBox.Checked == true)
            {
                SnMigBucketQtyText.ReadOnly = false;
            }
            else
            {
                SnMigBucketQtyText.ReadOnly = true;
                SnMigBucketQtyText.Clear();
                SMLBucketLabel.Text = "";
                SMLBucketsubtotal = 0;
                DrinksTotalOrder = SMLBucketsubtotal + SMLBottlesubtotal + SMBBucketsubtotal + SMBBottlesubtotal;
                DrinksTotalLabel.Text = DrinksTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }
        private void SnMigBottleChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SnMigBottleChkBox.Checked == true)
            {
                SnMigBottleQtyText.ReadOnly = false;
            }
            else
            {
                SnMigBottleQtyText.ReadOnly = true;
                SnMigBottleQtyText.Clear();
                SMLBottleLabel.Text = "";
                SMLBottlesubtotal = 0;
                DrinksTotalOrder = SMLBottlesubtotal + SMLBucketsubtotal + SMBBucketsubtotal + SMBBottlesubtotal;
                DrinksTotalLabel.Text = DrinksTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }

        }

        private void SMBBucketChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SMBBucketChkBox.Checked == true)
            {
                SMBBucketQtyText.ReadOnly = false;
            }
            else
            {
                SMBBucketQtyText.ReadOnly = true;
                SMBBucketQtyText.Clear();
                SMBBucketLabel.Text = "";
                SMBBucketsubtotal = 0;
                DrinksTotalOrder = SMBBucketsubtotal + SMLBucketsubtotal + SMLBottlesubtotal + SMBBottlesubtotal;
                DrinksTotalLabel.Text = DrinksTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }

        private void SMBBottleChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SMBBottleChkBox.Checked == true)
            {
                SMBBottleQtyText.ReadOnly = false;
            }
            else
            {
                SMBBottleQtyText.ReadOnly = true;
                SMBBottleQtyText.Clear();
                SMBBottleLabel.Text = "";
                SMBBottlesubtotal = 0;
                DrinksTotalOrder = SMBBottlesubtotal + SMLBucketsubtotal + SMLBottlesubtotal + SMBBucketsubtotal;
                DrinksTotalLabel.Text = DrinksTotalOrder.ToString("C", Cultures.Philippines);
                GrandTotal = MealTotalOrder + DrinksTotalOrder;
                GrandTotalLabel.Text = GrandTotal.ToString("C", Cultures.Philippines);
            }
        }        
        #endregion

        //Calling of Method
        private void SnMigBucketQtyText_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            SnMigBucketQtyText.ReadOnly = true;
        }

        private void SMLBucketPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void SnMigBottleQtyText_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            SnMigBottleQtyText.ReadOnly = true;
        }

        private void SMLBottlePriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void SMBBucketQtyText_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            SMBBucketQtyText.ReadOnly = true;
        }
        
        private void SMBBucketPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }
        
        private void SMBBottleQtyText_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            SMBBottleQtyText.ReadOnly = true;
        }

        private void SMBBottlePriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void BuffetQtyText_TextChanged(object sender, EventArgs e)
        {
            MenuGrandTotal();
            BuffetQtyText.ReadOnly = true;
        }
        private void BuffetPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void PlateQtyText_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            PlateQtyText.ReadOnly = true;
        }
        
        private void PlatePriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void SisigQtytext_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            SisigQtytext.ReadOnly = true;
        }
        
        private void SisigPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void DynamiteQtytext_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            DynamiteQtytext.ReadOnly = true;
        }
        
        private void DynaPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }
        
        private void BuffaloWingsQtytext_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            BuffaloWingsQtytext.ReadOnly = true;
        } 
        
        private void BuffaloPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void LechonKQtytext_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            LechonKQtytext.ReadOnly = true;
        }
        
        private void LechonPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void SCPFQTYtext_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            SCPFQTYtext.ReadOnly = true;
        }
        
        private void SCPFPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void SCPWQtyText_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            SCPWQtyText.ReadOnly = true;
        }
        
        private void SCPWPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void CrispyPwholeQtytext_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            CrispyPwholeQtytext.ReadOnly = true;
        }
        
        private void CPWPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void CrispyPHalfQtytext_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            CrispyPHalfQtytext.ReadOnly = true;
        }
        
        private void CPHPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }

        private void SamyupsalQtyText_TextChanged_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
            SamyupsalQtyText.ReadOnly = true;
        }

        private void SamyupsalPriceLabel_Click_1(object sender, EventArgs e)
        {
            MenuGrandTotal();
        }
    
    }
}
   
       