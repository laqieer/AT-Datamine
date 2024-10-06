// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildKick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CFD")]
  public class APIGuildKick
  {
    [Token(Token = "0x4007BD3")]
    public const string DefaultAPIPath = "api/v1/guild/kick";
    [Token(Token = "0x4007BD7")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007BD8")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildKickResponse> onSuccess;
    [Token(Token = "0x4007BD9")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020F8")]
    public APIGuildKickRequest Request
    {
      [Token(Token = "0x600AAD2"), Address(RVA = "0x1A40DC8", Offset = "0x1A40DC8", VA = "0x1A40DC8")] private get
      {
        return (APIGuildKickRequest) null;
      }
      [Token(Token = "0x600AAD3"), Address(RVA = "0x1A40DD0", Offset = "0x1A40DD0", VA = "0x1A40DD0")] set
      {
      }
    }

    [Token(Token = "0x170020F9")]
    public APIGuildKickResponse Response
    {
      [Token(Token = "0x600AAD4"), Address(RVA = "0x1A40DD8", Offset = "0x1A40DD8", VA = "0x1A40DD8")] get
      {
        return (APIGuildKickResponse) null;
      }
      [Token(Token = "0x600AAD5"), Address(RVA = "0x1A40DE0", Offset = "0x1A40DE0", VA = "0x1A40DE0")] private set
      {
      }
    }

    [Token(Token = "0x170020FA")]
    public int ResponseCode
    {
      [Token(Token = "0x600AAD6"), Address(RVA = "0x1A40DE8", Offset = "0x1A40DE8", VA = "0x1A40DE8")] get
      {
        return new int();
      }
      [Token(Token = "0x600AAD7"), Address(RVA = "0x1A40DF0", Offset = "0x1A40DF0", VA = "0x1A40DF0")] private set
      {
      }
    }

    [Token(Token = "0x170020FB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AAD8"), Address(RVA = "0x1A40DF8", Offset = "0x1A40DF8", VA = "0x1A40DF8")] set
      {
      }
      [Token(Token = "0x600AAD9"), Address(RVA = "0x1A40E14", Offset = "0x1A40E14", VA = "0x1A40E14")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AADA")]
    [Address(RVA = "0x1A40E30", Offset = "0x1A40E30", VA = "0x1A40E30")]
    public APIGuildKick(string apiPath = "api/v1/guild/kick")
    {
    }

    [Token(Token = "0x600AADB")]
    [Address(RVA = "0x1A40EC8", Offset = "0x1A40EC8", VA = "0x1A40EC8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AADC")]
    [Address(RVA = "0x1A40F58", Offset = "0x1A40F58", VA = "0x1A40F58")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AADD")]
    [Address(RVA = "0x1A40F64", Offset = "0x1A40F64", VA = "0x1A40F64")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AADE")]
    [Address(RVA = "0x1A41038", Offset = "0x1A41038", VA = "0x1A41038")]
    private void OnSuccess(string json)
    {
    }
  }
}
