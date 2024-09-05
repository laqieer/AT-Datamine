// Decompiled with JetBrains decompiler
// Type: Network.API.APIHome
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D2D")]
  public class APIHome
  {
    [Token(Token = "0x4007CA8")]
    public const string DefaultAPIPath = "api/v1/home/home";
    [Token(Token = "0x4007CAC")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007CAD")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIHomeResponse> onSuccess;
    [Token(Token = "0x4007CAE")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700216F")]
    public APIHomeRequest Request
    {
      [Token(Token = "0x600AC09"), Address(RVA = "0x1A44EC0", Offset = "0x1A44EC0", VA = "0x1A44EC0")] private get
      {
        return (APIHomeRequest) null;
      }
      [Token(Token = "0x600AC0A"), Address(RVA = "0x1A44EC8", Offset = "0x1A44EC8", VA = "0x1A44EC8")] set
      {
      }
    }

    [Token(Token = "0x17002170")]
    public APIHomeResponse Response
    {
      [Token(Token = "0x600AC0B"), Address(RVA = "0x1A44ED0", Offset = "0x1A44ED0", VA = "0x1A44ED0")] get
      {
        return (APIHomeResponse) null;
      }
      [Token(Token = "0x600AC0C"), Address(RVA = "0x1A44ED8", Offset = "0x1A44ED8", VA = "0x1A44ED8")] private set
      {
      }
    }

    [Token(Token = "0x17002171")]
    public int ResponseCode
    {
      [Token(Token = "0x600AC0D"), Address(RVA = "0x1A44EE0", Offset = "0x1A44EE0", VA = "0x1A44EE0")] get
      {
        return new int();
      }
      [Token(Token = "0x600AC0E"), Address(RVA = "0x1A44EE8", Offset = "0x1A44EE8", VA = "0x1A44EE8")] private set
      {
      }
    }

    [Token(Token = "0x17002172")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AC0F"), Address(RVA = "0x1A44EF0", Offset = "0x1A44EF0", VA = "0x1A44EF0")] set
      {
      }
      [Token(Token = "0x600AC10"), Address(RVA = "0x1A44F0C", Offset = "0x1A44F0C", VA = "0x1A44F0C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AC11")]
    [Address(RVA = "0x1A44F28", Offset = "0x1A44F28", VA = "0x1A44F28")]
    public APIHome(string apiPath = "api/v1/home/home")
    {
    }

    [Token(Token = "0x600AC12")]
    [Address(RVA = "0x1A44FC0", Offset = "0x1A44FC0", VA = "0x1A44FC0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AC13")]
    [Address(RVA = "0x1A45050", Offset = "0x1A45050", VA = "0x1A45050")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AC14")]
    [Address(RVA = "0x1A4505C", Offset = "0x1A4505C", VA = "0x1A4505C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AC15")]
    [Address(RVA = "0x1A45130", Offset = "0x1A45130", VA = "0x1A45130")]
    private void OnSuccess(string json)
    {
    }
  }
}
