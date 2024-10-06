// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IStoryQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200142F")]
  public interface IStoryQuestData
  {
    [Token(Token = "0x6007195")]
    int GetID();

    [Token(Token = "0x1700112B")]
    QuestTypeEnum TypeEnum { [Token(Token = "0x6007196")] get; }

    [Token(Token = "0x1700112C")]
    int StageId { [Token(Token = "0x6007197")] get; }

    [Token(Token = "0x1700112D")]
    int QuestLevel { [Token(Token = "0x6007198")] get; }

    [Token(Token = "0x1700112E")]
    int MissionId { [Token(Token = "0x6007199")] get; }

    [Token(Token = "0x1700112F")]
    int FirstClearRewardGroupID { [Token(Token = "0x600719A")] get; }

    [Token(Token = "0x17001130")]
    int ClearRewardGroupID { [Token(Token = "0x600719B")] get; }
  }
}
