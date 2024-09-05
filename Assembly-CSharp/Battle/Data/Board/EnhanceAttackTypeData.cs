// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnhanceAttackTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027B6")]
  public class EnhanceAttackTypeData : ModifierEffectData
  {
    [Token(Token = "0x400A939")]
    [FieldOffset(Offset = "0x94")]
    private EnhanceAttackTypeData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x17003566")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F7F8"), Address(RVA = "0x1EDECD4", Offset = "0x1EDECD4", VA = "0x1EDECD4", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F7F9")]
    [Address(RVA = "0x1EDC210", Offset = "0x1EDC210", VA = "0x1EDC210")]
    public static EnhanceAttackTypeData Create(EffectSource source) => (EnhanceAttackTypeData) null;

    [Token(Token = "0x600F7FA")]
    [Address(RVA = "0x1EDED38", Offset = "0x1EDED38", VA = "0x1EDED38")]
    protected EnhanceAttackTypeData(EffectSource source)
    {
    }

    [Token(Token = "0x600F7FB")]
    [Address(RVA = "0x1EDEE8C", Offset = "0x1EDEE8C", VA = "0x1EDEE8C", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F7FC")]
    [Address(RVA = "0x1EDEEEC", Offset = "0x1EDEEEC", VA = "0x1EDEEEC", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027B7")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x17003567")]
      public int ValueType
      {
        [Token(Token = "0x600F7FD"), Address(RVA = "0x1EDF0F8", Offset = "0x1EDF0F8", VA = "0x1EDF0F8", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F7FE"), Address(RVA = "0x1EDF100", Offset = "0x1EDF100", VA = "0x1EDF100")] set
        {
        }
      }

      [Token(Token = "0x17003568")]
      public int SLASH
      {
        [Token(Token = "0x600F7FF"), Address(RVA = "0x1EDF108", Offset = "0x1EDF108", VA = "0x1EDF108")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F800"), Address(RVA = "0x1EDF110", Offset = "0x1EDF110", VA = "0x1EDF110")] set
        {
        }
      }

      [Token(Token = "0x17003569")]
      public int THRUS
      {
        [Token(Token = "0x600F801"), Address(RVA = "0x1EDF118", Offset = "0x1EDF118", VA = "0x1EDF118")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F802"), Address(RVA = "0x1EDF120", Offset = "0x1EDF120", VA = "0x1EDF120")] set
        {
        }
      }

      [Token(Token = "0x1700356A")]
      public int BLOW
      {
        [Token(Token = "0x600F803"), Address(RVA = "0x1EDF128", Offset = "0x1EDF128", VA = "0x1EDF128")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F804"), Address(RVA = "0x1EDF130", Offset = "0x1EDF130", VA = "0x1EDF130")] set
        {
        }
      }

      [Token(Token = "0x1700356B")]
      public int SHOOT
      {
        [Token(Token = "0x600F805"), Address(RVA = "0x1EDF138", Offset = "0x1EDF138", VA = "0x1EDF138")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F806"), Address(RVA = "0x1EDF140", Offset = "0x1EDF140", VA = "0x1EDF140")] set
        {
        }
      }

      [Token(Token = "0x1700356C")]
      public int MAGIC
      {
        [Token(Token = "0x600F807"), Address(RVA = "0x1EDF148", Offset = "0x1EDF148", VA = "0x1EDF148")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F808"), Address(RVA = "0x1EDF150", Offset = "0x1EDF150", VA = "0x1EDF150")] set
        {
        }
      }
    }
  }
}
