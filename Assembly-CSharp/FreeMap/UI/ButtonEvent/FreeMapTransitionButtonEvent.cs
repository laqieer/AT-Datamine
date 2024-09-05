// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapTransitionButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.State;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x2001713")]
  public class FreeMapTransitionButtonEvent : 
    FreeMapIconButtonEventBase<FreeMapTransitionEventUIParam>,
    ITransitionEvent
  {
    [Token(Token = "0x40066E2")]
    [FieldOffset(Offset = "0x50")]
    private int toAreaID;
    [Token(Token = "0x40066E3")]
    [FieldOffset(Offset = "0x58")]
    private string toStartAnchor;

    [Token(Token = "0x17001468")]
    public int ToAreaID
    {
      [Token(Token = "0x600828F"), Address(RVA = "0x42011A8", Offset = "0x42011A8", VA = "0x42011A8", Slot = "23")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001469")]
    public string ToStartAnchor
    {
      [Token(Token = "0x6008290"), Address(RVA = "0x42011B0", Offset = "0x42011B0", VA = "0x42011B0", Slot = "24")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700146A")]
    protected override bool IsSavePosition
    {
      [Token(Token = "0x6008291"), Address(RVA = "0x42011B8", Offset = "0x42011B8", VA = "0x42011B8", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008292")]
    [Address(RVA = "0x42011C0", Offset = "0x42011C0", VA = "0x42011C0")]
    public FreeMapTransitionButtonEvent(
      FreeMapTransitionEventUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008293")]
    [Address(RVA = "0x420123C", Offset = "0x420123C", VA = "0x420123C", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;
  }
}
