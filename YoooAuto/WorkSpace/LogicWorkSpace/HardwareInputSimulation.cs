using System;
using System.Data;
using System.Drawing;
namespace YoooAuto.WorkSpace.LogicWorkSpace;

enum eMouse
{
    Left = 0,
    Center = 1,
    Right = 2,
    Count,
}

public class HardwareInputSimulation
{
    /// <summary>
    /// 基础时间倍率因子，使得所有关于时间的动作上升至秒
    /// </summary>
    const int _baseTimeFactor = 1000;

    public void KeyBoardPressKey(string sPressKey, out bool bPressed, int iWaitingTime = 1)
    {
        bPressed = false;

        Thread.Sleep(iWaitingTime * _baseTimeFactor);
    }

    public void KeyBoardPressKey(string sPressKey, int iWaitingTime = 1)
    {
        KeyBoardPressKey(sPressKey, out bool bPressed, iWaitingTime);
    }
    public void KeyBoardPressKeys(string[] sPressKeys, bool bSimultaneous, int iWaitingTime = -1)
    {

    }

    public void MouseLeftClick(Point pClickPosition, out bool bClicked, int iWaitingTime = 1)
    {
        bClicked = false;

        Thread.Sleep(iWaitingTime * _baseTimeFactor);
    }
    public void MouseLeftClick(Point pClickPosition, int iWaitingTime = 1)
    {
        MouseLeftClick(pClickPosition, out bool bClicked, iWaitingTime);
    }
}

