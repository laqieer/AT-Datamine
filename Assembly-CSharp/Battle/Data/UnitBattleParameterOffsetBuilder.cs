// Decompiled with JetBrains decompiler
// Type: Battle.Data.UnitBattleParameterOffsetBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002722")]
  public class UnitBattleParameterOffsetBuilder
  {
    [Token(Token = "0x400A75D")]
    [FieldOffset(Offset = "0x10")]
    private BattleLogicConstData logicConst;
    [Token(Token = "0x400A75E")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<UnitParameterData> unitParamRef;
    [Token(Token = "0x400A75F")]
    [FieldOffset(Offset = "0x20")]
    private WeakReference<UnitParameterData> backUnitParamRef;
    [Token(Token = "0x400A760")]
    [FieldOffset(Offset = "0x28")]
    private WeakReference<SupportRankData> supportRankRef;
    [Token(Token = "0x400A761")]
    [FieldOffset(Offset = "0x30")]
    private WeakReference<WeaponParameterData> weaponParamRef;
    [Token(Token = "0x400A762")]
    [FieldOffset(Offset = "0x38")]
    private WeakReference<WeaponParameterData> backWeaponParamRef;

    [Token(Token = "0x170033C8")]
    private UnitParameterData UnitParam
    {
      [Token(Token = "0x600F33D"), Address(RVA = "0x1FA0144", Offset = "0x1FA0144", VA = "0x1FA0144")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x170033C9")]
    private UnitParameterData BackUnitParam
    {
      [Token(Token = "0x600F33E"), Address(RVA = "0x1FA01A8", Offset = "0x1FA01A8", VA = "0x1FA01A8")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x170033CA")]
    private SupportRankData SupportRank
    {
      [Token(Token = "0x600F33F"), Address(RVA = "0x1FA020C", Offset = "0x1FA020C", VA = "0x1FA020C")] get
      {
        return (SupportRankData) null;
      }
    }

    [Token(Token = "0x170033CB")]
    private WeaponParameterData WeaponParam
    {
      [Token(Token = "0x600F340"), Address(RVA = "0x1FA0270", Offset = "0x1FA0270", VA = "0x1FA0270")] get
      {
        return (WeaponParameterData) null;
      }
    }

    [Token(Token = "0x170033CC")]
    private WeaponParameterData BackWeaponParam
    {
      [Token(Token = "0x600F341"), Address(RVA = "0x1FA02D4", Offset = "0x1FA02D4", VA = "0x1FA02D4")] get
      {
        return (WeaponParameterData) null;
      }
    }

    [Token(Token = "0x600F342")]
    [Address(RVA = "0x1FA0338", Offset = "0x1FA0338", VA = "0x1FA0338")]
    public UnitBattleParameterOffsetBuilder()
    {
    }

    [Token(Token = "0x600F343")]
    [Address(RVA = "0x1FA03D0", Offset = "0x1FA03D0", VA = "0x1FA03D0")]
    public UnitBattleParameterOffsetBuilder SetUnitParameter(UnitParameterData unitParam)
    {
      return (UnitBattleParameterOffsetBuilder) null;
    }

    [Token(Token = "0x600F344")]
    [Address(RVA = "0x1FA04F4", Offset = "0x1FA04F4", VA = "0x1FA04F4")]
    public UnitBattleParameterOffsetBuilder SetBackUnitParameter(UnitParameterData unitParam)
    {
      return (UnitBattleParameterOffsetBuilder) null;
    }

    [Token(Token = "0x600F345")]
    [Address(RVA = "0x1FA0618", Offset = "0x1FA0618", VA = "0x1FA0618")]
    private UnitBattleParameterOffsetBuilder SetSupport(SupportRankData support)
    {
      return (UnitBattleParameterOffsetBuilder) null;
    }

    [Token(Token = "0x600F346")]
    [Address(RVA = "0x1FA046C", Offset = "0x1FA046C", VA = "0x1FA046C")]
    private UnitBattleParameterOffsetBuilder SetWeaponParameter(WeaponParameterData weaponParam)
    {
      return (UnitBattleParameterOffsetBuilder) null;
    }

    [Token(Token = "0x600F347")]
    [Address(RVA = "0x1FA0590", Offset = "0x1FA0590", VA = "0x1FA0590")]
    private UnitBattleParameterOffsetBuilder SetBackWeaponParameter(WeaponParameterData weaponParam)
    {
      return (UnitBattleParameterOffsetBuilder) null;
    }

    [Token(Token = "0x600F348")]
    [Address(RVA = "0x1FA06A0", Offset = "0x1FA06A0", VA = "0x1FA06A0")]
    public UnitBattleParameterOffsetBuilder Reset() => (UnitBattleParameterOffsetBuilder) null;

    [Token(Token = "0x600F349")]
    [Address(RVA = "0x1FA06B4", Offset = "0x1FA06B4", VA = "0x1FA06B4")]
    public ICorrectableParameter<IBattleParameter> Build()
    {
      return (ICorrectableParameter<IBattleParameter>) null;
    }

    [Token(Token = "0x600F34A")]
    [Address(RVA = "0x1FA0768", Offset = "0x1FA0768", VA = "0x1FA0768")]
    private void AddUnitParameterOffsets(ref BattleParameter fixedOffset)
    {
    }

    [Token(Token = "0x600F34B")]
    [Address(RVA = "0x1FA0AD8", Offset = "0x1FA0AD8", VA = "0x1FA0AD8")]
    private void AddBackUnitParameterOffsets(ref BattleParameter fixedOffset)
    {
    }

    [Token(Token = "0x600F34C")]
    [Address(RVA = "0x1FA15F4", Offset = "0x1FA15F4", VA = "0x1FA15F4")]
    public static UnitBattleParameterOffsetBuilder CreateTemplateBuilder(
      UnitParameterData unit,
      BattlePlayerData owner)
    {
      return (UnitBattleParameterOffsetBuilder) null;
    }

    [Token(Token = "0x600F34D")]
    [Address(RVA = "0x1FA16CC", Offset = "0x1FA16CC", VA = "0x1FA16CC")]
    public static UnitBattleParameterOffsetBuilder CreateTemplateBuilder(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      BattlePlayerData owner)
    {
      return (UnitBattleParameterOffsetBuilder) null;
    }
  }
}
