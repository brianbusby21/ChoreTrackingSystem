using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_DataModels
{
    class User
    {
        private ChoreList _assignedChoreList;

        public int Id { get; set; }

        public string Name { get; set; }

        public short Age { get; set; }

        public string Role { get; set; }

        public User(string name)
        {
            this.Name = name;
            _assignedChoreList = new ChoreList();
        }

        public void AssignChore(Chore newChore)
        {
            if (newChore != null)
            {
                _assignedChoreList.AddChore(newChore);
            }
        }

        public void UpdateChore()
        {

        }

        public void UnassignChore(string choreName)
        {
            _assignedChoreList.DeleteChore(choreName);

        }

    }
}
