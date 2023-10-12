using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsolEAppEmployment
{
    public class Baku : ICity
    {
        private readonly List<Human> _people = new List<Human>();

        public void AddHuman(Human human)
        {
            if (string.IsNullOrEmpty(human.Name) || string.IsNullOrEmpty(human.Surname))
            {
                throw new ArgumentException("Ad ve familia bosh olmamalidir");
            }

            if (!char.IsLetter(human.Name[0]) || !char.IsLetter(human.Surname[0]))
            {
                throw new ArgumentException("Ad ve Familia ancaq herflerden olmalidir");
            }

            _people.Add(human);
        }

        public IEnumerable<Human> SearchHumans(string name)
        {
            return _people.Where(h => h.ToString().Contains(name));
        }

        public IEnumerable<Student> GetStudents()
        {
            return _people.OfType<Student>();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _people.OfType<Employee>();
        }
    }

}
