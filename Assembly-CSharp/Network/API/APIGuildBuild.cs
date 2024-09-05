// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildBuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CA9")]
  public class APIGuildBuild
  {
    [Token(Token = "0x4007A8E")]
    public const string DefaultAPIPath = "api/v1/guild/build";
    [Token(Token = "0x4007A92")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A93")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildBuildResponse> onSuccess;
    [Token(Token = "0x4007A94")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002048")]
    public APIGuildBuildRequest Request
    {
      [Token(Token = "0x600A8D2"), Address(RVA = "0x191325C", Offset = "0x191325C", VA = "0x191325C")] private get
      {
        return (APIGuildBuildRequest) null;
      }
      [Token(Token = "0x600A8D3"), Address(RVA = "0x1913264", Offset = "0x1913264", VA = "0x1913264")] set
      {
      }
    }

    [Token(Token = "0x17002049")]
    public APIGuildBuildResponse Response
    {
      [Token(Token = "0x600A8D4"), Address(RVA = "0x191326C", Offset = "0x191326C", VA = "0x191326C")] get
      {
        return (APIGuildBuildResponse) null;
      }
      [Token(Token = "0x600A8D5"), Address(RVA = "0x1913274", Offset = "0x1913274", VA = "0x1913274")] private set
      {
      }
    }

    [Token(Token = "0x1700204A")]
    public int ResponseCode
    {
      [Token(Token = "0x600A8D6"), Address(RVA = "0x191327C", Offset = "0x191327C", VA = "0x191327C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A8D7"), Address(RVA = "0x1913284", Offset = "0x1913284", VA = "0x1913284")] private set
      {
      }
    }

    [Token(Token = "0x1700204B")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A8D8"), Address(RVA = "0x191328C", Offset = "0x191328C", VA = "0x191328C")] set
      {
      }
      [Token(Token = "0x600A8D9"), Address(RVA = "0x19132A8", Offset = "0x19132A8", VA = "0x19132A8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A8DA")]
    [Address(RVA = "0x19132C4", Offset = "0x19132C4", VA = "0x19132C4")]
    public APIGuildBuild(string apiPath = "api/v1/guild/build")
    {
    }

    [Token(Token = "0x600A8DB")]
    [Address(RVA = "0x191335C", Offset = "0x191335C", VA = "0x191335C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A8DC")]
    [Address(RVA = "0x19133EC", Offset = "0x19133EC", VA = "0x19133EC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A8DD")]
    [Address(RVA = "0x19133F8", Offset = "0x19133F8", VA = "0x19133F8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A8DE")]
    [Address(RVA = "0x19134CC", Offset = "0x19134CC", VA = "0x19134CC")]
    private void OnSuccess(string json)
    {
    }
  }
}
