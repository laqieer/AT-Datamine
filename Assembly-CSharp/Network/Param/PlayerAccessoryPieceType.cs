// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAccessoryPieceType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A7D")]
  [Serializable]
  public class PlayerAccessoryPieceType
  {
    [Token(Token = "0x4007192")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x4007193")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x170019D6")]
    public int ItemId
    {
      [Token(Token = "0x60098B2"), Address(RVA = "0x48F0380", Offset = "0x48F0380", VA = "0x48F0380")] get
      {
        return new int();
      }
      [Token(Token = "0x60098B3"), Address(RVA = "0x48F0388", Offset = "0x48F0388", VA = "0x48F0388")] set
      {
      }
    }

    [Token(Token = "0x170019D7")]
    public int StackCount
    {
      [Token(Token = "0x60098B4"), Address(RVA = "0x48F0390", Offset = "0x48F0390", VA = "0x48F0390")] get
      {
        return new int();
      }
      [Token(Token = "0x60098B5"), Address(RVA = "0x48F0398", Offset = "0x48F0398", VA = "0x48F0398")] set
      {
      }
    }

    [Token(Token = "0x60098B6")]
    [Address(RVA = "0x48F03A0", Offset = "0x48F03A0", VA = "0x48F03A0")]
    public PlayerAccessoryPieceType()
    {
    }
  }
}
