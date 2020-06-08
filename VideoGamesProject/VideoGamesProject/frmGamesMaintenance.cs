using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesProject
{
    public partial class frmGamesMaintenance : Form
    {
        public frmGamesMaintenance()
        {
            InitializeComponent();
        }

        #region Fields/Global Variables

        int currentRecord = 0;
        int currentGameId = 0;
        int firstGameId = 0;
        int lastGameId = 0;
        int? previousGameId;
        int? nextGameId;
        int totalGamesCount = 0;

        #endregion


        #region RETRIEVES
        private void LoadCategory()
        {
            DataTable dtCategory = DataAccess.GetData("Select * from Category");
            UIUtilities.FillListControl(cmbGenre, "CategoryName", "CategoryId", dtCategory, true);
        }
        private void LoadFirstGames()
        {
            currentGameId = Convert.ToInt32(DataAccess.ExecuteScalar("Select TOP(1) GameId from Games Order by GameName"));
            LoadGameDetails();


        }

        private void LoadGameDetails()
        {
            string sqlGameById = $"Select * from Games where GameId = {currentGameId}";

            string sqlNav = $@"
                Select
		        (
			        Select TOP(1) GameId as FirstGameId FROM Games ORDER BY GameName
		        ) AS FirstGameId,
		        q.NextGameId,
		        q.PreviousGameId,
		        (
			        Select TOP(1) GameId as LastGameId FROM Games ORDER BY GameName DESC
		        ) AS LastGameId,
		        q.RowNumber
		        FROM
		        (
			        SELECT GameId, GameName, 
			        LEAD(GameId) OVER(ORDER BY GameName) AS NextGameId, 
			        LAG(GameId) OVER(ORDER BY GameName) AS PreviousGameId,
			        ROW_NUMBER() OVER(ORDER BY GameName) AS 'RowNumber'
	    			FROM Games
		        ) AS q
		        where GameId = {currentGameId}
		        ORDER BY q.GameName";

            string sqlGameCount = "Select Count(GameId) AS GameCount from Games";

            string[] sqlStatement = new string[] { sqlGameById, sqlNav, sqlGameCount };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatement);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow selectedGame = ds.Tables[0].Rows[0];

                txtId.Text = selectedGame["GameId"].ToString();
                txtName.Text = selectedGame["GameName"].ToString();
                cmbGenre.SelectedValue = selectedGame["CategoryId"];
                txtDesc.Text = selectedGame["Description"].ToString();
                txtManufacturer.Text = selectedGame["Manufacturer"].ToString();
                txtPulishedYear.Text = selectedGame["PublishYear"].ToString();
                txtPrice.Text = Convert.ToDecimal(selectedGame["Price"]).ToString("n2");
                string value = selectedGame["ESRB"].ToString();
                if (value.Contains("10+"))
                {
                    rdo10.Checked = true;
                }
                if (value.Contains("13+"))
                {
                    rdo13.Checked = true;
                }
                if (value.Contains("17+"))
                {
                    rdo17.Checked = true;
                }
                if (value.Contains("18+"))
                {
                    rdo18.Checked = true;
                }
                if (value.Contains("all ages"))
                {
                    rdoAllAges.Checked = true;
                }
                if (value.Contains("rating pending"))
                {
                    rdoPending.Checked = true;
                }

                firstGameId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstGameId"]);
                previousGameId = ds.Tables[1].Rows[0]["PreviousGameId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousGameId"]) : (int?)null;
                nextGameId = ds.Tables[1].Rows[0]["NextGameId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextGameId"]) : (int?)null;
                lastGameId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastGameId"]);
                currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);

                totalGamesCount = Convert.ToInt32(ds.Tables[2].Rows[0]["GameCount"]);

                toolStripStatusLabel1.Text = $"Displaying game {currentRecord} of {totalGamesCount}";
            }
            else
            {
                MessageBox.Show("The game no longer exists");
                LoadFirstGames();
            }

        }

        #endregion


        #region NONQUERY Execution
        private void CreateGame()
        {
            string value = "";
            if (rdo10.Checked)
            {
                value = "10+";
            }
            if (rdo13.Checked)
            {
                value = "13+";
            }
            if (rdo17.Checked)
            {
                value = "17+";
            }
            if (rdo18.Checked)
            {
                value = "18+";
            }
            if (rdoAllAges.Checked)
            {
                value = "all ages";
            }
            if (rdoPending.Checked)
            {
                value = "rating pending";
            }
            string sqlInsertProduct = $@"
                Insert Into Games
                (
                    GameName,
                    CategoryId,
                    Description,
                    Manufacturer,
                    PublishYear,
                    Price,  
                    ESRB
                )
                Values
                    (
                    '{DataAccess.SQLFix(txtName.Text.Trim())}',
                    {cmbGenre.SelectedValue},
                    '{DataAccess.SQLFix(txtDesc.Text.Trim())}',
                    '{txtManufacturer.Text.Trim()}',
                    {txtPulishedYear.Text.Trim()},
                    {txtPrice.Text.Trim()},
                    '{value}'
                    )";

            int rowAffected = DataAccess.ExecuteNonQuery(sqlInsertProduct);

            if (rowAffected == 1)
            {
                MessageBox.Show("New Game added.");
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                LoadFirstGames();
            }
            else
            {
                MessageBox.Show("The database reported no rows affected.");
            }

            NavigationState(true);
        }

        private void SaveGameChanges()
        {
            string value = "";
            if (rdo10.Checked)
            {
                value = "10+";
            }
            if (rdo13.Checked)
            {
                value = "13+";
            }
            if (rdo17.Checked)
            {
                value = "17+";
            }
            if (rdo18.Checked)
            {
                value = "18+";
            }
            if (rdoAllAges.Checked)
            {
                value = "all ages";
            }
            if (rdoPending.Checked)
            {
                value = "rating pending";
            }

            string sqlUpdateGame = $@"
                Update Games
                Set GameName = '{DataAccess.SQLFix(txtName.Text.Trim())}'
                ,CategoryID = {cmbGenre.SelectedValue}
                ,Description = '{txtDesc.Text.Trim()}'
                ,Manufacturer = '{txtManufacturer.Text.Trim()}'
                ,PublishYear = {txtPulishedYear.Text.Trim()}
                ,Price = {txtPrice.Text.Trim()}
                ,ESRB = '{value.Trim()}'
                where GameId  = {txtId.Text}";

            sqlUpdateGame = DataAccess.SQLCleaner(sqlUpdateGame);

            int rowAffected = DataAccess.ExecuteNonQuery(sqlUpdateGame);

            if (rowAffected == 1)
            {
                MessageBox.Show("Games Updated");

            }
            else
            {
                MessageBox.Show("The database reported no rows affected.");
            }
        }

        private void DeleteGame()
        {
            string sqlDelete = $"DELETE FROM Games where GameId = {txtId.Text}";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlDelete);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Game was deleted");
            }
            else
            {
                MessageBox.Show("The database reported no rows affected.");
            }
        }
        #endregion


        #region EVENTS

        private void frmGamesMaintenance_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFirstGames();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Adding a new Product";
            toolStripStatusLabel2.Text = "";

            ClearControls(grpGameDetails.Controls);

            LoadCategory();

            rdo10.Checked = true;
            btnSave.Text = "Create";
            btnAdd.Text = "";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            NavigationState(false);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar();

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (txtId.Text == string.Empty)
                    {
                        CreateGame();
                    }
                    else
                    {
                        SaveGameChanges();
                    }

                }
                else
                {
                    MessageBox.Show("Please ensure data is valid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadGameDetails();

            btnSave.Text = "Save";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            NavigationState(true);
            NextPreviousButtonManagement();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check to make sure the product can be deleted. A product can only be deleted if it
            // doesn't exist in the order details
            string sqlNumTimesGameOrdered = $"Select Count(*) from [GameOrders] where GameId = {txtId.Text}";
            int numTimesProductOrdered = Convert.ToInt32(DataAccess.ExecuteScalar(sqlNumTimesGameOrdered));

            if (numTimesProductOrdered == 0)
            {
                if (MessageBox.Show("Are you sure you wish to remove this game in the list?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // go ahead and delete
                    DeleteGame();
                    LoadFirstGames();
                }
                else
                {
                    MessageBox.Show("The database reported no rows affected.");
                }
            }
            else
            {
                MessageBox.Show("This game could not be deleted because it belongs to an previous order.");
            }
        }

        #endregion


        #region [Navigation Helpers]

        /// <summary>
        /// Helps manage the enable state of our next and previous navigation buttons
        /// Depending on where we are in products we may need to set enable state based on position
        /// navigation through product records
        /// </summary>
        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousGameId != null;
            btnNext.Enabled = nextGameId != null;
        }

        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;

        }

        /// <summary>
        /// Handle navigation button interaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            toolStripStatusLabel2.Text = string.Empty;

            switch (b.Name)
            {
                case "btnFirst":
                    currentGameId = firstGameId;
                    toolStripStatusLabel2.Text = "The first game is currently displayed";
                    break;
                case "btnLast":
                    currentGameId = lastGameId;
                    toolStripStatusLabel2.Text = "The last game is currently displayed";
                    break;
                case "btnPrevious":
                    currentGameId = previousGameId.Value;
                    if (currentRecord - 1 == 1)
                        toolStripStatusLabel2.Text = "The first game is currently displayed";
                    break;
                case "btnNext":
                    currentGameId = nextGameId.Value;
                    if (currentRecord == totalGamesCount - 1)
                        toolStripStatusLabel2.Text = "The last game is currently displayed";
                    break;
            }
            

            LoadGameDetails();
            NextPreviousButtonManagement();
        }

        #endregion


        #region Helpers

        /// <summary>
        /// Clears the forms inputs
        /// </summary>
        /// <param name="controls"></param>
        private void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case RadioButton rdo:
                        rdo.Checked = false;
                        break;
                    case GroupBox gB:
                        ClearControls(gB.Controls);
                        break;
                }
            }
        }

        /// <summary>
        /// Animate the progres bar
        /// This is UI thread blocking, however, that is ok for this application
        /// </summary>
        private void ProgressBar()
        {
            toolStripStatusLabel3.Text = "Processing...";
            prgBar.Value = 0;
            statusStrip1.Refresh();

            while (prgBar.Value < prgBar.Maximum)
            {
                Thread.Sleep(15);
                prgBar.Value += 1;
            }

            this.toolStripStatusLabel3.Text = "Processed";
        }

        #endregion


        #region Validation

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string cmbName = cmb.Tag.ToString();

            string errMsg = null;

            if (cmb.SelectedIndex == -1 || string.IsNullOrEmpty(cmb.SelectedValue.ToString()))
            {
                errMsg = $"{cmbName} is required";
                e.Cancel = true;
            }
            errProvider.SetError(cmb, errMsg);
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            string txtBoxName = txt.Tag.ToString();
            string errMsg = null;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is requried";
                e.Cancel = true;
            }

            if (txt.Name == "txtName"
                || txt.Name == "txtManufacturer"
                || txt.Name == "txtPublishedYear"
                || txt.Name == "txtPrice")
            {
                if (!IsNumeric(txt.Text))
                {
                    errMsg = $"{txtBoxName} is not numeriac";
                    e.Cancel = true;
                }
            }
            errProvider.SetError(txt, errMsg);
        }

        private bool IsNumeric(string value)
        {
            return Double.TryParse(value, out double a);
        }

        #endregion

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            if (txtDesc.Text == string.Empty || int.TryParse(txtDesc.Text, out int des))
            {
                errProvider.SetError(txtDesc, "Description cannot be empty or a number");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtDesc, "");
                e.Cancel = false;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text == string.Empty || int.TryParse(txtName.Text, out int name))
            {
                errProvider.SetError(txtName, "Game name cannot be empty or a number");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtName, "");
                e.Cancel = false;
            }
        }

        private void cmbGenre_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(cmbGenre.SelectedValue) != 0 )
            {
                errProvider.SetError(cmbGenre, "Please choose category");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(cmbGenre, "");
                e.Cancel = false;
            }
        }

        private void txtManufacturer_Validating(object sender, CancelEventArgs e)
        {
            if (txtManufacturer.Text == string.Empty || int.TryParse(txtManufacturer.Text, out int manu))
            {
                errProvider.SetError(txtManufacturer, "Manufacturer cannot be empty or a number");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtManufacturer, "");
                e.Cancel = false;
            }
        }

        private void txtPulishedYear_Validating(object sender, CancelEventArgs e)
        {
            if (txtPulishedYear.Text == string.Empty || !int.TryParse(txtPulishedYear.Text, out int manu))
            {
                errProvider.SetError(txtPulishedYear, "Published year cannot be empty and must be a number");
                e.Cancel = true;
            }
            else if(txtPulishedYear.Text.Length != 4)
            {
                errProvider.SetError(txtPulishedYear, "Published year must have 4 numbers");
                e.Cancel = true;
            }
            else if(Convert.ToInt32(txtPulishedYear.Text) > DateTime.Now.Year)
            {
                errProvider.SetError(txtPulishedYear, "Published year cannot be greater than current year");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtPulishedYear, "");
                e.Cancel = false;
            }

        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrice.Text == string.Empty || Decimal.TryParse(txtPrice.Text, out decimal price))
            {
                errProvider.SetError(txtPrice, "Price cannot be empty and must be numberic");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtPrice, "");
                e.Cancel = false;
            }
        }
    }
}
