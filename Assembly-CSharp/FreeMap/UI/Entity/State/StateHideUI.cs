// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.State.StateHideUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Entity.State
{
  [Token(Token = "0x200169F")]
  public class StateHideUI : PassiveMessageStateBase
  {
    [Token(Token = "0x6007FDF")]
    [Address(RVA = "0x41F0940", Offset = "0x41F0940", VA = "0x41F0940", Slot = "4")]
    protected override void OnInitialize(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FE0")]
    [Address(RVA = "0x41F0944", Offset = "0x41F0944", VA = "0x41F0944", Slot = "5")]
    protected override void OnEnter(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FE1")]
    [Address(RVA = "0x41F0948", Offset = "0x41F0948", VA = "0x41F0948", Slot = "6")]
    public override void Execute(FreeMapPassiveMessageUI entity, float deltaTime)
    {
    }

    [Token(Token = "0x6007FE2")]
    [Address(RVA = "0x41F0A38", Offset = "0x41F0A38", VA = "0x41F0A38", Slot = "7")]
    public override void Exit(FreeMapPassiveMessageUI entity)
    {
    }

    [Token(Token = "0x6007FE3")]
    [Address(RVA = "0x41F0A3C", Offset = "0x41F0A3C", VA = "0x41F0A3C", Slot = "8")]
    public override int GetStateType() => new int();

    [Token(Token = "0x6007FE4")]
    [Address(RVA = "0x41F0A44", Offset = "0x41F0A44", VA = "0x41F0A44")]
    public StateHideUI()
    {
    }
  }
}
