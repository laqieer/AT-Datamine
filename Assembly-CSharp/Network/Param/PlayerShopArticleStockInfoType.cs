// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerShopArticleStockInfoType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ADC")]
  [Serializable]
  public class PlayerShopArticleStockInfoType
  {
    [Token(Token = "0x400732A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int article_id;
    [Token(Token = "0x400732B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int purchased_count;
    [Token(Token = "0x400732C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int total_purchased_count;

    [Token(Token = "0x17001B8C")]
    public int ArticleId
    {
      [Token(Token = "0x6009C5F"), Address(RVA = "0x48F238C", Offset = "0x48F238C", VA = "0x48F238C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C60"), Address(RVA = "0x48F2394", Offset = "0x48F2394", VA = "0x48F2394")] set
      {
      }
    }

    [Token(Token = "0x17001B8D")]
    public int PurchasedCount
    {
      [Token(Token = "0x6009C61"), Address(RVA = "0x48F239C", Offset = "0x48F239C", VA = "0x48F239C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C62"), Address(RVA = "0x48F23A4", Offset = "0x48F23A4", VA = "0x48F23A4")] set
      {
      }
    }

    [Token(Token = "0x17001B8E")]
    public int TotalPurchasedCount
    {
      [Token(Token = "0x6009C63"), Address(RVA = "0x48F23AC", Offset = "0x48F23AC", VA = "0x48F23AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C64"), Address(RVA = "0x48F23B4", Offset = "0x48F23B4", VA = "0x48F23B4")] set
      {
      }
    }

    [Token(Token = "0x6009C65")]
    [Address(RVA = "0x48F23BC", Offset = "0x48F23BC", VA = "0x48F23BC")]
    public PlayerShopArticleStockInfoType()
    {
    }
  }
}
