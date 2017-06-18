using System.Collections.Generic;
using System.Data;
using LivePerformance.Database;

namespace TourPouleApp.service
{
    public class TourService
    {
        Database database = new Database();

        public DataTable getStage(int stageID)
        {
            string query = "SELECT * FROM STAGE WHERE ID=" + stageID;
            DataTable stage = database.Select(query);
            return stage;
        }
    }
}