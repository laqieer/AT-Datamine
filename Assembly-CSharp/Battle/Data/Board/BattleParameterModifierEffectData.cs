// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BattleParameterModifierEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027B2")]
  public class BattleParameterModifierEffectData : ModifierEffectData
  {
    [Token(Token = "0x400A929")]
    [FieldOffset(Offset = "0x94")]
    private BattleParameterModifierEffectData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x17003555")]
    public Dictionary<int, string> ParameterTextMap
    {
      [Token(Token = "0x600F7D1"), Address(RVA = "0x1EDDEF0", Offset = "0x1EDDEF0", VA = "0x1EDDEF0")] get
      {
        return (Dictionary<int, string>) null;
      }
    }

    [Token(Token = "0x17003556")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F7D2"), Address(RVA = "0x1EDDEF8", Offset = "0x1EDDEF8", VA = "0x1EDDEF8", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F7D3")]
    [Address(RVA = "0x1EDC0F8", Offset = "0x1EDC0F8", VA = "0x1EDC0F8")]
    public static BattleParameterModifierEffectData Create(EffectSource source)
    {
      return (BattleParameterModifierEffectData) null;
    }

    [Token(Token = "0x600F7D4")]
    [Address(RVA = "0x1EDDF60", Offset = "0x1EDDF60", VA = "0x1EDDF60")]
    protected BattleParameterModifierEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F7D5")]
    [Address(RVA = "0x1ED9824", Offset = "0x1ED9824", VA = "0x1ED9824")]
    public BattleBuffTagEnum GetBattleTag() => new BattleBuffTagEnum();

    [Token(Token = "0x600F7D6")]
    [Address(RVA = "0x1EDE18C", Offset = "0x1EDE18C", VA = "0x1EDE18C", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F7D7")]
    [Address(RVA = "0x1EDE5AC", Offset = "0x1EDE5AC", VA = "0x1EDE5AC", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027B3")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x17003557")]
      public int ValueType
      {
        [Token(Token = "0x600F7D8"), Address(RVA = "0x1EDE90C", Offset = "0x1EDE90C", VA = "0x1EDE90C", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7D9"), Address(RVA = "0x1EDE914", Offset = "0x1EDE914", VA = "0x1EDE914")] set
        {
        }
      }

      [Token(Token = "0x17003558")]
      public int HP
      {
        [Token(Token = "0x600F7DA"), Address(RVA = "0x1EDE91C", Offset = "0x1EDE91C", VA = "0x1EDE91C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7DB"), Address(RVA = "0x1EDE924", Offset = "0x1EDE924", VA = "0x1EDE924")] set
        {
        }
      }

      [Token(Token = "0x17003559")]
      public int PhysicsAtk
      {
        [Token(Token = "0x600F7DC"), Address(RVA = "0x1EDE92C", Offset = "0x1EDE92C", VA = "0x1EDE92C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7DD"), Address(RVA = "0x1EDE934", Offset = "0x1EDE934", VA = "0x1EDE934")] set
        {
        }
      }

      [Token(Token = "0x1700355A")]
      public int MagicAtk
      {
        [Token(Token = "0x600F7DE"), Address(RVA = "0x1EDE93C", Offset = "0x1EDE93C", VA = "0x1EDE93C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7DF"), Address(RVA = "0x1EDE944", Offset = "0x1EDE944", VA = "0x1EDE944")] set
        {
        }
      }

      [Token(Token = "0x1700355B")]
      public int PhysicsDef
      {
        [Token(Token = "0x600F7E0"), Address(RVA = "0x1EDE94C", Offset = "0x1EDE94C", VA = "0x1EDE94C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7E1"), Address(RVA = "0x1EDE954", Offset = "0x1EDE954", VA = "0x1EDE954")] set
        {
        }
      }

      [Token(Token = "0x1700355C")]
      public int MagicDef
      {
        [Token(Token = "0x600F7E2"), Address(RVA = "0x1EDE95C", Offset = "0x1EDE95C", VA = "0x1EDE95C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7E3"), Address(RVA = "0x1EDE964", Offset = "0x1EDE964", VA = "0x1EDE964")] set
        {
        }
      }

      [Token(Token = "0x1700355D")]
      public int Hit
      {
        [Token(Token = "0x600F7E4"), Address(RVA = "0x1EDE96C", Offset = "0x1EDE96C", VA = "0x1EDE96C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7E5"), Address(RVA = "0x1EDE974", Offset = "0x1EDE974", VA = "0x1EDE974")] set
        {
        }
      }

      [Token(Token = "0x1700355E")]
      public int Avoid
      {
        [Token(Token = "0x600F7E6"), Address(RVA = "0x1EDE97C", Offset = "0x1EDE97C", VA = "0x1EDE97C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7E7"), Address(RVA = "0x1EDE984", Offset = "0x1EDE984", VA = "0x1EDE984")] set
        {
        }
      }

      [Token(Token = "0x1700355F")]
      public int Critical
      {
        [Token(Token = "0x600F7E8"), Address(RVA = "0x1EDE98C", Offset = "0x1EDE98C", VA = "0x1EDE98C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7E9"), Address(RVA = "0x1EDE994", Offset = "0x1EDE994", VA = "0x1EDE994")] set
        {
        }
      }

      [Token(Token = "0x17003560")]
      public int CriticalAvoid
      {
        [Token(Token = "0x600F7EA"), Address(RVA = "0x1EDE99C", Offset = "0x1EDE99C", VA = "0x1EDE99C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7EB"), Address(RVA = "0x1EDE9A4", Offset = "0x1EDE9A4", VA = "0x1EDE9A4")] set
        {
        }
      }

      [Token(Token = "0x17003561")]
      public int AtkSpeed
      {
        [Token(Token = "0x600F7EC"), Address(RVA = "0x1EDE9AC", Offset = "0x1EDE9AC", VA = "0x1EDE9AC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7ED"), Address(RVA = "0x1EDE9B4", Offset = "0x1EDE9B4", VA = "0x1EDE9B4")] set
        {
        }
      }
    }
  }
}
