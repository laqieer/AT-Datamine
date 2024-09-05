// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.StopPlayerLookAt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001725")]
  public class StopPlayerLookAt : IFreeMapButtonEventTask
  {
    [Token(Token = "0x17001483")]
    private FreeMapInstanceHolder InstanceHolder
    {
      [Token(Token = "0x60082F6"), Address(RVA = "0x42031A8", Offset = "0x42031A8", VA = "0x42031A8")] get
      {
        return (FreeMapInstanceHolder) null;
      }
    }

    [Token(Token = "0x60082F7")]
    [Address(RVA = "0x4200654", Offset = "0x4200654", VA = "0x4200654")]
    public StopPlayerLookAt(FreeMapInstanceHolder instanceHolder)
    {
    }

    [Token(Token = "0x60082F8")]
    [Address(RVA = "0x42031B0", Offset = "0x42031B0", VA = "0x42031B0", Slot = "4")]
    public void Execute()
    {
    }

    [Token(Token = "0x60082F9")]
    [Address(RVA = "0x420323C", Offset = "0x420323C", VA = "0x420323C", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x60082FA")]
    [Address(RVA = "0x4203240", Offset = "0x4203240", VA = "0x4203240", Slot = "6")]
    public bool IsBusy() => new bool();
  }
}
