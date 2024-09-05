// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpecialQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200114C")]
  [Serializable]
  public sealed class SpecialQuestMaster : BaseMaster<SpecialQuestData>, IStoryQuestMaster
  {
    [Token(Token = "0x6006377")]
    [Address(RVA = "0x4AE8B44", Offset = "0x4AE8B44", VA = "0x4AE8B44")]
    public IReadOnlyDictionary<int, SpecialQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SpecialQuestData>) null;
    }

    [Token(Token = "0x6006378")]
    [Address(RVA = "0x4AE8B4C", Offset = "0x4AE8B4C", VA = "0x4AE8B4C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006379")]
    [Address(RVA = "0x4AE8BAC", Offset = "0x4AE8BAC", VA = "0x4AE8BAC", Slot = "5")]
    protected override SpecialQuestData LoadEntity(IMasterDataReader reader)
    {
      return (SpecialQuestData) null;
    }

    [Token(Token = "0x600637A")]
    [Address(RVA = "0x4AE8C04", Offset = "0x4AE8C04", VA = "0x4AE8C04", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x600637B")]
    [Address(RVA = "0x4AE7C64", Offset = "0x4AE7C64", VA = "0x4AE7C64")]
    public IReadOnlyCollection<SpecialQuestData> GetListByPeriodID(int specialPeriodID)
    {
      return (IReadOnlyCollection<SpecialQuestData>) null;
    }

    [Token(Token = "0x600637C")]
    [Address(RVA = "0x4AE8C64", Offset = "0x4AE8C64", VA = "0x4AE8C64")]
    public SpecialQuestData GetReleaseConditionQuest(int releaseConditionQuestId)
    {
      return (SpecialQuestData) null;
    }

    [Token(Token = "0x600637D")]
    [Address(RVA = "0x4AE8D6C", Offset = "0x4AE8D6C", VA = "0x4AE8D6C")]
    public int? GetPeriodId(int specialQuestID) => new int?();

    [Token(Token = "0x600637E")]
    [Address(RVA = "0x4AE8EB0", Offset = "0x4AE8EB0", VA = "0x4AE8EB0")]
    public SpecialQuestMaster()
    {
    }
  }
}
