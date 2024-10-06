// Decompiled with JetBrains decompiler
// Type: Data.PaymentCalculationSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Data
{
  [Token(Token = "0x2001FDA")]
  public struct PaymentCalculationSource
  {
    [Token(Token = "0x40087DD")]
    [FieldOffset(Offset = "0x0")]
    public int Balance;
    [Token(Token = "0x40087DE")]
    [FieldOffset(Offset = "0x4")]
    public int PaymentAmount;

    [Token(Token = "0x600BCFF")]
    [Address(RVA = "0x1E56934", Offset = "0x1E56934", VA = "0x1E56934")]
    public PaymentCalculationSource(int balance, int paymentAmount)
    {
    }
  }
}
