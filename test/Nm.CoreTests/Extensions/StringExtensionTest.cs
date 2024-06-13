using JetBrains.Annotations;
using Nm.Core.Extensions;
namespace Nm.CoreTests.Extensions;

[TestSubject(typeof(StringExtension))]
public class StringExtensionTest
{

    [Fact]
    public void IsNullOrWhiteSpace_Test()
    {
        var str1 = "abc";
        string? str2 = null;
        var str3 = "";
        var str4 = " ";
        Assert.Equal(str1.IsNullOrWhiteSpace(),string.IsNullOrWhiteSpace(str1));
        Assert.Equal(str2.IsNullOrWhiteSpace(),string.IsNullOrWhiteSpace(str2));
        Assert.Equal(str3.IsNullOrWhiteSpace(),string.IsNullOrWhiteSpace(str3));
        Assert.Equal(str4.IsNullOrWhiteSpace(),string.IsNullOrWhiteSpace(str4));
    }

    [Fact]
    public void IsNullOrEmpty_Test()
    {
        var str1 = "abc";
        string? str2 = null;
        var str3 = "";
        var str4 = " ";
        Assert.Equal(str1.IsNullOrEmpty(),string.IsNullOrEmpty(str1));
        Assert.Equal(str2.IsNullOrEmpty(),string.IsNullOrEmpty(str2));
        Assert.Equal(str3.IsNullOrEmpty(),string.IsNullOrEmpty(str3));
        Assert.Equal(str4.IsNullOrEmpty(),string.IsNullOrEmpty(str4));
    }

    [Fact]
    public void FileBeLocked_Test()
    {
    }
}