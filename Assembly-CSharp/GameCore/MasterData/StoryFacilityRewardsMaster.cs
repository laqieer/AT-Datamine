// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityRewardsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200122B")]
  [Serializable]
  public sealed class StoryFacilityRewardsMaster : BaseMaster<StoryFacilityRewardsData>
  {
    [Token(Token = "0x40056DD")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<StoryFacilityRewardsData> groupTable;

    [Token(Token = "0x600677E")]
    [Address(RVA = "0x4D300B0", Offset = "0x4D300B0", VA = "0x4D300B0")]
    public IReadOnlyDictionary<int, StoryFacilityRewardsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityRewardsData>) null;
    }

    [Token(Token = "0x600677F")]
    [Address(RVA = "0x4D300B8", Offset = "0x4D300B8", VA = "0x4D300B8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006780")]
    [Address(RVA = "0x4D30224", Offset = "0x4D30224", VA = "0x4D30224", Slot = "5")]
    protected override StoryFacilityRewardsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityRewardsData) null;
    }

    [Token(Token = "0x6006781")]
    [Address(RVA = "0x4D30120", Offset = "0x4D30120", VA = "0x4D30120")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006782")]
    [Address(RVA = "0x4D30294", Offset = "0x4D30294", VA = "0x4D30294")]
    private void OnLoadEntity(StoryFacilityRewardsData entity)
    {
    }

    [Token(Token = "0x6006783")]
    [Address(RVA = "0x4D302EC", Offset = "0x4D302EC", VA = "0x4D302EC")]
    public List<StoryFacilityRewardsData> GetList(int key) => (List<StoryFacilityRewardsData>) null;

    [Token(Token = "0x6006784")]
    [Address(RVA = "0x4D30344", Offset = "0x4D30344", VA = "0x4D30344")]
    public StoryFacilityRewardsMaster()
    {
    }
  }
}
