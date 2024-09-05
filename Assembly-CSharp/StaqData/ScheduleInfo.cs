// Decompiled with JetBrains decompiler
// Type: StaqData.ScheduleInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002141")]
  public class ScheduleInfo
  {
    [Token(Token = "0x17002C8F")]
    public DateTime StartAt
    {
      [Token(Token = "0x600CBCA"), Address(RVA = "0x1BAA330", Offset = "0x1BAA330", VA = "0x1BAA330")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600CBCB"), Address(RVA = "0x1BAA338", Offset = "0x1BAA338", VA = "0x1BAA338")] private set
      {
      }
    }

    [Token(Token = "0x17002C90")]
    public DateTime EndAt
    {
      [Token(Token = "0x600CBCC"), Address(RVA = "0x1BAA340", Offset = "0x1BAA340", VA = "0x1BAA340")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600CBCD"), Address(RVA = "0x1BAA348", Offset = "0x1BAA348", VA = "0x1BAA348")] private set
      {
      }
    }

    [Token(Token = "0x600CBCE")]
    [Address(RVA = "0x1BA7748", Offset = "0x1BA7748", VA = "0x1BA7748")]
    public ScheduleInfo(string startAt, string endAt)
    {
    }

    [Token(Token = "0x600CBCF")]
    [Address(RVA = "0x1BAA350", Offset = "0x1BAA350", VA = "0x1BAA350")]
    private static DateTime Parse(string s, DateTime defaultTime) => new DateTime();
  }
}
