// Decompiled with JetBrains decompiler
// Type: StaqData.QuestInfoFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200206A")]
  public static class QuestInfoFactory
  {
    [Token(Token = "0x600C3C5")]
    [Address(RVA = "0x19F41D0", Offset = "0x19F41D0", VA = "0x19F41D0")]
    public static QuestInfo Get(BattleResultSubScene.Parameter parameter) => (QuestInfo) null;

    [Token(Token = "0x600C3C6")]
    [Address(RVA = "0x19F41F8", Offset = "0x19F41F8", VA = "0x19F41F8")]
    public static QuestInfo Get(
      QuestTypeEnum questType,
      int questId,
      int subQuestTaskId = -1,
      int specialQuestLevel = -1,
      int areaQuestNodeId = 0)
    {
      return (QuestInfo) null;
    }
  }
}
