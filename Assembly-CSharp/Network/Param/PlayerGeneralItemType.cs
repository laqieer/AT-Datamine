// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGeneralItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AC2")]
  [Serializable]
  public class PlayerGeneralItemType
  {
    [Token(Token = "0x40072B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x40072B1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001B06")]
    public int ItemId
    {
      [Token(Token = "0x6009B45"), Address(RVA = "0x48F1A3C", Offset = "0x48F1A3C", VA = "0x48F1A3C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B46"), Address(RVA = "0x48F1A44", Offset = "0x48F1A44", VA = "0x48F1A44")] set
      {
      }
    }

    [Token(Token = "0x17001B07")]
    public int StackCount
    {
      [Token(Token = "0x6009B47"), Address(RVA = "0x48F1A4C", Offset = "0x48F1A4C", VA = "0x48F1A4C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B48"), Address(RVA = "0x48F1A54", Offset = "0x48F1A54", VA = "0x48F1A54")] set
      {
      }
    }

    [Token(Token = "0x6009B49")]
    [Address(RVA = "0x48F1A5C", Offset = "0x48F1A5C", VA = "0x48F1A5C")]
    public PlayerGeneralItemType()
    {
    }
  }
}
