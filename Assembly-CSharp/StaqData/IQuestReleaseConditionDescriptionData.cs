// Decompiled with JetBrains decompiler
// Type: StaqData.IQuestReleaseConditionDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002078")]
  public interface IQuestReleaseConditionDescriptionData
  {
    [Token(Token = "0x170029E8")]
    int AreaNodeId { [Token(Token = "0x600C458")] get; }

    [Token(Token = "0x170029E9")]
    int StoryChapterId { [Token(Token = "0x600C459")] get; }

    [Token(Token = "0x170029EA")]
    int StoryChapterLoopNum { [Token(Token = "0x600C45A")] get; }

    [Token(Token = "0x170029EB")]
    ConditionOpTypeEnum BooleanType { [Token(Token = "0x600C45B")] get; }
  }
}
