// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryShopListResponse
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
  [Token(Token = "0x2001E68")]
  [Serializable]
  public class APIStoryShopListResponse : ICommonApiResult
  {
    [Token(Token = "0x4008292")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008293")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerShopArticleStockInfoType> articles;

    [Token(Token = "0x170024D2")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B45B"), Address(RVA = "0x22E5B98", Offset = "0x22E5B98", VA = "0x22E5B98", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170024D3")]
    public List<PlayerShopArticleStockInfoType> Articles
    {
      [Token(Token = "0x600B45C"), Address(RVA = "0x22E5BA0", Offset = "0x22E5BA0", VA = "0x22E5BA0")] get
      {
        return (List<PlayerShopArticleStockInfoType>) null;
      }
    }

    [Token(Token = "0x600B45D")]
    [Address(RVA = "0x22E5BA8", Offset = "0x22E5BA8", VA = "0x22E5BA8")]
    public APIStoryShopListResponse()
    {
    }
  }
}
