using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesProject
{
    public partial class frmOrders : Form
    {
        private int orderId = 0;

        decimal subtotal;
        const decimal taxRate = 0.15m;

        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadGames();
            LoadGenre();
        }



        #region RETRIEVES
        private void LoadGames()
        {
            DataTable dtGames = DataAccess.GetData("Select Games.GameId, Games.GameName, Games.Description, Games.Manufacturer, Games.PublishYear, Games.Price, Games.ESRB, Category.CategoryName " +
                "from Games inner join Category on Games.CategoryId = CateGory.CategoryId");

            if (!Validator.IsNullOrEmpty(txtGameName.Text) || dtGames.Rows.Count > 0)
            {
                dgvGameLists.DataSource = dtGames;
                dgvGameLists.AutoResizeColumns();
                dgvGameLists.Columns[7].DefaultCellStyle.Format = "c";
                dgvGameLists.Columns[0].HeaderCell.Value = "Game ID";
                dgvGameLists.Columns[7].HeaderCell.Value = "Published Year";

            }
            else
            {
                MessageBox.Show("Invalid inputs.");
            }
        }

        private void LoadGenre()
        {
            DataTable dtGenre = DataAccess.GetData("Select * from Category");
            UIUtilities.FillListControl(cmbGenre, "CategoryName", "CategoryId", dtGenre, false, "--- Please Select a genre ---");
        }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
