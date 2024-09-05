// Decompiled with JetBrains decompiler
// Type: Network.API.APICoinShopListResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BDC")]
  [Serializable]
  public class APICoinShopListResponse
  {
    [Token(Token = "0x4007750")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerCoinShopType> coin_shops;

    [Token(Token = "0x17001E62")]
    public List<PlayerCoinShopType> CoinShops
    {
      [Token(Token = "0x600A3BB"), Address(RVA = "0x46CFE7C", Offset = "0x46CFE7C", VA = "0x46CFE7C")] get
      {
        return (List<PlayerCoinShopType>) null;
      }
    }

    [Token(Token = "0x600A3BC")]
    [Address(RVA = "0x46CFE84", Offset = "0x46CFE84", VA = "0x46CFE84")]
    public APICoinShopListResponse()
    {
    }
  }
}
