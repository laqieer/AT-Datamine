// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EffectedDuelFlowControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002795")]
  public struct EffectedDuelFlowControl : IDuelFlowControlEffect
  {
    [Token(Token = "0x1700350A")]
    public bool NullCounterStrike
    {
      [Token(Token = "0x600F709"), Address(RVA = "0x1ED8CC8", Offset = "0x1ED8CC8", VA = "0x1ED8CC8", Slot = "4")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F70A"), Address(RVA = "0x1ED8CD0", Offset = "0x1ED8CD0", VA = "0x1ED8CD0")] set
      {
      }
    }

    [Token(Token = "0x1700350B")]
    public bool AbsoluteSecondAttack
    {
      [Token(Token = "0x600F70B"), Address(RVA = "0x1ED8CDC", Offset = "0x1ED8CDC", VA = "0x1ED8CDC", Slot = "5")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F70C"), Address(RVA = "0x1ED8CE4", Offset = "0x1ED8CE4", VA = "0x1ED8CE4")] set
      {
      }
    }

    [Token(Token = "0x1700350C")]
    public bool NullChase
    {
      [Token(Token = "0x600F70D"), Address(RVA = "0x1ED8CF0", Offset = "0x1ED8CF0", VA = "0x1ED8CF0", Slot = "6")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F70E"), Address(RVA = "0x1ED8CF8", Offset = "0x1ED8CF8", VA = "0x1ED8CF8")] set
      {
      }
    }

    [Token(Token = "0x1700350D")]
    public bool AbsoluteChase
    {
      [Token(Token = "0x600F70F"), Address(RVA = "0x1ED8D04", Offset = "0x1ED8D04", VA = "0x1ED8D04", Slot = "7")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F710"), Address(RVA = "0x1ED8D0C", Offset = "0x1ED8D0C", VA = "0x1ED8D0C")] set
      {
      }
    }

    [Token(Token = "0x1700350E")]
    public bool FastChase
    {
      [Token(Token = "0x600F711"), Address(RVA = "0x1ED8D18", Offset = "0x1ED8D18", VA = "0x1ED8D18", Slot = "8")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F712"), Address(RVA = "0x1ED8D20", Offset = "0x1ED8D20", VA = "0x1ED8D20")] set
      {
      }
    }

    [Token(Token = "0x1700350F")]
    public bool FirstStrike
    {
      [Token(Token = "0x600F713"), Address(RVA = "0x1ED8D2C", Offset = "0x1ED8D2C", VA = "0x1ED8D2C", Slot = "9")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F714"), Address(RVA = "0x1ED8D34", Offset = "0x1ED8D34", VA = "0x1ED8D34")] set
      {
      }
    }

    [Token(Token = "0x17003510")]
    public bool SecondStrike
    {
      [Token(Token = "0x600F715"), Address(RVA = "0x1ED8D40", Offset = "0x1ED8D40", VA = "0x1ED8D40", Slot = "10")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F716"), Address(RVA = "0x1ED8D48", Offset = "0x1ED8D48", VA = "0x1ED8D48")] set
      {
      }
    }

    [Token(Token = "0x600F717")]
    [Address(RVA = "0x1ED8D54", Offset = "0x1ED8D54", VA = "0x1ED8D54")]
    public void Or(IDuelFlowControlEffect control)
    {
    }
  }
}
