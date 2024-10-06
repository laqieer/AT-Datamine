// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerInfoResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D9C")]
  [Serializable]
  public class APIPlayerInfoResponse
  {
    [Token(Token = "0x4007E5F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private long short_id;
    [Token(Token = "0x4007E60")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string player_name;

    [Token(Token = "0x1700226C")]
    public long ShortId
    {
      [Token(Token = "0x600AEC5"), Address(RVA = "0x1A4E590", Offset = "0x1A4E590", VA = "0x1A4E590")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700226D")]
    public string PlayerName
    {
      [Token(Token = "0x600AEC6"), Address(RVA = "0x1A4E598", Offset = "0x1A4E598", VA = "0x1A4E598")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600AEC7")]
    [Address(RVA = "0x1A4E5A0", Offset = "0x1A4E5A0", VA = "0x1A4E5A0")]
    public APIPlayerInfoResponse()
    {
    }
  }
}
