// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDCoinData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001977")]
  public class FgGIDCoinData
  {
    [Token(Token = "0x17001765")]
    public int Amount
    {
      [Token(Token = "0x600914C"), Address(RVA = "0x4D09588", Offset = "0x4D09588", VA = "0x4D09588")] get
      {
        return new int();
      }
      [Token(Token = "0x600914D"), Address(RVA = "0x4D09590", Offset = "0x4D09590", VA = "0x4D09590")] private set
      {
      }
    }

    [Token(Token = "0x17001766")]
    public DateTime AddedDateTime
    {
      [Token(Token = "0x600914E"), Address(RVA = "0x4D09598", Offset = "0x4D09598", VA = "0x4D09598")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600914F"), Address(RVA = "0x4D095A0", Offset = "0x4D095A0", VA = "0x4D095A0")] private set
      {
      }
    }

    [Token(Token = "0x17001767")]
    public DateTime ExpireDateTime
    {
      [Token(Token = "0x6009150"), Address(RVA = "0x4D095A8", Offset = "0x4D095A8", VA = "0x4D095A8")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6009151"), Address(RVA = "0x4D095B0", Offset = "0x4D095B0", VA = "0x4D095B0")] private set
      {
      }
    }

    [Token(Token = "0x6009152")]
    [Address(RVA = "0x4D095B8", Offset = "0x4D095B8", VA = "0x4D095B8")]
    public static FgGIDCoinData CreateDummyData(
      int amount,
      string expireDateTimeStr,
      string addedDateTimeStr)
    {
      return (FgGIDCoinData) null;
    }

    [Token(Token = "0x6009153")]
    [Address(RVA = "0x4D09694", Offset = "0x4D09694", VA = "0x4D09694")]
    public static FgGIDCoinData CreateFromServerData(PlayerFggfcCoin serverData)
    {
      return (FgGIDCoinData) null;
    }

    [Token(Token = "0x6009154")]
    [Address(RVA = "0x4D09764", Offset = "0x4D09764", VA = "0x4D09764")]
    public static List<FgGIDCoinData> CreateFromServerData(IEnumerable<PlayerFggfcCoin> serverDatas)
    {
      return (List<FgGIDCoinData>) null;
    }

    [Token(Token = "0x6009155")]
    [Address(RVA = "0x4D0968C", Offset = "0x4D0968C", VA = "0x4D0968C")]
    public FgGIDCoinData()
    {
    }
  }
}
