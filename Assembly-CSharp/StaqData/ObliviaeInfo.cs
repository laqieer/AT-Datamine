// Decompiled with JetBrains decompiler
// Type: StaqData.ObliviaeInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020C2")]
  public class ObliviaeInfo
  {
    [Token(Token = "0x17002A7E")]
    public bool IsPlaying
    {
      [Token(Token = "0x600C663"), Address(RVA = "0x1CD6B10", Offset = "0x1CD6B10", VA = "0x1CD6B10")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C664"), Address(RVA = "0x1CD6B18", Offset = "0x1CD6B18", VA = "0x1CD6B18")] private set
      {
      }
    }

    [Token(Token = "0x17002A7F")]
    public int ClearCount
    {
      [Token(Token = "0x600C665"), Address(RVA = "0x1CD6B24", Offset = "0x1CD6B24", VA = "0x1CD6B24")] get
      {
        return new int();
      }
      [Token(Token = "0x600C666"), Address(RVA = "0x1CD6B2C", Offset = "0x1CD6B2C", VA = "0x1CD6B2C")] private set
      {
      }
    }

    [Token(Token = "0x17002A80")]
    public bool Retreat
    {
      [Token(Token = "0x600C667"), Address(RVA = "0x1CD6B34", Offset = "0x1CD6B34", VA = "0x1CD6B34")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C668"), Address(RVA = "0x1CD6B3C", Offset = "0x1CD6B3C", VA = "0x1CD6B3C")] set
      {
      }
    }

    [Token(Token = "0x600C669")]
    [Address(RVA = "0x1CD6B48", Offset = "0x1CD6B48", VA = "0x1CD6B48")]
    public void Apply(bool inObliviae, int obliviaeClearCountInSequence)
    {
    }

    [Token(Token = "0x600C66A")]
    [Address(RVA = "0x1CD6B58", Offset = "0x1CD6B58", VA = "0x1CD6B58")]
    public void BattleRetreat()
    {
    }

    [Token(Token = "0x600C66B")]
    [Address(RVA = "0x1CD6B64", Offset = "0x1CD6B64", VA = "0x1CD6B64")]
    public void RetreatReset()
    {
    }

    [Token(Token = "0x600C66C")]
    [Address(RVA = "0x1CD6B6C", Offset = "0x1CD6B6C", VA = "0x1CD6B6C")]
    public bool IsReleased() => new bool();

    [Token(Token = "0x600C66D")]
    [Address(RVA = "0x1CD6B8C", Offset = "0x1CD6B8C", VA = "0x1CD6B8C")]
    public bool ConditionAbility() => new bool();

    [Token(Token = "0x600C66E")]
    [Address(RVA = "0x1CD6C9C", Offset = "0x1CD6C9C", VA = "0x1CD6C9C")]
    public bool ConditionCalendar() => new bool();

    [Token(Token = "0x600C66F")]
    [Address(RVA = "0x1CD6E64", Offset = "0x1CD6E64", VA = "0x1CD6E64")]
    public ObliviaeInfo()
    {
    }
  }
}
