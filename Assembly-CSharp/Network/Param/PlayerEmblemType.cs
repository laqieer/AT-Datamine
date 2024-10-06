// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerEmblemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA3")]
  [Serializable]
  public class PlayerEmblemType
  {
    [Token(Token = "0x4007232")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x4007233")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;
    [Token(Token = "0x4007234")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string created_at;

    [Token(Token = "0x17001A7F")]
    public int ItemId
    {
      [Token(Token = "0x6009A21"), Address(RVA = "0x48F1004", Offset = "0x48F1004", VA = "0x48F1004")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A22"), Address(RVA = "0x48F100C", Offset = "0x48F100C", VA = "0x48F100C")] set
      {
      }
    }

    [Token(Token = "0x17001A80")]
    public int StackCount
    {
      [Token(Token = "0x6009A23"), Address(RVA = "0x48F1014", Offset = "0x48F1014", VA = "0x48F1014")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A24"), Address(RVA = "0x48F101C", Offset = "0x48F101C", VA = "0x48F101C")] set
      {
      }
    }

    [Token(Token = "0x17001A81")]
    public string CreatedAt
    {
      [Token(Token = "0x6009A25"), Address(RVA = "0x48F1024", Offset = "0x48F1024", VA = "0x48F1024")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A26"), Address(RVA = "0x48F102C", Offset = "0x48F102C", VA = "0x48F102C")] set
      {
      }
    }

    [Token(Token = "0x6009A27")]
    [Address(RVA = "0x48F1034", Offset = "0x48F1034", VA = "0x48F1034")]
    public PlayerEmblemType()
    {
    }
  }
}
