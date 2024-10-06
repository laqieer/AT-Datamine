// Decompiled with JetBrains decompiler
// Type: Story.TutorialBattleDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000565")]
  public class TutorialBattleDirector : IContentDirector
  {
    [Token(Token = "0x4001BE0")]
    [FieldOffset(Offset = "0x18")]
    private ContentTutorialBattle content;

    [Token(Token = "0x17000445")]
    public ContentTaskList WithTransitionIn
    {
      [Token(Token = "0x6001F1E"), Address(RVA = "0x2A01E84", Offset = "0x2A01E84", VA = "0x2A01E84", Slot = "4")] get
      {
        return (ContentTaskList) null;
      }
    }

    [Token(Token = "0x6001F1F")]
    [Address(RVA = "0x2A01E8C", Offset = "0x2A01E8C", VA = "0x2A01E8C")]
    public TutorialBattleDirector(ITutorialBattleDirection direction)
    {
    }

    [Token(Token = "0x6001F20")]
    [Address(RVA = "0x2A01F34", Offset = "0x2A01F34", VA = "0x2A01F34", Slot = "6")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001F21")]
    [Address(RVA = "0x2A01FB0", Offset = "0x2A01FB0", VA = "0x2A01FB0", Slot = "9")]
    public void Abort()
    {
    }

    [Token(Token = "0x6001F22")]
    [Address(RVA = "0x2A01FD0", Offset = "0x2A01FD0", VA = "0x2A01FD0", Slot = "7")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F23")]
    [Address(RVA = "0x2A01FF8", Offset = "0x2A01FF8", VA = "0x2A01FF8", Slot = "8")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F24")]
    [Address(RVA = "0x2A02018", Offset = "0x2A02018", VA = "0x2A02018", Slot = "5")]
    public Content GetContent() => (Content) null;

    [Token(Token = "0x2000566")]
    public struct Default : ITutorialBattleDirection, IDirection
    {
      [Token(Token = "0x4001BE1")]
      [FieldOffset(Offset = "0x0")]
      private int questId;
      [Token(Token = "0x4001BE2")]
      [FieldOffset(Offset = "0x4")]
      private QuestTypeEnum questType;

      [Token(Token = "0x6001F25")]
      [Address(RVA = "0x2A02020", Offset = "0x2A02020", VA = "0x2A02020")]
      public Default(QuestTypeEnum questType, int questId)
      {
      }

      [Token(Token = "0x6001F26")]
      [Address(RVA = "0x2A02028", Offset = "0x2A02028", VA = "0x2A02028", Slot = "4")]
      private QuestTypeEnum Story\u002EITutorialBattleDirection\u002EGetTypeEnum()
      {
        return new QuestTypeEnum();
      }

      [Token(Token = "0x6001F27")]
      [Address(RVA = "0x2A02030", Offset = "0x2A02030", VA = "0x2A02030", Slot = "5")]
      private int Story\u002EITutorialBattleDirection\u002EGetTargetQuestID() => new int();
    }
  }
}
