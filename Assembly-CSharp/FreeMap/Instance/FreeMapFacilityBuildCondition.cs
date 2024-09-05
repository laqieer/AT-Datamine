// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapFacilityBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018CA")]
  public class FreeMapFacilityBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B93")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapSequenceBuildCondition conditionSequence;
    [Token(Token = "0x4006B94")]
    [FieldOffset(Offset = "0x18")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;
    [Token(Token = "0x4006B95")]
    [FieldOffset(Offset = "0x20")]
    protected readonly StoryFacilityAttachData attach;

    [Token(Token = "0x6008CF3")]
    [Address(RVA = "0x4530E08", Offset = "0x4530E08", VA = "0x4530E08")]
    public FreeMapFacilityBuildCondition(int facilityAttachID, int sequenceID)
    {
    }

    [Token(Token = "0x6008CF4")]
    [Address(RVA = "0x4530FE8", Offset = "0x4530FE8", VA = "0x4530FE8", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008CF5")]
    [Address(RVA = "0x45310D8", Offset = "0x45310D8", VA = "0x45310D8")]
    private bool CheckCondition(StoryFacilityAttachData attach) => new bool();
  }
}
