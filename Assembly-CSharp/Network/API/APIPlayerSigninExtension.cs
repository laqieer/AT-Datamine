// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSigninExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using PurchaseModule.Enum;
using PurchaseModule.Product;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001F0B")]
  public class APIPlayerSigninExtension
  {
    [Token(Token = "0x600B872")]
    [Address(RVA = "0x2134450", Offset = "0x2134450", VA = "0x2134450")]
    public static IEnumerator PlayerSignin() => (IEnumerator) null;

    [Token(Token = "0x600B873")]
    [Address(RVA = "0x21344D8", Offset = "0x21344D8", VA = "0x21344D8")]
    public static IEnumerator SetupPurchase(
      Action<IReadOnlyCollection<ProductInfo>, UpdateProductResultCode> callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600B874")]
    [Address(RVA = "0x2134568", Offset = "0x2134568", VA = "0x2134568")]
    public APIPlayerSigninExtension()
    {
    }
  }
}
