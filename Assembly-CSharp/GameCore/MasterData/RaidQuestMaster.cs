// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RaidQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200112C")]
  [Serializable]
  public sealed class RaidQuestMaster : BaseMaster<RaidQuestData>, IStoryQuestMaster
  {
    [Token(Token = "0x60062DB")]
    [Address(RVA = "0x4AE330C", Offset = "0x4AE330C", VA = "0x4AE330C")]
    public IReadOnlyDictionary<int, RaidQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, RaidQuestData>) null;
    }

    [Token(Token = "0x60062DC")]
    [Address(RVA = "0x4AE3314", Offset = "0x4AE3314", VA = "0x4AE3314", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60062DD")]
    [Address(RVA = "0x4AE3374", Offset = "0x4AE3374", VA = "0x4AE3374", Slot = "5")]
    protected override RaidQuestData LoadEntity(IMasterDataReader reader) => (RaidQuestData) null;

    [Token(Token = "0x60062DE")]
    [Address(RVA = "0x4AE33CC", Offset = "0x4AE33CC", VA = "0x4AE33CC")]
    public RaidQuestData GetRaidQuestData(int id, int pos, int lap) => (RaidQuestData) null;

    [Token(Token = "0x60062DF")]
    [Address(RVA = "0x4AE37C4", Offset = "0x4AE37C4", VA = "0x4AE37C4")]
    public List<RaidQuestData> GetRaidQuestData(int id, int pos) => (List<RaidQuestData>) null;

    [Token(Token = "0x60062E0")]
    [Address(RVA = "0x4AE38EC", Offset = "0x4AE38EC", VA = "0x4AE38EC", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x60062E1")]
    [Address(RVA = "0x4AE3944", Offset = "0x4AE3944", VA = "0x4AE3944")]
    public RaidQuestMaster()
    {
    }
  }
}
