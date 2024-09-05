// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AutoMoveToEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.State.ModeState;
using FreeMap.UI;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017B6")]
  public class AutoMoveToEvent : AutoMove
  {
    [Token(Token = "0x40068A3")]
    [FieldOffset(Offset = "0x30")]
    private FreeMapAutoMoveRouteHandler autoMoveRouteHandler;
    [Token(Token = "0x40068A4")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapIconEventHandler iconEventHandler;
    [Token(Token = "0x40068A5")]
    [FieldOffset(Offset = "0x40")]
    private int toAreaID;
    [Token(Token = "0x40068A6")]
    [FieldOffset(Offset = "0x48")]
    private FreeMapUIParamBase target;
    [Token(Token = "0x40068A7")]
    [FieldOffset(Offset = "0x50")]
    private FreeMapUIParamBase current;
    [Token(Token = "0x40068A8")]
    [FieldOffset(Offset = "0x58")]
    private IPlayerAreaOperationEvent playerOperation;

    [Token(Token = "0x6008681")]
    [Address(RVA = "0x43CECA4", Offset = "0x43CECA4", VA = "0x43CECA4")]
    public AutoMoveToEvent(
      FreeMapStateManager entity,
      int toAreaID,
      FreeMapUIParamBase target,
      IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x6008682")]
    [Address(RVA = "0x43CECE4", Offset = "0x43CECE4", VA = "0x43CECE4", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008683")]
    [Address(RVA = "0x43CEDA8", Offset = "0x43CEDA8", VA = "0x43CEDA8", Slot = "8")]
    protected override void OnCancelMove()
    {
    }

    [Token(Token = "0x6008684")]
    [Address(RVA = "0x43CEDF4", Offset = "0x43CEDF4", VA = "0x43CEDF4", Slot = "9")]
    protected override void OnAutoMoveFinish()
    {
    }

    [Token(Token = "0x6008685")]
    [Address(RVA = "0x43CF098", Offset = "0x43CF098", VA = "0x43CF098", Slot = "6")]
    protected override void OnEnd()
    {
    }
  }
}
