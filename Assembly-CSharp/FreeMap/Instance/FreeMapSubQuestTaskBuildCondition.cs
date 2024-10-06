// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapSubQuestTaskBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018DA")]
  public class FreeMapSubQuestTaskBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006BBE")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapSequenceBuildCondition conditionSequence;
    [Token(Token = "0x4006BBF")]
    [FieldOffset(Offset = "0x18")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;
    [Token(Token = "0x4006BC0")]
    [FieldOffset(Offset = "0x20")]
    protected readonly int taskID;

    [Token(Token = "0x6008D23")]
    [Address(RVA = "0x45245B0", Offset = "0x45245B0", VA = "0x45245B0")]
    public FreeMapSubQuestTaskBuildCondition(int taskID, int sequenceID, bool isBuildCondition = true)
    {
    }

    [Token(Token = "0x6008D24")]
    [Address(RVA = "0x4532CB4", Offset = "0x4532CB4", VA = "0x4532CB4", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}
