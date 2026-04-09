namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int totalCost = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            

            if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");

            }
            if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

 
            if (chkCoke.Checked) { 
                totalCost += 2500;
                lstOrder.Items.Add("콜라 추가 2,500원");
            }
            if (chkCheese.Checked) { 
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked) { 
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }

            if (chkFries.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");

                
            }
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked 
                                            && !rdoChickenBurger.Checked) 
            {
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;
            lblTotalCost.Text = "총금액 : " + totalCost.ToString("N0") + " 원";
        }   
            

        private void btnReset_Click(object sender, EventArgs e)
        {
            totalCost = 0;
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false; 
            rdoChickenBurger.Checked = false; chkFries.Checked = false; 
            chkCoke.Checked = false; 
            chkCheese.Checked = false; 
            chkSauce.Checked = false; 
            lstOrder.Items.Clear(); 
            lblTotalCost.Text = "총 금액 : 0원";
            

        }
    }
}
