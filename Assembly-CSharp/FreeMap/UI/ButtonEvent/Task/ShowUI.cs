// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.ShowUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001728")]
  public class ShowUI : IFreeMapButtonEventTask
  {
    [Token(Token = "0x17001485")]
    private FreeMapIconEventHandler EventHandler
    {
      [Token(Token = "0x6008305"), Address(RVA = "0x4203654", Offset = "0x4203654", VA = "0x4203654")] get
      {
        return (FreeMapIconEventHandler) null;
      }
    }

    [Token(Token = "0x6008306")]
    [Address(RVA = "0x420365C", Offset = "0x420365C", VA = "0x420365C")]
    public ShowUI(FreeMapIconEventHandler eventHandler)
    {
    }

    [Token(Token = "0x6008307")]
    [Address(RVA = "0x4203684", Offset = "0x4203684", VA = "0x4203684", Slot = "4")]
    public void Execute()
    {
    }

    [Token(Token = "0x6008308")]
    [Address(RVA = "0x42036A4", Offset = "0x42036A4", VA = "0x42036A4", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x6008309")]
    [Address(RVA = "0x42036A8", Offset = "0x42036A8", VA = "0x42036A8", Slot = "6")]
    public bool IsBusy() => new bool();
  }
}
