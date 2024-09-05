// Decompiled with JetBrains decompiler
// Type: Scenes.Story.MainQuest.ObliviaeBattleToMainQuestSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.MainQuest
{
  [Token(Token = "0x2002E84")]
  public class ObliviaeBattleToMainQuestSceneParameter : 
    MainQuestSceneParameter,
    IToMainQuestSceneParameter
  {
    [Token(Token = "0x60122C3")]
    [Address(RVA = "0x459137C", Offset = "0x459137C", VA = "0x459137C")]
    public ObliviaeBattleToMainQuestSceneParameter(int questID, QuestTypeEnum questType)
    {
    }

    [Token(Token = "0x17003DBD")]
    public int ChapterId
    {
      [Token(Token = "0x60122C4"), Address(RVA = "0x45913A8", Offset = "0x45913A8", VA = "0x45913A8", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x60122C5"), Address(RVA = "0x45913B0", Offset = "0x45913B0", VA = "0x45913B0")] private set
      {
      }
    }
  }
}
