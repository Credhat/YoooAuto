using System.Drawing;
using YoooAuto.WorkSpace.LogicWorkSpace;
namespace YoooAuto.WorkSpace.TestWorkSpace;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Rectangle arec = new Rectangle(0, 0, 1920, 1080);
        BaseFunctions baseFunctions = new BaseFunctions();
        baseFunctions.RecordGifAutomaticlly(arec, "gif.gif", "F:\\Edge");
    }
}