// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusBadStatusFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002349")]
  public sealed class UnitStatusBadStatusFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x40095CB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<UnitStatusBadStatusFactor.UnitStatusBadStatusUISet> badStatusUISets;
    [Token(Token = "0x40095CC")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Color plusColor;
    [Token(Token = "0x40095CD")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Color minusColor;
    [Token(Token = "0x40095CE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Color defaultColor;

    [Token(Token = "0x600D79E")]
    [Address(RVA = "0x1B88AE8", Offset = "0x1B88AE8", VA = "0x1B88AE8", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D79F")]
    [Address(RVA = "0x1B88E3C", Offset = "0x1B88E3C", VA = "0x1B88E3C", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D7A0")]
    [Address(RVA = "0x1B88FE0", Offset = "0x1B88FE0", VA = "0x1B88FE0")]
    private void SetValuesTo(
      UnitStatusBadStatusFactor.UnitStatusBadStatusUISet uiSet,
      UnitParameterData unit,
      BattleBadStatusTypeEnum type)
    {
    }

    [Token(Token = "0x600D7A1")]
    [Address(RVA = "0x1B88C50", Offset = "0x1B88C50", VA = "0x1B88C50")]
    private void SetBadStatus(
      UnitStatusBadStatusFactor.UnitStatusBadStatusUISet uiSet,
      int reinforce,
      int resist)
    {
    }

    [Token(Token = "0x600D7A2")]
    [Address(RVA = "0x1B891F4", Offset = "0x1B891F4", VA = "0x1B891F4")]
    private Color GetColor(int value) => new Color();

    [Token(Token = "0x600D7A3")]
    [Address(RVA = "0x1B8924C", Offset = "0x1B8924C", VA = "0x1B8924C")]
    private string GetText(int value) => (string) null;

    [Token(Token = "0x600D7A4")]
    [Address(RVA = "0x1B89310", Offset = "0x1B89310", VA = "0x1B89310")]
    public UnitStatusBadStatusFactor()
    {
    }

    [Token(Token = "0x200234A")]
    [Serializable]
    private class UnitStatusBadStatusUISet
    {
      [Token(Token = "0x40095CF")]
      [FieldOffset(Offset = "0x10")]
      public Text reinforceHead;
      [Token(Token = "0x40095D0")]
      [FieldOffset(Offset = "0x18")]
      public Text reinforce;
      [Token(Token = "0x40095D1")]
      [FieldOffset(Offset = "0x20")]
      public Text resistHead;
      [Token(Token = "0x40095D2")]
      [FieldOffset(Offset = "0x28")]
      public Text resist;

      [Token(Token = "0x600D7A5")]
      [Address(RVA = "0x1B8933C", Offset = "0x1B8933C", VA = "0x1B8933C")]
      public UnitStatusBadStatusUISet()
      {
      }
    }
  }
}
