// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerSoulType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE1")]
  [Serializable]
  public class PlayerSoulType
  {
    [Token(Token = "0x400734A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x400734B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001BAC")]
    public int ItemId
    {
      [Token(Token = "0x6009CA4"), Address(RVA = "0x48F25B8", Offset = "0x48F25B8", VA = "0x48F25B8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CA5"), Address(RVA = "0x48F25C0", Offset = "0x48F25C0", VA = "0x48F25C0")] set
      {
      }
    }

    [Token(Token = "0x17001BAD")]
    public int StackCount
    {
      [Token(Token = "0x6009CA6"), Address(RVA = "0x48F25C8", Offset = "0x48F25C8", VA = "0x48F25C8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CA7"), Address(RVA = "0x48F25D0", Offset = "0x48F25D0", VA = "0x48F25D0")] set
      {
      }
    }

    [Token(Token = "0x6009CA8")]
    [Address(RVA = "0x48F25D8", Offset = "0x48F25D8", VA = "0x48F25D8")]
    public PlayerSoulType()
    {
    }
  }
}
