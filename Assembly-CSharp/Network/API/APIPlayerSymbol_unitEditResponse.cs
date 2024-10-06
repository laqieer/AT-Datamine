// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSymbol_unitEditResponse
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
  [Token(Token = "0x2001DB8")]
  [Serializable]
  public class APIPlayerSymbol_unitEditResponse
  {
    [Token(Token = "0x4007EFB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;

    [Token(Token = "0x170022DD")]
    public PlayerType Player
    {
      [Token(Token = "0x600AFA6"), Address(RVA = "0x1A50CCC", Offset = "0x1A50CCC", VA = "0x1A50CCC")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x600AFA7")]
    [Address(RVA = "0x1A50CD4", Offset = "0x1A50CD4", VA = "0x1A50CD4")]
    public APIPlayerSymbol_unitEditResponse()
    {
    }
  }
}
