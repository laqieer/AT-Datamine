// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerCommentEditResponse
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
  [Token(Token = "0x2001D8C")]
  [Serializable]
  public class APIPlayerCommentEditResponse
  {
    [Token(Token = "0x4007E2A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;

    [Token(Token = "0x1700224E")]
    public PlayerType Player
    {
      [Token(Token = "0x600AE67"), Address(RVA = "0x1A4D030", Offset = "0x1A4D030", VA = "0x1A4D030")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x600AE68")]
    [Address(RVA = "0x1A4D038", Offset = "0x1A4D038", VA = "0x1A4D038")]
    public APIPlayerCommentEditResponse()
    {
    }
  }
}
