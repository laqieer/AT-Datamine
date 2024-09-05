// Decompiled with JetBrains decompiler
// Type: Network.Param.G0000GachaAdditionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A54")]
  [Serializable]
  public class G0000GachaAdditionType
  {
    [Token(Token = "0x400709D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int reward_type_id;
    [Token(Token = "0x400709E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int reward_id;
    [Token(Token = "0x400709F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int reward_quantity;

    [Token(Token = "0x170018D3")]
    public int RewardTypeId
    {
      [Token(Token = "0x6009690"), Address(RVA = "0x48EF2C0", Offset = "0x48EF2C0", VA = "0x48EF2C0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009691"), Address(RVA = "0x48EF2C8", Offset = "0x48EF2C8", VA = "0x48EF2C8")] set
      {
      }
    }

    [Token(Token = "0x170018D4")]
    public int RewardId
    {
      [Token(Token = "0x6009692"), Address(RVA = "0x48EF2D0", Offset = "0x48EF2D0", VA = "0x48EF2D0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009693"), Address(RVA = "0x48EF2D8", Offset = "0x48EF2D8", VA = "0x48EF2D8")] set
      {
      }
    }

    [Token(Token = "0x170018D5")]
    public int RewardQuantity
    {
      [Token(Token = "0x6009694"), Address(RVA = "0x48EF2E0", Offset = "0x48EF2E0", VA = "0x48EF2E0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009695"), Address(RVA = "0x48EF2E8", Offset = "0x48EF2E8", VA = "0x48EF2E8")] set
      {
      }
    }

    [Token(Token = "0x6009696")]
    [Address(RVA = "0x48EF2F0", Offset = "0x48EF2F0", VA = "0x48EF2F0")]
    public G0000GachaAdditionType()
    {
    }
  }
}
