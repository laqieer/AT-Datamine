// Decompiled with JetBrains decompiler
// Type: StaqData.PossessionAmountInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002057")]
  public struct PossessionAmountInfo
  {
    [Token(Token = "0x17002909")]
    public int Amount
    {
      [Token(Token = "0x600C2FA"), Address(RVA = "0x19EEFA0", Offset = "0x19EEFA0", VA = "0x19EEFA0")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600C2FB"), Address(RVA = "0x19EEFA8", Offset = "0x19EEFA8", VA = "0x19EEFA8")] private set
      {
      }
    }

    [Token(Token = "0x1700290A")]
    public int ShowLimit
    {
      [Token(Token = "0x600C2FC"), Address(RVA = "0x19EEFB0", Offset = "0x19EEFB0", VA = "0x19EEFB0")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600C2FD"), Address(RVA = "0x19EEFB8", Offset = "0x19EEFB8", VA = "0x19EEFB8")] private set
      {
      }
    }

    [Token(Token = "0x1700290B")]
    public int PossessionLimit
    {
      [Token(Token = "0x600C2FE"), Address(RVA = "0x19EEFC0", Offset = "0x19EEFC0", VA = "0x19EEFC0")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600C2FF"), Address(RVA = "0x19EEFC8", Offset = "0x19EEFC8", VA = "0x19EEFC8")] private set
      {
      }
    }

    [Token(Token = "0x1700290C")]
    public bool HasShowLimit
    {
      [Token(Token = "0x600C300"), Address(RVA = "0x19EEFD0", Offset = "0x19EEFD0", VA = "0x19EEFD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700290D")]
    public bool HasPossessionLimit
    {
      [Token(Token = "0x600C301"), Address(RVA = "0x19EEFE0", Offset = "0x19EEFE0", VA = "0x19EEFE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700290E")]
    public int RoundedAmountByShowLimit
    {
      [Token(Token = "0x600C302"), Address(RVA = "0x19EEFF0", Offset = "0x19EEFF0", VA = "0x19EEFF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700290F")]
    public int RoundedAmountByPossessionLimit
    {
      [Token(Token = "0x600C303"), Address(RVA = "0x19EF004", Offset = "0x19EF004", VA = "0x19EF004")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002910")]
    public bool IsOverPossessionLimit
    {
      [Token(Token = "0x600C304"), Address(RVA = "0x19EF01C", Offset = "0x19EF01C", VA = "0x19EF01C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002911")]
    public bool IsOverShowLimit
    {
      [Token(Token = "0x600C305"), Address(RVA = "0x19EF03C", Offset = "0x19EF03C", VA = "0x19EF03C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C306")]
    [Address(RVA = "0x19EF05C", Offset = "0x19EF05C", VA = "0x19EF05C")]
    public PossessionAmountInfo(int amount, int showLimit, int possessionLimit)
    {
    }

    [Token(Token = "0x600C307")]
    [Address(RVA = "0x19EF068", Offset = "0x19EF068", VA = "0x19EF068")]
    public PossessionAmountInfo(int amount)
    {
    }
  }
}
