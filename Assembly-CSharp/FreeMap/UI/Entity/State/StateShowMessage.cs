// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.State.StateShowMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Entity.State
{
  [Token(Token = "0x20016A2")]
  public class StateShowMessage : PassiveMessageStateBase
  {
    [Token(Token = "0x4006590")]
    [FieldOffset(Offset = "0x20")]
    private readonly float DisplayTimeMax;
    [Token(Token = "0x4006591")]
    [FieldOffset(Offset = "0x24")]
    protected float showUITime;

    [Token(Token = "0x6007FF1")]
    [Address(RVA = "0x41F0C1C", Offset = "0x41F0C1C", VA = "0x41F0C1C")]
    public StateShowMessage()
    {
    }

    [Token(Token = "0x6007FF2")]
    [Address(RVA = "0x41F0CBC", Offset = "0x41F0CBC", VA = "0x41F0CBC", Slot = "4")]
    protected override void OnInitialize(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FF3")]
    [Address(RVA = "0x41F0CC0", Offset = "0x41F0CC0", VA = "0x41F0CC0", Slot = "5")]
    protected override void OnEnter(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FF4")]
    [Address(RVA = "0x41F0E98", Offset = "0x41F0E98", VA = "0x41F0E98", Slot = "6")]
    public override void Execute(FreeMapPassiveMessageUI entity, float deltaTime)
    {
    }

    [Token(Token = "0x6007FF5")]
    [Address(RVA = "0x41F0FCC", Offset = "0x41F0FCC", VA = "0x41F0FCC", Slot = "7")]
    public override void Exit(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FF6")]
    [Address(RVA = "0x41F1040", Offset = "0x41F1040", VA = "0x41F1040", Slot = "8")]
    public override int GetStateType() => new int();
  }
}
