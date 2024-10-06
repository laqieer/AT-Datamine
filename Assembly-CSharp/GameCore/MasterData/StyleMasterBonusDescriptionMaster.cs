// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMasterBonusDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010CA")]
  [Serializable]
  public sealed class StyleMasterBonusDescriptionMaster : BaseMaster<StyleMasterBonusDescriptionData>
  {
    [Token(Token = "0x4005265")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StyleMasterBonusDescriptionData>> descriptionTable;

    [Token(Token = "0x600610B")]
    [Address(RVA = "0x28DC7F8", Offset = "0x28DC7F8", VA = "0x28DC7F8")]
    public IReadOnlyDictionary<int, StyleMasterBonusDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleMasterBonusDescriptionData>) null;
    }

    [Token(Token = "0x600610C")]
    [Address(RVA = "0x28DC800", Offset = "0x28DC800", VA = "0x28DC800", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600610D")]
    [Address(RVA = "0x28DCAC4", Offset = "0x28DCAC4", VA = "0x28DCAC4", Slot = "5")]
    protected override StyleMasterBonusDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (StyleMasterBonusDescriptionData) null;
    }

    [Token(Token = "0x600610E")]
    [Address(RVA = "0x28DCB34", Offset = "0x28DCB34", VA = "0x28DCB34")]
    private void OnLoadEntity(StyleMasterBonusDescriptionData entity)
    {
    }

    [Token(Token = "0x600610F")]
    [Address(RVA = "0x28DC868", Offset = "0x28DC868", VA = "0x28DC868")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006110")]
    [Address(RVA = "0x28DCB38", Offset = "0x28DCB38", VA = "0x28DCB38")]
    private void GroupingByStyleMasterExpId(StyleMasterBonusDescriptionData entity)
    {
    }

    [Token(Token = "0x6006111")]
    [Address(RVA = "0x28DCCF4", Offset = "0x28DCCF4", VA = "0x28DCCF4")]
    public IReadOnlyList<StyleMasterBonusDescriptionData> GetListByStyleMasterExpId(
      int styleMasterBonusCategoryId)
    {
      return (IReadOnlyList<StyleMasterBonusDescriptionData>) null;
    }

    [Token(Token = "0x6006112")]
    [Address(RVA = "0x28DCDB0", Offset = "0x28DCDB0", VA = "0x28DCDB0")]
    public StyleMasterBonusDescriptionData GetDataByStyleMasterExpIdLevelPair(
      int styleMasterExpId,
      int level)
    {
      return (StyleMasterBonusDescriptionData) null;
    }

    [Token(Token = "0x6006113")]
    [Address(RVA = "0x28DD0D4", Offset = "0x28DD0D4", VA = "0x28DD0D4")]
    public StyleMasterBonusDescriptionMaster()
    {
    }
  }
}
