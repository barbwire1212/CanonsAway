using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CannonsAway;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RandomNumberGeneratorTest() 
        {

         //instantiate the Form
        frmCanon myfrmCanon = new frmCanon();

            //run the method on the form and then pass the number to a variable for testing
            int RndCanonShot = myfrmCanon.myFire.Canon();
            //is the number great than 0 and less than 7?
            Assert.IsTrue(RndCanonShot > 0 && RndCanonShot < 7);
        }
    }
}
