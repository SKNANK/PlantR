using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantRService.DataAccess.Stubs;
using PlantRService.Model;

namespace PlantRService.Repo
{
    public class AccountRepository
    {
        public List<Account> Accounts { get; set; }
        public List<Plant> Plants { get; set; }



        public PersonalPlant AddPlant(int plantID, int accID, int daysWater, string nName)
        {
            throw new NotImplementedException();
        }

        public void GetAllPlants()
        {
            //TODO To connect to data access layer later.
            Plants = StubPDB.GetAllPlants();
        }

        public void GetAccountPlants(int accID)
        {
            List<PersonalPlant> ppList = StubPPDB.GetAllPlants(accID);
            foreach (var acc in Accounts)
            {
                if (acc.ID == accID)
                {
                    acc.PlantList = ppList;
                }
            }
        }



    }
}
