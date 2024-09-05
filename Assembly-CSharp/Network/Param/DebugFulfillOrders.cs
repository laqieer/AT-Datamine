// Decompiled with JetBrains decompiler
// Type: Network.Param.DebugFulfillOrders
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A4F")]
  [Serializable]
  public class DebugFulfillOrders
  {
    [Token(Token = "0x4007080")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string order_id;
    [Token(Token = "0x4007081")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string product_id;
    [Token(Token = "0x4007082")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float price;
    [Token(Token = "0x4007083")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string currency;

    [Token(Token = "0x170018B6")]
    public string OrderId
    {
      [Token(Token = "0x6009651"), Address(RVA = "0x48EF0C4", Offset = "0x48EF0C4", VA = "0x48EF0C4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009652"), Address(RVA = "0x48EF0CC", Offset = "0x48EF0CC", VA = "0x48EF0CC")] set
      {
      }
    }

    [Token(Token = "0x170018B7")]
    public string ProductId
    {
      [Token(Token = "0x6009653"), Address(RVA = "0x48EF0D4", Offset = "0x48EF0D4", VA = "0x48EF0D4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009654"), Address(RVA = "0x48EF0DC", Offset = "0x48EF0DC", VA = "0x48EF0DC")] set
      {
      }
    }

    [Token(Token = "0x170018B8")]
    public float Price
    {
      [Token(Token = "0x6009655"), Address(RVA = "0x48EF0E4", Offset = "0x48EF0E4", VA = "0x48EF0E4")] get
      {
        return new float();
      }
      [Token(Token = "0x6009656"), Address(RVA = "0x48EF0EC", Offset = "0x48EF0EC", VA = "0x48EF0EC")] set
      {
      }
    }

    [Token(Token = "0x170018B9")]
    public string Currency
    {
      [Token(Token = "0x6009657"), Address(RVA = "0x48EF0F4", Offset = "0x48EF0F4", VA = "0x48EF0F4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009658"), Address(RVA = "0x48EF0FC", Offset = "0x48EF0FC", VA = "0x48EF0FC")] set
      {
      }
    }

    [Token(Token = "0x6009659")]
    [Address(RVA = "0x48EF104", Offset = "0x48EF104", VA = "0x48EF104")]
    public DebugFulfillOrders()
    {
    }
  }
}
