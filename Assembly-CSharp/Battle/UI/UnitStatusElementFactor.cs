// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusElementFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002353")]
  public sealed class UnitStatusElementFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x4009608")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnitStatusElementFactor.UnitStatusElementUISet fireElement;
    [Token(Token = "0x4009609")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnitStatusElementFactor.UnitStatusElementUISet iceElement;
    [Token(Token = "0x400960A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UnitStatusElementFactor.UnitStatusElementUISet thunderElement;
    [Token(Token = "0x400960B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UnitStatusElementFactor.UnitStatusElementUISet windElement;
    [Token(Token = "0x400960C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UnitStatusElementFactor.UnitStatusElementUISet lightElement;
    [Token(Token = "0x400960D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UnitStatusElementFactor.UnitStatusElementUISet darkElement;
    [Token(Token = "0x400960E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Color plusColor;
    [Token(Token = "0x400960F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Color minusColor;
    [Token(Token = "0x4009610")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Color defaultColor;

    [Token(Token = "0x600D7C4")]
    [Address(RVA = "0x1B8BBD0", Offset = "0x1B8BBD0", VA = "0x1B8BBD0", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D7C5")]
    [Address(RVA = "0x1B8BE4C", Offset = "0x1B8BE4C", VA = "0x1B8BE4C", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D7C6")]
    [Address(RVA = "0x1B8BEDC", Offset = "0x1B8BEDC", VA = "0x1B8BEDC")]
    private void SetElement(
      UnitStatusElementFactor.UnitStatusElementUISet uiSet,
      ElementTypeEnum element,
      UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7C7")]
    [Address(RVA = "0x1B8BC60", Offset = "0x1B8BC60", VA = "0x1B8BC60")]
    private void SetElementValues(
      UnitStatusElementFactor.UnitStatusElementUISet uiSet,
      int enhance,
      int resist)
    {
    }

    [Token(Token = "0x600D7C8")]
    [Address(RVA = "0x1B8BF54", Offset = "0x1B8BF54", VA = "0x1B8BF54")]
    private Color GetColor(int value) => new Color();

    [Token(Token = "0x600D7C9")]
    [Address(RVA = "0x1B8BFAC", Offset = "0x1B8BFAC", VA = "0x1B8BFAC")]
    private string GetText(int value) => (string) null;

    [Token(Token = "0x600D7CA")]
    [Address(RVA = "0x1B8C070", Offset = "0x1B8C070", VA = "0x1B8C070")]
    public UnitStatusElementFactor()
    {
    }

    [Token(Token = "0x2002354")]
    [Serializable]
    private class UnitStatusElementUISet
    {
      [Token(Token = "0x4009611")]
      [FieldOffset(Offset = "0x10")]
      public Text reinforceHead;
      [Token(Token = "0x4009612")]
      [FieldOffset(Offset = "0x18")]
      public Text reinforce;
      [Token(Token = "0x4009613")]
      [FieldOffset(Offset = "0x20")]
      public Text resistHead;
      [Token(Token = "0x4009614")]
      [FieldOffset(Offset = "0x28")]
      public Text resist;

      [Token(Token = "0x600D7CB")]
      [Address(RVA = "0x1B8C098", Offset = "0x1B8C098", VA = "0x1B8C098")]
      public UnitStatusElementUISet()
      {
      }
    }
  }
}
