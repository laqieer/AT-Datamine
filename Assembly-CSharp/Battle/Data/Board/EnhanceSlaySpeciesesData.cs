// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnhanceSlaySpeciesesData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027C4")]
  public class EnhanceSlaySpeciesesData : ModifierEffectData
  {
    [Token(Token = "0x400A96E")]
    [FieldOffset(Offset = "0x94")]
    private EnhanceSlaySpeciesesData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x1700359E")]
    public Dictionary<int, string> ParameterTextMap
    {
      [Token(Token = "0x600F87A"), Address(RVA = "0x44BB3A0", Offset = "0x44BB3A0", VA = "0x44BB3A0")] get
      {
        return (Dictionary<int, string>) null;
      }
    }

    [Token(Token = "0x1700359F")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F87B"), Address(RVA = "0x44BB3A8", Offset = "0x44BB3A8", VA = "0x44BB3A8", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F87C")]
    [Address(RVA = "0x44BB40C", Offset = "0x44BB40C", VA = "0x44BB40C")]
    public static EnhanceSlaySpeciesesData Create(EffectSource source)
    {
      return (EnhanceSlaySpeciesesData) null;
    }

    [Token(Token = "0x600F87D")]
    [Address(RVA = "0x44BB498", Offset = "0x44BB498", VA = "0x44BB498")]
    protected EnhanceSlaySpeciesesData(EffectSource source)
    {
    }

    [Token(Token = "0x600F87E")]
    [Address(RVA = "0x44BB5FC", Offset = "0x44BB5FC", VA = "0x44BB5FC", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F87F")]
    [Address(RVA = "0x44BB660", Offset = "0x44BB660", VA = "0x44BB660", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027C5")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x170035A0")]
      public int ValueType
      {
        [Token(Token = "0x600F880"), Address(RVA = "0x44BB8B0", Offset = "0x44BB8B0", VA = "0x44BB8B0", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F881"), Address(RVA = "0x44BB8B8", Offset = "0x44BB8B8", VA = "0x44BB8B8")] set
        {
        }
      }

      [Token(Token = "0x170035A1")]
      public int HUMAN
      {
        [Token(Token = "0x600F882"), Address(RVA = "0x44BB8C0", Offset = "0x44BB8C0", VA = "0x44BB8C0")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F883"), Address(RVA = "0x44BB8C8", Offset = "0x44BB8C8", VA = "0x44BB8C8")] set
        {
        }
      }

      [Token(Token = "0x170035A2")]
      public int DRAGON
      {
        [Token(Token = "0x600F884"), Address(RVA = "0x44BB8D0", Offset = "0x44BB8D0", VA = "0x44BB8D0")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F885"), Address(RVA = "0x44BB8D8", Offset = "0x44BB8D8", VA = "0x44BB8D8")] set
        {
        }
      }

      [Token(Token = "0x170035A3")]
      public int BEAST
      {
        [Token(Token = "0x600F886"), Address(RVA = "0x44BB8E0", Offset = "0x44BB8E0", VA = "0x44BB8E0")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F887"), Address(RVA = "0x44BB8E8", Offset = "0x44BB8E8", VA = "0x44BB8E8")] set
        {
        }
      }

      [Token(Token = "0x170035A4")]
      public int BARBAROY
      {
        [Token(Token = "0x600F888"), Address(RVA = "0x44BB8F0", Offset = "0x44BB8F0", VA = "0x44BB8F0")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F889"), Address(RVA = "0x44BB8F8", Offset = "0x44BB8F8", VA = "0x44BB8F8")] set
        {
        }
      }

      [Token(Token = "0x170035A5")]
      public int GOD
      {
        [Token(Token = "0x600F88A"), Address(RVA = "0x44BB900", Offset = "0x44BB900", VA = "0x44BB900")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F88B"), Address(RVA = "0x44BB908", Offset = "0x44BB908", VA = "0x44BB908")] set
        {
        }
      }

      [Token(Token = "0x170035A6")]
      public int EVIL
      {
        [Token(Token = "0x600F88C"), Address(RVA = "0x44BB910", Offset = "0x44BB910", VA = "0x44BB910")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F88D"), Address(RVA = "0x44BB918", Offset = "0x44BB918", VA = "0x44BB918")] set
        {
        }
      }
    }
  }
}
