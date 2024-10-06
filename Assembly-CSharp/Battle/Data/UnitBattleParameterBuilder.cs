// Decompiled with JetBrains decompiler
// Type: Battle.Data.UnitBattleParameterBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200271F")]
  public class UnitBattleParameterBuilder
  {
    [Token(Token = "0x400A74F")]
    [FieldOffset(Offset = "0x10")]
    private BattleLogicConstData logicConst;
    [Token(Token = "0x400A750")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<ICorrectableParameter<IBasicParameter>> basicParamRef;
    [Token(Token = "0x400A751")]
    [FieldOffset(Offset = "0x20")]
    private WeakReference<UnitParameterData> unitParamRef;
    [Token(Token = "0x400A752")]
    [FieldOffset(Offset = "0x28")]
    private WeakReference<WeaponParameterData> weaponParamRef;
    [Token(Token = "0x400A753")]
    [FieldOffset(Offset = "0x30")]
    private List<WeakReference<AccessoryData>> accessoryRefs;
    [Token(Token = "0x400A754")]
    [FieldOffset(Offset = "0x38")]
    private List<WeakReference<Battle.Data.Board.MindEquipmentData>> mindEquipRefs;
    [Token(Token = "0x400A755")]
    [FieldOffset(Offset = "0x40")]
    private List<WeakReference<Battle.Data.Board.TrustData>> trustRefs;
    [Token(Token = "0x400A756")]
    [FieldOffset(Offset = "0x48")]
    private WeakReference<UnitParameterData> targetUnitRef;
    [Token(Token = "0x400A757")]
    [FieldOffset(Offset = "0x50")]
    private bool isCalculateHPFromParam;

    [Token(Token = "0x170033C1")]
    private ICorrectableParameter<IBasicParameter> BasicParam
    {
      [Token(Token = "0x600F313"), Address(RVA = "0x1F9C9AC", Offset = "0x1F9C9AC", VA = "0x1F9C9AC")] get
      {
        return (ICorrectableParameter<IBasicParameter>) null;
      }
    }

    [Token(Token = "0x170033C2")]
    private UnitParameterData UnitParam
    {
      [Token(Token = "0x600F314"), Address(RVA = "0x1F9CA10", Offset = "0x1F9CA10", VA = "0x1F9CA10")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x170033C3")]
    private WeaponParameterData WeaponParam
    {
      [Token(Token = "0x600F315"), Address(RVA = "0x1F9CA74", Offset = "0x1F9CA74", VA = "0x1F9CA74")] get
      {
        return (WeaponParameterData) null;
      }
    }

    [Token(Token = "0x170033C4")]
    private IReadOnlyList<AccessoryData> Accessories
    {
      [Token(Token = "0x600F316"), Address(RVA = "0x1F9CAD8", Offset = "0x1F9CAD8", VA = "0x1F9CAD8")] get
      {
        return (IReadOnlyList<AccessoryData>) null;
      }
    }

    [Token(Token = "0x170033C5")]
    private IReadOnlyList<Battle.Data.Board.MindEquipmentData> MindEquipments
    {
      [Token(Token = "0x600F317"), Address(RVA = "0x1F9CC7C", Offset = "0x1F9CC7C", VA = "0x1F9CC7C")] get
      {
        return (IReadOnlyList<Battle.Data.Board.MindEquipmentData>) null;
      }
    }

    [Token(Token = "0x170033C6")]
    private IReadOnlyList<Battle.Data.Board.TrustData> Trusts
    {
      [Token(Token = "0x600F318"), Address(RVA = "0x1F9CE20", Offset = "0x1F9CE20", VA = "0x1F9CE20")] get
      {
        return (IReadOnlyList<Battle.Data.Board.TrustData>) null;
      }
    }

    [Token(Token = "0x170033C7")]
    private UnitParameterData TargetUnit
    {
      [Token(Token = "0x600F319"), Address(RVA = "0x1F9CFC4", Offset = "0x1F9CFC4", VA = "0x1F9CFC4")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x600F31A")]
    [Address(RVA = "0x1F9D028", Offset = "0x1F9D028", VA = "0x1F9D028")]
    public UnitBattleParameterBuilder()
    {
    }

    [Token(Token = "0x600F31B")]
    [Address(RVA = "0x1F9D194", Offset = "0x1F9D194", VA = "0x1F9D194")]
    public UnitBattleParameterBuilder SetBasicParam(
      ICorrectableParameter<IBasicParameter> basicParam)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F31C")]
    [Address(RVA = "0x1F9D21C", Offset = "0x1F9D21C", VA = "0x1F9D21C")]
    public UnitBattleParameterBuilder SetUnitParameter(UnitParameterData unitParam)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F31D")]
    [Address(RVA = "0x1F9D2A4", Offset = "0x1F9D2A4", VA = "0x1F9D2A4")]
    public UnitBattleParameterBuilder SetWeaponParameter(WeaponParameterData weapon)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F31E")]
    [Address(RVA = "0x1F9D32C", Offset = "0x1F9D32C", VA = "0x1F9D32C")]
    public UnitBattleParameterBuilder AddAccessory(AccessoryData accessory)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F31F")]
    [Address(RVA = "0x1F9D424", Offset = "0x1F9D424", VA = "0x1F9D424")]
    public UnitBattleParameterBuilder AddAccessories(IReadOnlyList<AccessoryData> accessories)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F320")]
    [Address(RVA = "0x1F9D6F8", Offset = "0x1F9D6F8", VA = "0x1F9D6F8")]
    public UnitBattleParameterBuilder AddMindEquipment(Battle.Data.Board.MindEquipmentData mindEquipment)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F321")]
    [Address(RVA = "0x1F9D7F0", Offset = "0x1F9D7F0", VA = "0x1F9D7F0")]
    public UnitBattleParameterBuilder AddMindEquipments(
      IReadOnlyList<Battle.Data.Board.MindEquipmentData> mindEquipments)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F322")]
    [Address(RVA = "0x1F9DAC4", Offset = "0x1F9DAC4", VA = "0x1F9DAC4")]
    public UnitBattleParameterBuilder ResetMindEquipments() => (UnitBattleParameterBuilder) null;

    [Token(Token = "0x600F323")]
    [Address(RVA = "0x1F9DB30", Offset = "0x1F9DB30", VA = "0x1F9DB30")]
    public UnitBattleParameterBuilder AddTrust(Battle.Data.Board.TrustData trust)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F324")]
    [Address(RVA = "0x1F9DC28", Offset = "0x1F9DC28", VA = "0x1F9DC28")]
    public UnitBattleParameterBuilder AddTrusts(IReadOnlyList<Battle.Data.Board.TrustData> trusts)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F325")]
    [Address(RVA = "0x1F9DEFC", Offset = "0x1F9DEFC", VA = "0x1F9DEFC")]
    public UnitBattleParameterBuilder ResetTrusts() => (UnitBattleParameterBuilder) null;

    [Token(Token = "0x600F326")]
    [Address(RVA = "0x1F9DF68", Offset = "0x1F9DF68", VA = "0x1F9DF68")]
    public UnitBattleParameterBuilder SetTargetUnit(UnitParameterData target)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F327")]
    [Address(RVA = "0x1F9DFF0", Offset = "0x1F9DFF0", VA = "0x1F9DFF0")]
    public UnitBattleParameterBuilder SetOptionCalculateHPFromParam(bool isEnable)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F328")]
    [Address(RVA = "0x1F9DFFC", Offset = "0x1F9DFFC", VA = "0x1F9DFFC")]
    public UnitBattleParameterBuilder Reset() => (UnitBattleParameterBuilder) null;

    [Token(Token = "0x600F329")]
    [Address(RVA = "0x1F9E018", Offset = "0x1F9E018", VA = "0x1F9E018")]
    public ICorrectableParameter<IBattleParameter> Build()
    {
      return (ICorrectableParameter<IBattleParameter>) null;
    }

    [Token(Token = "0x600F32A")]
    [Address(RVA = "0x1F9E130", Offset = "0x1F9E130", VA = "0x1F9E130")]
    private void GenerateBasicParam(out CorrectableBasicParameter correctableBasic)
    {
    }

    [Token(Token = "0x600F32B")]
    [Address(RVA = "0x1F9E21C", Offset = "0x1F9E21C", VA = "0x1F9E21C")]
    private void GenerateBaseBattleParam(
      CorrectableBasicParameter correctableBasic,
      out BattleParameter baseParam)
    {
    }

    [Token(Token = "0x600F32C")]
    [Address(RVA = "0x1F9EC1C", Offset = "0x1F9EC1C", VA = "0x1F9EC1C")]
    private void AddUnitModifierOffsets(
      ref BattleParameter fixedOffset,
      ref BattleParameter ratedOffset)
    {
    }

    [Token(Token = "0x600F32D")]
    [Address(RVA = "0x1F9F970", Offset = "0x1F9F970", VA = "0x1F9F970")]
    private (int, int) CalcModifier(BattleParameterType paramType) => ();

    [Token(Token = "0x600F32E")]
    [Address(RVA = "0x1F9E334", Offset = "0x1F9E334", VA = "0x1F9E334")]
    private void AddProficiencyPlus(ref BattleParameter offset)
    {
    }

    [Token(Token = "0x600F32F")]
    [Address(RVA = "0x1F9E3C0", Offset = "0x1F9E3C0", VA = "0x1F9E3C0")]
    private void AddWeaponOffsets(ref BattleParameter offset)
    {
    }

    [Token(Token = "0x600F330")]
    [Address(RVA = "0x1F9E8D4", Offset = "0x1F9E8D4", VA = "0x1F9E8D4")]
    private void AddAccessoryOffsets(ref BattleParameter offset)
    {
    }

    [Token(Token = "0x600F331")]
    [Address(RVA = "0x1F9E9EC", Offset = "0x1F9E9EC", VA = "0x1F9E9EC")]
    private void AddMindEquipmentOffsets(ref BattleParameter offset)
    {
    }

    [Token(Token = "0x600F332")]
    [Address(RVA = "0x1F9EB04", Offset = "0x1F9EB04", VA = "0x1F9EB04")]
    private void AddTrustOffsets(ref BattleParameter offset)
    {
    }

    [Token(Token = "0x600F333")]
    [Address(RVA = "0x1F9EDD8", Offset = "0x1F9EDD8", VA = "0x1F9EDD8")]
    private void AddLoadWeightOffsets(
      in CorrectableBasicParameter basicParam,
      ref BattleParameter offset)
    {
    }

    [Token(Token = "0x600F334")]
    [Address(RVA = "0x1F9FAA4", Offset = "0x1F9FAA4", VA = "0x1F9FAA4")]
    private WeaponProficiencyPlusData GetWeaponProficiencyPlus(WeaponTypeEnum weaponType)
    {
      return (WeaponProficiencyPlusData) null;
    }

    [Token(Token = "0x600F335")]
    [Address(RVA = "0x1F9FC64", Offset = "0x1F9FC64", VA = "0x1F9FC64")]
    private WeaponRarityAptitudeDescriptionData GetWeaponRarityAptitude(
      WeaponParameterData weaponParam)
    {
      return (WeaponRarityAptitudeDescriptionData) null;
    }

    [Token(Token = "0x600F336")]
    [Address(RVA = "0x1F9FF94", Offset = "0x1F9FF94", VA = "0x1F9FF94")]
    public UnitBattleParameterBuilder SetTemplateBuilder(UnitParameterData unit)
    {
      return (UnitBattleParameterBuilder) null;
    }

    [Token(Token = "0x600F337")]
    [Address(RVA = "0x1FA0048", Offset = "0x1FA0048", VA = "0x1FA0048")]
    public static UnitBattleParameterBuilder CreateTemplateBuilder(UnitParameterData unit)
    {
      return (UnitBattleParameterBuilder) null;
    }
  }
}
