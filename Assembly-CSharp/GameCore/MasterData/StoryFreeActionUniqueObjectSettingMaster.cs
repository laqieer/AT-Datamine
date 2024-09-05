// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionUniqueObjectSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200128E")]
  [Serializable]
  public sealed class StoryFreeActionUniqueObjectSettingMaster : 
    BaseMaster<StoryFreeActionUniqueObjectSettingData>
  {
    [Token(Token = "0x400589D")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionUniqueObjectSettingData>> groupingTable;

    [Token(Token = "0x6006971")]
    [Address(RVA = "0x48D044C", Offset = "0x48D044C", VA = "0x48D044C")]
    public IReadOnlyDictionary<int, StoryFreeActionUniqueObjectSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionUniqueObjectSettingData>) null;
    }

    [Token(Token = "0x6006972")]
    [Address(RVA = "0x48D0454", Offset = "0x48D0454", VA = "0x48D0454", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006973")]
    [Address(RVA = "0x48D050C", Offset = "0x48D050C", VA = "0x48D050C", Slot = "5")]
    protected override StoryFreeActionUniqueObjectSettingData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionUniqueObjectSettingData) null;
    }

    [Token(Token = "0x6006974")]
    [Address(RVA = "0x48D04BC", Offset = "0x48D04BC", VA = "0x48D04BC")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006975")]
    [Address(RVA = "0x48D057C", Offset = "0x48D057C", VA = "0x48D057C")]
    private void OnLoadEntity(StoryFreeActionUniqueObjectSettingData entity)
    {
    }

    [Token(Token = "0x6006976")]
    [Address(RVA = "0x48D06F8", Offset = "0x48D06F8", VA = "0x48D06F8")]
    public IReadOnlyList<StoryFreeActionUniqueObjectSettingData> GetSettingDataByGroupLabel(
      int label)
    {
      return (IReadOnlyList<StoryFreeActionUniqueObjectSettingData>) null;
    }

    [Token(Token = "0x6006977")]
    [Address(RVA = "0x48D07B4", Offset = "0x48D07B4", VA = "0x48D07B4")]
    public StoryFreeActionUniqueObjectSettingMaster()
    {
    }
  }
}
