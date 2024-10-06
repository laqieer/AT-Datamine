// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableSpawnPatternMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011D2")]
  [Serializable]
  public sealed class StoryAreaMovableSpawnPatternMaster : 
    BaseMaster<StoryAreaMovableSpawnPatternData>
  {
    [Token(Token = "0x40055AC")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryAreaMovableSpawnPatternData>> groupDic;

    [Token(Token = "0x60065F4")]
    [Address(RVA = "0x4D20C84", Offset = "0x4D20C84", VA = "0x4D20C84")]
    public IReadOnlyDictionary<int, StoryAreaMovableSpawnPatternData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaMovableSpawnPatternData>) null;
    }

    [Token(Token = "0x60065F5")]
    [Address(RVA = "0x4D20C8C", Offset = "0x4D20C8C", VA = "0x4D20C8C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065F6")]
    [Address(RVA = "0x4D20D44", Offset = "0x4D20D44", VA = "0x4D20D44", Slot = "5")]
    protected override StoryAreaMovableSpawnPatternData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaMovableSpawnPatternData) null;
    }

    [Token(Token = "0x60065F7")]
    [Address(RVA = "0x4D20CF4", Offset = "0x4D20CF4", VA = "0x4D20CF4")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60065F8")]
    [Address(RVA = "0x4D20DB4", Offset = "0x4D20DB4", VA = "0x4D20DB4")]
    private void OnLoadEntity(StoryAreaMovableSpawnPatternData entity)
    {
    }

    [Token(Token = "0x60065F9")]
    [Address(RVA = "0x4D20F30", Offset = "0x4D20F30", VA = "0x4D20F30")]
    public IEnumerable<StoryAreaMovableSpawnPatternData> GetSingleMobGroupingList(int groupLabel)
    {
      return (IEnumerable<StoryAreaMovableSpawnPatternData>) null;
    }

    [Token(Token = "0x60065FA")]
    [Address(RVA = "0x4D210B4", Offset = "0x4D210B4", VA = "0x4D210B4")]
    public IEnumerable<StoryAreaMovableSpawnPatternData> GetPairMobGroupingList(int groupLabel)
    {
      return (IEnumerable<StoryAreaMovableSpawnPatternData>) null;
    }

    [Token(Token = "0x60065FB")]
    [Address(RVA = "0x4D21238", Offset = "0x4D21238", VA = "0x4D21238")]
    public StoryAreaMovableSpawnPatternMaster()
    {
    }
  }
}
