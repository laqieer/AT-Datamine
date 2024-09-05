// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildDelete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CBD")]
  public class APIGuildDelete
  {
    [Token(Token = "0x4007ADB")]
    public const string DefaultAPIPath = "api/v1/guild/delete";
    [Token(Token = "0x4007ADF")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007AE0")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildDeleteResponse> onSuccess;
    [Token(Token = "0x4007AE1")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002073")]
    public APIGuildDeleteRequest Request
    {
      [Token(Token = "0x600A94D"), Address(RVA = "0x1914D30", Offset = "0x1914D30", VA = "0x1914D30")] private get
      {
        return (APIGuildDeleteRequest) null;
      }
      [Token(Token = "0x600A94E"), Address(RVA = "0x1914D38", Offset = "0x1914D38", VA = "0x1914D38")] set
      {
      }
    }

    [Token(Token = "0x17002074")]
    public APIGuildDeleteResponse Response
    {
      [Token(Token = "0x600A94F"), Address(RVA = "0x1914D40", Offset = "0x1914D40", VA = "0x1914D40")] get
      {
        return (APIGuildDeleteResponse) null;
      }
      [Token(Token = "0x600A950"), Address(RVA = "0x1914D48", Offset = "0x1914D48", VA = "0x1914D48")] private set
      {
      }
    }

    [Token(Token = "0x17002075")]
    public int ResponseCode
    {
      [Token(Token = "0x600A951"), Address(RVA = "0x1914D50", Offset = "0x1914D50", VA = "0x1914D50")] get
      {
        return new int();
      }
      [Token(Token = "0x600A952"), Address(RVA = "0x1914D58", Offset = "0x1914D58", VA = "0x1914D58")] private set
      {
      }
    }

    [Token(Token = "0x17002076")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A953"), Address(RVA = "0x1914D60", Offset = "0x1914D60", VA = "0x1914D60")] set
      {
      }
      [Token(Token = "0x600A954"), Address(RVA = "0x1914D7C", Offset = "0x1914D7C", VA = "0x1914D7C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A955")]
    [Address(RVA = "0x1914D98", Offset = "0x1914D98", VA = "0x1914D98")]
    public APIGuildDelete(string apiPath = "api/v1/guild/delete")
    {
    }

    [Token(Token = "0x600A956")]
    [Address(RVA = "0x1914E30", Offset = "0x1914E30", VA = "0x1914E30")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A957")]
    [Address(RVA = "0x1914EC0", Offset = "0x1914EC0", VA = "0x1914EC0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A958")]
    [Address(RVA = "0x1914ECC", Offset = "0x1914ECC", VA = "0x1914ECC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A959")]
    [Address(RVA = "0x1914FA0", Offset = "0x1914FA0", VA = "0x1914FA0")]
    private void OnSuccess(string json)
    {
    }
  }
}
