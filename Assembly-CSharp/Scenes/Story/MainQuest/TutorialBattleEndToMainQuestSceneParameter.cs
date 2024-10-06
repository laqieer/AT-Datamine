// Decompiled with JetBrains decompiler
// Type: Scenes.Story.MainQuest.TutorialBattleEndToMainQuestSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.MainQuest
{
  [Token(Token = "0x2002E89")]
  public class TutorialBattleEndToMainQuestSceneParameter : 
    MainQuestSceneParameter,
    IToMainQuestSceneParameter,
    IStorySceneCycleInitializerMethod
  {
    [Token(Token = "0x60122D0")]
    [Address(RVA = "0x4591630", Offset = "0x4591630", VA = "0x4591630")]
    public TutorialBattleEndToMainQuestSceneParameter(
      int questID,
      QuestTypeEnum questType,
      int subquestTaskID)
    {
    }

    [Token(Token = "0x60122D1")]
    [Address(RVA = "0x4591724", Offset = "0x4591724", VA = "0x4591724", Slot = "5")]
    private IStorySceneCycleInitializer Scenes\u002EStory\u002EMainQuest\u002EIStorySceneCycleInitializerMethod\u002ECreateInitializer()
    {
      return (IStorySceneCycleInitializer) null;
    }

    [Token(Token = "0x17003DC0")]
    public int ChapterId
    {
      [Token(Token = "0x60122D2"), Address(RVA = "0x459178C", Offset = "0x459178C", VA = "0x459178C", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x60122D3"), Address(RVA = "0x4591794", Offset = "0x4591794", VA = "0x4591794")] private set
      {
      }
    }
  }
}
