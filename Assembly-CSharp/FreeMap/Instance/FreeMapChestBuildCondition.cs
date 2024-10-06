// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapChestBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018C9")]
  public class FreeMapChestBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B92")]
    [FieldOffset(Offset = "0x10")]
    protected readonly int chestID;

    [Token(Token = "0x6008CF0")]
    [Address(RVA = "0x4530D58", Offset = "0x4530D58", VA = "0x4530D58")]
    public FreeMapChestBuildCondition(int chestID)
    {
    }

    [Token(Token = "0x6008CF1")]
    [Address(RVA = "0x4530D80", Offset = "0x4530D80", VA = "0x4530D80", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008CF2")]
    [Address(RVA = "0x4530D98", Offset = "0x4530D98", VA = "0x4530D98")]
    protected bool IsObtained() => new bool();
  }
}
