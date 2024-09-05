// Decompiled with JetBrains decompiler
// Type: UnitView.ModelView.UI.AnimationBGMove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;

#nullable disable
namespace UnitView.ModelView.UI
{
  [Token(Token = "0x20003D1")]
  public class AnimationBGMove
  {
    [Token(Token = "0x4001674")]
    [FieldOffset(Offset = "0x0")]
    public static readonly AnimationBGMove.PosLeft Left;
    [Token(Token = "0x4001675")]
    [FieldOffset(Offset = "0x8")]
    public static readonly AnimationBGMove.PosRight Right;
    [Token(Token = "0x4001676")]
    private const string AnimationGroupFormat = "BgMove_{0}_{1}";
    [Token(Token = "0x4001677")]
    [FieldOffset(Offset = "0x10")]
    private AnimationBGMove.Pos current;
    [Token(Token = "0x4001678")]
    [FieldOffset(Offset = "0x18")]
    private UITweenGroup tweenGroup;

    [Token(Token = "0x600162A")]
    [Address(RVA = "0x2485424", Offset = "0x2485424", VA = "0x2485424")]
    public AnimationBGMove(UITweenGroup tweenGroup)
    {
    }

    [Token(Token = "0x600162B")]
    [Address(RVA = "0x2485B40", Offset = "0x2485B40", VA = "0x2485B40")]
    public void MoveTo(AnimationBGMove.Pos pos)
    {
    }

    [Token(Token = "0x600162C")]
    [Address(RVA = "0x2485BFC", Offset = "0x2485BFC", VA = "0x2485BFC")]
    static AnimationBGMove()
    {
    }

    [Token(Token = "0x20003D2")]
    public abstract class Pos
    {
      [Token(Token = "0x17000262")]
      public abstract string Character { [Token(Token = "0x600162D")] get; }

      [Token(Token = "0x600162E")]
      [Address(RVA = "0x2485CBC", Offset = "0x2485CBC", VA = "0x2485CBC")]
      protected Pos()
      {
      }
    }

    [Token(Token = "0x20003D3")]
    public class PosLeft : AnimationBGMove.Pos
    {
      [Token(Token = "0x17000263")]
      public override string Character
      {
        [Token(Token = "0x600162F"), Address(RVA = "0x2485CC4", Offset = "0x2485CC4", VA = "0x2485CC4", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001630")]
      [Address(RVA = "0x2485CAC", Offset = "0x2485CAC", VA = "0x2485CAC")]
      public PosLeft()
      {
      }
    }

    [Token(Token = "0x20003D4")]
    public class PosRight : AnimationBGMove.Pos
    {
      [Token(Token = "0x17000264")]
      public override string Character
      {
        [Token(Token = "0x6001631"), Address(RVA = "0x2485D04", Offset = "0x2485D04", VA = "0x2485D04", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001632")]
      [Address(RVA = "0x2485CB4", Offset = "0x2485CB4", VA = "0x2485CB4")]
      public PosRight()
      {
      }
    }
  }
}
