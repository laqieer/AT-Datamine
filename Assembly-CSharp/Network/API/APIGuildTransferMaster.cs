// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildTransferMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D25")]
  public class APIGuildTransferMaster
  {
    [Token(Token = "0x4007C80")]
    public const string DefaultAPIPath = "api/v1/guild/transfer/master";
    [Token(Token = "0x4007C84")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C85")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildTransferMasterResponse> onSuccess;
    [Token(Token = "0x4007C86")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002151")]
    public APIGuildTransferMasterRequest Request
    {
      [Token(Token = "0x600ABCB"), Address(RVA = "0x1A443A8", Offset = "0x1A443A8", VA = "0x1A443A8")] private get
      {
        return (APIGuildTransferMasterRequest) null;
      }
      [Token(Token = "0x600ABCC"), Address(RVA = "0x1A443B0", Offset = "0x1A443B0", VA = "0x1A443B0")] set
      {
      }
    }

    [Token(Token = "0x17002152")]
    public APIGuildTransferMasterResponse Response
    {
      [Token(Token = "0x600ABCD"), Address(RVA = "0x1A443B8", Offset = "0x1A443B8", VA = "0x1A443B8")] get
      {
        return (APIGuildTransferMasterResponse) null;
      }
      [Token(Token = "0x600ABCE"), Address(RVA = "0x1A443C0", Offset = "0x1A443C0", VA = "0x1A443C0")] private set
      {
      }
    }

    [Token(Token = "0x17002153")]
    public int ResponseCode
    {
      [Token(Token = "0x600ABCF"), Address(RVA = "0x1A443C8", Offset = "0x1A443C8", VA = "0x1A443C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600ABD0"), Address(RVA = "0x1A443D0", Offset = "0x1A443D0", VA = "0x1A443D0")] private set
      {
      }
    }

    [Token(Token = "0x17002154")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ABD1"), Address(RVA = "0x1A443D8", Offset = "0x1A443D8", VA = "0x1A443D8")] set
      {
      }
      [Token(Token = "0x600ABD2"), Address(RVA = "0x1A443F4", Offset = "0x1A443F4", VA = "0x1A443F4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ABD3")]
    [Address(RVA = "0x1A44410", Offset = "0x1A44410", VA = "0x1A44410")]
    public APIGuildTransferMaster(string apiPath = "api/v1/guild/transfer/master")
    {
    }

    [Token(Token = "0x600ABD4")]
    [Address(RVA = "0x1A444A8", Offset = "0x1A444A8", VA = "0x1A444A8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ABD5")]
    [Address(RVA = "0x1A44538", Offset = "0x1A44538", VA = "0x1A44538")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ABD6")]
    [Address(RVA = "0x1A44544", Offset = "0x1A44544", VA = "0x1A44544")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ABD7")]
    [Address(RVA = "0x1A44618", Offset = "0x1A44618", VA = "0x1A44618")]
    private void OnSuccess(string json)
    {
    }
  }
}
