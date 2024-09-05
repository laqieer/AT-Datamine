// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAreaNodeType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A84")]
  [Serializable]
  public class PlayerAreaNodeType
  {
    [Token(Token = "0x40071AC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int area_id;
    [Token(Token = "0x40071AD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int area_node_id;

    [Token(Token = "0x170019F0")]
    public int AreaId
    {
      [Token(Token = "0x60098ED"), Address(RVA = "0x48F0564", Offset = "0x48F0564", VA = "0x48F0564")] get
      {
        return new int();
      }
      [Token(Token = "0x60098EE"), Address(RVA = "0x48F056C", Offset = "0x48F056C", VA = "0x48F056C")] set
      {
      }
    }

    [Token(Token = "0x170019F1")]
    public int AreaNodeId
    {
      [Token(Token = "0x60098EF"), Address(RVA = "0x48F0574", Offset = "0x48F0574", VA = "0x48F0574")] get
      {
        return new int();
      }
      [Token(Token = "0x60098F0"), Address(RVA = "0x48F057C", Offset = "0x48F057C", VA = "0x48F057C")] set
      {
      }
    }

    [Token(Token = "0x60098F1")]
    [Address(RVA = "0x48F0584", Offset = "0x48F0584", VA = "0x48F0584")]
    public PlayerAreaNodeType()
    {
    }
  }
}
