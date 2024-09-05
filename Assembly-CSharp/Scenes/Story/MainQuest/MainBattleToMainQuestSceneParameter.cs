// Decompiled with JetBrains decompiler
// Type: Scenes.Story.MainQuest.MainBattleToMainQuestSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.MainQuest
{
  [Token(Token = "0x2002E82")]
  public class MainBattleToMainQuestSceneParameter : 
    MainQuestSceneParameter,
    IToMainQuestSceneParameter
  {
    [Token(Token = "0x60122BB")]
    [Address(RVA = "0x4591154", Offset = "0x4591154", VA = "0x4591154")]
    public MainBattleToMainQuestSceneParameter(int questID, QuestTypeEnum questType)
    {
    }

    [Token(Token = "0x17003DBA")]
    public int ChapterId
    {
      [Token(Token = "0x60122BC"), Address(RVA = "0x4591248", Offset = "0x4591248", VA = "0x4591248", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x60122BD"), Address(RVA = "0x4591250", Offset = "0x4591250", VA = "0x4591250")] private set
      {
      }
    }
  }
}
