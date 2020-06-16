using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twh.TestData.Vault.VaultBase;

namespace twh.testdata.driver_demo.Tests
{
    class DemoTests
    {


        String TestDataFile = @"C:\Users\hariprasad.srinivas\Documents\twh.testdata.driver\twh.testdata.driver_demo\twh.testdata.driver_demo\TestData\testdata1.xlsx";
        [Test]
        public void Test1()
        {
            VaultReader.ExcelToJson(TestDataFile,"Sheet1");
            String name = VaultReader.GetValue("username");

            Console.WriteLine(name);
        }

        [Test]
        public void Test2()
        {
            VaultReader.ExcelToJson(TestDataFile, "Sheet2");

            String name = VaultReader.GetValue("one");

            Console.WriteLine(name);


        }

        [Test]
        public void Test_GetAllValuesFromASheet()
        {
            VaultReader.ExcelToJson(TestDataFile, "Sheet2");

            List<String> all= VaultReader.GetAllValues();

            foreach (var data in all)
            {
                Console.WriteLine(data);
            }

        }

        [Test]
        public void Test_GetCountOfDataFromASheet()
        {
            VaultReader.ExcelToJson(TestDataFile, "Sheet2");

            int DataCount = VaultReader.GetValuesCount();

            Console.WriteLine(DataCount);
        }

    }
}
