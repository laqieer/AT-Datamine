// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultCommon.SceneChangeCtrl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Battle.ResultCommon
{
  [Token(Token = "0x20037E9")]
  public class SceneChangeCtrl
  {
    [Token(Token = "0x6015FE8")]
    [Address(RVA = "0x232FF48", Offset = "0x232FF48", VA = "0x232FF48")]
    public static void ChangeToQuestSelect(QuestTypeEnum questType, int questId)
    {
    }

    [Token(Token = "0x6015FE9")]
    [Address(RVA = "0x232A528", Offset = "0x232A528", VA = "0x232A528")]
    public static void ChangeToQuestSelect(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x6015FEA")]
    [Address(RVA = "0x2330094", Offset = "0x2330094", VA = "0x2330094")]
    public static void ChangeToQuestPrepare(
      QuestTypeEnum questType,
      int questId,
      bool isChangeToQuestPrepare = false,
      bool isContinueSound = false)
    {
    }

    [Token(Token = "0x6015FEB")]
    [Address(RVA = "0x232AA68", Offset = "0x232AA68", VA = "0x232AA68")]
    public static void ChangeToQuestPrepare(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x6015FEC")]
    [Address(RVA = "0x232E9D8", Offset = "0x232E9D8", VA = "0x232E9D8")]
    public static void ChangeToQuestPrepareFromSkip(QuestInfo questInfo, bool isContinueSound = false)
    {
    }

    [Token(Token = "0x6015FED")]
    [Address(RVA = "0x23300A0", Offset = "0x23300A0", VA = "0x23300A0")]
    public static void ChangeToQuest(QuestTypeEnum questType, int questId)
    {
    }

    [Token(Token = "0x6015FEE")]
    [Address(RVA = "0x23300AC", Offset = "0x23300AC", VA = "0x23300AC")]
    public static void ChangeToAreaQuest(QuestTypeEnum questType)
    {
    }

    [Token(Token = "0x6015FEF")]
    [Address(RVA = "0x23300BC", Offset = "0x23300BC", VA = "0x23300BC")]
    public static void ChangeToEventTop(QuestTypeEnum questType, int questId)
    {
    }

    [Token(Token = "0x6015FF0")]
    [Address(RVA = "0x23300C8", Offset = "0x23300C8", VA = "0x23300C8")]
    public static void ChangeToAreaQuestAdv(int nodeId, bool playClearedNode)
    {
    }

    [Token(Token = "0x6015FF1")]
    [Address(RVA = "0x232FF54", Offset = "0x232FF54", VA = "0x232FF54")]
    private static void ChangeToHome(
      QuestTypeEnum questType,
      int questId,
      bool isChangeToQuestPrepare,
      bool isContinueSound = false)
    {
    }

    [Token(Token = "0x6015FF2")]
    [Address(RVA = "0x233018C", Offset = "0x233018C", VA = "0x233018C")]
    public static void ChangeToHomeQuestContentsList()
    {
    }

    [Token(Token = "0x6015FF3")]
    [Address(RVA = "0x2330308", Offset = "0x2330308", VA = "0x2330308")]
    public SceneChangeCtrl()
    {
    }
  }
}
