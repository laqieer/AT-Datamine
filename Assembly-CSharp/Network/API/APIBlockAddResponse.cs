// Decompiled with JetBrains decompiler
// Type: Network.API.APIBlockAddResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BB4")]
  [Serializable]
  public class APIBlockAddResponse
  {
    [Token(Token = "0x40076C3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerBlockType created_player_block;

    [Token(Token = "0x17001E18")]
    public PlayerBlockType CreatedPlayerBlock
    {
      [Token(Token = "0x600A2D1"), Address(RVA = "0x46CC914", Offset = "0x46CC914", VA = "0x46CC914")] get
      {
        return (PlayerBlockType) null;
      }
    }

    [Token(Token = "0x600A2D2")]
    [Address(RVA = "0x46CC91C", Offset = "0x46CC91C", VA = "0x46CC91C")]
    public APIBlockAddResponse()
    {
    }
  }
}
