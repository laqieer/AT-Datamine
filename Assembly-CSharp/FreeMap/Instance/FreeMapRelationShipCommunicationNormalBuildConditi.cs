// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapRelationShipCommunicationNormalBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018D1")]
  public class FreeMapRelationShipCommunicationNormalBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B9F")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapSequenceBuildCondition conditionSequence;
    [Token(Token = "0x4006BA0")]
    [FieldOffset(Offset = "0x18")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;
    [Token(Token = "0x4006BA1")]
    [FieldOffset(Offset = "0x20")]
    protected readonly int commuID;
    [Token(Token = "0x4006BA2")]
    [FieldOffset(Offset = "0x24")]
    protected readonly int rank;
    [Token(Token = "0x4006BA3")]
    [FieldOffset(Offset = "0x28")]
    private readonly bool isExistingRank;

    [Token(Token = "0x6008D0A")]
    [Address(RVA = "0x4531FA0", Offset = "0x4531FA0", VA = "0x4531FA0")]
    public FreeMapRelationShipCommunicationNormalBuildCondition(
      int commuAttachID,
      int rank,
      int sequenceID)
    {
    }

    [Token(Token = "0x6008D0B")]
    [Address(RVA = "0x4532370", Offset = "0x4532370", VA = "0x4532370", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008D0C")]
    [Address(RVA = "0x453241C", Offset = "0x453241C", VA = "0x453241C")]
    protected bool CheckRank() => new bool();
  }
}
