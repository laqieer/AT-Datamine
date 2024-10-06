// Decompiled with JetBrains decompiler
// Type: Scenes.Story.MainQuest.SubQuestBattleToMainQuestSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.MainQuest
{
  [Token(Token = "0x2002E83")]
  public class SubQuestBattleToMainQuestSceneParameter : 
    MainQuestSceneParameter,
    IToMainQuestSceneParameter
  {
    [Token(Token = "0x60122BE")]
    [Address(RVA = "0x4591258", Offset = "0x4591258", VA = "0x4591258")]
    public SubQuestBattleToMainQuestSceneParameter(
      int questID,
      QuestTypeEnum questType,
      int subquestTaskID)
    {
    }

    [Token(Token = "0x17003DBB")]
    public int ChapterId
    {
      [Token(Token = "0x60122BF"), Address(RVA = "0x459135C", Offset = "0x459135C", VA = "0x459135C", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x60122C0"), Address(RVA = "0x4591364", Offset = "0x4591364", VA = "0x4591364")] private set
      {
      }
    }

    [Token(Token = "0x17003DBC")]
    public int SubquestTaskID
    {
      [Token(Token = "0x60122C1"), Address(RVA = "0x459136C", Offset = "0x459136C", VA = "0x459136C")] get
      {
        return new int();
      }
      [Token(Token = "0x60122C2"), Address(RVA = "0x4591374", Offset = "0x4591374", VA = "0x4591374")] private set
      {
      }
    }
  }
}
