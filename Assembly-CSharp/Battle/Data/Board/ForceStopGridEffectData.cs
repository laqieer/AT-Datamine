// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ForceStopGridEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027AE")]
  public class ForceStopGridEffectData : EffectData
  {
    [Token(Token = "0x17003552")]
    public int RangeMin
    {
      [Token(Token = "0x600F7C7"), Address(RVA = "0x1ECFC74", Offset = "0x1ECFC74", VA = "0x1ECFC74")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003553")]
    public int RangeMax
    {
      [Token(Token = "0x600F7C8"), Address(RVA = "0x1ECFCC8", Offset = "0x1ECFCC8", VA = "0x1ECFCC8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F7C9")]
    [Address(RVA = "0x1EDC5FC", Offset = "0x1EDC5FC", VA = "0x1EDC5FC")]
    public static ForceStopGridEffectData Create(EffectSource source)
    {
      return (ForceStopGridEffectData) null;
    }

    [Token(Token = "0x600F7CA")]
    [Address(RVA = "0x1EDDBCC", Offset = "0x1EDDBCC", VA = "0x1EDDBCC")]
    protected ForceStopGridEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F7CB")]
    [Address(RVA = "0x1EDDBFC", Offset = "0x1EDDBFC", VA = "0x1EDDBFC", Slot = "5")]
    public override bool IsEffectable(UnitParameterData from, UnitParameterData to) => new bool();

    [Token(Token = "0x20027AF")]
    public enum ContextType
    {
      [Token(Token = "0x400A91D")] RangeMin,
      [Token(Token = "0x400A91E")] RangeMax,
      [Token(Token = "0x400A91F")] MoveType,
      [Token(Token = "0x400A920")] ElementType1,
      [Token(Token = "0x400A921")] ElementType2,
      [Token(Token = "0x400A922")] ElementType3,
      [Token(Token = "0x400A923")] ElementType4,
      [Token(Token = "0x400A924")] ElementType5,
    }
  }
}
