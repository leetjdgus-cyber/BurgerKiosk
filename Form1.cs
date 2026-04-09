namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        private Control[][] _groups = null!;

        public Form1()
        {
            InitializeComponent();
            InitializeKeyboardNavigation();
        }

        public int totalCost = 0;

        private void InitializeKeyboardNavigation()
        {
            _groups = new Control[][]
            {
                new Control[] { rdoHamBurger, rdoBulgogiBurger, rdoChickenBurger },
                new Control[] { chkFries, chkCoke, chkCheese, chkSauce },
                new Control[] { btnOrder, btnReset }
            };

            Load += (s, e) => rdoHamBurger.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Control? focused = FindFocusedControl(this);
            if (focused == null)
                return base.ProcessCmdKey(ref msg, keyData);

            int groupIndex = -1;
            int itemIndex = -1;

            for (int g = 0; g < _groups.Length; g++)
            {
                for (int i = 0; i < _groups[g].Length; i++)
                {
                    if (_groups[g][i] == focused)
                    {
                        groupIndex = g;
                        itemIndex = i;
                        break;
                    }
                }
                if (groupIndex >= 0) break;
            }

            if (groupIndex < 0)
                return base.ProcessCmdKey(ref msg, keyData);

            switch (keyData)
            {
                case Keys.Tab:
                    {
                        int next = (groupIndex + 1) % _groups.Length;
                        _groups[next][0].Focus();
                        return true;
                    }

                case Keys.Tab | Keys.Shift:
                    {
                        int prev = (groupIndex - 1 + _groups.Length) % _groups.Length;
                        _groups[prev][0].Focus();
                        return true;
                    }

                case Keys.Up:
                    if (itemIndex > 0)
                        _groups[groupIndex][itemIndex - 1].Focus();
                    return true;

                case Keys.Down:
                    if (itemIndex < _groups[groupIndex].Length - 1)
                        _groups[groupIndex][itemIndex + 1].Focus();
                    return true;

                case Keys.Enter:
                    btnOrder.PerformClick();
                    return true;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private static Control? FindFocusedControl(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c.Focused) return c;
                if (c.ContainsFocus)
                {
                    var found = FindFocusedControl(c);
                    if (found != null) return found;
                }
            }
            return null;
        }

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
