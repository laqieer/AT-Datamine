// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerTitleEditResponse
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
  [Token(Token = "0x2001DBC")]
  [Serializable]
  public class APIPlayerTitleEditResponse
  {
    [Token(Token = "0x4007F0A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;

    [Token(Token = "0x170022E4")]
    public PlayerType Player
    {
      [Token(Token = "0x600AFBD"), Address(RVA = "0x1A51220", Offset = "0x1A51220", VA = "0x1A51220")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x600AFBE")]
    [Address(RVA = "0x1A51228", Offset = "0x1A51228", VA = "0x1A51228")]
    public APIPlayerTitleEditResponse()
    {
    }
  }
}
