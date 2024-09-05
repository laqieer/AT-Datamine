// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapSequenceBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018D3")]
  public class FreeMapSequenceBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006BA9")]
    [FieldOffset(Offset = "0x10")]
    protected readonly ConditionDate conditionDate;
    [Token(Token = "0x4006BAA")]
    [FieldOffset(Offset = "0x14")]
    protected readonly ConditionWeather conditionWeather;
    [Token(Token = "0x4006BAB")]
    [FieldOffset(Offset = "0x18")]
    protected readonly ConditionTimeslot conditionTimeSlot;

    [Token(Token = "0x6008D11")]
    [Address(RVA = "0x4530FAC", Offset = "0x4530FAC", VA = "0x4530FAC")]
    public FreeMapSequenceBuildCondition(
      int conditionDateID,
      int conditionWeatherID,
      int conditionTimeSlotID)
    {
    }

    [Token(Token = "0x6008D12")]
    [Address(RVA = "0x453133C", Offset = "0x453133C", VA = "0x453133C")]
    public FreeMapSequenceBuildCondition(
      ConditionDate conditionDate,
      ConditionWeather conditionWeather,
      ConditionTimeslot conditionTimeSlot)
    {
    }

    [Token(Token = "0x6008D13")]
    [Address(RVA = "0x45312F4", Offset = "0x45312F4", VA = "0x45312F4", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008D14")]
    [Address(RVA = "0x4532660", Offset = "0x4532660", VA = "0x4532660")]
    protected bool CheckSequence(int sequenceID) => new bool();
  }
}
