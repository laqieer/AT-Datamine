// Decompiled with JetBrains decompiler
// Type: Story.XDayCalendarTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005C5")]
  public class XDayCalendarTransition
  {
    [Token(Token = "0x600212D")]
    [Address(RVA = "0x2D9502C", Offset = "0x2D9502C", VA = "0x2D9502C")]
    public XDayCalendarTransition(int xDay)
    {
    }

    [Token(Token = "0x600212E")]
    [Address(RVA = "0x2D9503C", Offset = "0x2D9503C", VA = "0x2D9503C")]
    public XDayCalendarTransition(int prev, int next)
    {
    }

    [Token(Token = "0x600212F")]
    [Address(RVA = "0x2D95034", Offset = "0x2D95034", VA = "0x2D95034")]
    public void RegisterOnSetup(IContentTaskHandler transitionSetup)
    {
    }

    [Token(Token = "0x6002130")]
    [Address(RVA = "0x2D95038", Offset = "0x2D95038", VA = "0x2D95038")]
    public void RegisterOnWith(IContentTaskHandler transitionWith)
    {
    }
  }
}
