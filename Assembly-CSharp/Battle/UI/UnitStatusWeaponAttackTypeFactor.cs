// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusWeaponAttackTypeFactor
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
  [Token(Token = "0x2002360")]
  public sealed class UnitStatusWeaponAttackTypeFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x4009657")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnitStatusWeaponAttackTypeFactor.UnitStatusWeaponAttackTypeUISetGroup slash;
    [Token(Token = "0x4009658")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnitStatusWeaponAttackTypeFactor.UnitStatusWeaponAttackTypeUISetGroup blow;
    [Token(Token = "0x4009659")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UnitStatusWeaponAttackTypeFactor.UnitStatusWeaponAttackTypeUISetGroup pierce;
    [Token(Token = "0x400965A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UnitStatusWeaponAttackTypeFactor.UnitStatusWeaponAttackTypeUISetGroup shot;
    [Token(Token = "0x400965B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UnitStatusWeaponAttackTypeFactor.UnitStatusWeaponAttackTypeUISetGroup magic;
    [Token(Token = "0x400965C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Color defaultColor;
    [Token(Token = "0x400965D")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Color plusColor;
    [Token(Token = "0x400965E")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Color minusColor;

    [Token(Token = "0x600D800")]
    [Address(RVA = "0x1B8F508", Offset = "0x1B8F508", VA = "0x1B8F508", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D801")]
    [Address(RVA = "0x1B8F5BC", Offset = "0x1B8F5BC", VA = "0x1B8F5BC", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D802")]
    [Address(RVA = "0x1B8F630", Offset = "0x1B8F630", VA = "0x1B8F630")]
    private void Set(
      UnitParameterData unit,
      AttackTypeEnum attackType,
      UnitStatusWeaponAttackTypeFactor.UnitStatusWeaponAttackTypeUISetGroup uiGroup)
    {
    }

    [Token(Token = "0x600D803")]
    [Address(RVA = "0x1B8F654", Offset = "0x1B8F654", VA = "0x1B8F654")]
    private void Set(
      UnitParameterData unit,
      AttackTypeEnum attackType,
      int weaponIndex,
      UnitStatusWeaponAttackTypeFactor.UnitStatusWeaponAttackTypeUISet ui)
    {
    }

    [Token(Token = "0x600D804")]
    [Address(RVA = "0x1B8FB24", Offset = "0x1B8FB24", VA = "0x1B8FB24")]
    public UnitStatusWeaponAttackTypeFactor()
    {
    }

    [Token(Token = "0x2002361")]
    [Serializable]
    private class UnitStatusWeaponAttackTypeUISetGroup
    {
      [Token(Token = "0x400965F")]
      [FieldOffset(Offset = "0x10")]
      public UnitStatusWeaponAttackTypeFactor.UnitStatusWeaponAttackTypeUISet currentWeapon;

      [Token(Token = "0x600D805")]
      [Address(RVA = "0x1B8F5A0", Offset = "0x1B8F5A0", VA = "0x1B8F5A0")]
      public void SetActive(bool flag)
      {
      }

      [Token(Token = "0x600D806")]
      [Address(RVA = "0x1B8FB48", Offset = "0x1B8FB48", VA = "0x1B8FB48")]
      public UnitStatusWeaponAttackTypeUISetGroup()
      {
      }
    }

    [Token(Token = "0x2002362")]
    [Serializable]
    private class UnitStatusWeaponAttackTypeUISet
    {
      [Token(Token = "0x4009660")]
      [FieldOffset(Offset = "0x10")]
      public Text enhanceText;
      [Token(Token = "0x4009661")]
      [FieldOffset(Offset = "0x18")]
      public Text registText;

      [Token(Token = "0x600D807")]
      [Address(RVA = "0x1B8F77C", Offset = "0x1B8F77C", VA = "0x1B8F77C")]
      public void SetActive(bool flag)
      {
      }

      [Token(Token = "0x600D808")]
      [Address(RVA = "0x1B8F850", Offset = "0x1B8F850", VA = "0x1B8F850")]
      public void Set(
        int enhance,
        int regist,
        Color defaultColor,
        Color upColor,
        Color downColor)
      {
      }

      [Token(Token = "0x600D809")]
      [Address(RVA = "0x1B8FB50", Offset = "0x1B8FB50", VA = "0x1B8FB50")]
      public UnitStatusWeaponAttackTypeUISet()
      {
      }
    }
  }
}
