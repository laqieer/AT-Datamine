// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.DisconnectPlayerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Instance.KeyController;
using FreeMap.UI.SwipeController;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001722")]
  public class DisconnectPlayerController : IFreeMapButtonEventTask
  {
    [Token(Token = "0x1700147B")]
    private SwipeControllerLogic SwipeController
    {
      [Token(Token = "0x60082DF"), Address(RVA = "0x4202E0C", Offset = "0x4202E0C", VA = "0x4202E0C")] get
      {
        return (SwipeControllerLogic) null;
      }
    }

    [Token(Token = "0x1700147C")]
    private FreeMapPlayerKeyControllerLogic KeyController
    {
      [Token(Token = "0x60082E0"), Address(RVA = "0x4202E14", Offset = "0x4202E14", VA = "0x4202E14")] get
      {
        return (FreeMapPlayerKeyControllerLogic) null;
      }
    }

    [Token(Token = "0x1700147D")]
    private FreeMapInstanceHolder InstanceHolder
    {
      [Token(Token = "0x60082E1"), Address(RVA = "0x4202E1C", Offset = "0x4202E1C", VA = "0x4202E1C")] get
      {
        return (FreeMapInstanceHolder) null;
      }
    }

    [Token(Token = "0x60082E2")]
    [Address(RVA = "0x420037C", Offset = "0x420037C", VA = "0x420037C")]
    public DisconnectPlayerController(
      SwipeControllerLogic swipeController,
      FreeMapPlayerKeyControllerLogic keyController,
      FreeMapInstanceHolder instanceHolder)
    {
    }

    [Token(Token = "0x60082E3")]
    [Address(RVA = "0x4202E24", Offset = "0x4202E24", VA = "0x4202E24", Slot = "4")]
    public void Execute()
    {
    }

    [Token(Token = "0x60082E4")]
    [Address(RVA = "0x4202E64", Offset = "0x4202E64", VA = "0x4202E64", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x60082E5")]
    [Address(RVA = "0x4202E68", Offset = "0x4202E68", VA = "0x4202E68", Slot = "6")]
    public bool IsBusy() => new bool();
  }
}
