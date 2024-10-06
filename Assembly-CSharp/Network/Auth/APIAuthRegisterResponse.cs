// Decompiled with JetBrains decompiler
// Type: Network.Auth.APIAuthRegisterResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Auth
{
  [Token(Token = "0x2001B21")]
  [Serializable]
  public class APIAuthRegisterResponse
  {
    [Token(Token = "0x4007497")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string device_id;
    [Token(Token = "0x4007498")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x17001CEF")]
    public string DeviceID
    {
      [Token(Token = "0x6009F72"), Address(RVA = "0x46BFE34", Offset = "0x46BFE34", VA = "0x46BFE34")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6009F73")]
    [Address(RVA = "0x46BFE3C", Offset = "0x46BFE3C", VA = "0x46BFE3C")]
    public APIAuthRegisterResponse()
    {
    }
  }
}
