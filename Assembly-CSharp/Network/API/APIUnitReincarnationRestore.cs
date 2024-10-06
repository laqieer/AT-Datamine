// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationRestore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ED1")]
  public class APIUnitReincarnationRestore
  {
    [Token(Token = "0x4008459")]
    public const string DefaultAPIPath = "api/v1/unit/reincarnation/restore";
    [Token(Token = "0x400845D")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400845E")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitReincarnationRestoreResponse> onSuccess;
    [Token(Token = "0x400845F")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025DA")]
    public APIUnitReincarnationRestoreRequest Request
    {
      [Token(Token = "0x600B704"), Address(RVA = "0x212F3FC", Offset = "0x212F3FC", VA = "0x212F3FC")] private get
      {
        return (APIUnitReincarnationRestoreRequest) null;
      }
      [Token(Token = "0x600B705"), Address(RVA = "0x212F404", Offset = "0x212F404", VA = "0x212F404")] set
      {
      }
    }

    [Token(Token = "0x170025DB")]
    public APIUnitReincarnationRestoreResponse Response
    {
      [Token(Token = "0x600B706"), Address(RVA = "0x212F40C", Offset = "0x212F40C", VA = "0x212F40C")] get
      {
        return (APIUnitReincarnationRestoreResponse) null;
      }
      [Token(Token = "0x600B707"), Address(RVA = "0x212F414", Offset = "0x212F414", VA = "0x212F414")] private set
      {
      }
    }

    [Token(Token = "0x170025DC")]
    public int ResponseCode
    {
      [Token(Token = "0x600B708"), Address(RVA = "0x212F41C", Offset = "0x212F41C", VA = "0x212F41C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B709"), Address(RVA = "0x212F424", Offset = "0x212F424", VA = "0x212F424")] private set
      {
      }
    }

    [Token(Token = "0x170025DD")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B70A"), Address(RVA = "0x212F42C", Offset = "0x212F42C", VA = "0x212F42C")] set
      {
      }
      [Token(Token = "0x600B70B"), Address(RVA = "0x212F448", Offset = "0x212F448", VA = "0x212F448")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B70C")]
    [Address(RVA = "0x212F464", Offset = "0x212F464", VA = "0x212F464")]
    public APIUnitReincarnationRestore(string apiPath = "api/v1/unit/reincarnation/restore")
    {
    }

    [Token(Token = "0x600B70D")]
    [Address(RVA = "0x212F4FC", Offset = "0x212F4FC", VA = "0x212F4FC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B70E")]
    [Address(RVA = "0x212F58C", Offset = "0x212F58C", VA = "0x212F58C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B70F")]
    [Address(RVA = "0x212F598", Offset = "0x212F598", VA = "0x212F598")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B710")]
    [Address(RVA = "0x212F66C", Offset = "0x212F66C", VA = "0x212F66C")]
    private void OnSuccess(string json)
    {
    }
  }
}
