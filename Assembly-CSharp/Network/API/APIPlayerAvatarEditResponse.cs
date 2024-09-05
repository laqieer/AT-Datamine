// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerAvatarEditResponse
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
  [Token(Token = "0x2001D88")]
  [Serializable]
  public class APIPlayerAvatarEditResponse
  {
    [Token(Token = "0x4007E1D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;

    [Token(Token = "0x17002247")]
    public PlayerType Player
    {
      [Token(Token = "0x600AE50"), Address(RVA = "0x1A4CADC", Offset = "0x1A4CADC", VA = "0x1A4CADC")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x600AE51")]
    [Address(RVA = "0x1A4CAE4", Offset = "0x1A4CAE4", VA = "0x1A4CAE4")]
    public APIPlayerAvatarEditResponse()
    {
    }
  }
}
