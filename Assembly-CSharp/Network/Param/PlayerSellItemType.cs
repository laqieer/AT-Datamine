// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerSellItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ADB")]
  [Serializable]
  public class PlayerSellItemType
  {
    [Token(Token = "0x4007327")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int payment_type_id;
    [Token(Token = "0x4007328")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int payment_id;
    [Token(Token = "0x4007329")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int payment_amount;

    [Token(Token = "0x17001B89")]
    public int PaymentTypeId
    {
      [Token(Token = "0x6009C58"), Address(RVA = "0x48F2354", Offset = "0x48F2354", VA = "0x48F2354")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C59"), Address(RVA = "0x48F235C", Offset = "0x48F235C", VA = "0x48F235C")] set
      {
      }
    }

    [Token(Token = "0x17001B8A")]
    public int PaymentId
    {
      [Token(Token = "0x6009C5A"), Address(RVA = "0x48F2364", Offset = "0x48F2364", VA = "0x48F2364")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C5B"), Address(RVA = "0x48F236C", Offset = "0x48F236C", VA = "0x48F236C")] set
      {
      }
    }

    [Token(Token = "0x17001B8B")]
    public int PaymentAmount
    {
      [Token(Token = "0x6009C5C"), Address(RVA = "0x48F2374", Offset = "0x48F2374", VA = "0x48F2374")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C5D"), Address(RVA = "0x48F237C", Offset = "0x48F237C", VA = "0x48F237C")] set
      {
      }
    }

    [Token(Token = "0x6009C5E")]
    [Address(RVA = "0x48F2384", Offset = "0x48F2384", VA = "0x48F2384")]
    public PlayerSellItemType()
    {
    }
  }
}
