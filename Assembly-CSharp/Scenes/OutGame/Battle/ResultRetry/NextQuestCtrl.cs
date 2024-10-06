// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultRetry.NextQuestCtrl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Battle.ResultRetry
{
  [Token(Token = "0x20037C0")]
  public class NextQuestCtrl
  {
    [Token(Token = "0x400F3B0")]
    [FieldOffset(Offset = "0x18")]
    private QuestInfo _nextQuest;

    [Token(Token = "0x6015F0D")]
    [Address(RVA = "0x232A850", Offset = "0x232A850", VA = "0x232A850")]
    public NextQuestCtrl(QuestTypeEnum questType, int baseQuestId)
    {
    }

    [Token(Token = "0x1700488E")]
    public QuestInfo NextQuest
    {
      [Token(Token = "0x6015F0E"), Address(RVA = "0x232A934", Offset = "0x232A934", VA = "0x232A934")] get
      {
        return (QuestInfo) null;
      }
    }

    [Token(Token = "0x1700488F")]
    public bool IsExistNextQuest
    {
      [Token(Token = "0x6015F0F"), Address(RVA = "0x232A93C", Offset = "0x232A93C", VA = "0x232A93C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004890")]
    public bool IsReleasedNextQuest
    {
      [Token(Token = "0x6015F10"), Address(RVA = "0x232A94C", Offset = "0x232A94C", VA = "0x232A94C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004891")]
    public bool Executable
    {
      [Token(Token = "0x6015F11"), Address(RVA = "0x232A968", Offset = "0x232A968", VA = "0x232A968")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015F12"), Address(RVA = "0x232A970", Offset = "0x232A970", VA = "0x232A970")] private set
      {
      }
    }

    [Token(Token = "0x17004892")]
    public bool OccupancyProcessing
    {
      [Token(Token = "0x6015F13"), Address(RVA = "0x232A97C", Offset = "0x232A97C", VA = "0x232A97C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015F14")]
    [Address(RVA = "0x232A98C", Offset = "0x232A98C", VA = "0x232A98C")]
    public void Exec()
    {
    }

    [Token(Token = "0x6015F15")]
    [Address(RVA = "0x232A890", Offset = "0x232A890", VA = "0x232A890")]
    private static QuestInfo FindNextQuest(QuestTypeEnum questType, int baseQuestId)
    {
      return (QuestInfo) null;
    }
  }
}
