// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerDeckPlacementInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA0")]
  [Serializable]
  public class PlayerDeckPlacementInfo
  {
    [Token(Token = "0x400721B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int position_id;
    [Token(Token = "0x400721C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int placement;

    [Token(Token = "0x17001A68")]
    public int PositionId
    {
      [Token(Token = "0x60099F0"), Address(RVA = "0x48F0E78", Offset = "0x48F0E78", VA = "0x48F0E78")] get
      {
        return new int();
      }
      [Token(Token = "0x60099F1"), Address(RVA = "0x48F0E80", Offset = "0x48F0E80", VA = "0x48F0E80")] set
      {
      }
    }

    [Token(Token = "0x17001A69")]
    public int Placement
    {
      [Token(Token = "0x60099F2"), Address(RVA = "0x48F0E88", Offset = "0x48F0E88", VA = "0x48F0E88")] get
      {
        return new int();
      }
      [Token(Token = "0x60099F3"), Address(RVA = "0x48F0E90", Offset = "0x48F0E90", VA = "0x48F0E90")] set
      {
      }
    }

    [Token(Token = "0x60099F4")]
    [Address(RVA = "0x48F0E98", Offset = "0x48F0E98", VA = "0x48F0E98")]
    public PlayerDeckPlacementInfo()
    {
    }
  }
}
