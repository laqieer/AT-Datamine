// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDCoinModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x200198E")]
  public class FgGIDCoinModel
  {
    [Token(Token = "0x17001783")]
    public List<FgGIDCoinData> FgGIDCoinDatas
    {
      [Token(Token = "0x60091E7"), Address(RVA = "0x4D0D694", Offset = "0x4D0D694", VA = "0x4D0D694")] get
      {
        return (List<FgGIDCoinData>) null;
      }
      [Token(Token = "0x60091E8"), Address(RVA = "0x4D0D69C", Offset = "0x4D0D69C", VA = "0x4D0D69C")] private set
      {
      }
    }

    [Token(Token = "0x17001784")]
    public int CoinAmount
    {
      [Token(Token = "0x60091E9"), Address(RVA = "0x4D0D6A4", Offset = "0x4D0D6A4", VA = "0x4D0D6A4")] get
      {
        return new int();
      }
      [Token(Token = "0x60091EA"), Address(RVA = "0x4D0D6AC", Offset = "0x4D0D6AC", VA = "0x4D0D6AC")] private set
      {
      }
    }

    [Token(Token = "0x17001785")]
    public int DisappearCoinAmount
    {
      [Token(Token = "0x60091EB"), Address(RVA = "0x4D0D6B4", Offset = "0x4D0D6B4", VA = "0x4D0D6B4")] get
      {
        return new int();
      }
      [Token(Token = "0x60091EC"), Address(RVA = "0x4D0D6BC", Offset = "0x4D0D6BC", VA = "0x4D0D6BC")] private set
      {
      }
    }

    [Token(Token = "0x60091ED")]
    [Address(RVA = "0x4D0D6C4", Offset = "0x4D0D6C4", VA = "0x4D0D6C4")]
    private FgGIDCoinModel(List<FgGIDCoinData> fgGIDCoinDatas)
    {
    }

    [Token(Token = "0x60091EE")]
    [Address(RVA = "0x4D0D6F0", Offset = "0x4D0D6F0", VA = "0x4D0D6F0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x60091EF")]
    [Address(RVA = "0x4D0D948", Offset = "0x4D0D948", VA = "0x4D0D948")]
    private static bool IsThisMonth(DateTime dateTime) => new bool();

    [Token(Token = "0x60091F0")]
    [Address(RVA = "0x4D0A78C", Offset = "0x4D0A78C", VA = "0x4D0A78C")]
    public static FgGIDCoinModel CreateFrom(List<FgGIDCoinData> fgGIDCoinDatas)
    {
      return (FgGIDCoinModel) null;
    }
  }
}
