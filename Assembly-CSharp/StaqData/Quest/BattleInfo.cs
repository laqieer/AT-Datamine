// Decompiled with JetBrains decompiler
// Type: StaqData.Quest.BattleInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData.Quest
{
  [Token(Token = "0x200214C")]
  public class BattleInfo
  {
    [Token(Token = "0x4008D30")]
    [FieldOffset(Offset = "0x14")]
    private int timeslotLabel;

    [Token(Token = "0x17002C9D")]
    public int QuestID
    {
      [Token(Token = "0x600CBFC"), Address(RVA = "0x1BAB66C", Offset = "0x1BAB66C", VA = "0x1BAB66C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600CBFD")]
    [Address(RVA = "0x1BAB674", Offset = "0x1BAB674", VA = "0x1BAB674")]
    public BattleInfo(StorySubquestTaskData record)
    {
    }

    [Token(Token = "0x600CBFE")]
    [Address(RVA = "0x1BAB6AC", Offset = "0x1BAB6AC", VA = "0x1BAB6AC")]
    public bool IsValid() => new bool();

    [Token(Token = "0x600CBFF")]
    [Address(RVA = "0x1BAB6B0", Offset = "0x1BAB6B0", VA = "0x1BAB6B0")]
    public bool IsValidTimeSlot() => new bool();

    [Token(Token = "0x600CC00")]
    [Address(RVA = "0x1BAB728", Offset = "0x1BAB728", VA = "0x1BAB728")]
    public bool IsValidTimeSlot(StoryTimeSlotTypeEnum currentTimeSlot) => new bool();
  }
}
