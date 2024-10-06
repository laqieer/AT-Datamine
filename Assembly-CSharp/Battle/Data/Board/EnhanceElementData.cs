// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnhanceElementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027BA")]
  public class EnhanceElementData : ModifierEffectData
  {
    [Token(Token = "0x400A94E")]
    [FieldOffset(Offset = "0x94")]
    private EnhanceElementData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x1700357C")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F829"), Address(RVA = "0x1EDF924", Offset = "0x1EDF924", VA = "0x1EDF924", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F82A")]
    [Address(RVA = "0x1EDC184", Offset = "0x1EDC184", VA = "0x1EDC184")]
    public static EnhanceElementData Create(EffectSource source) => (EnhanceElementData) null;

    [Token(Token = "0x600F82B")]
    [Address(RVA = "0x1EDF988", Offset = "0x1EDF988", VA = "0x1EDF988")]
    protected EnhanceElementData(EffectSource source)
    {
    }

    [Token(Token = "0x600F82C")]
    [Address(RVA = "0x1EDFB0C", Offset = "0x1EDFB0C", VA = "0x1EDFB0C", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F82D")]
    [Address(RVA = "0x1EDFB6C", Offset = "0x1EDFB6C", VA = "0x1EDFB6C", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027BB")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x1700357D")]
      public int ValueType
      {
        [Token(Token = "0x600F82E"), Address(RVA = "0x1EDFDBC", Offset = "0x1EDFDBC", VA = "0x1EDFDBC", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F82F"), Address(RVA = "0x1EDFDC4", Offset = "0x1EDFDC4", VA = "0x1EDFDC4")] set
        {
        }
      }

      [Token(Token = "0x1700357E")]
      public int Fire
      {
        [Token(Token = "0x600F830"), Address(RVA = "0x1EDFDCC", Offset = "0x1EDFDCC", VA = "0x1EDFDCC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F831"), Address(RVA = "0x1EDFDD4", Offset = "0x1EDFDD4", VA = "0x1EDFDD4")] set
        {
        }
      }

      [Token(Token = "0x1700357F")]
      public int ICE
      {
        [Token(Token = "0x600F832"), Address(RVA = "0x1EDFDDC", Offset = "0x1EDFDDC", VA = "0x1EDFDDC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F833"), Address(RVA = "0x1EDFDE4", Offset = "0x1EDFDE4", VA = "0x1EDFDE4")] set
        {
        }
      }

      [Token(Token = "0x17003580")]
      public int THUNDER
      {
        [Token(Token = "0x600F834"), Address(RVA = "0x1EDFDEC", Offset = "0x1EDFDEC", VA = "0x1EDFDEC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F835"), Address(RVA = "0x1EDFDF4", Offset = "0x1EDFDF4", VA = "0x1EDFDF4")] set
        {
        }
      }

      [Token(Token = "0x17003581")]
      public int WIND
      {
        [Token(Token = "0x600F836"), Address(RVA = "0x1EDFDFC", Offset = "0x1EDFDFC", VA = "0x1EDFDFC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F837"), Address(RVA = "0x1EDFE04", Offset = "0x1EDFE04", VA = "0x1EDFE04")] set
        {
        }
      }

      [Token(Token = "0x17003582")]
      public int LIGHT
      {
        [Token(Token = "0x600F838"), Address(RVA = "0x1EDFE0C", Offset = "0x1EDFE0C", VA = "0x1EDFE0C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F839"), Address(RVA = "0x1EDFE14", Offset = "0x1EDFE14", VA = "0x1EDFE14")] set
        {
        }
      }

      [Token(Token = "0x17003583")]
      public int DARK
      {
        [Token(Token = "0x600F83A"), Address(RVA = "0x1EDFE1C", Offset = "0x1EDFE1C", VA = "0x1EDFE1C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F83B"), Address(RVA = "0x1EDFE24", Offset = "0x1EDFE24", VA = "0x1EDFE24")] set
        {
        }
      }
    }
  }
}
