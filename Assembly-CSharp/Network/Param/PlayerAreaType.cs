// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAreaType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A85")]
  [Serializable]
  public class PlayerAreaType
  {
    [Token(Token = "0x40071AE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int area_id;
    [Token(Token = "0x40071AF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int current_area_node_id;

    [Token(Token = "0x170019F2")]
    public int AreaId
    {
      [Token(Token = "0x60098F2"), Address(RVA = "0x48F058C", Offset = "0x48F058C", VA = "0x48F058C")] get
      {
        return new int();
      }
      [Token(Token = "0x60098F3"), Address(RVA = "0x48F0594", Offset = "0x48F0594", VA = "0x48F0594")] set
      {
      }
    }

    [Token(Token = "0x170019F3")]
    public int CurrentAreaNodeId
    {
      [Token(Token = "0x60098F4"), Address(RVA = "0x48F059C", Offset = "0x48F059C", VA = "0x48F059C")] get
      {
        return new int();
      }
      [Token(Token = "0x60098F5"), Address(RVA = "0x48F05A4", Offset = "0x48F05A4", VA = "0x48F05A4")] set
      {
      }
    }

    [Token(Token = "0x60098F6")]
    [Address(RVA = "0x48F05AC", Offset = "0x48F05AC", VA = "0x48F05AC")]
    public PlayerAreaType()
    {
    }
  }
}
