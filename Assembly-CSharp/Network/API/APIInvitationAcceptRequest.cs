// Decompiled with JetBrains decompiler
// Type: Network.API.APIInvitationAcceptRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D3B")]
  [Serializable]
  public class APIInvitationAcceptRequest
  {
    [Token(Token = "0x4007CD7")]
    [FieldOffset(Offset = "0x10")]
    public string invitation_code;

    [Token(Token = "0x600AC61")]
    [Address(RVA = "0x1A463B0", Offset = "0x1A463B0", VA = "0x1A463B0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AC62")]
    [Address(RVA = "0x1A463F8", Offset = "0x1A463F8", VA = "0x1A463F8")]
    public APIInvitationAcceptRequest()
    {
    }
  }
}
