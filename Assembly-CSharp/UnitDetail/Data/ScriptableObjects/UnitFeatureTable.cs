// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.UnitFeatureTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004D3")]
  public class UnitFeatureTable : ScriptableObject
  {
    [Token(Token = "0x4001949")]
    private const string AssetRootPath = "Assets/Resources/Prefabs/DataTable/";
    [Token(Token = "0x400194A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("属性リスト")]
    private ElementTypeInfo[] elementList;
    [Token(Token = "0x400194B")]
    [FieldOffset(Offset = "0x20")]
    [Header("武器種リスト")]
    [SerializeField]
    private WeaponTypeInfo[] equipmentList;
    [Token(Token = "0x400194C")]
    [FieldOffset(Offset = "0x28")]
    [Header("種族リスト")]
    [SerializeField]
    private SpeciesTypeInfo[] speciesList;
    [Token(Token = "0x400194D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("移動タイプリスト")]
    private MoveTypeInfo[] moveTypeList;
    [Token(Token = "0x400194E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("装甲タイプリスト")]
    private ArmorTypeInfo[] armorTypeList;
    [Token(Token = "0x400194F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("乗降タイプリスト")]
    private RideTypeInfo[] rideTypeList;

    [Token(Token = "0x1700035B")]
    public static string AssetPath
    {
      [Token(Token = "0x6001B7A"), Address(RVA = "0x2C2C97C", Offset = "0x2C2C97C", VA = "0x2C2C97C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700035C")]
    public IReadOnlyList<ElementTypeInfo> ElementList
    {
      [Token(Token = "0x6001B7B"), Address(RVA = "0x2C2CA3C", Offset = "0x2C2CA3C", VA = "0x2C2CA3C")] get
      {
        return (IReadOnlyList<ElementTypeInfo>) null;
      }
    }

    [Token(Token = "0x1700035D")]
    public IReadOnlyList<WeaponTypeInfo> EquipementList
    {
      [Token(Token = "0x6001B7C"), Address(RVA = "0x2C2CA44", Offset = "0x2C2CA44", VA = "0x2C2CA44")] get
      {
        return (IReadOnlyList<WeaponTypeInfo>) null;
      }
    }

    [Token(Token = "0x1700035E")]
    public IReadOnlyList<SpeciesTypeInfo> SpeciesList
    {
      [Token(Token = "0x6001B7D"), Address(RVA = "0x2C2CA4C", Offset = "0x2C2CA4C", VA = "0x2C2CA4C")] get
      {
        return (IReadOnlyList<SpeciesTypeInfo>) null;
      }
    }

    [Token(Token = "0x1700035F")]
    public IReadOnlyList<MoveTypeInfo> MoveTypeList
    {
      [Token(Token = "0x6001B7E"), Address(RVA = "0x2C2CA54", Offset = "0x2C2CA54", VA = "0x2C2CA54")] get
      {
        return (IReadOnlyList<MoveTypeInfo>) null;
      }
    }

    [Token(Token = "0x17000360")]
    public IReadOnlyList<ArmorTypeInfo> ArmorTypeList
    {
      [Token(Token = "0x6001B7F"), Address(RVA = "0x2C2CA5C", Offset = "0x2C2CA5C", VA = "0x2C2CA5C")] get
      {
        return (IReadOnlyList<ArmorTypeInfo>) null;
      }
    }

    [Token(Token = "0x17000361")]
    public IReadOnlyList<RideTypeInfo> RideTypeList
    {
      [Token(Token = "0x6001B80"), Address(RVA = "0x2C2CA64", Offset = "0x2C2CA64", VA = "0x2C2CA64")] get
      {
        return (IReadOnlyList<RideTypeInfo>) null;
      }
    }

    [Token(Token = "0x6001B81")]
    [Address(RVA = "0x2C238C0", Offset = "0x2C238C0", VA = "0x2C238C0")]
    public ElementTypeInfo GetElement(ElementTypeEnum element) => (ElementTypeInfo) null;

    [Token(Token = "0x6001B82")]
    [Address(RVA = "0x2C2CA6C", Offset = "0x2C2CA6C", VA = "0x2C2CA6C")]
    public WeaponTypeInfo GetWeaponType(WeaponTypeEnum weaponType) => (WeaponTypeInfo) null;

    [Token(Token = "0x6001B83")]
    [Address(RVA = "0x2C2391C", Offset = "0x2C2391C", VA = "0x2C2391C")]
    public SpeciesTypeInfo GetSpecies(SpeciesTypeEnum species) => (SpeciesTypeInfo) null;

    [Token(Token = "0x6001B84")]
    [Address(RVA = "0x2C2CAC8", Offset = "0x2C2CAC8", VA = "0x2C2CAC8")]
    public MoveTypeInfo GetMoveType(MoveTypeEnum moveType) => (MoveTypeInfo) null;

    [Token(Token = "0x6001B85")]
    [Address(RVA = "0x2C2CB24", Offset = "0x2C2CB24", VA = "0x2C2CB24")]
    public ArmorTypeInfo GetArmorType(ArmorTypeEnum armorType) => (ArmorTypeInfo) null;

    [Token(Token = "0x6001B86")]
    [Address(RVA = "0x2C2CB80", Offset = "0x2C2CB80", VA = "0x2C2CB80")]
    public RideTypeInfo GetRideType(RideTypeEnum rideType) => (RideTypeInfo) null;

    [Token(Token = "0x6001B87")]
    public FeatureBase GetFeature<TEnum>(TEnum feature) where TEnum : Enum => (FeatureBase) null;

    [Token(Token = "0x6001B88")]
    [Address(RVA = "0x2C2CBDC", Offset = "0x2C2CBDC", VA = "0x2C2CBDC")]
    public UnitFeatureTable()
    {
    }
  }
}
