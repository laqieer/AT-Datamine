// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionRapidTicketType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AAA")]
  [Serializable]
  public class PlayerExpeditionRapidTicketType
  {
    [Token(Token = "0x4007246")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x4007247")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001A93")]
    public int ItemId
    {
      [Token(Token = "0x6009A50"), Address(RVA = "0x48F117C", Offset = "0x48F117C", VA = "0x48F117C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A51"), Address(RVA = "0x48F1184", Offset = "0x48F1184", VA = "0x48F1184")] set
      {
      }
    }

    [Token(Token = "0x17001A94")]
    public int StackCount
    {
      [Token(Token = "0x6009A52"), Address(RVA = "0x48F118C", Offset = "0x48F118C", VA = "0x48F118C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A53"), Address(RVA = "0x48F1194", Offset = "0x48F1194", VA = "0x48F1194")] set
      {
      }
    }

    [Token(Token = "0x6009A54")]
    [Address(RVA = "0x48F119C", Offset = "0x48F119C", VA = "0x48F119C")]
    public PlayerExpeditionRapidTicketType()
    {
    }
  }
}
