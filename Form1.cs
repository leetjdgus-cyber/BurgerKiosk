namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false; 
            rdoChickenBurger.Checked = false; chkFries.Checked = false; 
            chkCoke.Checked = false; 
            chkCheese.Checked = false; 
            chkSauce.Checked = false; 
            lstOrder.Items.Clear(); lblTotalCost.Text = "총 금액 : 0원";
        }
    }
}
