// Decompiled with JetBrains decompiler
// Type: Gacha.GachaHeaderInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014F9")]
  internal class GachaHeaderInfo
  {
    [Token(Token = "0x17001252")]
    public List<MedalItem> medals
    {
      [Token(Token = "0x600768E"), Address(RVA = "0x44EA424", Offset = "0x44EA424", VA = "0x44EA424")] get
      {
        return (List<MedalItem>) null;
      }
      [Token(Token = "0x600768F"), Address(RVA = "0x44EA42C", Offset = "0x44EA42C", VA = "0x44EA42C")] private set
      {
      }
    }

    [Token(Token = "0x17001253")]
    public List<GachaTicketItem> tickets
    {
      [Token(Token = "0x6007690"), Address(RVA = "0x44EA434", Offset = "0x44EA434", VA = "0x44EA434")] get
      {
        return (List<GachaTicketItem>) null;
      }
      [Token(Token = "0x6007691"), Address(RVA = "0x44EA43C", Offset = "0x44EA43C", VA = "0x44EA43C")] private set
      {
      }
    }

    [Token(Token = "0x17001254")]
    public bool IsEnableMedalHeader
    {
      [Token(Token = "0x6007692"), Address(RVA = "0x44EA444", Offset = "0x44EA444", VA = "0x44EA444")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001255")]
    public bool IsEnableTicketHeader
    {
      [Token(Token = "0x6007693"), Address(RVA = "0x44EA494", Offset = "0x44EA494", VA = "0x44EA494")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001256")]
    public int TotalCoinNum
    {
      [Token(Token = "0x6007694"), Address(RVA = "0x44EA4E4", Offset = "0x44EA4E4", VA = "0x44EA4E4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001257")]
    public int TotalTicketNum
    {
      [Token(Token = "0x6007695"), Address(RVA = "0x44EA558", Offset = "0x44EA558", VA = "0x44EA558")] get
      {
        return new int();
      }
      [Token(Token = "0x6007696"), Address(RVA = "0x44EA560", Offset = "0x44EA560", VA = "0x44EA560")] private set
      {
      }
    }

    [Token(Token = "0x17001258")]
    public int TotalMedalNum
    {
      [Token(Token = "0x6007697"), Address(RVA = "0x44EA568", Offset = "0x44EA568", VA = "0x44EA568")] get
      {
        return new int();
      }
      [Token(Token = "0x6007698"), Address(RVA = "0x44EA570", Offset = "0x44EA570", VA = "0x44EA570")] private set
      {
      }
    }

    [Token(Token = "0x6007699")]
    [Address(RVA = "0x44EA578", Offset = "0x44EA578", VA = "0x44EA578")]
    public GachaHeaderInfo(GachaDetailGroupInfo gachaDetailGroupInfo)
    {
    }

    [Token(Token = "0x600769A")]
    [Address(RVA = "0x44EA7E4", Offset = "0x44EA7E4", VA = "0x44EA7E4")]
    private void InitializeMedals(GachaDetailGroupInfo gachaDetailGroupInfo)
    {
    }

    [Token(Token = "0x600769B")]
    [Address(RVA = "0x44EAE30", Offset = "0x44EAE30", VA = "0x44EAE30")]
    private void InitializeGachaTickets(GachaDetailGroupInfo gachaDetailGroupInfo)
    {
    }
  }
}
