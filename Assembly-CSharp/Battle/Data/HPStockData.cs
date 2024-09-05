// Decompiled with JetBrains decompiler
// Type: Battle.Data.HPStockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200272A")]
  public sealed class HPStockData : IReadableHPStockData
  {
    [Token(Token = "0x400A774")]
    [FieldOffset(Offset = "0x18")]
    private HP[] hpList;

    [Token(Token = "0x600F38A")]
    [Address(RVA = "0x1FA3ED0", Offset = "0x1FA3ED0", VA = "0x1FA3ED0")]
    public static HPStockData CloneFrom(IReadableHPStockData source) => (HPStockData) null;

    [Token(Token = "0x170033E2")]
    public bool IsCalculatedFromParam
    {
      [Token(Token = "0x600F38B"), Address(RVA = "0x1FA441C", Offset = "0x1FA441C", VA = "0x1FA441C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F38C"), Address(RVA = "0x1FA4424", Offset = "0x1FA4424", VA = "0x1FA4424")] private set
      {
      }
    }

    [Token(Token = "0x170033E3")]
    public HP[] HPList
    {
      [Token(Token = "0x600F38D"), Address(RVA = "0x1FA4430", Offset = "0x1FA4430", VA = "0x1FA4430", Slot = "5")] get
      {
        return (HP[]) null;
      }
    }

    [Token(Token = "0x170033E4")]
    public int CurrentHPStockIndex
    {
      [Token(Token = "0x600F38E"), Address(RVA = "0x1FA4438", Offset = "0x1FA4438", VA = "0x1FA4438", Slot = "7")] get
      {
        return new int();
      }
      [Token(Token = "0x600F38F"), Address(RVA = "0x1FA4440", Offset = "0x1FA4440", VA = "0x1FA4440")] private set
      {
      }
    }

    [Token(Token = "0x170033E5")]
    public int RemainingStock
    {
      [Token(Token = "0x600F390"), Address(RVA = "0x1FA4448", Offset = "0x1FA4448", VA = "0x1FA4448", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033E6")]
    public HP HP
    {
      [Token(Token = "0x600F391"), Address(RVA = "0x1FA4470", Offset = "0x1FA4470", VA = "0x1FA4470", Slot = "6")] get
      {
        return (HP) null;
      }
    }

    [Token(Token = "0x170033E7")]
    public int BaseHP
    {
      [Token(Token = "0x600F392"), Address(RVA = "0x1FA44A4", Offset = "0x1FA44A4", VA = "0x1FA44A4", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033E8")]
    public int MaxHP
    {
      [Token(Token = "0x600F393"), Address(RVA = "0x1FA44C0", Offset = "0x1FA44C0", VA = "0x1FA44C0", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033E9")]
    public int CurrentHP
    {
      [Token(Token = "0x600F394"), Address(RVA = "0x1FA44DC", Offset = "0x1FA44DC", VA = "0x1FA44DC", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033EA")]
    public Decimal CurrentHPPercentage
    {
      [Token(Token = "0x600F395"), Address(RVA = "0x1FA44F8", Offset = "0x1FA44F8", VA = "0x1FA44F8", Slot = "9")] get
      {
        return 0M;
      }
    }

    [Token(Token = "0x170033EB")]
    public int CurrentHPPercentageInt
    {
      [Token(Token = "0x600F396"), Address(RVA = "0x1FA45C4", Offset = "0x1FA45C4", VA = "0x1FA45C4", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033EC")]
    public float CurrentHPRatio
    {
      [Token(Token = "0x600F397"), Address(RVA = "0x1FA4650", Offset = "0x1FA4650", VA = "0x1FA4650", Slot = "11")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170033ED")]
    public bool IsAlive
    {
      [Token(Token = "0x600F398"), Address(RVA = "0x1FA4718", Offset = "0x1FA4718", VA = "0x1FA4718", Slot = "15")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170033EE")]
    public int TotalBase
    {
      [Token(Token = "0x600F399"), Address(RVA = "0x1FA477C", Offset = "0x1FA477C", VA = "0x1FA477C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033EF")]
    public int TotalRest
    {
      [Token(Token = "0x600F39A"), Address(RVA = "0x1FA47D0", Offset = "0x1FA47D0", VA = "0x1FA47D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F39B")]
    [Address(RVA = "0x1FA4824", Offset = "0x1FA4824", VA = "0x1FA4824", Slot = "16")]
    public void SwitchNextHP()
    {
    }

    [Token(Token = "0x600F39C")]
    [Address(RVA = "0x1FA41E4", Offset = "0x1FA41E4", VA = "0x1FA41E4")]
    public HPStockData(IReadOnlyList<HP> hpList, int currentIndex, bool isCalculatedFromParam)
    {
    }

    [Token(Token = "0x600F39D")]
    [Address(RVA = "0x1FA489C", Offset = "0x1FA489C", VA = "0x1FA489C")]
    public HPStockData(HPStockData stockData)
    {
    }

    [Token(Token = "0x600F39E")]
    [Address(RVA = "0x1FA4904", Offset = "0x1FA4904", VA = "0x1FA4904")]
    public void Reset()
    {
    }

    [Token(Token = "0x600F39F")]
    [Address(RVA = "0x1FA4998", Offset = "0x1FA4998", VA = "0x1FA4998")]
    public void UpdateCurrentMaxHP(int maxHP)
    {
    }

    [Token(Token = "0x600F3A0")]
    [Address(RVA = "0x1FA4A4C", Offset = "0x1FA4A4C", VA = "0x1FA4A4C")]
    public void ApplyCurrentHPDataTo(IReadableHPStockData data)
    {
    }

    [Token(Token = "0x600F3A1")]
    [Address(RVA = "0x1FA4B60", Offset = "0x1FA4B60", VA = "0x1FA4B60")]
    public void ApplyCurrentHPData(int currentIndex, int nextCurrentHP)
    {
    }

    [Token(Token = "0x600F3A2")]
    [Address(RVA = "0x1FA4B6C", Offset = "0x1FA4B6C", VA = "0x1FA4B6C")]
    public void ApplyCurrentHPData(int nextCurrentHP)
    {
    }

    [Token(Token = "0x600F3A3")]
    [Address(RVA = "0x1FA4C08", Offset = "0x1FA4C08", VA = "0x1FA4C08")]
    public void Empty()
    {
    }

    [Token(Token = "0x600F3A4")]
    [Address(RVA = "0x1FA4C80", Offset = "0x1FA4C80", VA = "0x1FA4C80", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
