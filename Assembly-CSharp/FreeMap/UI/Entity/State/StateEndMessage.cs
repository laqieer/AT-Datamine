// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.State.StateEndMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Entity.State
{
  [Token(Token = "0x200169E")]
  public class StateEndMessage : PassiveMessageStateBase
  {
    [Token(Token = "0x400658E")]
    [FieldOffset(Offset = "0x20")]
    protected readonly float IntervalTime;
    [Token(Token = "0x400658F")]
    [FieldOffset(Offset = "0x24")]
    protected float waitEndTime;

    [Token(Token = "0x6007FD9")]
    [Address(RVA = "0x41F0754", Offset = "0x41F0754", VA = "0x41F0754")]
    public StateEndMessage()
    {
    }

    [Token(Token = "0x6007FDA")]
    [Address(RVA = "0x41F07F4", Offset = "0x41F07F4", VA = "0x41F07F4", Slot = "4")]
    protected override void OnInitialize(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FDB")]
    [Address(RVA = "0x41F07F8", Offset = "0x41F07F8", VA = "0x41F07F8", Slot = "5")]
    protected override void OnEnter(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FDC")]
    [Address(RVA = "0x41F0804", Offset = "0x41F0804", VA = "0x41F0804", Slot = "6")]
    public override void Execute(FreeMapPassiveMessageUI entity, float deltaTime)
    {
    }

    [Token(Token = "0x6007FDD")]
    [Address(RVA = "0x41F0934", Offset = "0x41F0934", VA = "0x41F0934", Slot = "7")]
    public override void Exit(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FDE")]
    [Address(RVA = "0x41F0938", Offset = "0x41F0938", VA = "0x41F0938", Slot = "8")]
    public override int GetStateType() => new int();
  }
}
