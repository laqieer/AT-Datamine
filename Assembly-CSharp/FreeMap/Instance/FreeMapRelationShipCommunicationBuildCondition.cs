// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapRelationShipCommunicationBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018D0")]
  public class FreeMapRelationShipCommunicationBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B9D")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapRelationShipCommunicationNormalBuildCondition normalCondition;
    [Token(Token = "0x4006B9E")]
    [FieldOffset(Offset = "0x18")]
    protected readonly FreeMapRelationShipCommunicationRankupBuildCondition rankupCondition;

    [Token(Token = "0x6008D07")]
    [Address(RVA = "0x4531E50", Offset = "0x4531E50", VA = "0x4531E50")]
    public FreeMapRelationShipCommunicationBuildCondition(int commuAttachID, int rank)
    {
    }

    [Token(Token = "0x6008D08")]
    [Address(RVA = "0x4531ED8", Offset = "0x4531ED8", VA = "0x4531ED8")]
    public FreeMapRelationShipCommunicationBuildCondition(
      int commuAttachID,
      int rank,
      int sequenceID)
    {
    }

    [Token(Token = "0x6008D09")]
    [Address(RVA = "0x4532324", Offset = "0x4532324", VA = "0x4532324", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}
