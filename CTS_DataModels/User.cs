using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_DataModels
{
    [Serializable]
    class User
    {
        private List<Chore> _assignedChoreList;

        public int Id { get; set; }

        public string UserName { get; private set; }

        public string Name { get; set; }

        public short Age { get; set; }

        public string Role { get; set; }

        public User(string name, string userName)
        {
            this.Name = name;
            this.UserName = userName;
            _assignedChoreList = new List<Chore>();
        }

        public void AssignChore(Chore newChore)
        {
            if (newChore != null)
            {
                _assignedChoreList.Add(newChore);
            }
        }

        public void UpdateChore()
        {

        }

        public void UnassignChore(string choreName)
        {
            var choreToRemove = _assignedChoreList.SingleOrDefault(c => c.Name == choreName);
            if (choreToRemove != null)
            {
                _assignedChoreList.Remove(choreToRemove);
            }

        }

        public void Save()
        {

        }

    }
}
