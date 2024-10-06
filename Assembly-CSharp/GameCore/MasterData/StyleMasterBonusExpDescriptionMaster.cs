// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMasterBonusExpDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010CD")]
  [Serializable]
  public sealed class StyleMasterBonusExpDescriptionMaster : 
    BaseMaster<StyleMasterBonusExpDescriptionData>
  {
    [Token(Token = "0x4005274")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StyleMasterBonusExpDescriptionData>> descriptionTable;

    [Token(Token = "0x600611B")]
    [Address(RVA = "0x28DD7F8", Offset = "0x28DD7F8", VA = "0x28DD7F8")]
    public IReadOnlyDictionary<int, StyleMasterBonusExpDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleMasterBonusExpDescriptionData>) null;
    }

    [Token(Token = "0x600611C")]
    [Address(RVA = "0x28DD800", Offset = "0x28DD800", VA = "0x28DD800", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600611D")]
    [Address(RVA = "0x28DDAC4", Offset = "0x28DDAC4", VA = "0x28DDAC4", Slot = "5")]
    protected override StyleMasterBonusExpDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (StyleMasterBonusExpDescriptionData) null;
    }

    [Token(Token = "0x600611E")]
    [Address(RVA = "0x28DDB34", Offset = "0x28DDB34", VA = "0x28DDB34")]
    private void OnLoadEntity(StyleMasterBonusExpDescriptionData entity)
    {
    }

    [Token(Token = "0x600611F")]
    [Address(RVA = "0x28DD868", Offset = "0x28DD868", VA = "0x28DD868")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006120")]
    [Address(RVA = "0x28DDB38", Offset = "0x28DDB38", VA = "0x28DDB38")]
    private void GroupingByStyleMasterExpId(StyleMasterBonusExpDescriptionData entity)
    {
    }

    [Token(Token = "0x6006121")]
    [Address(RVA = "0x28DDCF4", Offset = "0x28DDCF4", VA = "0x28DDCF4")]
    public IReadOnlyList<StyleMasterBonusExpDescriptionData> GetListByStyleMasterExpId(
      int styleMasterExpId)
    {
      return (IReadOnlyList<StyleMasterBonusExpDescriptionData>) null;
    }

    [Token(Token = "0x6006122")]
    [Address(RVA = "0x28DDDB0", Offset = "0x28DDDB0", VA = "0x28DDDB0")]
    public StyleMasterBonusExpDescriptionData GetDataByStyleMasterExpIdLevelPair(
      int styleMasterExpId,
      int level)
    {
      return (StyleMasterBonusExpDescriptionData) null;
    }

    [Token(Token = "0x6006123")]
    [Address(RVA = "0x28DE0D4", Offset = "0x28DE0D4", VA = "0x28DE0D4")]
    public StyleMasterBonusExpDescriptionData GetDataByStyleMasterExpIdExpPair(
      int styleMasterExpId,
      int exp)
    {
      return (StyleMasterBonusExpDescriptionData) null;
    }

    [Token(Token = "0x6006124")]
    [Address(RVA = "0x28DE4FC", Offset = "0x28DE4FC", VA = "0x28DE4FC")]
    public StyleMasterBonusExpDescriptionMaster()
    {
    }
  }
}
