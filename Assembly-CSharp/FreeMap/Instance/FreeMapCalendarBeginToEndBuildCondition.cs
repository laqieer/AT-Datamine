// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapCalendarBeginToEndBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018C8")]
  public class FreeMapCalendarBeginToEndBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B90")]
    [FieldOffset(Offset = "0x10")]
    protected readonly int beginCalendarID;
    [Token(Token = "0x4006B91")]
    [FieldOffset(Offset = "0x14")]
    protected readonly int endCalendarID;

    [Token(Token = "0x6008CED")]
    [Address(RVA = "0x4530C24", Offset = "0x4530C24", VA = "0x4530C24")]
    public FreeMapCalendarBeginToEndBuildCondition(int beginCalendarID, int endCalendarID)
    {
    }

    [Token(Token = "0x6008CEE")]
    [Address(RVA = "0x4530C50", Offset = "0x4530C50", VA = "0x4530C50", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008CEF")]
    [Address(RVA = "0x4530D2C", Offset = "0x4530D2C", VA = "0x4530D2C")]
    protected bool InRange(int calendarID) => new bool();
  }
}
