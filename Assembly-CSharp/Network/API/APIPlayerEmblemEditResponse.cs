// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerEmblemEditResponse
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
  [Token(Token = "0x2001D94")]
  [Serializable]
  public class APIPlayerEmblemEditResponse
  {
    [Token(Token = "0x4007E47")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;

    [Token(Token = "0x1700225F")]
    public PlayerType Player
    {
      [Token(Token = "0x600AE98"), Address(RVA = "0x1A4DAF0", Offset = "0x1A4DAF0", VA = "0x1A4DAF0")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x600AE99")]
    [Address(RVA = "0x1A4DAF8", Offset = "0x1A4DAF8", VA = "0x1A4DAF8")]
    public APIPlayerEmblemEditResponse()
    {
    }
  }
}
