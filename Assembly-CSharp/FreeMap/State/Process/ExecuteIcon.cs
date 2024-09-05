// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ExecuteIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017B9")]
  public class ExecuteIcon : FreeMapProcess
  {
    [Token(Token = "0x40068AA")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapIconEventHandler iconEventHandler;
    [Token(Token = "0x40068AB")]
    [FieldOffset(Offset = "0x40")]
    private IFreeMapIconButtonEvent playableButtonEvent;

    [Token(Token = "0x600868B")]
    [Address(RVA = "0x43CF2EC", Offset = "0x43CF2EC", VA = "0x43CF2EC")]
    public ExecuteIcon(FreeMapStateManager entity, FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x600868C")]
    [Address(RVA = "0x43CF3F4", Offset = "0x43CF3F4", VA = "0x43CF3F4", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600868D")]
    [Address(RVA = "0x43CF610", Offset = "0x43CF610", VA = "0x43CF610", Slot = "7")]
    protected virtual void OnExit()
    {
    }

    [Token(Token = "0x600868E")]
    [Address(RVA = "0x43CF7E0", Offset = "0x43CF7E0", VA = "0x43CF7E0")]
    protected void OnChangeAreaExit(int sequenceID)
    {
    }
  }
}
