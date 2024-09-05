// Decompiled with JetBrains decompiler
// Type: Story.CalendarTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005BA")]
  public static class CalendarTransition
  {
    [Token(Token = "0x60020F1")]
    [Address(RVA = "0x2D94EB0", Offset = "0x2D94EB0", VA = "0x2D94EB0")]
    public static void XDayTransition(
      IContentTaskHandler transitionSetup,
      IContentTaskHandler transitionWith,
      int prevSequenceID,
      int currentSequenceID)
    {
    }

    [Token(Token = "0x60020F2")]
    [Address(RVA = "0x2D95044", Offset = "0x2D95044", VA = "0x2D95044")]
    public static void YearMonthDayTransition(
      IContentTaskHandler transitionSetup,
      IContentTaskHandler transitionWith,
      int prevSequenceID,
      int currentSequenceID)
    {
    }
  }
}
