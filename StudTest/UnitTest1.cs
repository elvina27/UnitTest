using Microsoft.VisualBasic;
using ��������_��������.Genderi;
using ��������_��������.Haracteristika;
using ��������_��������;
using StudLib;

namespace StudTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddButton()
        {
            AbiturientNuget Abiturient = new();
            var result = Abiturient.Get();
            Abiturient mytest = new()
            {
                FullName = "����",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObucheniya = FormaObucheniya.Ochnoe,
                Matem = 80,
                Rus = 78,
                Inf = 91,
                Sum =249,

            };
            Abiturient.Add(mytest);
            Assert.Equal(mytest, result[0]);
        }

        [Fact]
        public void ChangeButton()
        {
            AbiturientNuget Abiturient = new();
            var result = Abiturient.Get();
            Abiturient list = new()
            {

                FullName = "����",
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
                FullName = "����",
                Gender = Gender.Male,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObucheniya = FormaObucheniya.Ochnoe,
                Matem = 20,
                Rus = 35,
                Inf = 45,
                Sum = 100,
            };
            Abiturient.Update(0, list2);
            Assert.Equal(list2, result[0]);
        }

        [Fact]
        public void DeleteButton()
        {
            AbiturientNuget Abiturient = new();
            var result = Abiturient.Get();
            Abiturient list = new()
            {
                FullName = "�����",
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
            Assert.Empty(result);
        }
    }
}