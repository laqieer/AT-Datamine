// Decompiled with JetBrains decompiler
// Type: Data.PaymentUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Data
{
  [Token(Token = "0x2001FD6")]
  public static class PaymentUtility
  {
    [Token(Token = "0x600BCF3")]
    [Address(RVA = "0x1E5625C", Offset = "0x1E5625C", VA = "0x1E5625C")]
    public static string GetNameByType(PaymentTypeEnum type, int id) => (string) null;

    [Token(Token = "0x600BCF4")]
    [Address(RVA = "0x1E56278", Offset = "0x1E56278", VA = "0x1E56278")]
    private static PaymentUtility.Parameter GetByType(PaymentTypeEnum type, int id)
    {
      return (PaymentUtility.Parameter) null;
    }

    [Token(Token = "0x600BCF5")]
    [Address(RVA = "0x1E563FC", Offset = "0x1E563FC", VA = "0x1E563FC")]
    public static bool HasEnoughAny(PaymentTypeEnum paymentType, int paymentId, int paymentAmount)
    {
      return new bool();
    }

    [Token(Token = "0x600BCF6")]
    [Address(RVA = "0x1E5651C", Offset = "0x1E5651C", VA = "0x1E5651C")]
    public static List<(PaymentTypeEnum, PaymentCalculationResult)> CalculatePaymentResult(
      PaymentTypeEnum paymentType,
      int paymentId,
      int paymentAmount,
      bool isAllowNegativeValue)
    {
      return (List<(PaymentTypeEnum, PaymentCalculationResult)>) null;
    }

    [Token(Token = "0x600BCF7")]
    [Address(RVA = "0x1E56880", Offset = "0x1E56880", VA = "0x1E56880")]
    public static void CalculatePaymentResult(
      int balance,
      int paymentAmount,
      bool isAllowNegativeValue,
      out PaymentCalculationResult result)
    {
    }

    [Token(Token = "0x2001FD7")]
    private class Parameter
    {
      [Token(Token = "0x40087D8")]
      [FieldOffset(Offset = "0x10")]
      public string Name;
      [Token(Token = "0x40087D9")]
      [FieldOffset(Offset = "0x18")]
      public string Description;
      [Token(Token = "0x40087DA")]
      [FieldOffset(Offset = "0x20")]
      public string IconAssetName;

      [Token(Token = "0x600BCF8")]
      [Address(RVA = "0x1E563A0", Offset = "0x1E563A0", VA = "0x1E563A0")]
      public Parameter()
      {
      }
    }
  }
}
