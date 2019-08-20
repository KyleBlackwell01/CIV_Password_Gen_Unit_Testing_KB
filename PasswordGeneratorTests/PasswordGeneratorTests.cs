using NUnit.Framework;
using PasswordGenerator;

namespace Tests {
    public class Tests {


        Generator Pass;


        [SetUp]
        public void Setup () {
            Pass = new Generator();
        }

        [Test]
        [TestCase ("Mary","Bill",54,"maryB_1965")]
        [TestCase ("Joe","feathers",32,"joeF_1987")]
        [TestCase ("Frank","Grasper",66,"frankG_1953")]
        public void PasswordGenOneTest (string firstname, string lastname, int age, string ans) {

            var result = Pass.PasswordGenOne(firstname, lastname, age);

            Assert.AreEqual(ans, result);
        }

        [Test]
        [TestCase ("Mary","Bill",54,"Bill1965M")]
        [TestCase ("Joe","feathers",32,"feathers1987J")]
        [TestCase ("frank","Grasper",66,"Grasper1953F")]
        public void PasswordGenTwoTest (string firstname, string lastname, int age, string ans) {

            var result = Pass.PasswordGenTwo(firstname, lastname, age);
            Assert.AreEqual(ans, result);
        }

        [Test]
        [TestCase (8)]
        public void PasswordGenThreeTest(int length) {

            var result = Pass.PasswordGenThree(length);



            Assert.AreEqual(length, result);
        }
    }
}