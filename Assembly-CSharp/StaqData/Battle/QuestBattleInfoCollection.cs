// Decompiled with JetBrains decompiler
// Type: StaqData.Battle.QuestBattleInfoCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData.Battle
{
  [Token(Token = "0x20021BF")]
  public class QuestBattleInfoCollection
  {
    [Token(Token = "0x4008EF3")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, BattleInfo> dic;

    [Token(Token = "0x600CE28")]
    [Address(RVA = "0x4B60FD0", Offset = "0x4B60FD0", VA = "0x4B60FD0")]
    public QuestBattleInfoCollection()
    {
    }

    [Token(Token = "0x600CE29")]
    [Address(RVA = "0x4B61048", Offset = "0x4B61048", VA = "0x4B61048")]
    public QuestBattleInfoCollection(IEnumerable<PlayerQuestBattleType> entities)
    {
    }

    [Token(Token = "0x600CE2A")]
    [Address(RVA = "0x4B610DC", Offset = "0x4B610DC", VA = "0x4B610DC")]
    public void Apply(IEnumerable<PlayerQuestBattleType> entities)
    {
    }

    [Token(Token = "0x600CE2B")]
    [Address(RVA = "0x4B613B4", Offset = "0x4B613B4", VA = "0x4B613B4")]
    public void Apply(PlayerQuestBattleType entity)
    {
    }

    [Token(Token = "0x600CE2C")]
    [Address(RVA = "0x4B614E4", Offset = "0x4B614E4", VA = "0x4B614E4")]
    public void ApplyAchievedMission(PlayerQuestBattleMissionType entity)
    {
    }

    [Token(Token = "0x600CE2D")]
    [Address(RVA = "0x4B61504", Offset = "0x4B61504", VA = "0x4B61504")]
    public void ApplyAchievedMission(int battleId, int missionId, bool achieved)
    {
    }

    [Token(Token = "0x600CE2E")]
    [Address(RVA = "0x4B613E8", Offset = "0x4B613E8", VA = "0x4B613E8")]
    public BattleInfo GetInfo(int questId) => (BattleInfo) null;

    [Token(Token = "0x600CE2F")]
    [Address(RVA = "0x4B61534", Offset = "0x4B61534", VA = "0x4B61534")]
    public IEnumerable<BattleInfo> GetListByQuestType(QuestTypeEnum questType)
    {
      return (IEnumerable<BattleInfo>) null;
    }

    [Token(Token = "0x600CE30")]
    [Address(RVA = "0x4B6163C", Offset = "0x4B6163C", VA = "0x4B6163C")]
    public bool ContainsKey(int questId) => new bool();
  }
}
