// Decompiled with JetBrains decompiler
// Type: Data.PaymentCalculationResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Data
{
  [Token(Token = "0x2001FDB")]
  public struct PaymentCalculationResult
  {
    [Token(Token = "0x17002707")]
    public PaymentCalculationSource Source
    {
      [Token(Token = "0x600BD00"), Address(RVA = "0x1E569E4", Offset = "0x1E569E4", VA = "0x1E569E4")] readonly get
      {
        return new PaymentCalculationSource();
      }
      [Token(Token = "0x600BD01"), Address(RVA = "0x1E569EC", Offset = "0x1E569EC", VA = "0x1E569EC")] private set
      {
      }
    }

    [Token(Token = "0x17002708")]
    public int BalanceAfterPayment
    {
      [Token(Token = "0x600BD02"), Address(RVA = "0x1E569F4", Offset = "0x1E569F4", VA = "0x1E569F4")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600BD03"), Address(RVA = "0x1E569FC", Offset = "0x1E569FC", VA = "0x1E569FC")] private set
      {
      }
    }

    [Token(Token = "0x17002709")]
    public int RemainingPaymentAmount
    {
      [Token(Token = "0x600BD04"), Address(RVA = "0x1E56A04", Offset = "0x1E56A04", VA = "0x1E56A04")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600BD05"), Address(RVA = "0x1E56A0C", Offset = "0x1E56A0C", VA = "0x1E56A0C")] private set
      {
      }
    }

    [Token(Token = "0x1700270A")]
    public bool IsNotEnough
    {
      [Token(Token = "0x600BD06"), Address(RVA = "0x1E56A14", Offset = "0x1E56A14", VA = "0x1E56A14")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600BD07"), Address(RVA = "0x1E56A1C", Offset = "0x1E56A1C", VA = "0x1E56A1C")] private set
      {
      }
    }

    [Token(Token = "0x600BD08")]
    [Address(RVA = "0x1E5693C", Offset = "0x1E5693C", VA = "0x1E5693C")]
    public PaymentCalculationResult(
      PaymentCalculationSource source,
      int balanceAfterPayment,
      int remainingPaymentAmount,
      bool isNotEnough)
    {
    }
  }
}
