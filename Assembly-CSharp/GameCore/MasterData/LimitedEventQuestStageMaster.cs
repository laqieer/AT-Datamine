// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LimitedEventQuestStageMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200111F")]
  [Serializable]
  public sealed class LimitedEventQuestStageMaster : 
    BaseMaster<LimitedEventQuestStageData>,
    IStoryQuestMaster
  {
    [Token(Token = "0x600628B")]
    [Address(RVA = "0x4ADFE04", Offset = "0x4ADFE04", VA = "0x4ADFE04")]
    public IReadOnlyDictionary<int, LimitedEventQuestStageData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LimitedEventQuestStageData>) null;
    }

    [Token(Token = "0x600628C")]
    [Address(RVA = "0x4ADFE0C", Offset = "0x4ADFE0C", VA = "0x4ADFE0C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600628D")]
    [Address(RVA = "0x4ADFE6C", Offset = "0x4ADFE6C", VA = "0x4ADFE6C", Slot = "5")]
    protected override LimitedEventQuestStageData LoadEntity(IMasterDataReader reader)
    {
      return (LimitedEventQuestStageData) null;
    }

    [Token(Token = "0x600628E")]
    [Address(RVA = "0x4ADFEC4", Offset = "0x4ADFEC4", VA = "0x4ADFEC4")]
    public IReadOnlyCollection<LimitedEventQuestStageData> GetAllItem()
    {
      return (IReadOnlyCollection<LimitedEventQuestStageData>) null;
    }

    [Token(Token = "0x600628F")]
    [Address(RVA = "0x4ADFF14", Offset = "0x4ADFF14", VA = "0x4ADFF14")]
    public List<LimitedEventQuestStageData> GetGroupDataForEvent(int eventId)
    {
      return (List<LimitedEventQuestStageData>) null;
    }

    [Token(Token = "0x6006290")]
    [Address(RVA = "0x4AE0038", Offset = "0x4AE0038", VA = "0x4AE0038")]
    public LimitedEventQuestStageData GetReleaseConditionQuest(int releaseConditionQuestId)
    {
      return (LimitedEventQuestStageData) null;
    }

    [Token(Token = "0x6006291")]
    [Address(RVA = "0x4AE0140", Offset = "0x4AE0140", VA = "0x4AE0140", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x6006292")]
    [Address(RVA = "0x4AE0198", Offset = "0x4AE0198", VA = "0x4AE0198")]
    public LimitedEventQuestStageMaster()
    {
    }
  }
}
