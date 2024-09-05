// Decompiled with JetBrains decompiler
// Type: StaqData.HaveQuestDifficulty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200205D")]
  public interface HaveQuestDifficulty
  {
    [Token(Token = "0x17002933")]
    int QuestGroupId { [Token(Token = "0x600C33E")] get; }

    [Token(Token = "0x17002934")]
    QuestDifficultyTypeEnum DifficultyType { [Token(Token = "0x600C33F")] get; }
  }
}
