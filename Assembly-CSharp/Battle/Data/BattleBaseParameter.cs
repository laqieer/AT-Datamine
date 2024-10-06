// Decompiled with JetBrains decompiler
// Type: Battle.Data.BattleBaseParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002719")]
  public class BattleBaseParameter : IBasicParameter
  {
    [Token(Token = "0x400A742")]
    [FieldOffset(Offset = "0x10")]
    protected BasicParameter BasicParam;

    [Token(Token = "0x170033B6")]
    public int MinDamage
    {
      [Token(Token = "0x600F2DB"), Address(RVA = "0x41BB864", Offset = "0x41BB864", VA = "0x41BB864")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2DC"), Address(RVA = "0x41BB86C", Offset = "0x41BB86C", VA = "0x41BB86C")] protected set
      {
      }
    }

    [Token(Token = "0x170033B7")]
    public int MaxDamage
    {
      [Token(Token = "0x600F2DD"), Address(RVA = "0x41BB874", Offset = "0x41BB874", VA = "0x41BB874")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2DE"), Address(RVA = "0x41BB87C", Offset = "0x41BB87C", VA = "0x41BB87C")] protected set
      {
      }
    }

    [Token(Token = "0x170033B8")]
    public int Life
    {
      [Token(Token = "0x600F2DF"), Address(RVA = "0x41BB884", Offset = "0x41BB884", VA = "0x41BB884", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033B9")]
    public int Strength
    {
      [Token(Token = "0x600F2E0"), Address(RVA = "0x41BB8A0", Offset = "0x41BB8A0", VA = "0x41BB8A0", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033BA")]
    public int Intelligence
    {
      [Token(Token = "0x600F2E1"), Address(RVA = "0x41BB8BC", Offset = "0x41BB8BC", VA = "0x41BB8BC", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033BB")]
    public int Vitality
    {
      [Token(Token = "0x600F2E2"), Address(RVA = "0x41BB8D8", Offset = "0x41BB8D8", VA = "0x41BB8D8", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033BC")]
    public int Mind
    {
      [Token(Token = "0x600F2E3"), Address(RVA = "0x41BB8F4", Offset = "0x41BB8F4", VA = "0x41BB8F4", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033BD")]
    public int Agility
    {
      [Token(Token = "0x600F2E4"), Address(RVA = "0x41BB910", Offset = "0x41BB910", VA = "0x41BB910", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033BE")]
    public int Dexterity
    {
      [Token(Token = "0x600F2E5"), Address(RVA = "0x41BB92C", Offset = "0x41BB92C", VA = "0x41BB92C", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033BF")]
    public int Lucky
    {
      [Token(Token = "0x600F2E6"), Address(RVA = "0x41BB948", Offset = "0x41BB948", VA = "0x41BB948", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F2E7")]
    [Address(RVA = "0x41BB964", Offset = "0x41BB964", VA = "0x41BB964")]
    public BattleBaseParameter(IBasicParameter basicParam, int minDamage, int maxDamage)
    {
    }

    [Token(Token = "0x600F2E8")]
    [Address(RVA = "0x41BBA2C", Offset = "0x41BBA2C", VA = "0x41BBA2C", Slot = "12")]
    public virtual void Update(BattleBaseParameter param)
    {
    }
  }
}
