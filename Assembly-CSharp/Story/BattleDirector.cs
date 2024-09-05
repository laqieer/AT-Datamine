// Decompiled with JetBrains decompiler
// Type: Story.BattleDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000567")]
  public class BattleDirector : IContentDirector
  {
    [Token(Token = "0x4001BE4")]
    [FieldOffset(Offset = "0x18")]
    private ContentBattle content;

    [Token(Token = "0x17000446")]
    public ContentTaskList WithTransitionIn
    {
      [Token(Token = "0x6001F28"), Address(RVA = "0x2A02038", Offset = "0x2A02038", VA = "0x2A02038", Slot = "4")] get
      {
        return (ContentTaskList) null;
      }
    }

    [Token(Token = "0x6001F29")]
    [Address(RVA = "0x2A02040", Offset = "0x2A02040", VA = "0x2A02040")]
    public BattleDirector(IBattleDirection direction)
    {
    }

    [Token(Token = "0x6001F2A")]
    [Address(RVA = "0x2A020E8", Offset = "0x2A020E8", VA = "0x2A020E8", Slot = "6")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001F2B")]
    [Address(RVA = "0x2A02164", Offset = "0x2A02164", VA = "0x2A02164", Slot = "9")]
    public void Abort()
    {
    }

    [Token(Token = "0x6001F2C")]
    [Address(RVA = "0x2A02184", Offset = "0x2A02184", VA = "0x2A02184", Slot = "7")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F2D")]
    [Address(RVA = "0x2A021AC", Offset = "0x2A021AC", VA = "0x2A021AC", Slot = "8")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F2E")]
    [Address(RVA = "0x2A021CC", Offset = "0x2A021CC", VA = "0x2A021CC", Slot = "5")]
    public Content GetContent() => (Content) null;

    [Token(Token = "0x2000568")]
    public struct Default : IBattleDirection, IDirection
    {
      [Token(Token = "0x4001BE5")]
      [FieldOffset(Offset = "0x0")]
      private int questId;
      [Token(Token = "0x4001BE6")]
      [FieldOffset(Offset = "0x4")]
      private QuestTypeEnum questType;

      [Token(Token = "0x6001F2F")]
      [Address(RVA = "0x2A021D4", Offset = "0x2A021D4", VA = "0x2A021D4")]
      public Default(QuestTypeEnum questType, int questId)
      {
      }

      [Token(Token = "0x6001F30")]
      [Address(RVA = "0x2A021DC", Offset = "0x2A021DC", VA = "0x2A021DC", Slot = "4")]
      private QuestTypeEnum Story\u002EIBattleDirection\u002EGetTypeEnum() => new QuestTypeEnum();

      [Token(Token = "0x6001F31")]
      [Address(RVA = "0x2A021E4", Offset = "0x2A021E4", VA = "0x2A021E4", Slot = "5")]
      private List<int> Story\u002EIBattleDirection\u002EGetTargetQuestIDs() => (List<int>) null;
    }
  }
}
