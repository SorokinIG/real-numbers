
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = false;

            var res = chec.Display("21");

            Assert.IsNotNull(res);
            Assert.AreEqual("Натуральное число", res);           
        }

        [TestMethod]
        public void TestMethod2()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = false;

            var res = chec.Display("20");

            Assert.IsNotNull(res);
            Assert.AreEqual("Натуральное число", res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = false;

            var res = chec.Display("19");

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = false;

            var res = chec.Display("49");

            Assert.IsNotNull(res);
            Assert.AreEqual("Натуральное число", res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = false;

            var res = chec.Display("50");

            Assert.IsNotNull(res);
            Assert.AreEqual("Натуральное число", res);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = false;

            var res = chec.Display("51");
            

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("21,1");

            Assert.IsNotNull(res);
            Assert.AreEqual("Вещественное число", res);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("20,5");

            Assert.IsNotNull(res);
            Assert.AreEqual("Вещественное число", res);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("19,9");

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("49,9");

            Assert.IsNotNull(res);
            Assert.AreEqual("Вещественное число", res);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("50,5");

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod12()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("51,1");


            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod13()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("-21");

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod14()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("-20");

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod15()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("-19");

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod16()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("-49");

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod17()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("-50");

            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }

        [TestMethod]
        public void TestMethod18()
        {
            var chec = new Form1();

            chec.checkBox1.Checked = true;

            var res = chec.Display("-51");


            Assert.IsNotNull(res);
            Assert.AreEqual("Ошибка", res);
        }
    }
}
