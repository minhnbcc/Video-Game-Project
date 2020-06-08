using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesProject
{
    public partial class frmModifyOrders : Form
    {
        public frmModifyOrders()
        {
            InitializeComponent();
        }

        #region Fields/Global Variables
        const decimal taxRate = 0.15m;
        #endregion


        #region RETRIEVES
        private void LoadGameOrders()
        {
            DataTable dtGameOrders = DataAccess.GetData(
                "select Orders.OrderId, Orders.OrderDate, Orders.Subtotal, Orders.Tax, Orders.Total, Employees.FirstName + ' ' + Employees.LastName as [Employee Name] " +
                "from Orders inner join Employees on Employees.EmployeeId = Orders.EmployeeId");
            if (dtGameOrders.Rows.Count > 0)
            {
                dgvOrderList.DataSource = dtGameOrders;
                dgvOrderList.Columns["OrderId"].HeaderCell.Value = "Order ID";
                dgvOrderList.Columns["OrderDate"].HeaderCell.Value = "Order Date";
                dgvOrderList.Columns["Subtotal"].DefaultCellStyle.Format = "C";
                dgvOrderList.Columns["Tax"].DefaultCellStyle.Format = "C";
                dgvOrderList.Columns["Total"].DefaultCellStyle.Format = "C";

                dgvOrderList.AutoResizeColumns();
            }
           
        }

        private void SearchByID()
        {

            DataTable dtOrders = DataAccess.GetData("select Orders.OrderId, Orders.OrderDate, Orders.Subtotal, Orders.Tax, Orders.Total, Employees.FirstName + ' ' + Employees.LastName as [Employee Name] " +
                $"from Orders inner join Employees on Employees.EmployeeId = Orders.EmployeeId where Orders.OrderId = {txtOrderId.Text}");
            dgvOrderList.DataSource = dtOrders;
            dgvOrderList.Columns["OrderId"].HeaderCell.Value = "Order ID";
            dgvOrderList.Columns["OrderDate"].HeaderCell.Value = "Order Date";
            dgvOrderList.Columns["Subtotal"].DefaultCellStyle.Format = "C";
            dgvOrderList.Columns["Tax"].DefaultCellStyle.Format = "C";
            dgvOrderList.Columns["Total"].DefaultCellStyle.Format = "C";
            dgvOrderList.AutoResizeColumns();
        }

        private void LoadSwitchGames()
        {
            DataTable dtGames = DataAccess.GetData("Select GameName, GameId from Games");
            UIUtilities.FillListControl(cmbSwitch, "GameName", "GameId", dtGames, true, "--- Please select a game to switch ---");
        }
        #endregion


        #region EVENTS
        private void frmModifyOrders_Load(object sender, EventArgs e)
        {
            LoadGameOrders();
            rdoModify.Enabled = false;
            rdoSwitch.Enabled = false;
            btnSwitch.Enabled = false;
            btnModify.Enabled = false;

            dgvOrderList.AllowUserToAddRows = false;
            PreventEnable();
            LoadSwitchGames();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderId.Text != string.Empty)
                {
                    LoadGameOrders();
                    SearchByID();
                    rdoSwitch.Enabled = true;
                    rdoModify.Enabled = true;
                    if (rdoSwitch.Checked)
                    {
                        ModifyEnable();
                        btnModify.Enabled = false;
                        btnSwitch.Enabled = true;
                    }
                    if (rdoSwitch.Checked == false)

                        ModifyDisable();
                    btnModify.Enabled = true;
                    btnSwitch.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please type your Order ID to search");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void dgvOrderDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow orderDetailRow = dgvOrderDetails.CurrentRow;
                string orderDetail = $"OrderID: {orderDetailRow.Cells["OrderId"].Value}\r\n" +
                    $"GameID: {orderDetailRow.Cells["GameID"].Value}\r\n" +
                    $"GameName: {orderDetailRow.Cells["GameName"].Value}\r\n" +
                    $"Quantity: {orderDetailRow.Cells["Quantity"].Value}\r\n" +
                    $"Subtotal: {Convert.ToDecimal(orderDetailRow.Cells["Subtotal"].Value):c2}\r\n" +
                    $"Tax: {Convert.ToDecimal(orderDetailRow.Cells["Tax"].Value):c2}\r\n" +
                    $"Total: {Convert.ToDecimal(orderDetailRow.Cells["Total"].Value):c2}\r\n";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOrderList.CurrentCell.Selected || dgvOrderList.CurrentRow.Selected)
                {
                    rdoModify.Enabled = true;
                    rdoSwitch.Enabled = true;

                    DataGridViewRow orderRow = dgvOrderList.CurrentRow;
                    int orderId = Convert.ToInt32(orderRow.Cells[0].Value);

                    string sql = $@"select GameOrders.OrderId,Games.GameId, Games.GameName, GameOrders.UnitPrice, GameOrders.Quantity from GameOrders inner join Games on GameOrders.GameId = Games.GameId where GameOrders.OrderId = {orderId}";

                    dgvOrderDetails.DataSource = DataAccess.GetData(sql);

                    dgvOrderDetails.AutoResizeColumns();
                    dgvOrderDetails.Columns["OrderId"].HeaderCell.Value = "Order ID";
                    dgvOrderDetails.Columns["GameName"].HeaderCell.Value = "Game Name";
                    dgvOrderDetails.Columns["UnitPrice"].DefaultCellStyle.Format = "c";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void rdoSwitch_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SwitchEnable();
                if (rdoSwitch.Checked == false)
                {
                    cmbSwitch.Enabled = false;
                    btnModify.Enabled = true;
                }
                if (rdoSwitch.Checked == true)
                {
                    btnSwitch.Enabled = true;
                    btnModify.Enabled = false;

                    LoadSwitchGames();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void rdoModify_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ModifyEnable();
                if (rdoModify.Checked == false)
                {
                    ModifyDisable();
                    btnSwitch.Enabled = true;
                }
                if (rdoModify.Checked == true)
                {
                    btnSwitch.Enabled = false;
                    btnModify.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoSwitch.Checked)
                {
                    if (cmbSwitch.SelectedIndex != -1)
                    {
                        SwitchGame();
                    }
                    LoadGameOrders();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (rdoModify.Checked)
            {
                if (txtQty.Text != string.Empty || txtQty.Text != "0")
                {
                    ModifyQuantity();
                }
                else
                {
                    MessageBox.Show("Quantity cannot be blank or value must be greater than 0.");
                }
                LoadGameOrders();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //UpdateOrders();
            LoadGameOrders();
            dgvOrderDetails.DataSource = null;
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.CornflowerBlue;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Gainsboro;
        }

        private void btnReload_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.CornflowerBlue;
        }

        private void btnReload_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Gainsboro;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region NONQUERY Execution

        private void SwitchGame()
        {
            if (!CheckDuplicateGames())
            {
                string sqlUpdateGameOrders = $@"Update GameOrders 
                    set GameOrders.GameId = {Convert.ToInt32(cmbSwitch.SelectedValue)}, 
                    GameOrders.UnitPrice = (Select Price from Games where GameId = {Convert.ToInt32(cmbSwitch.SelectedValue)})
	                from GameOrders
                    inner join Games on GameOrders.GameId = Games.GameId
                    where GameOrders.GameId = {dgvOrderDetails.CurrentRow.Cells["GameId"].Value} and GameOrders.OrderId = {dgvOrderDetails.CurrentRow.Cells["OrderId"].Value}";

                int rowsAffected = DataAccess.ExecuteNonQuery(sqlUpdateGameOrders);

                if (rowsAffected > 0)
                {
                    if (Recalculate())
                    {

                        txtSSubtotal.Text = Convert.ToDecimal((dgvOrderList.CurrentRow.Cells["Subtotal"].Value)).ToString("c");
                        txtSTax.Text = Convert.ToDecimal(dgvOrderList.CurrentRow.Cells["Tax"].Value).ToString("c");
                        txtSTotal.Text = Convert.ToDecimal(dgvOrderList.CurrentRow.Cells["Total"].Value).ToString("c");
                        MessageBox.Show("Your game order is changed as your request");
                    }
                }
                else
                {
                    MessageBox.Show("The database reported no rows affected.");
                }
            }
            else
            {
                MessageBox.Show("Cannot duplicate games in one order.");

            }
        }

        private void ModifyQuantity()
        {
            string sqlUpdateGameOrders = $@"Update GameOrders 
                set GameOrders.Quantity = {Convert.ToInt32(txtQty.Text)}
                from GameOrders
                where GameOrders.GameId = {Convert.ToInt32(dgvOrderDetails.CurrentRow.Cells["GameId"].Value)} and GameOrders.OrderId = {Convert.ToInt32(dgvOrderDetails.CurrentRow.Cells["OrderId"].Value)}";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlUpdateGameOrders);
            if (rowsAffected > 0)
            {
                if (Recalculate())
                {
                    txtSSubtotal.Text = Convert.ToDecimal((dgvOrderList.CurrentRow.Cells["Subtotal"].Value)).ToString("c");
                    txtSTax.Text = Convert.ToDecimal(dgvOrderList.CurrentRow.Cells["Tax"].Value).ToString("c");
                    txtSTotal.Text = Convert.ToDecimal(dgvOrderList.CurrentRow.Cells["Total"].Value).ToString("c");
                    MessageBox.Show("The quantity in the order has been changed as your request");
                }

            }
            else
            {
                MessageBox.Show("The database reported no rows affected.");
            }

        }
        #endregion


        #region VALIDATOR

        private bool CheckDuplicateGames()
        {
            string sqlDuplicateGameId = $@"select Count(*) From GameOrders where GameId = {Convert.ToInt32(cmbSwitch.SelectedValue)} and OrderId = {Convert.ToInt32(dgvOrderDetails.CurrentRow.Cells["OrderId"].Value)}";

            return Convert.ToBoolean(Convert.ToInt32(DataAccess.ExecuteScalar(sqlDuplicateGameId)) > 0 ? true : false);
        }

        private bool Recalculate()
        {
            string sqlUpdateOrders =
            $@"Update Orders
            set Orders.Subtotal = (Select Sum(UnitPrice * Quantity) from GameOrders where OrderId = {dgvOrderList.CurrentRow.Cells["OrderId"].Value}),
            Orders.Tax = (Select Sum(UnitPrice * Quantity) * {taxRate} from GameOrders where OrderId = {dgvOrderList.CurrentRow.Cells["OrderId"].Value}),
            Orders.Total = (Select Sum(UnitPrice * Quantity) + Sum(UnitPrice * Quantity) * {taxRate} from GameOrders where OrderId = {dgvOrderList.CurrentRow.Cells["OrderId"].Value})
            from Orders
            inner join GameOrders on GameOrders.OrderId = Orders.OrderId
            where Orders.OrderId = {dgvOrderList.CurrentRow.Cells["OrderId"].Value} ";

            return Convert.ToBoolean(DataAccess.ExecuteNonQuery(sqlUpdateOrders) > 0 ? true : false);
        }

        #endregion


        #region HINT TEXT

        private void txtOrderId_Enter(object sender, EventArgs e)
        {
            if (txtOrderId.Text == "Search by ID")
            {
                txtOrderId.Text = "";

                txtOrderId.ForeColor = Color.Black;
            }
        }

        private void txtOrderId_Leave(object sender, EventArgs e)
        {
            if (txtOrderId.Text == "")
            {
                txtOrderId.Text = "Search by ID";

                txtOrderId.ForeColor = Color.Silver;
            }
        }

        #endregion


        #region Helpers

        private void SwitchEnable()
        {
            cmbSwitch.Enabled = true;
        }

        private void ModifyEnable()
        {
            txtQty.Enabled = true;
            txtMSubtotal.Enabled = true;
            txtMTax.Enabled = true;
            txtMTotal.Enabled = true;
        }

        private void ModifyDisable()
        {
            txtQty.Enabled = false;
            txtMSubtotal.Enabled = false;
            txtMTax.Enabled = false;
            txtMTotal.Enabled = false;
        }

        private void PreventEnable()
        {
            cmbSwitch.Enabled = false;
            txtQty.Enabled = false;
            txtMSubtotal.Enabled = false;
            txtMTax.Enabled = false;
            txtMTotal.Enabled = false;
        }

        private void ClearForm()
        {
            txtOrderId.Text = string.Empty;
            dgvOrderDetails.DataSource = null;
            txtQty.Text = string.Empty;
            ModifyDisable();
            PreventEnable();
            rdoModify.Checked = false;
            rdoSwitch.Checked = false;
            btnSwitch.Enabled = false;
            btnModify.Enabled = false;
            rdoModify.Enabled = false;
            rdoSwitch.Enabled = false;
            txtSSubtotal.Text = string.Empty;
            txtSTax.Text = string.Empty;
            txtSTotal.Text = string.Empty;
            txtMSubtotal.Text = string.Empty;
            txtMTax.Text = string.Empty;
            txtMTotal.Text = string.Empty;
            cmbSwitch.SelectedIndex = 0;
        }

        #endregion
  
    }
}
