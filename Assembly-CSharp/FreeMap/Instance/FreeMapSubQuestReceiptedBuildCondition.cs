// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapSubQuestReceiptedBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018D7")]
  public class FreeMapSubQuestReceiptedBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006BB6")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapSequenceBuildCondition conditionSequence;
    [Token(Token = "0x4006BB7")]
    [FieldOffset(Offset = "0x18")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;
    [Token(Token = "0x4006BB8")]
    [FieldOffset(Offset = "0x20")]
    protected readonly FreeMapCalendarBeginToEndBuildCondition conditionCalendar;
    [Token(Token = "0x4006BB9")]
    [FieldOffset(Offset = "0x28")]
    protected readonly int subquestID;
    [Token(Token = "0x4006BBA")]
    [FieldOffset(Offset = "0x30")]
    protected readonly List<FreeMapSubQuestTaskBuildCondition> samePlaceTasks;

    [Token(Token = "0x6008D1C")]
    [Address(RVA = "0x4524780", Offset = "0x4524780", VA = "0x4524780")]
    public FreeMapSubQuestReceiptedBuildCondition(int subquestID, int sequenceID)
    {
    }

    [Token(Token = "0x6008D1D")]
    [Address(RVA = "0x4532A78", Offset = "0x4532A78", VA = "0x4532A78", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}
