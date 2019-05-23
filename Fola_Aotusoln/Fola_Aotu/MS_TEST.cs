using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fola_Aotu
    
    [TestClass]
    public class MS_TEST

    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext testContext)
        {
            Console.WriteLine(" before assembly");
        }

        [ClassInitialize]
        public static void  BeforeClass(TestContext testContext)
        {
            Console.WriteLine("class initialise");
        }

        [TestInitializeAttribute]

        public void BeforeTest()
        {
            Console.WriteLine("Test Initialize---Run before test----");
            Console.WriteLine("launch the browser");

        }

        [TestMethod]
        [TestCategory("smokeTest")]
        public void CreateAccount()


        {
            Console.WriteLine("Create A User Account");
        }

     

        [TestMethod, TestCategory("UAT")]
        
        public void LogIntoAccount()

        {
            Console.WriteLine("LOG INTO THE APPLICATION");
        }

        [TestMethod]
        [TestCategory("REGRESSION")]


        public void LogOutOfAccount()

        {
            Console.WriteLine("LOG OUT OF THE APPLICATION");
        }




        [TestCleanupAttribute]
        public void AfterTest()
        {
            Console.WriteLine("Test Cleanup ---Run after test");
            Console.WriteLine("close the browser");

        }

        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("class cleanup");
        }

        [AssemblyCleanup]

        public static void AfterAssembly()
        {
            Console.WriteLine("after assembly");
        }

    }
}
