// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.InputEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003E3")]
  public class InputEventData
  {
    [Token(Token = "0x1700026A")]
    public Vector2 Position
    {
      [Token(Token = "0x600166E"), Address(RVA = "0x248764C", Offset = "0x248764C", VA = "0x248764C")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x600166F"), Address(RVA = "0x2487654", Offset = "0x2487654", VA = "0x2487654")] protected set
      {
      }
    }

    [Token(Token = "0x1700026B")]
    public Vector2 PressPosition
    {
      [Token(Token = "0x6001670"), Address(RVA = "0x248765C", Offset = "0x248765C", VA = "0x248765C")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001671"), Address(RVA = "0x2487664", Offset = "0x2487664", VA = "0x2487664")] protected set
      {
      }
    }

    [Token(Token = "0x1700026C")]
    public InputEventTime EventTimes
    {
      [Token(Token = "0x6001672"), Address(RVA = "0x248766C", Offset = "0x248766C", VA = "0x248766C")] get
      {
        return (InputEventTime) null;
      }
    }

    [Token(Token = "0x1700026D")]
    public Vector2 Direction
    {
      [Token(Token = "0x6001673"), Address(RVA = "0x2487674", Offset = "0x2487674", VA = "0x2487674")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x1700026E")]
    public Vector2 BeforePosition
    {
      [Token(Token = "0x6001674"), Address(RVA = "0x2487688", Offset = "0x2487688", VA = "0x2487688")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001675"), Address(RVA = "0x2487690", Offset = "0x2487690", VA = "0x2487690")] protected set
      {
      }
    }

    [Token(Token = "0x6001676")]
    [Address(RVA = "0x2487698", Offset = "0x2487698", VA = "0x2487698")]
    public InputEventData()
    {
    }
  }
}
