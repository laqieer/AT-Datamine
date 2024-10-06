// Decompiled with JetBrains decompiler
// Type: Story.Tracker.Logic.TrackingDataFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using StaqData.AreaEvent;

#nullable disable
namespace Story.Tracker.Logic
{
  [Token(Token = "0x20005FA")]
  public static class TrackingDataFactory
  {
    [Token(Token = "0x60022C6")]
    [Address(RVA = "0x2D9ACCC", Offset = "0x2D9ACCC", VA = "0x2D9ACCC")]
    public static TrackingData CreateByMainQuest(int sequenceID) => (TrackingData) null;

    [Token(Token = "0x60022C7")]
    [Address(RVA = "0x2D9C16C", Offset = "0x2D9C16C", VA = "0x2D9C16C")]
    public static TrackingData CreateBySubQuest(SubQuestData subquest) => (TrackingData) null;

    [Token(Token = "0x60022C8")]
    [Address(RVA = "0x2D9BAD8", Offset = "0x2D9BAD8", VA = "0x2D9BAD8")]
    public static TrackingData CreateByAreaEventQuest(AreaEventQuestData areaevent)
    {
      return (TrackingData) null;
    }
  }
}
