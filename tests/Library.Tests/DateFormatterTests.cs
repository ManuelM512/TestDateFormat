namespace Library.Tests;
using TestDateFormat;
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        const string expectedDate="2022-09-07";
        const string givenDate="07/09/2022";
        string returnedDate=DateFormatter.ChangeFormat(givenDate);
        Assert.AreEqual(expectedDate, returnedDate);
    }
    [Test]
    public void IncorrectFormat()
    {
        const string expectedDate="";
        const string givenDate="07 09 2022";
        string returnedDate=DateFormatter.ChangeFormat(givenDate);
        Assert.AreEqual(expectedDate, returnedDate);
    }

    [Test]
    public void BlankDate()
    {
        const string expectedDate="";
        const string givenDate="";
        string returnedDate=DateFormatter.ChangeFormat(givenDate);
        Assert.AreEqual(expectedDate, returnedDate);
    }

    [Test]
    public void NullDate()
    {
        const string expectedDate="";
        const string givenDate=null;
        string returnedDate=DateFormatter.ChangeFormat(givenDate);
        Assert.AreEqual(expectedDate, returnedDate);
    }

}