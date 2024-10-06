// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerNameEditResponse
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
  [Token(Token = "0x2001DA4")]
  [Serializable]
  public class APIPlayerNameEditResponse
  {
    [Token(Token = "0x4007E79")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerProfileChangeType player_profile_change;

    [Token(Token = "0x1700227A")]
    public PlayerProfileChangeType PlayerProfileChange
    {
      [Token(Token = "0x600AEF3"), Address(RVA = "0x1A4F038", Offset = "0x1A4F038", VA = "0x1A4F038")] get
      {
        return (PlayerProfileChangeType) null;
      }
    }

    [Token(Token = "0x600AEF4")]
    [Address(RVA = "0x1A4F040", Offset = "0x1A4F040", VA = "0x1A4F040")]
    public APIPlayerNameEditResponse()
    {
    }
  }
}
