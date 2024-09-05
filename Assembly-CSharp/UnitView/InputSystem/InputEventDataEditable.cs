// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.InputEventDataEditable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003E4")]
  public class InputEventDataEditable : InputEventData
  {
    [Token(Token = "0x1700026F")]
    public bool PointerDown
    {
      [Token(Token = "0x6001677"), Address(RVA = "0x2487780", Offset = "0x2487780", VA = "0x2487780")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001678"), Address(RVA = "0x2487788", Offset = "0x2487788", VA = "0x2487788")] set
      {
      }
    }

    [Token(Token = "0x17000270")]
    public Vector2 SetterPosition
    {
      [Token(Token = "0x6001679"), Address(RVA = "0x2487100", Offset = "0x2487100", VA = "0x2487100")] set
      {
      }
    }

    [Token(Token = "0x17000271")]
    public Vector2 SetterPressPosition
    {
      [Token(Token = "0x600167A"), Address(RVA = "0x2487794", Offset = "0x2487794", VA = "0x2487794")] set
      {
      }
    }

    [Token(Token = "0x17000272")]
    public Vector2 SetterBeforePosition
    {
      [Token(Token = "0x600167B"), Address(RVA = "0x2487600", Offset = "0x2487600", VA = "0x2487600")] set
      {
      }
    }

    [Token(Token = "0x600167C")]
    [Address(RVA = "0x248779C", Offset = "0x248779C", VA = "0x248779C")]
    public void OnPointerDown()
    {
    }

    [Token(Token = "0x600167D")]
    [Address(RVA = "0x24877F8", Offset = "0x24877F8", VA = "0x24877F8")]
    public void OnPointerUp()
    {
    }

    [Token(Token = "0x600167E")]
    [Address(RVA = "0x2487868", Offset = "0x2487868", VA = "0x2487868")]
    public InputEventDataEditable()
    {
    }

    [Token(Token = "0x20003E5")]
    public struct History
    {
      [Token(Token = "0x400169A")]
      [FieldOffset(Offset = "0x0")]
      public static InputEventDataEditable.History Default;

      [Token(Token = "0x17000273")]
      public bool IsDefault
      {
        [Token(Token = "0x600167F"), Address(RVA = "0x248786C", Offset = "0x248786C", VA = "0x248786C")] readonly get
        {
          return new bool();
        }
        [Token(Token = "0x6001680"), Address(RVA = "0x2487874", Offset = "0x2487874", VA = "0x2487874")] private set
        {
        }
      }

      [Token(Token = "0x17000274")]
      public Vector2 Position
      {
        [Token(Token = "0x6001681"), Address(RVA = "0x2487880", Offset = "0x2487880", VA = "0x2487880")] readonly get
        {
          return new Vector2();
        }
        [Token(Token = "0x6001682"), Address(RVA = "0x2487888", Offset = "0x2487888", VA = "0x2487888")] private set
        {
        }
      }

      [Token(Token = "0x17000275")]
      public Vector2 PressPosition
      {
        [Token(Token = "0x6001683"), Address(RVA = "0x2487890", Offset = "0x2487890", VA = "0x2487890")] readonly get
        {
          return new Vector2();
        }
        [Token(Token = "0x6001684"), Address(RVA = "0x2487898", Offset = "0x2487898", VA = "0x2487898")] private set
        {
        }
      }

      [Token(Token = "0x17000276")]
      public float PointerUpTime
      {
        [Token(Token = "0x6001685"), Address(RVA = "0x24878A0", Offset = "0x24878A0", VA = "0x24878A0")] readonly get
        {
          return new float();
        }
        [Token(Token = "0x6001686"), Address(RVA = "0x24878A8", Offset = "0x24878A8", VA = "0x24878A8")] private set
        {
        }
      }

      [Token(Token = "0x17000277")]
      public float PointingTime
      {
        [Token(Token = "0x6001687"), Address(RVA = "0x24878B0", Offset = "0x24878B0", VA = "0x24878B0")] readonly get
        {
          return new float();
        }
        [Token(Token = "0x6001688"), Address(RVA = "0x24878B8", Offset = "0x24878B8", VA = "0x24878B8")] private set
        {
        }
      }

      [Token(Token = "0x6001689")]
      [Address(RVA = "0x24878C0", Offset = "0x24878C0", VA = "0x24878C0")]
      private History(bool isDefault)
      {
      }

      [Token(Token = "0x600168A")]
      [Address(RVA = "0x2486FB0", Offset = "0x2486FB0", VA = "0x2486FB0")]
      public History(InputEventData data)
      {
      }

      [Token(Token = "0x600168B")]
      [Address(RVA = "0x2487970", Offset = "0x2487970", VA = "0x2487970")]
      static History()
      {
      }
    }
  }
}
