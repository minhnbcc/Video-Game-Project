using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesProject
{
    public partial class frmOrders : Form
    {

        public frmOrders()
        {
            InitializeComponent();
        }

        #region Fields/Global Variables
        private int orderId = 0;


        decimal subtotal;
        const decimal taxRate = 0.15m;
        //const decimal discountRate = 0.15m;
        #endregion


        #region RETRIEVES
        private void LoadGames()
        {
            DataTable dtGames = DataAccess.GetData("Select GameId, GameName, Description, Manufacturer, PublishYear, Price, ESRB from Games");
            if (dtGames.Rows.Count > 0)
            {
                dgvGameLists.DataSource = dtGames;
                dgvGameLists.AutoResizeColumns();
                dgvGameLists.Columns["Price"].DefaultCellStyle.Format = "C";
                dgvGameLists.Columns["GameId"].HeaderCell.Value = "Game ID";
                dgvGameLists.Columns["PublishYear"].HeaderCell.Value = "Published Year";


            }
            else
            {
                MessageBox.Show("Invalid inputs.");
            }
        }

        private void LoadGenre()
        {
            DataTable dtGenre = DataAccess.GetData("Select * from Category");
            UIUtilities.FillListControl(cmbGenre, "CategoryName", "CategoryId", dtGenre, true, "--- Please select a genre ---");
        }
        #endregion


        #region SEARCH
        private void SearchByCategory()
        {

            string sql = $"Select Games.GameId, Games.GameName, Games.Description, Games.Manufacturer, Games.PublishYear, Games.Price, Games.ESRB, Category.CategoryName From Category inner join Games on Games.CategoryId = Category.CategoryId where Category.CategoryId = {cmbGenre.SelectedValue}";
            DataTable dtSearch = DataAccess.GetData(sql);

            dgvGameLists.DataSource = dtSearch;
            dgvGameLists.AutoResizeColumns();
            dgvGameLists.Columns["CategoryName"].HeaderCell.Value = "Genre";
        }

        private void SearchByName()
        {
            string sql =
            $"select Games.GameId, Games.GameName, Games.Description, Games.Manufacturer, Games.PublishYear, Games.Price, Games.ESRB, Category.CategoryName from Games inner join Category on Games.CategoryId = Category.CategoryId where Games.GameName like '%{txtGameName.Text}%'";

            DataTable dtSearch = DataAccess.GetData(sql);

            dgvGameLists.DataSource = dtSearch;
            dgvGameLists.AutoResizeColumns();
            dgvGameLists.Columns[7].DefaultCellStyle.Format = "c";

            dgvGameLists.Columns[7].HeaderCell.Value = "Published Year";
        }

        private decimal GetPrice()
        {
            string sql = $"select Price from Games where GameId = {dgvGameLists.CurrentRow.Cells["GameId"].Value}";

            return Convert.ToDecimal(DataAccess.ExecuteScalar(sql));
        }

        private void DisplayCalculation(decimal subtotal, decimal tax, decimal total)
        {
            txtTotal.Text = total.ToString("c");
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
        }

        #endregion

        #region EVENTS
        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadGames();
            LoadGenre();
            DisplayStatusStrip("Ready...", true);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar();
                if (!dgvGameLists.CurrentCell.Selected)
                {
                    MessageBox.Show("Please select the items prior to processing creation");
                }
                else
                {
                    if (txtQty.Text != string.Empty)
                    {
                        if (txtCustomerAge.Text != string.Empty)
                        {
                            if (chkLegalAge.Checked)
                            {
                                //decimal discount = 0;
                                decimal tax = 0;
                                decimal total = 0;

                                subtotal += GetPrice() * Convert.ToInt32(txtQty.Text);
                                tax = subtotal * taxRate;
                                total = subtotal + tax;
                                lstShow.Items.Add("\t\t----------------------------------------------------------");
                                lstShow.Items.Add("\t   " + $"--- Your Invoice is: \n{dgvGameLists.CurrentRow.Cells["GameName"].Value} ---");
                                lstShow.Items.Add($"\tQuantity: {txtQty.Text} \tPrice: {GetPrice().ToString("c")}");
                                lstShow.Items.Add($"\tLegal Age: {(chkLegalAge.Checked ? 1 : 0).ToString("Valid")}");
                                lstShow.Items.Add("\t\t----------x----------x---------x----------x------------");

                                if (orderId == 0)
                                {

                                    if (InsertOrder(total, tax) && InsertOrderDetail(Convert.ToInt32(txtQty.Text)))
                                    {
                                        MessageBox.Show("Order is created with the first game");
                                    }

                                    else
                                    {
                                        MessageBox.Show("Your order refused");
                                    }
                                }
                                else
                                {
                                    if (InsertOrderDetail(Convert.ToInt32(txtQty.Text)) && UpdateOrders(tax, total))
                                    {
                                        MessageBox.Show("Item is added");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Item insert failed");
                                    }

                                }
                                //if (Convert.ToInt32(txtQty.Text) > 3 && Convert.ToDecimal(txtTotal.Text) > 60)
                                //{
                                //    discount = GetPrice() * Convert.ToInt32(txtQty.Text) * discountRate;
                                //    txtDiscount.Text = discount.ToString("c");

                                //}

                                DisplayCalculation(subtotal, tax, total);
                                txtQty.Text = string.Empty;
                                txtCustomerAge.Text = string.Empty;
                                chkLegalAge.Checked = false;

                            }
                            else
                            {
                                MessageBox.Show("Customer is not old enough to buy the item(s).", "Illegal Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Customer's age is not empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Type the quantity of items to calculate your order");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGenre.SelectedValue != DBNull.Value)
                {
                    SearchByCategory();
                }
                else if (txtGameName.Text != string.Empty)
                {
                    SearchByName();
                }
                else
                {
                    LoadGames();
                    MessageBox.Show("Your searching item(s) is empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadGames();
            LoadGenre();
        }

        /// <summary>
        /// Validate age legally to buy games
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCustomerAge_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerAge.Text == string.Empty)
                {
                    MessageBox.Show("Verify customer's age");
                }
                else
                {
                    if (Convert.ToInt32(txtCustomerAge.Text) >= CheckAge())
                    {
                        chkLegalAge.Checked = true;
                    }
                    else
                    {
                        chkLegalAge.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.CornflowerBlue;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Gainsboro;
        }

        private void btnShowAll_MouseHover(object sender, EventArgs e)
        {
            btnShowAll.BackColor = Color.CornflowerBlue;
        }

        private void btnShowAll_MouseLeave(object sender, EventArgs e)
        {
            btnShowAll.BackColor = Color.Gainsboro;
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.CornflowerBlue;
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.SkyBlue;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.CornflowerBlue;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.SkyBlue;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.CornflowerBlue;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.SkyBlue;
        }

        #endregion 


        #region CREATE ORDER AND ID
        /// <summary>
        /// Create Order
        /// </summary>
        /// <param name="total"></param>
        /// <param name="tax"></param>
        /// <returns></returns>
        public bool InsertOrder(decimal total, decimal tax)
        {

            GetOrderId();
            /* int empId = 10000;*///Properties.Settings.Default.EmployeeId; // Nho doi lai employee id
            string sql = $"Insert into Orders (OrderId,OrderDate, Subtotal, Tax, Total, EmployeeId) Values({orderId},'{DateTime.Now.ToShortDateString()}',{subtotal},{tax},{total}, {Properties.Settings.Default.EmployeeId})";
            return DataAccess.ExecuteNonQuery(sql) > 0 ? true : false;

        }
        /// <summary>
        /// Create order Id
        /// </summary>
        private void GetOrderId()
        {
            string sql = "SELECT COUNT(*) FROM Orders";

            orderId = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;
        }
        #endregion

        #region Validation

        /// <summary>
        /// Insert order details (Game Orders)
        /// </summary>
        /// <returns></returns>
        private bool InsertOrderDetail(int qty)
        {
            string sqlInsert = $"Insert into GameOrders (GameId, OrderId, UnitPrice,Quantity) VALUES ({dgvGameLists.CurrentRow.Cells["GameId"].Value},{orderId},{GetPrice()},{txtQty.Text})";

            return DataAccess.ExecuteNonQuery(sqlInsert) > 0 ? true : false;
        }

        private bool UpdateOrders(decimal tax, decimal total)
        {
            string sqlUpdate = $"Update Orders set Subtotal = {subtotal}, Tax = {tax}, Total={total} where OrderId = {orderId} ";

            return DataAccess.ExecuteNonQuery(sqlUpdate) > 0 ? true : false;
        }

        #region Validate Age
        private int CheckAge()
        {
            string sql = $"select ESRB from Games where GameId = {dgvGameLists.CurrentRow.Cells["GameId"].Value}";

            string value = Convert.ToString(DataAccess.ExecuteScalar(sql)).Substring(0, 2);

            if (int.TryParse(value, out int v))
            {
                return Convert.ToInt32(value);
            }
            return 0;
        }

        #endregion

        #endregion


       #region HINT TEXT
        private void txtGameName_Enter(object sender, EventArgs e)
        {
            if (txtGameName.Text == "Search by Name")
            {
                txtGameName.Text = "";

                txtGameName.ForeColor = Color.Black;
            }
        }

        private void txtGameName_Leave(object sender, EventArgs e)
        {
            if (txtGameName.Text == "")
            {
                txtGameName.Text = "Search by Name";

                txtGameName.ForeColor = Color.Silver;
            }
        }
        #endregion


        #region Helpers
        private void ClearForm()
        {
            txtCustomerAge.Text = "";
            cmbGenre.SelectedIndex = 0;
            lstShow.Items.Clear();
            txtQty.Text = "";
            txtCustomerAge.Text = "";
            chkLegalAge.Checked = false;
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            DisplayStatusStrip("Ready...", true);

        }

        private void ProgressBar()
        {
            toolStripStatusLabel1.Text = "Processing...";
            prgBar.Value = 0;
            statusStrip1.Refresh();

            while (prgBar.Value < prgBar.Maximum)
            {
                Thread.Sleep(15);
                prgBar.Value += 1;
            }
            toolStripStatusLabel2.Visible = true;
            this.toolStripStatusLabel2.Text = "Processed";

        }

        private void DisplayStatusStrip(string msg, bool c)
        {
            toolStripStatusLabel1.Text = msg;
            if (c == true)
            {
                toolStripStatusLabel1.ForeColor = Color.Black;
            }
            else
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private void CLearProgressBar()
        {
            prgBar.Value = 0;

        }

        #endregion
    }
}
