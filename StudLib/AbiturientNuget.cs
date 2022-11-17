using Приемная_комиссия;
using Приемная_комиссия.Haracteristika;

namespace StudLib
{
    public class AbiturientNuget
    {
        private List<Abiturient> Abitur = new List<Abiturient>();

        public AbiturientNuget() { }
        public List<Abiturient> Get()
        {
            return Abitur;
        }

        public void Add(Abiturient data)
        {
            Abitur.Add(data);
        }
        public void Remove(Abiturient data)
        {
            Abitur.Remove(data);
        }

        public void Update(int index, Abiturient data)
        {
            Abitur[index] = data;
        }
    }
}