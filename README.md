# twh.testdata.driver
Sample code to demonstrate use of twh.testdata.driver nuget packge 

Nuget package download here - https://www.nuget.org/packages/twh.testdata.driver/

Refer this link for example code - 

https://github.com/hariprasadms/twh.testdata.driver/blob/master/twh.testdata.driver_demo/twh.testdata.driver_demo/Tests/DemoTests.cs

Refer sample test data file here - 

https://github.com/hariprasadms/twh.testdata.driver/tree/master/twh.testdata.driver_demo/twh.testdata.driver_demo/TestData

Usage -

Below are the steps -

1. Create an excel file.

2. In excel sheets, add two columns with the names as 'Name' and 'Value' ( These are case sensitive ). Name is the column holds the 'Key' and Value is the column holds the 'value' associated with the key.

Note - In version 1.0, it supported to have only two columns in a sheet.

3. Import below class

Using Twh.TestData.Vault.VaultBase;


VaultBase is a class contains below static methods

VaultReader.ExcelToJson(<ExcelFile>,<SheetName>);

VaultReader.GetValue(<A field from Name Filed>); - It gets a perticular value associated with given Name filed.
  
VaultReader.GetAllValues(); - Gets the all values from a sheet in the given excel data file

VaultReader.GetValuesCount();
