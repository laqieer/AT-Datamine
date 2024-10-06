// Decompiled with JetBrains decompiler
// Type: Network.API.APIShopListResponse
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
  [Token(Token = "0x2001E10")]
  [Serializable]
  public class APIShopListResponse
  {
    [Token(Token = "0x40080AA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerShopType> shops;
    [Token(Token = "0x40080AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerShopArticleType> articles;

    [Token(Token = "0x170023B9")]
    public List<PlayerShopType> Shops
    {
      [Token(Token = "0x600B1E2"), Address(RVA = "0x22DE268", Offset = "0x22DE268", VA = "0x22DE268")] get
      {
        return (List<PlayerShopType>) null;
      }
    }

    [Token(Token = "0x170023BA")]
    public List<PlayerShopArticleType> Articles
    {
      [Token(Token = "0x600B1E3"), Address(RVA = "0x22DE270", Offset = "0x22DE270", VA = "0x22DE270")] get
      {
        return (List<PlayerShopArticleType>) null;
      }
    }

    [Token(Token = "0x600B1E4")]
    [Address(RVA = "0x22DE278", Offset = "0x22DE278", VA = "0x22DE278")]
    public APIShopListResponse()
    {
    }
  }
}
