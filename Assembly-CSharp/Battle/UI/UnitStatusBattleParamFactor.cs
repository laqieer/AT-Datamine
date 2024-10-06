// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusBattleParamFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002351")]
  public sealed class UnitStatusBattleParamFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x40095FB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet physicalAtk;
    [Token(Token = "0x40095FC")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet physicalDef;
    [Token(Token = "0x40095FD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet magicalAtk;
    [Token(Token = "0x40095FE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet magicalDef;
    [Token(Token = "0x40095FF")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet hit;
    [Token(Token = "0x4009600")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet avoid;
    [Token(Token = "0x4009601")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet critical;
    [Token(Token = "0x4009602")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet criticalAvoid;
    [Token(Token = "0x4009603")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UnitStatusBattleParamFactor.UnitStatusBattleParamUISet attackSpeed;
    [Token(Token = "0x4009604")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Color plusColor;
    [Token(Token = "0x4009605")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Color minusColor;

    [Token(Token = "0x600D7BF")]
    [Address(RVA = "0x1B8B020", Offset = "0x1B8B020", VA = "0x1B8B020", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D7C0")]
    [Address(RVA = "0x1B8B2F4", Offset = "0x1B8B2F4", VA = "0x1B8B2F4", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D7C1")]
    [Address(RVA = "0x1B8B0EC", Offset = "0x1B8B0EC", VA = "0x1B8B0EC")]
    private void SetParam(
      UnitStatusBattleParamFactor.UnitStatusBattleParamUISet uiSet,
      int original,
      int corrected)
    {
    }

    [Token(Token = "0x600D7C2")]
    [Address(RVA = "0x1B8BBB4", Offset = "0x1B8BBB4", VA = "0x1B8BBB4")]
    public UnitStatusBattleParamFactor()
    {
    }

    [Token(Token = "0x2002352")]
    [Serializable]
    private class UnitStatusBattleParamUISet
    {
      [Token(Token = "0x4009606")]
      [FieldOffset(Offset = "0x10")]
      public Text corrected;
      [Token(Token = "0x4009607")]
      [FieldOffset(Offset = "0x18")]
      public Text rate;

      [Token(Token = "0x600D7C3")]
      [Address(RVA = "0x1B8BBC8", Offset = "0x1B8BBC8", VA = "0x1B8BBC8")]
      public UnitStatusBattleParamUISet()
      {
      }
    }
  }
}
