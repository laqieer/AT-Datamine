// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnhanceSlayRideData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027C2")]
  public class EnhanceSlayRideData : ModifierEffectData
  {
    [Token(Token = "0x400A969")]
    [FieldOffset(Offset = "0x94")]
    private EnhanceSlayRideData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x17003598")]
    public Dictionary<int, string> ParameterTextMap
    {
      [Token(Token = "0x600F86C"), Address(RVA = "0x44BAFA4", Offset = "0x44BAFA4", VA = "0x44BAFA4")] get
      {
        return (Dictionary<int, string>) null;
      }
    }

    [Token(Token = "0x17003599")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F86D"), Address(RVA = "0x44BAFAC", Offset = "0x44BAFAC", VA = "0x44BAFAC", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F86E")]
    [Address(RVA = "0x44BB008", Offset = "0x44BB008", VA = "0x44BB008")]
    public static EnhanceSlayRideData Create(EffectSource source) => (EnhanceSlayRideData) null;

    [Token(Token = "0x600F86F")]
    [Address(RVA = "0x44BB094", Offset = "0x44BB094", VA = "0x44BB094")]
    protected EnhanceSlayRideData(EffectSource source)
    {
    }

    [Token(Token = "0x600F870")]
    [Address(RVA = "0x44BB178", Offset = "0x44BB178", VA = "0x44BB178", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F871")]
    [Address(RVA = "0x44BB1DC", Offset = "0x44BB1DC", VA = "0x44BB1DC", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027C3")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x1700359A")]
      public int ValueType
      {
        [Token(Token = "0x600F872"), Address(RVA = "0x44BB360", Offset = "0x44BB360", VA = "0x44BB360", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F873"), Address(RVA = "0x44BB368", Offset = "0x44BB368", VA = "0x44BB368")] set
        {
        }
      }

      [Token(Token = "0x1700359B")]
      public int INFANTRY
      {
        [Token(Token = "0x600F874"), Address(RVA = "0x44BB370", Offset = "0x44BB370", VA = "0x44BB370")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F875"), Address(RVA = "0x44BB378", Offset = "0x44BB378", VA = "0x44BB378")] set
        {
        }
      }

      [Token(Token = "0x1700359C")]
      public int LIGHT_INFANTRY
      {
        [Token(Token = "0x600F876"), Address(RVA = "0x44BB380", Offset = "0x44BB380", VA = "0x44BB380")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F877"), Address(RVA = "0x44BB388", Offset = "0x44BB388", VA = "0x44BB388")] set
        {
        }
      }

      [Token(Token = "0x1700359D")]
      public int DEFAULT
      {
        [Token(Token = "0x600F878"), Address(RVA = "0x44BB390", Offset = "0x44BB390", VA = "0x44BB390")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F879"), Address(RVA = "0x44BB398", Offset = "0x44BB398", VA = "0x44BB398")] set
        {
        }
      }
    }
  }
}
