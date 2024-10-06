// Decompiled with JetBrains decompiler
// Type: Utility.ParameterColorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Utility
{
  [Token(Token = "0x200041C")]
  public class ParameterColorCode
  {
    [Token(Token = "0x1700029C")]
    public ParameterColorCode.Color None
    {
      [Token(Token = "0x600174C"), Address(RVA = "0x248BB54", Offset = "0x248BB54", VA = "0x248BB54")] get
      {
        return (ParameterColorCode.Color) null;
      }
    }

    [Token(Token = "0x1700029D")]
    public ParameterColorCode.Color Positive
    {
      [Token(Token = "0x600174D"), Address(RVA = "0x248BB5C", Offset = "0x248BB5C", VA = "0x248BB5C")] get
      {
        return (ParameterColorCode.Color) null;
      }
    }

    [Token(Token = "0x1700029E")]
    public ParameterColorCode.Color Negative
    {
      [Token(Token = "0x600174E"), Address(RVA = "0x248BB64", Offset = "0x248BB64", VA = "0x248BB64")] get
      {
        return (ParameterColorCode.Color) null;
      }
    }

    [Token(Token = "0x600174F")]
    [Address(RVA = "0x248BB6C", Offset = "0x248BB6C", VA = "0x248BB6C")]
    public ParameterColorCode()
    {
    }

    [Token(Token = "0x6001750")]
    [Address(RVA = "0x248BC90", Offset = "0x248BC90", VA = "0x248BC90")]
    public ParameterColorCode(ParameterColorCode.Color positive, ParameterColorCode.Color negative)
    {
    }

    [Token(Token = "0x6001751")]
    [Address(RVA = "0x248BC54", Offset = "0x248BC54", VA = "0x248BC54")]
    public ParameterColorCode(
      ParameterColorCode.Color none,
      ParameterColorCode.Color positive,
      ParameterColorCode.Color negative)
    {
    }

    [Token(Token = "0x200041D")]
    public abstract class Color
    {
      [Token(Token = "0x1700029F")]
      public abstract string ColorCode { [Token(Token = "0x6001752")] get; }

      [Token(Token = "0x6001753")]
      [Address(RVA = "0x248BD10", Offset = "0x248BD10", VA = "0x248BD10")]
      protected Color()
      {
      }
    }

    [Token(Token = "0x200041E")]
    private class NoneColor : ParameterColorCode.Color
    {
      [Token(Token = "0x170002A0")]
      public override string ColorCode
      {
        [Token(Token = "0x6001754"), Address(RVA = "0x248BD18", Offset = "0x248BD18", VA = "0x248BD18", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001755")]
      [Address(RVA = "0x248BC3C", Offset = "0x248BC3C", VA = "0x248BC3C")]
      public NoneColor()
      {
      }
    }

    [Token(Token = "0x200041F")]
    private class PositiveColor : ParameterColorCode.Color
    {
      [Token(Token = "0x170002A1")]
      public override string ColorCode
      {
        [Token(Token = "0x6001756"), Address(RVA = "0x248BD58", Offset = "0x248BD58", VA = "0x248BD58", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001757")]
      [Address(RVA = "0x248BC44", Offset = "0x248BC44", VA = "0x248BC44")]
      public PositiveColor()
      {
      }
    }

    [Token(Token = "0x2000420")]
    private class NegativeColor : ParameterColorCode.Color
    {
      [Token(Token = "0x170002A2")]
      public override string ColorCode
      {
        [Token(Token = "0x6001758"), Address(RVA = "0x248BD98", Offset = "0x248BD98", VA = "0x248BD98", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001759")]
      [Address(RVA = "0x248BC4C", Offset = "0x248BC4C", VA = "0x248BC4C")]
      public NegativeColor()
      {
      }
    }
  }
}
