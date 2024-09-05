// Decompiled with JetBrains decompiler
// Type: Network.API.APIIgnore_encryptionServer_time
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D35")]
  public class APIIgnore_encryptionServer_time
  {
    [Token(Token = "0x4007CC0")]
    public const string DefaultAPIPath = "api/v1/ignore_encryption/server_time";
    [Token(Token = "0x4007CC4")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007CC5")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIIgnore_encryptionServer_timeResponse> onSuccess;
    [Token(Token = "0x4007CC6")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700217D")]
    public APIIgnore_encryptionServer_timeRequest Request
    {
      [Token(Token = "0x600AC37"), Address(RVA = "0x1A45968", Offset = "0x1A45968", VA = "0x1A45968")] private get
      {
        return (APIIgnore_encryptionServer_timeRequest) null;
      }
      [Token(Token = "0x600AC38"), Address(RVA = "0x1A45970", Offset = "0x1A45970", VA = "0x1A45970")] set
      {
      }
    }

    [Token(Token = "0x1700217E")]
    public APIIgnore_encryptionServer_timeResponse Response
    {
      [Token(Token = "0x600AC39"), Address(RVA = "0x1A45978", Offset = "0x1A45978", VA = "0x1A45978")] get
      {
        return (APIIgnore_encryptionServer_timeResponse) null;
      }
      [Token(Token = "0x600AC3A"), Address(RVA = "0x1A45980", Offset = "0x1A45980", VA = "0x1A45980")] private set
      {
      }
    }

    [Token(Token = "0x1700217F")]
    public int ResponseCode
    {
      [Token(Token = "0x600AC3B"), Address(RVA = "0x1A45988", Offset = "0x1A45988", VA = "0x1A45988")] get
      {
        return new int();
      }
      [Token(Token = "0x600AC3C"), Address(RVA = "0x1A45990", Offset = "0x1A45990", VA = "0x1A45990")] private set
      {
      }
    }

    [Token(Token = "0x17002180")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AC3D"), Address(RVA = "0x1A45998", Offset = "0x1A45998", VA = "0x1A45998")] set
      {
      }
      [Token(Token = "0x600AC3E"), Address(RVA = "0x1A459B4", Offset = "0x1A459B4", VA = "0x1A459B4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AC3F")]
    [Address(RVA = "0x1A459D0", Offset = "0x1A459D0", VA = "0x1A459D0")]
    public APIIgnore_encryptionServer_time(string apiPath = "api/v1/ignore_encryption/server_time")
    {
    }

    [Token(Token = "0x600AC40")]
    [Address(RVA = "0x1A45A68", Offset = "0x1A45A68", VA = "0x1A45A68")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AC41")]
    [Address(RVA = "0x1A45AF8", Offset = "0x1A45AF8", VA = "0x1A45AF8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AC42")]
    [Address(RVA = "0x1A45B04", Offset = "0x1A45B04", VA = "0x1A45B04")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AC43")]
    [Address(RVA = "0x1A45BD8", Offset = "0x1A45BD8", VA = "0x1A45BD8")]
    private void OnSuccess(string json)
    {
    }
  }
}
