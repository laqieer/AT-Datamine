// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitDetailInfoFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnitDetail.Data.ScriptableObjects;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x200049E")]
  public class UnitDetailInfoFactory
  {
    [Token(Token = "0x400187B")]
    [FieldOffset(Offset = "0x10")]
    private UnitFeatureTable table;

    [Token(Token = "0x60019D5")]
    [Address(RVA = "0x2C2354C", Offset = "0x2C2354C", VA = "0x2C2354C")]
    public UnitDetailInfoFactory(UnitFeatureTable table)
    {
    }

    [Token(Token = "0x60019D6")]
    [Address(RVA = "0x2C23574", Offset = "0x2C23574", VA = "0x2C23574")]
    public UnitDetailInfo Create(Style style) => (UnitDetailInfo) null;

    [Token(Token = "0x60019D7")]
    [Address(RVA = "0x2C23D18", Offset = "0x2C23D18", VA = "0x2C23D18")]
    public List<UnitDetailInfo> Create(IEnumerable<Style> styleList) => (List<UnitDetailInfo>) null;

    [Token(Token = "0x60019D8")]
    [Address(RVA = "0x2C23978", Offset = "0x2C23978", VA = "0x2C23978")]
    private Dictionary<UnitDetailInfo.AssetTypeEnum, UnitDetailInfo.AssetInfo> CreateAssetDic(
      Style style)
    {
      return (Dictionary<UnitDetailInfo.AssetTypeEnum, UnitDetailInfo.AssetInfo>) null;
    }

    [Token(Token = "0x60019D9")]
    [Address(RVA = "0x2C23B70", Offset = "0x2C23B70", VA = "0x2C23B70")]
    private void CreateSpecialEffect(
      Style style,
      out List<UnitDetailInfo.SpecialInfo> specialAttackList,
      out List<UnitDetailInfo.SpecialInfo> specialDefenceList)
    {
    }

    [Token(Token = "0x60019DA")]
    private IEnumerable<UnitDetailInfo.SpecialInfo> CreateSpecialEffect<TEnum>(
      FeatureWraper<TEnum, int> wraper)
      where TEnum : Enum
    {
      return (IEnumerable<UnitDetailInfo.SpecialInfo>) null;
    }
  }
}
