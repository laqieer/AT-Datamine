// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGachaTicketType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AB7")]
  [Serializable]
  public class PlayerGachaTicketType
  {
    [Token(Token = "0x4007280")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x4007281")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001AD6")]
    public int ItemId
    {
      [Token(Token = "0x6009ADA"), Address(RVA = "0x48F16D4", Offset = "0x48F16D4", VA = "0x48F16D4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009ADB"), Address(RVA = "0x48F16DC", Offset = "0x48F16DC", VA = "0x48F16DC")] set
      {
      }
    }

    [Token(Token = "0x17001AD7")]
    public int StackCount
    {
      [Token(Token = "0x6009ADC"), Address(RVA = "0x48F16E4", Offset = "0x48F16E4", VA = "0x48F16E4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009ADD"), Address(RVA = "0x48F16EC", Offset = "0x48F16EC", VA = "0x48F16EC")] set
      {
      }
    }

    [Token(Token = "0x6009ADE")]
    [Address(RVA = "0x48F16F4", Offset = "0x48F16F4", VA = "0x48F16F4")]
    public PlayerGachaTicketType()
    {
    }
  }
}
