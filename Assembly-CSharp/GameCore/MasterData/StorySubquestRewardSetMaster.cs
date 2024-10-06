// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestRewardSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200130E")]
  [Serializable]
  public sealed class StorySubquestRewardSetMaster : BaseMaster<StorySubquestRewardSetData>
  {
    [Token(Token = "0x4005A21")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StorySubquestRewardSetData>> groupingTable;
    [Token(Token = "0x4005A22")]
    [FieldOffset(Offset = "0x20")]
    private readonly List<StorySubquestRewardSetData> defaultList;

    [Token(Token = "0x6006B9E")]
    [Address(RVA = "0x48E3C80", Offset = "0x48E3C80", VA = "0x48E3C80")]
    public IReadOnlyDictionary<int, StorySubquestRewardSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestRewardSetData>) null;
    }

    [Token(Token = "0x6006B9F")]
    [Address(RVA = "0x48E3C88", Offset = "0x48E3C88", VA = "0x48E3C88", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006BA0")]
    [Address(RVA = "0x48E3D4C", Offset = "0x48E3D4C", VA = "0x48E3D4C", Slot = "5")]
    protected override StorySubquestRewardSetData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestRewardSetData) null;
    }

    [Token(Token = "0x6006BA1")]
    [Address(RVA = "0x48E3CF0", Offset = "0x48E3CF0", VA = "0x48E3CF0")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006BA2")]
    [Address(RVA = "0x48E3DBC", Offset = "0x48E3DBC", VA = "0x48E3DBC")]
    private void OnLoadEntity(StorySubquestRewardSetData entity)
    {
    }

    [Token(Token = "0x6006BA3")]
    [Address(RVA = "0x48E3DC0", Offset = "0x48E3DC0", VA = "0x48E3DC0")]
    private void Grouping(StorySubquestRewardSetData entity)
    {
    }

    [Token(Token = "0x6006BA4")]
    [Address(RVA = "0x48E3F3C", Offset = "0x48E3F3C", VA = "0x48E3F3C")]
    public IReadOnlyCollection<StorySubquestRewardSetData> GetListByRewardSetLabel(
      int rewardSetLabel)
    {
      return (IReadOnlyCollection<StorySubquestRewardSetData>) null;
    }

    [Token(Token = "0x6006BA5")]
    [Address(RVA = "0x48E3FBC", Offset = "0x48E3FBC", VA = "0x48E3FBC")]
    public StorySubquestRewardSetMaster()
    {
    }
  }
}
