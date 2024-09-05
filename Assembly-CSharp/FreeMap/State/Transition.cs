// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Transition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State
{
  [Token(Token = "0x2001796")]
  public class Transition : ITransitionEvent
  {
    [Token(Token = "0x17001543")]
    public int ToAreaID
    {
      [Token(Token = "0x60085F8"), Address(RVA = "0x406E67C", Offset = "0x406E67C", VA = "0x406E67C", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x60085F9"), Address(RVA = "0x406E684", Offset = "0x406E684", VA = "0x406E684")] set
      {
      }
    }

    [Token(Token = "0x17001544")]
    public string ToStartAnchor
    {
      [Token(Token = "0x60085FA"), Address(RVA = "0x406E68C", Offset = "0x406E68C", VA = "0x406E68C", Slot = "5")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60085FB"), Address(RVA = "0x406E694", Offset = "0x406E694", VA = "0x406E694")] set
      {
      }
    }

    [Token(Token = "0x60085FC")]
    [Address(RVA = "0x406E69C", Offset = "0x406E69C", VA = "0x406E69C")]
    public Transition()
    {
    }
  }
}
