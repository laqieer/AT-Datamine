// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestCommunicationRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E4F")]
  [Serializable]
  public class APIStoryMainquestCommunicationRequest
  {
    [Token(Token = "0x40081FF")]
    [FieldOffset(Offset = "0x10")]
    public int communication_id;
    [Token(Token = "0x4008200")]
    [FieldOffset(Offset = "0x14")]
    public bool rank_up;
    [Token(Token = "0x4008201")]
    [FieldOffset(Offset = "0x18")]
    public AdvRequest adv_request;
    [Token(Token = "0x4008202")]
    [FieldOffset(Offset = "0x20")]
    public int location_id;

    [Token(Token = "0x600B3A3")]
    [Address(RVA = "0x22E39F0", Offset = "0x22E39F0", VA = "0x22E39F0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B3A4")]
    [Address(RVA = "0x22E3A38", Offset = "0x22E3A38", VA = "0x22E3A38")]
    public APIStoryMainquestCommunicationRequest()
    {
    }
  }
}
