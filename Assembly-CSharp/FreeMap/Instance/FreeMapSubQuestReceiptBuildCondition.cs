// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapSubQuestReceiptBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018D5")]
  public class FreeMapSubQuestReceiptBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006BAF")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapSequenceBuildCondition conditionSequence;
    [Token(Token = "0x4006BB0")]
    [FieldOffset(Offset = "0x18")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;
    [Token(Token = "0x4006BB1")]
    [FieldOffset(Offset = "0x20")]
    protected readonly FreeMapCalendarBeginToEndBuildCondition conditionCalendar;
    [Token(Token = "0x4006BB2")]
    [FieldOffset(Offset = "0x28")]
    protected readonly int subquestID;
    [Token(Token = "0x4006BB3")]
    [FieldOffset(Offset = "0x2C")]
    protected readonly int sequenceID;

    [Token(Token = "0x6008D17")]
    [Address(RVA = "0x4524E8C", Offset = "0x4524E8C", VA = "0x4524E8C")]
    public FreeMapSubQuestReceiptBuildCondition(int subquestID, int sequenceID)
    {
    }

    [Token(Token = "0x6008D18")]
    [Address(RVA = "0x4532908", Offset = "0x4532908", VA = "0x4532908", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}
