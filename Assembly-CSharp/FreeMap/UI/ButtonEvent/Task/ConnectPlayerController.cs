// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.ConnectPlayerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance.KeyController;
using FreeMap.UI.SwipeController;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001723")]
  public class ConnectPlayerController : IFreeMapButtonEventTask
  {
    [Token(Token = "0x1700147E")]
    private SwipeControllerLogic SwipeController
    {
      [Token(Token = "0x60082E6"), Address(RVA = "0x4202EFC", Offset = "0x4202EFC", VA = "0x4202EFC")] get
      {
        return (SwipeControllerLogic) null;
      }
    }

    [Token(Token = "0x1700147F")]
    private FreeMapPlayerKeyControllerLogic KeyController
    {
      [Token(Token = "0x60082E7"), Address(RVA = "0x4202F04", Offset = "0x4202F04", VA = "0x4202F04")] get
      {
        return (FreeMapPlayerKeyControllerLogic) null;
      }
    }

    [Token(Token = "0x60082E8")]
    [Address(RVA = "0x4200808", Offset = "0x4200808", VA = "0x4200808")]
    public ConnectPlayerController(
      SwipeControllerLogic swipeController,
      FreeMapPlayerKeyControllerLogic keyController)
    {
    }

    [Token(Token = "0x60082E9")]
    [Address(RVA = "0x4202F0C", Offset = "0x4202F0C", VA = "0x4202F0C", Slot = "4")]
    public void Execute()
    {
    }

    [Token(Token = "0x60082EA")]
    [Address(RVA = "0x4202F4C", Offset = "0x4202F4C", VA = "0x4202F4C", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x60082EB")]
    [Address(RVA = "0x4202F50", Offset = "0x4202F50", VA = "0x4202F50", Slot = "6")]
    public bool IsBusy() => new bool();
  }
}
