// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerProfileResponse
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
  [Token(Token = "0x2001DA8")]
  [Serializable]
  public class APIPlayerProfileResponse
  {
    [Token(Token = "0x4007E85")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;

    [Token(Token = "0x17002281")]
    public PlayerType Player
    {
      [Token(Token = "0x600AF0A"), Address(RVA = "0x1A4F58C", Offset = "0x1A4F58C", VA = "0x1A4F58C")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x600AF0B")]
    [Address(RVA = "0x1A4F594", Offset = "0x1A4F594", VA = "0x1A4F594")]
    public APIPlayerProfileResponse()
    {
    }
  }
}
