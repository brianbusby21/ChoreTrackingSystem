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

        public int Id { get; private set; }

        public string UserName { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public short Age { get; private set; }

        public string Role { get; private set; }

        public User(string firstName, string lastName, string userName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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

        private int CalculateAge(DateTime dateOfBirth)
        {

            return 0;
        }
    }
}
