// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DA9")]
  public class APIPlayerProfile
  {
    [Token(Token = "0x4007E86")]
    public const string DefaultAPIPath = "api/v1/player/profile";
    [Token(Token = "0x4007E8A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E8B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerProfileResponse> onSuccess;
    [Token(Token = "0x4007E8C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002282")]
    public APIPlayerProfileRequest Request
    {
      [Token(Token = "0x600AF0C"), Address(RVA = "0x1A4F59C", Offset = "0x1A4F59C", VA = "0x1A4F59C")] private get
      {
        return (APIPlayerProfileRequest) null;
      }
      [Token(Token = "0x600AF0D"), Address(RVA = "0x1A4F5A4", Offset = "0x1A4F5A4", VA = "0x1A4F5A4")] set
      {
      }
    }

    [Token(Token = "0x17002283")]
    public APIPlayerProfileResponse Response
    {
      [Token(Token = "0x600AF0E"), Address(RVA = "0x1A4F5AC", Offset = "0x1A4F5AC", VA = "0x1A4F5AC")] get
      {
        return (APIPlayerProfileResponse) null;
      }
      [Token(Token = "0x600AF0F"), Address(RVA = "0x1A4F5B4", Offset = "0x1A4F5B4", VA = "0x1A4F5B4")] private set
      {
      }
    }

    [Token(Token = "0x17002284")]
    public int ResponseCode
    {
      [Token(Token = "0x600AF10"), Address(RVA = "0x1A4F5BC", Offset = "0x1A4F5BC", VA = "0x1A4F5BC")] get
      {
        return new int();
      }
      [Token(Token = "0x600AF11"), Address(RVA = "0x1A4F5C4", Offset = "0x1A4F5C4", VA = "0x1A4F5C4")] private set
      {
      }
    }

    [Token(Token = "0x17002285")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AF12"), Address(RVA = "0x1A4F5CC", Offset = "0x1A4F5CC", VA = "0x1A4F5CC")] set
      {
      }
      [Token(Token = "0x600AF13"), Address(RVA = "0x1A4F5E8", Offset = "0x1A4F5E8", VA = "0x1A4F5E8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AF14")]
    [Address(RVA = "0x1A4F604", Offset = "0x1A4F604", VA = "0x1A4F604")]
    public APIPlayerProfile(string apiPath = "api/v1/player/profile")
    {
    }

    [Token(Token = "0x600AF15")]
    [Address(RVA = "0x1A4F69C", Offset = "0x1A4F69C", VA = "0x1A4F69C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AF16")]
    [Address(RVA = "0x1A4F72C", Offset = "0x1A4F72C", VA = "0x1A4F72C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AF17")]
    [Address(RVA = "0x1A4F738", Offset = "0x1A4F738", VA = "0x1A4F738")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AF18")]
    [Address(RVA = "0x1A4F80C", Offset = "0x1A4F80C", VA = "0x1A4F80C")]
    private void OnSuccess(string json)
    {
    }
  }
}
