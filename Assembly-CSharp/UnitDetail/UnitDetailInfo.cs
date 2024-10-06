// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitDetailInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnitDetail.Data.ScriptableObjects;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x200049A")]
  public class UnitDetailInfo
  {
    [Token(Token = "0x400186B")]
    [FieldOffset(Offset = "0x10")]
    private ReadOnlyDictionary<UnitDetailInfo.AssetTypeEnum, UnitDetailInfo.AssetInfo> assetDic;

    [Token(Token = "0x1700031F")]
    public Style Style
    {
      [Token(Token = "0x60019CB"), Address(RVA = "0x2C2344C", Offset = "0x2C2344C", VA = "0x2C2344C")] get
      {
        return (Style) null;
      }
      [Token(Token = "0x60019CC"), Address(RVA = "0x2C23454", Offset = "0x2C23454", VA = "0x2C23454")] private set
      {
      }
    }

    [Token(Token = "0x17000320")]
    public FeatureBase[] Features
    {
      [Token(Token = "0x60019CD"), Address(RVA = "0x2C2345C", Offset = "0x2C2345C", VA = "0x2C2345C")] get
      {
        return (FeatureBase[]) null;
      }
      [Token(Token = "0x60019CE"), Address(RVA = "0x2C23464", Offset = "0x2C23464", VA = "0x2C23464")] private set
      {
      }
    }

    [Token(Token = "0x17000321")]
    public ReadOnlyDictionary<UnitDetailInfo.AssetTypeEnum, UnitDetailInfo.AssetInfo> AssetDic
    {
      [Token(Token = "0x60019CF"), Address(RVA = "0x2C2346C", Offset = "0x2C2346C", VA = "0x2C2346C")] get
      {
        return (ReadOnlyDictionary<UnitDetailInfo.AssetTypeEnum, UnitDetailInfo.AssetInfo>) null;
      }
    }

    [Token(Token = "0x17000322")]
    public List<UnitDetailInfo.SpecialInfo> SpecialAttack
    {
      [Token(Token = "0x60019D0"), Address(RVA = "0x2C23474", Offset = "0x2C23474", VA = "0x2C23474")] get
      {
        return (List<UnitDetailInfo.SpecialInfo>) null;
      }
      [Token(Token = "0x60019D1"), Address(RVA = "0x2C2347C", Offset = "0x2C2347C", VA = "0x2C2347C")] private set
      {
      }
    }

    [Token(Token = "0x17000323")]
    public List<UnitDetailInfo.SpecialInfo> SpecialDefence
    {
      [Token(Token = "0x60019D2"), Address(RVA = "0x2C23484", Offset = "0x2C23484", VA = "0x2C23484")] get
      {
        return (List<UnitDetailInfo.SpecialInfo>) null;
      }
      [Token(Token = "0x60019D3"), Address(RVA = "0x2C2348C", Offset = "0x2C2348C", VA = "0x2C2348C")] private set
      {
      }
    }

    [Token(Token = "0x60019D4")]
    [Address(RVA = "0x2C23494", Offset = "0x2C23494", VA = "0x2C23494")]
    public UnitDetailInfo(
      Style style,
      FeatureBase[] features,
      Dictionary<UnitDetailInfo.AssetTypeEnum, UnitDetailInfo.AssetInfo> assetDic,
      List<UnitDetailInfo.SpecialInfo> specialAttack,
      List<UnitDetailInfo.SpecialInfo> specialDefence)
    {
    }

    [Token(Token = "0x200049B")]
    public enum AssetTypeEnum
    {
      [Token(Token = "0x4001871")] UnitImage,
      [Token(Token = "0x4001872")] UnitModel,
      [Token(Token = "0x4001873")] RideModel,
      [Token(Token = "0x4001874")] DotModel,
      [Token(Token = "0x4001875")] EmblemImage,
      [Token(Token = "0x4001876")] SpriteAtlas,
    }

    [Token(Token = "0x200049C")]
    public struct AssetInfo
    {
      [Token(Token = "0x4001877")]
      [FieldOffset(Offset = "0x0")]
      public string assetBundleName;
      [Token(Token = "0x4001878")]
      [FieldOffset(Offset = "0x8")]
      public string assetName;
    }

    [Token(Token = "0x200049D")]
    public struct SpecialInfo
    {
      [Token(Token = "0x4001879")]
      [FieldOffset(Offset = "0x0")]
      public FeatureBase featureBase;
      [Token(Token = "0x400187A")]
      [FieldOffset(Offset = "0x8")]
      public int value;
    }
  }
}
