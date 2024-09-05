// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestRewardsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001310")]
  [Serializable]
  public sealed class StorySubquestRewardsMaster : BaseMaster<StorySubquestRewardsData>
  {
    [Token(Token = "0x4005A28")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StorySubquestRewardsData>> groupingTable;
    [Token(Token = "0x4005A29")]
    [FieldOffset(Offset = "0x20")]
    private readonly List<StorySubquestRewardsData> defaultList;

    [Token(Token = "0x6006BAC")]
    [Address(RVA = "0x48E43B8", Offset = "0x48E43B8", VA = "0x48E43B8")]
    public IReadOnlyDictionary<int, StorySubquestRewardsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestRewardsData>) null;
    }

    [Token(Token = "0x6006BAD")]
    [Address(RVA = "0x48E43C0", Offset = "0x48E43C0", VA = "0x48E43C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006BAE")]
    [Address(RVA = "0x48E4484", Offset = "0x48E4484", VA = "0x48E4484", Slot = "5")]
    protected override StorySubquestRewardsData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestRewardsData) null;
    }

    [Token(Token = "0x6006BAF")]
    [Address(RVA = "0x48E4428", Offset = "0x48E4428", VA = "0x48E4428")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006BB0")]
    [Address(RVA = "0x48E44F4", Offset = "0x48E44F4", VA = "0x48E44F4")]
    private void OnLoadEntity(StorySubquestRewardsData entity)
    {
    }

    [Token(Token = "0x6006BB1")]
    [Address(RVA = "0x48E44F8", Offset = "0x48E44F8", VA = "0x48E44F8")]
    private void Grouping(StorySubquestRewardsData entity)
    {
    }

    [Token(Token = "0x6006BB2")]
    [Address(RVA = "0x48E4674", Offset = "0x48E4674", VA = "0x48E4674")]
    public IReadOnlyCollection<StorySubquestRewardsData> GetListBySubquestID(int subquestID)
    {
      return (IReadOnlyCollection<StorySubquestRewardsData>) null;
    }

    [Token(Token = "0x6006BB3")]
    [Address(RVA = "0x48E46F4", Offset = "0x48E46F4", VA = "0x48E46F4")]
    public StorySubquestRewardsMaster()
    {
    }
  }
}
