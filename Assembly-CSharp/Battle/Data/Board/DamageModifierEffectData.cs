// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.DamageModifierEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027B4")]
  public class DamageModifierEffectData : ModifierEffectData
  {
    [Token(Token = "0x400A935")]
    [FieldOffset(Offset = "0x94")]
    private DamageModifierEffectData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x17003562")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F7EE"), Address(RVA = "0x1EDE9BC", Offset = "0x1EDE9BC", VA = "0x1EDE9BC", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F7EF")]
    [Address(RVA = "0x1EDC440", Offset = "0x1EDC440", VA = "0x1EDC440")]
    public static DamageModifierEffectData Create(EffectSource source)
    {
      return (DamageModifierEffectData) null;
    }

    [Token(Token = "0x600F7F0")]
    [Address(RVA = "0x1EDEAF4", Offset = "0x1EDEAF4", VA = "0x1EDEAF4", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x600F7F1")]
    [Address(RVA = "0x1EDEA20", Offset = "0x1EDEA20", VA = "0x1EDEA20")]
    protected DamageModifierEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x20027B5")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x17003563")]
      public int ValueType
      {
        [Token(Token = "0x600F7F2"), Address(RVA = "0x1EDECA4", Offset = "0x1EDECA4", VA = "0x1EDECA4", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7F3"), Address(RVA = "0x1EDECAC", Offset = "0x1EDECAC", VA = "0x1EDECAC")] set
        {
        }
      }

      [Token(Token = "0x17003564")]
      public int Physics
      {
        [Token(Token = "0x600F7F4"), Address(RVA = "0x1EDECB4", Offset = "0x1EDECB4", VA = "0x1EDECB4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7F5"), Address(RVA = "0x1EDECBC", Offset = "0x1EDECBC", VA = "0x1EDECBC")] set
        {
        }
      }

      [Token(Token = "0x17003565")]
      public int Magic
      {
        [Token(Token = "0x600F7F6"), Address(RVA = "0x1EDECC4", Offset = "0x1EDECC4", VA = "0x1EDECC4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7F7"), Address(RVA = "0x1EDECCC", Offset = "0x1EDECCC", VA = "0x1EDECCC")] set
        {
        }
      }
    }
  }
}
