// Decompiled with JetBrains decompiler
// Type: Network.Param.Reward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B0D")]
  [Serializable]
  public class Reward
  {
    [Token(Token = "0x4007436")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int reward_type_id;
    [Token(Token = "0x4007437")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int reward_id;
    [Token(Token = "0x4007438")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int reward_quantity;

    [Token(Token = "0x17001C98")]
    public int RewardTypeId
    {
      [Token(Token = "0x6009EA8"), Address(RVA = "0x48F3620", Offset = "0x48F3620", VA = "0x48F3620")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EA9"), Address(RVA = "0x48F3628", Offset = "0x48F3628", VA = "0x48F3628")] set
      {
      }
    }

    [Token(Token = "0x17001C99")]
    public int RewardId
    {
      [Token(Token = "0x6009EAA"), Address(RVA = "0x48F3630", Offset = "0x48F3630", VA = "0x48F3630")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EAB"), Address(RVA = "0x48F3638", Offset = "0x48F3638", VA = "0x48F3638")] set
      {
      }
    }

    [Token(Token = "0x17001C9A")]
    public int RewardQuantity
    {
      [Token(Token = "0x6009EAC"), Address(RVA = "0x48F3640", Offset = "0x48F3640", VA = "0x48F3640")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EAD"), Address(RVA = "0x48F3648", Offset = "0x48F3648", VA = "0x48F3648")] set
      {
      }
    }

    [Token(Token = "0x6009EAE")]
    [Address(RVA = "0x48F3650", Offset = "0x48F3650", VA = "0x48F3650")]
    public Reward()
    {
    }
  }
}
