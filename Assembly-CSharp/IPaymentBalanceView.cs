// Decompiled with JetBrains decompiler
// Type: IPaymentBalanceView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000238")]
public interface IPaymentBalanceView
{
  [Token(Token = "0x6000DF2")]
  void DisableBalanceObjects();

  [Token(Token = "0x6000DF3")]
  void SetPaidCoinBalance(int beforeBalance, int afterBalance);

  [Token(Token = "0x6000DF4")]
  void SetFreeCoinBalance(int beforeBalance, int afterBalance);

  [Token(Token = "0x6000DF5")]
  void SetItemBalance(
    ItemUtility.Parameter parameter,
    int beforeBalance,
    int afterBalance,
    Sprite iconSprite = null);
}
