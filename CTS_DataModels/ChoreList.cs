using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_DataModels
{
    class ChoreList
    {         
        private List<Chore> _choreList;

        public ChoreList()
        {
            _choreList = new List<Chore>();
        }

        public void AddChore(Chore newChore)
        {
            if(newChore != null)
            {
                _choreList.Add(newChore);
            }
        }

        public void UpdateChore()
        {

        }

        public void DeleteChore(string choreName)
        {
            var choreToRemove = _choreList.SingleOrDefault(c => c.Name == choreName);
            if (choreToRemove != null)
            {
                _choreList.Remove(choreToRemove);
            }
            
        }
    }
}
