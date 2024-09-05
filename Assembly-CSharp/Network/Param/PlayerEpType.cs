// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerEpType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA4")]
  [Serializable]
  public class PlayerEpType
  {
    [Token(Token = "0x4007235")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x4007236")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001A82")]
    public int ItemId
    {
      [Token(Token = "0x6009A28"), Address(RVA = "0x48F103C", Offset = "0x48F103C", VA = "0x48F103C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A29"), Address(RVA = "0x48F1044", Offset = "0x48F1044", VA = "0x48F1044")] set
      {
      }
    }

    [Token(Token = "0x17001A83")]
    public int StackCount
    {
      [Token(Token = "0x6009A2A"), Address(RVA = "0x48F104C", Offset = "0x48F104C", VA = "0x48F104C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A2B"), Address(RVA = "0x48F1054", Offset = "0x48F1054", VA = "0x48F1054")] set
      {
      }
    }

    [Token(Token = "0x6009A2C")]
    [Address(RVA = "0x48F105C", Offset = "0x48F105C", VA = "0x48F105C")]
    public PlayerEpType()
    {
    }
  }
}
