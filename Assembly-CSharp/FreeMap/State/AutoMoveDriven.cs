// Decompiled with JetBrains decompiler
// Type: FreeMap.State.AutoMoveDriven
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.State.ModeState;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State
{
  [Token(Token = "0x200179F")]
  public class AutoMoveDriven : PlayerControl.Allow.IDriven
  {
    [Token(Token = "0x4006871")]
    [FieldOffset(Offset = "0x10")]
    private FreeMap.State.Process.AutoMove process;

    [Token(Token = "0x6008615")]
    [Address(RVA = "0x406EC54", Offset = "0x406EC54", VA = "0x406EC54")]
    public void AutoMove(
      FreeMapStateManager entity,
      FreeMapUIParamBase target,
      IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x6008616")]
    [Address(RVA = "0x406ED58", Offset = "0x406ED58", VA = "0x406ED58")]
    public void Cancel()
    {
    }

    [Token(Token = "0x6008617")]
    [Address(RVA = "0x406ED80", Offset = "0x406ED80", VA = "0x406ED80", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6008618")]
    [Address(RVA = "0x406EC4C", Offset = "0x406EC4C", VA = "0x406EC4C")]
    public AutoMoveDriven()
    {
    }
  }
}
