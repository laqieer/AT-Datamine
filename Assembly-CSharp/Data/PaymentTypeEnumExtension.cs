// Decompiled with JetBrains decompiler
// Type: Data.PaymentTypeEnumExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Data
{
  [Token(Token = "0x2001FD9")]
  public static class PaymentTypeEnumExtension
  {
    [Token(Token = "0x600BCFC")]
    [Address(RVA = "0x1E56874", Offset = "0x1E56874", VA = "0x1E56874")]
    public static bool IsAnyCoin(this PaymentTypeEnum paymentType) => new bool();

    [Token(Token = "0x600BCFD")]
    [Address(RVA = "0x1E569CC", Offset = "0x1E569CC", VA = "0x1E569CC")]
    public static bool IsPaidCoin(this PaymentTypeEnum paymentType) => new bool();

    [Token(Token = "0x600BCFE")]
    [Address(RVA = "0x1E569D8", Offset = "0x1E569D8", VA = "0x1E569D8")]
    public static bool IsFreeCoin(this PaymentTypeEnum paymentType) => new bool();
  }
}
