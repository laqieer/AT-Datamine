// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapBreakableObjectBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018C7")]
  public class FreeMapBreakableObjectBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B8F")]
    [FieldOffset(Offset = "0x10")]
    protected readonly int breakableObjectID;

    [Token(Token = "0x6008CEA")]
    [Address(RVA = "0x4530B50", Offset = "0x4530B50", VA = "0x4530B50")]
    public FreeMapBreakableObjectBuildCondition(int breakableObjectID)
    {
    }

    [Token(Token = "0x6008CEB")]
    [Address(RVA = "0x4530B9C", Offset = "0x4530B9C", VA = "0x4530B9C", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008CEC")]
    [Address(RVA = "0x4530BB4", Offset = "0x4530BB4", VA = "0x4530BB4")]
    protected bool Broken() => new bool();
  }
}
