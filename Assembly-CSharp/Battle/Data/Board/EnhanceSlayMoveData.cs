// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnhanceSlayMoveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027C0")]
  public class EnhanceSlayMoveData : ModifierEffectData
  {
    [Token(Token = "0x400A963")]
    [FieldOffset(Offset = "0x94")]
    private EnhanceSlayMoveData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x17003592")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F85D"), Address(RVA = "0x44BA90C", Offset = "0x44BA90C", VA = "0x44BA90C", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F85E")]
    [Address(RVA = "0x44BA970", Offset = "0x44BA970", VA = "0x44BA970")]
    public static EnhanceSlayMoveData Create(EffectSource source) => (EnhanceSlayMoveData) null;

    [Token(Token = "0x600F85F")]
    [Address(RVA = "0x44BA9FC", Offset = "0x44BA9FC", VA = "0x44BA9FC")]
    protected EnhanceSlayMoveData(EffectSource source)
    {
    }

    [Token(Token = "0x600F860")]
    [Address(RVA = "0x44BAD28", Offset = "0x44BAD28", VA = "0x44BAD28", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F861")]
    [Address(RVA = "0x44BAD8C", Offset = "0x44BAD8C", VA = "0x44BAD8C", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027C1")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x17003593")]
      public int ValueType
      {
        [Token(Token = "0x600F862"), Address(RVA = "0x44BAF54", Offset = "0x44BAF54", VA = "0x44BAF54", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F863"), Address(RVA = "0x44BAF5C", Offset = "0x44BAF5C", VA = "0x44BAF5C")] set
        {
        }
      }

      [Token(Token = "0x17003594")]
      public int Infantry
      {
        [Token(Token = "0x600F864"), Address(RVA = "0x44BAF64", Offset = "0x44BAF64", VA = "0x44BAF64")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F865"), Address(RVA = "0x44BAF6C", Offset = "0x44BAF6C", VA = "0x44BAF6C")] set
        {
        }
      }

      [Token(Token = "0x17003595")]
      public int Fly
      {
        [Token(Token = "0x600F866"), Address(RVA = "0x44BAF74", Offset = "0x44BAF74", VA = "0x44BAF74")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F867"), Address(RVA = "0x44BAF7C", Offset = "0x44BAF7C", VA = "0x44BAF7C")] set
        {
        }
      }

      [Token(Token = "0x17003596")]
      public int Equestrian
      {
        [Token(Token = "0x600F868"), Address(RVA = "0x44BAF84", Offset = "0x44BAF84", VA = "0x44BAF84")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F869"), Address(RVA = "0x44BAF8C", Offset = "0x44BAF8C", VA = "0x44BAF8C")] set
        {
        }
      }

      [Token(Token = "0x17003597")]
      public int Floating
      {
        [Token(Token = "0x600F86A"), Address(RVA = "0x44BAF94", Offset = "0x44BAF94", VA = "0x44BAF94")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F86B"), Address(RVA = "0x44BAF9C", Offset = "0x44BAF9C", VA = "0x44BAF9C")] set
        {
        }
      }
    }
  }
}
