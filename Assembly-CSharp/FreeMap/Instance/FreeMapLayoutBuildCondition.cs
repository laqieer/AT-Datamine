// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapLayoutBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018CC")]
  public class FreeMapLayoutBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B97")]
    [FieldOffset(Offset = "0x10")]
    protected FreeMapSequenceBuildCondition conditionSequence;
    [Token(Token = "0x4006B98")]
    [FieldOffset(Offset = "0x18")]
    protected int activeConditionEvent;
    [Token(Token = "0x4006B99")]
    [FieldOffset(Offset = "0x1C")]
    protected int inactiveConditionEvent;

    [Token(Token = "0x6008CF8")]
    [Address(RVA = "0x452B6F4", Offset = "0x452B6F4", VA = "0x452B6F4")]
    public FreeMapLayoutBuildCondition(StoryFreeActionLayoutData layoutData)
    {
    }

    [Token(Token = "0x6008CF9")]
    [Address(RVA = "0x45309C0", Offset = "0x45309C0", VA = "0x45309C0", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008CFA")]
    [Address(RVA = "0x45313BC", Offset = "0x45313BC", VA = "0x45313BC")]
    public bool CanCreateEnviroment(int sequenceID) => new bool();

    [Token(Token = "0x6008CFB")]
    [Address(RVA = "0x45313EC", Offset = "0x45313EC", VA = "0x45313EC")]
    protected bool CheckEventEnvironment() => new bool();

    [Token(Token = "0x6008CFC")]
    [Address(RVA = "0x4531430", Offset = "0x4531430", VA = "0x4531430")]
    protected bool IsMatchConditionEventEnvironment(int conditionID) => new bool();

    [Token(Token = "0x6008CFD")]
    [Address(RVA = "0x4531378", Offset = "0x4531378", VA = "0x4531378")]
    protected bool CheckEvent() => new bool();

    [Token(Token = "0x6008CFE")]
    [Address(RVA = "0x45315AC", Offset = "0x45315AC", VA = "0x45315AC")]
    protected bool IsMatchConditionEvent(int conditionID) => new bool();

    [Token(Token = "0x6008CFF")]
    [Address(RVA = "0x45317E0", Offset = "0x45317E0", VA = "0x45317E0")]
    protected bool IsMatchSubquestTask(int taskID) => new bool();

    [Token(Token = "0x6008D00")]
    [Address(RVA = "0x45319F0", Offset = "0x45319F0", VA = "0x45319F0")]
    protected bool IsMatchEventQuestTask(int taskID) => new bool();
  }
}
