// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitAbilityBoardType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AF2")]
  [Serializable]
  public class PlayerUnitAbilityBoardType
  {
    [Token(Token = "0x40073A1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40073A2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int unit_node_id;

    [Token(Token = "0x17001C03")]
    public string Id
    {
      [Token(Token = "0x6009D63"), Address(RVA = "0x48F2BC8", Offset = "0x48F2BC8", VA = "0x48F2BC8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D64"), Address(RVA = "0x48F2BD0", Offset = "0x48F2BD0", VA = "0x48F2BD0")] set
      {
      }
    }

    [Token(Token = "0x17001C04")]
    public int UnitNodeId
    {
      [Token(Token = "0x6009D65"), Address(RVA = "0x48F2BD8", Offset = "0x48F2BD8", VA = "0x48F2BD8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D66"), Address(RVA = "0x48F2BE0", Offset = "0x48F2BE0", VA = "0x48F2BE0")] set
      {
      }
    }

    [Token(Token = "0x6009D67")]
    [Address(RVA = "0x48F2BE8", Offset = "0x48F2BE8", VA = "0x48F2BE8")]
    public PlayerUnitAbilityBoardType()
    {
    }
  }
}
