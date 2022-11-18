Kousing Microsoft.VisualBasic;
using Ïðèåìíàÿ_êîìèññèÿ.Genderi;
using Ïðèåìíàÿ_êîìèññèÿ.Haracteristika;
using Ïðèåìíàÿ_êîìèññèÿ;
using StudLib;

namespace StudTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddButton()
        {
            AbiturientNuget Abiturient = new();
          
            Abiturient mytest = new()
            {
                FullName = "Íèíà",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObucheniya = FormaObucheniya.Ochnoe,
                Matem = 80,
                Rus = 78,
                Inf = 91,
                Sum =249,

            };
            Abiturient.Add(mytest);
            var result = Abiturient.Get();
            Assert.Equal(mytest, result[0]);
        }

        [Fact]
        public void ChangeButton()
        {
            AbiturientNuget Abiturient = new();
            Abiturient list = new()
            {

                FullName = "Íèíà",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObucheniya = FormaObucheniya.Ochnoe,
                Matem = 80,
                Rus = 78,
                Inf = 91,
                Sum = 249,
            };
            Abiturient.Add(list);
            Abiturient list2 = new()
            {
                FullName = "Âëàä",
                Gender = Gender.Male,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObucheniya = FormaObucheniya.Ochnoe,
                Matem = 20,
                Rus = 35,
                Inf = 45,
                Sum = 100,
            };
            Abiturient.Update(0, list2);
            var result = Abiturient.Get();
            Assert.Equal(list2, result[0]);
        }

        [Fact]
        public void DeleteButton()
        {
            AbiturientNuget Abiturient = new();
            Abiturient list = new()
            {
                FullName = "Èðèíà",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObucheniya = FormaObucheniya.Ochnoe,
                Matem = 80,
                Rus = 78,
                Inf = 91,
                Sum = 249,
            };
            Abiturient.Add(list);
            Abiturient.Remove(list);
            var result = Abiturient.Get();
            Assert.Empty(result);
        }
    }
}
