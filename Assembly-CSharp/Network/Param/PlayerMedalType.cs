// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerMedalType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ACA")]
  [Serializable]
  public class PlayerMedalType
  {
    [Token(Token = "0x40072C9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x40072CA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001B1F")]
    public int ItemId
    {
      [Token(Token = "0x6009B7F"), Address(RVA = "0x48F1C0C", Offset = "0x48F1C0C", VA = "0x48F1C0C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B80"), Address(RVA = "0x48F1C14", Offset = "0x48F1C14", VA = "0x48F1C14")] set
      {
      }
    }

    [Token(Token = "0x17001B20")]
    public int StackCount
    {
      [Token(Token = "0x6009B81"), Address(RVA = "0x48F1C1C", Offset = "0x48F1C1C", VA = "0x48F1C1C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B82"), Address(RVA = "0x48F1C24", Offset = "0x48F1C24", VA = "0x48F1C24")] set
      {
      }
    }

    [Token(Token = "0x6009B83")]
    [Address(RVA = "0x48F1C2C", Offset = "0x48F1C2C", VA = "0x48F1C2C")]
    public PlayerMedalType()
    {
    }
  }
}
