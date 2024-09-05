// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerWeaponPieceType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B06")]
  [Serializable]
  public class PlayerWeaponPieceType
  {
    [Token(Token = "0x400741D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x400741E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001C7F")]
    public int ItemId
    {
      [Token(Token = "0x6009E6F"), Address(RVA = "0x48F3454", Offset = "0x48F3454", VA = "0x48F3454")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E70"), Address(RVA = "0x48F345C", Offset = "0x48F345C", VA = "0x48F345C")] set
      {
      }
    }

    [Token(Token = "0x17001C80")]
    public int StackCount
    {
      [Token(Token = "0x6009E71"), Address(RVA = "0x48F3464", Offset = "0x48F3464", VA = "0x48F3464")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E72"), Address(RVA = "0x48F346C", Offset = "0x48F346C", VA = "0x48F346C")] set
      {
      }
    }

    [Token(Token = "0x6009E73")]
    [Address(RVA = "0x48F3474", Offset = "0x48F3474", VA = "0x48F3474")]
    public PlayerWeaponPieceType()
    {
    }
  }
}
