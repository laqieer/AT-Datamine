// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnhanceBadStatusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027B8")]
  public class EnhanceBadStatusData : ModifierEffectData
  {
    [Token(Token = "0x400A940")]
    [FieldOffset(Offset = "0x94")]
    private EnhanceBadStatusData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x1700356D")]
    public Dictionary<int, string> ParameterTextMap
    {
      [Token(Token = "0x600F809"), Address(RVA = "0x1EDF158", Offset = "0x1EDF158", VA = "0x1EDF158")] get
      {
        return (Dictionary<int, string>) null;
      }
    }

    [Token(Token = "0x1700356E")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F80A"), Address(RVA = "0x1EDF160", Offset = "0x1EDF160", VA = "0x1EDF160", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F80B")]
    [Address(RVA = "0x1EDC29C", Offset = "0x1EDC29C", VA = "0x1EDC29C")]
    public static EnhanceBadStatusData Create(EffectSource source) => (EnhanceBadStatusData) null;

    [Token(Token = "0x600F80C")]
    [Address(RVA = "0x1EDF1D0", Offset = "0x1EDF1D0", VA = "0x1EDF1D0")]
    protected EnhanceBadStatusData(EffectSource source)
    {
    }

    [Token(Token = "0x600F80D")]
    [Address(RVA = "0x1EDF450", Offset = "0x1EDF450", VA = "0x1EDF450", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F80E")]
    [Address(RVA = "0x1EDF4B0", Offset = "0x1EDF4B0", VA = "0x1EDF4B0", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027B9")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x1700356F")]
      public int ValueType
      {
        [Token(Token = "0x600F80F"), Address(RVA = "0x1EDF854", Offset = "0x1EDF854", VA = "0x1EDF854", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F810"), Address(RVA = "0x1EDF85C", Offset = "0x1EDF85C", VA = "0x1EDF85C")] set
        {
        }
      }

      [Token(Token = "0x17003570")]
      public int PROVOCATION
      {
        [Token(Token = "0x600F811"), Address(RVA = "0x1EDF864", Offset = "0x1EDF864", VA = "0x1EDF864")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F812"), Address(RVA = "0x1EDF86C", Offset = "0x1EDF86C", VA = "0x1EDF86C")] set
        {
        }
      }

      [Token(Token = "0x17003571")]
      public int CONFUSION
      {
        [Token(Token = "0x600F813"), Address(RVA = "0x1EDF874", Offset = "0x1EDF874", VA = "0x1EDF874")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F814"), Address(RVA = "0x1EDF87C", Offset = "0x1EDF87C", VA = "0x1EDF87C")] set
        {
        }
      }

      [Token(Token = "0x17003572")]
      public int AGITATION
      {
        [Token(Token = "0x600F815"), Address(RVA = "0x1EDF884", Offset = "0x1EDF884", VA = "0x1EDF884")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F816"), Address(RVA = "0x1EDF88C", Offset = "0x1EDF88C", VA = "0x1EDF88C")] set
        {
        }
      }

      [Token(Token = "0x17003573")]
      public int CHARMED
      {
        [Token(Token = "0x600F817"), Address(RVA = "0x1EDF894", Offset = "0x1EDF894", VA = "0x1EDF894")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F818"), Address(RVA = "0x1EDF89C", Offset = "0x1EDF89C", VA = "0x1EDF89C")] set
        {
        }
      }

      [Token(Token = "0x17003574")]
      public int BERSERK
      {
        [Token(Token = "0x600F819"), Address(RVA = "0x1EDF8A4", Offset = "0x1EDF8A4", VA = "0x1EDF8A4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F81A"), Address(RVA = "0x1EDF8AC", Offset = "0x1EDF8AC", VA = "0x1EDF8AC")] set
        {
        }
      }

      [Token(Token = "0x17003575")]
      public int BURNED
      {
        [Token(Token = "0x600F81B"), Address(RVA = "0x1EDF8B4", Offset = "0x1EDF8B4", VA = "0x1EDF8B4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F81C"), Address(RVA = "0x1EDF8BC", Offset = "0x1EDF8BC", VA = "0x1EDF8BC")] set
        {
        }
      }

      [Token(Token = "0x17003576")]
      public int SLEEP
      {
        [Token(Token = "0x600F81D"), Address(RVA = "0x1EDF8C4", Offset = "0x1EDF8C4", VA = "0x1EDF8C4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F81E"), Address(RVA = "0x1EDF8CC", Offset = "0x1EDF8CC", VA = "0x1EDF8CC")] set
        {
        }
      }

      [Token(Token = "0x17003577")]
      public int PARALYSIS
      {
        [Token(Token = "0x600F81F"), Address(RVA = "0x1EDF8D4", Offset = "0x1EDF8D4", VA = "0x1EDF8D4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F820"), Address(RVA = "0x1EDF8DC", Offset = "0x1EDF8DC", VA = "0x1EDF8DC")] set
        {
        }
      }

      [Token(Token = "0x17003578")]
      public int POISON
      {
        [Token(Token = "0x600F821"), Address(RVA = "0x1EDF8E4", Offset = "0x1EDF8E4", VA = "0x1EDF8E4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F822"), Address(RVA = "0x1EDF8EC", Offset = "0x1EDF8EC", VA = "0x1EDF8EC")] set
        {
        }
      }

      [Token(Token = "0x17003579")]
      public int BLEEDING
      {
        [Token(Token = "0x600F823"), Address(RVA = "0x1EDF8F4", Offset = "0x1EDF8F4", VA = "0x1EDF8F4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F824"), Address(RVA = "0x1EDF8FC", Offset = "0x1EDF8FC", VA = "0x1EDF8FC")] set
        {
        }
      }

      [Token(Token = "0x1700357A")]
      public int DAZZLEMENT
      {
        [Token(Token = "0x600F825"), Address(RVA = "0x1EDF904", Offset = "0x1EDF904", VA = "0x1EDF904")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F826"), Address(RVA = "0x1EDF90C", Offset = "0x1EDF90C", VA = "0x1EDF90C")] set
        {
        }
      }

      [Token(Token = "0x1700357B")]
      public int DARKNESS
      {
        [Token(Token = "0x600F827"), Address(RVA = "0x1EDF914", Offset = "0x1EDF914", VA = "0x1EDF914")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F828"), Address(RVA = "0x1EDF91C", Offset = "0x1EDF91C", VA = "0x1EDF91C")] set
        {
        }
      }
    }
  }
}
