using System.Security.Cryptography;
using System;
using System.Linq;
using System.Drawing;
using System.Buffers.Text;
using System.Windows.Input;

namespace YoooAuto.WorkSpace.LogicWorkSpace;

public class BaseFunctions
{
    public void RecordGifAutomaticlly(Rectangle bounds, string gifName, string ouputPath)
    {
        ScreenRecordGif GIF = new ScreenRecordGif(bounds);
        GIF.Record();
        Console.Write("Input Pause Press <Enter> to Pause Record gif... \r\n");
        Console.Write("Input StopGIF Press <Enter> to Save Record gif... \r\n");
        string UserInput = Console.ReadLine().ToString();
        while (!UserInput.Equals("StopGIF"))
        {
            if (UserInput.ToString().Equals("Pause"))
            {
                GIF.Pause();
            }
            else if (UserInput.ToString().Equals("Continue") || UserInput.ToString().Equals("continue"))
            {
                GIF.Record();
            }

            UserInput = Console.ReadLine().ToString();
        }
        // while (Console.ReadKey().Key != ConsoleKey.Enter) {}
        GIF.StopSave(ouputPath + "\\" + gifName);
    }
}
