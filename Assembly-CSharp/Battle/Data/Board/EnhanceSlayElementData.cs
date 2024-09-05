// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnhanceSlayElementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027BE")]
  public class EnhanceSlayElementData : ModifierEffectData
  {
    [Token(Token = "0x400A95B")]
    [FieldOffset(Offset = "0x94")]
    private EnhanceSlayElementData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x1700358A")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F84A"), Address(RVA = "0x1EE01AC", Offset = "0x1EE01AC", VA = "0x1EE01AC", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F84B")]
    [Address(RVA = "0x1EDC328", Offset = "0x1EDC328", VA = "0x1EDC328")]
    public static EnhanceSlayElementData Create(EffectSource source)
    {
      return (EnhanceSlayElementData) null;
    }

    [Token(Token = "0x600F84C")]
    [Address(RVA = "0x1EE0210", Offset = "0x1EE0210", VA = "0x1EE0210")]
    protected EnhanceSlayElementData(EffectSource source)
    {
    }

    [Token(Token = "0x600F84D")]
    [Address(RVA = "0x1EE0394", Offset = "0x1EE0394", VA = "0x1EE0394", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F84E")]
    [Address(RVA = "0x1EE03F4", Offset = "0x1EE03F4", VA = "0x1EE03F4", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027BF")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x1700358B")]
      public int ValueType
      {
        [Token(Token = "0x600F84F"), Address(RVA = "0x44BA89C", Offset = "0x44BA89C", VA = "0x44BA89C", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F850"), Address(RVA = "0x44BA8A4", Offset = "0x44BA8A4", VA = "0x44BA8A4")] set
        {
        }
      }

      [Token(Token = "0x1700358C")]
      public int FIRE
      {
        [Token(Token = "0x600F851"), Address(RVA = "0x44BA8AC", Offset = "0x44BA8AC", VA = "0x44BA8AC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F852"), Address(RVA = "0x44BA8B4", Offset = "0x44BA8B4", VA = "0x44BA8B4")] set
        {
        }
      }

      [Token(Token = "0x1700358D")]
      public int ICE
      {
        [Token(Token = "0x600F853"), Address(RVA = "0x44BA8BC", Offset = "0x44BA8BC", VA = "0x44BA8BC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F854"), Address(RVA = "0x44BA8C4", Offset = "0x44BA8C4", VA = "0x44BA8C4")] set
        {
        }
      }

      [Token(Token = "0x1700358E")]
      public int THUNDER
      {
        [Token(Token = "0x600F855"), Address(RVA = "0x44BA8CC", Offset = "0x44BA8CC", VA = "0x44BA8CC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F856"), Address(RVA = "0x44BA8D4", Offset = "0x44BA8D4", VA = "0x44BA8D4")] set
        {
        }
      }

      [Token(Token = "0x1700358F")]
      public int WIND
      {
        [Token(Token = "0x600F857"), Address(RVA = "0x44BA8DC", Offset = "0x44BA8DC", VA = "0x44BA8DC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F858"), Address(RVA = "0x44BA8E4", Offset = "0x44BA8E4", VA = "0x44BA8E4")] set
        {
        }
      }

      [Token(Token = "0x17003590")]
      public int LIGHT
      {
        [Token(Token = "0x600F859"), Address(RVA = "0x44BA8EC", Offset = "0x44BA8EC", VA = "0x44BA8EC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F85A"), Address(RVA = "0x44BA8F4", Offset = "0x44BA8F4", VA = "0x44BA8F4")] set
        {
        }
      }

      [Token(Token = "0x17003591")]
      public int DARK
      {
        [Token(Token = "0x600F85B"), Address(RVA = "0x44BA8FC", Offset = "0x44BA8FC", VA = "0x44BA8FC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F85C"), Address(RVA = "0x44BA904", Offset = "0x44BA904", VA = "0x44BA904")] set
        {
        }
      }
    }
  }
}
