// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapRelationShipCommunicationRankupBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018D2")]
  public class FreeMapRelationShipCommunicationRankupBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006BA4")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapSequenceBuildCondition conditionSequence;
    [Token(Token = "0x4006BA5")]
    [FieldOffset(Offset = "0x18")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;
    [Token(Token = "0x4006BA6")]
    [FieldOffset(Offset = "0x20")]
    protected readonly int commuID;
    [Token(Token = "0x4006BA7")]
    [FieldOffset(Offset = "0x24")]
    protected readonly int rank;
    [Token(Token = "0x4006BA8")]
    [FieldOffset(Offset = "0x28")]
    private readonly bool isExistingRank;

    [Token(Token = "0x6008D0D")]
    [Address(RVA = "0x4532164", Offset = "0x4532164", VA = "0x4532164")]
    public FreeMapRelationShipCommunicationRankupBuildCondition(
      int commuAttachID,
      int rank,
      int sequenceID)
    {
    }

    [Token(Token = "0x6008D0E")]
    [Address(RVA = "0x45323D8", Offset = "0x45323D8", VA = "0x45323D8", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008D0F")]
    [Address(RVA = "0x453260C", Offset = "0x453260C", VA = "0x453260C")]
    public bool CheckSequence(int sequenceID) => new bool();

    [Token(Token = "0x6008D10")]
    [Address(RVA = "0x4532574", Offset = "0x4532574", VA = "0x4532574")]
    private bool CheckRank() => new bool();
  }
}
