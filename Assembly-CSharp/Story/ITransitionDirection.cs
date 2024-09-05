// Decompiled with JetBrains decompiler
// Type: Story.ITransitionDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005BB")]
  public interface ITransitionDirection
  {
    [Token(Token = "0x60020F3")]
    void TransitionOnStart(IContentTaskHandler transitionSetup, IContentTaskHandler transitionWith);

    [Token(Token = "0x60020F4")]
    void TransitionOnEnd(IContentTaskHandler transitionSetup, IContentTaskHandler transitionWith);
  }
}
