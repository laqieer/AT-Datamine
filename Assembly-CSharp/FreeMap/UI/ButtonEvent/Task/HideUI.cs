// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.HideUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001727")]
  public class HideUI : IFreeMapButtonEventTask
  {
    [Token(Token = "0x17001484")]
    private FreeMapIconEventHandler EventHandler
    {
      [Token(Token = "0x6008300"), Address(RVA = "0x42035F8", Offset = "0x42035F8", VA = "0x42035F8")] get
      {
        return (FreeMapIconEventHandler) null;
      }
    }

    [Token(Token = "0x6008301")]
    [Address(RVA = "0x4203600", Offset = "0x4203600", VA = "0x4203600")]
    public HideUI(FreeMapIconEventHandler eventHandler)
    {
    }

    [Token(Token = "0x6008302")]
    [Address(RVA = "0x4203628", Offset = "0x4203628", VA = "0x4203628", Slot = "4")]
    public void Execute()
    {
    }

    [Token(Token = "0x6008303")]
    [Address(RVA = "0x4203648", Offset = "0x4203648", VA = "0x4203648", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x6008304")]
    [Address(RVA = "0x420364C", Offset = "0x420364C", VA = "0x420364C", Slot = "6")]
    public bool IsBusy() => new bool();
  }
}
