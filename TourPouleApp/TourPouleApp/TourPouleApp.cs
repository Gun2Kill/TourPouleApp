using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourPouleApp.service;

namespace TourPouleApp
{
    public partial class Form1 : Form
    {
        private TourService service;

        public Form1()
        {
            InitializeComponent();
             service = new TourService();
        }

        private void cbStageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            string startCity = "";
            string finishCity = "";
            double distance = 0;

            int stageID = cbStageSelector.SelectedIndex;
            DataTable stageInfo = service.getStage(stageID + 1);
            foreach (DataRow row in stageInfo.Rows)
            {
                id = (int) row["id"];
                startCity = row["start"].ToString();
                finishCity = row["finish"].ToString();
                distance = (double) row["distance"];
            }

            lblStageInfo.Text = startCity + " / " + finishCity + " (" + distance + "km)";
            pbStageMap.Image = Image.FromFile("C:/Users/robin/Documents/GitHub/TourPouleApp/TourPouleApp/TourPouleApp/stageImages/stage" + id + "map.jpg");
            pbStageProfile.Image = Image.FromFile("C:/Users/robin/Documents/GitHub/TourPouleApp/TourPouleApp/TourPouleApp/stageImages/stage" + id + "profile.png");
        }

        private void tblGeneralEtappe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbGeneral_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
