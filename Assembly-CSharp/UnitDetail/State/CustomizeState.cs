// Decompiled with JetBrains decompiler
// Type: UnitDetail.State.CustomizeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using UnitDetail.Customize;
using UnityEngine;

#nullable disable
namespace UnitDetail.State
{
  [Token(Token = "0x20004CB")]
  public class CustomizeState : UnitDetailState
  {
    [Token(Token = "0x4001947")]
    [FieldOffset(Offset = "0x20")]
    private UnitCustomizeStateHandler stateHandler;

    [Token(Token = "0x6001B35")]
    [Address(RVA = "0x2C2C22C", Offset = "0x2C2C22C", VA = "0x2C2C22C")]
    public CustomizeState(UnitCustomizeStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6001B36")]
    [Address(RVA = "0x2C2C298", Offset = "0x2C2C298", VA = "0x2C2C298", Slot = "5")]
    protected override void OnEnter(UnitDetailSubScene entity)
    {
    }

    [Token(Token = "0x6001B37")]
    [Address(RVA = "0x2C2C2B8", Offset = "0x2C2C2B8", VA = "0x2C2C2B8", Slot = "12")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001B38")]
    [Address(RVA = "0x2C2C2DC", Offset = "0x2C2C2DC", VA = "0x2C2C2DC", Slot = "15")]
    public override void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x6001B39")]
    [Address(RVA = "0x2C2C2FC", Offset = "0x2C2C2FC", VA = "0x2C2C2FC", Slot = "10")]
    public override void OnNextUnit()
    {
    }

    [Token(Token = "0x6001B3A")]
    [Address(RVA = "0x2C2C418", Offset = "0x2C2C418", VA = "0x2C2C418", Slot = "11")]
    public override void OnPrevUnit()
    {
    }

    [Token(Token = "0x6001B3B")]
    [Address(RVA = "0x2C2C448", Offset = "0x2C2C448", VA = "0x2C2C448", Slot = "13")]
    public override void OnSwitchOverViewer()
    {
    }
  }
}
