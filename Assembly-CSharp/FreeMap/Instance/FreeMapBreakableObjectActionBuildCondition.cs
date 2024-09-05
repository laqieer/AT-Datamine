// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapBreakableObjectActionBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018C6")]
  public class FreeMapBreakableObjectActionBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B8D")]
    [FieldOffset(Offset = "0x10")]
    private readonly FreeMapBreakableObjectBuildCondition objectCondition;
    [Token(Token = "0x4006B8E")]
    [FieldOffset(Offset = "0x18")]
    protected readonly int breakableObjectID;

    [Token(Token = "0x6008CE8")]
    [Address(RVA = "0x4530AD0", Offset = "0x4530AD0", VA = "0x4530AD0")]
    public FreeMapBreakableObjectActionBuildCondition(int breakableObjectID)
    {
    }

    [Token(Token = "0x6008CE9")]
    [Address(RVA = "0x4530B78", Offset = "0x4530B78", VA = "0x4530B78", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}
