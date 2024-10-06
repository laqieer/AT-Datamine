// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitPieceType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AFD")]
  [Serializable]
  public class PlayerUnitPieceType
  {
    [Token(Token = "0x40073E5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x40073E6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001C47")]
    public int ItemId
    {
      [Token(Token = "0x6009DF6"), Address(RVA = "0x48F3064", Offset = "0x48F3064", VA = "0x48F3064")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DF7"), Address(RVA = "0x48F306C", Offset = "0x48F306C", VA = "0x48F306C")] set
      {
      }
    }

    [Token(Token = "0x17001C48")]
    public int StackCount
    {
      [Token(Token = "0x6009DF8"), Address(RVA = "0x48F3074", Offset = "0x48F3074", VA = "0x48F3074")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DF9"), Address(RVA = "0x48F307C", Offset = "0x48F307C", VA = "0x48F307C")] set
      {
      }
    }

    [Token(Token = "0x6009DFA")]
    [Address(RVA = "0x48F3084", Offset = "0x48F3084", VA = "0x48F3084")]
    public PlayerUnitPieceType()
    {
    }
  }
}
