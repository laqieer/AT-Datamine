// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionChestOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E3D")]
  public class APIStoryFreeactionChestOpen
  {
    [Token(Token = "0x400818C")]
    public const string DefaultAPIPath = "api/v1/story/freeaction/chest/open";
    [Token(Token = "0x4008190")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008191")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryFreeactionChestOpenResponse> onSuccess;
    [Token(Token = "0x4008192")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700243D")]
    public APIStoryFreeactionChestOpenRequest Request
    {
      [Token(Token = "0x600B317"), Address(RVA = "0x22E1EC4", Offset = "0x22E1EC4", VA = "0x22E1EC4")] private get
      {
        return (APIStoryFreeactionChestOpenRequest) null;
      }
      [Token(Token = "0x600B318"), Address(RVA = "0x22E1ECC", Offset = "0x22E1ECC", VA = "0x22E1ECC")] set
      {
      }
    }

    [Token(Token = "0x1700243E")]
    public APIStoryFreeactionChestOpenResponse Response
    {
      [Token(Token = "0x600B319"), Address(RVA = "0x22E1ED4", Offset = "0x22E1ED4", VA = "0x22E1ED4")] get
      {
        return (APIStoryFreeactionChestOpenResponse) null;
      }
      [Token(Token = "0x600B31A"), Address(RVA = "0x22E1EDC", Offset = "0x22E1EDC", VA = "0x22E1EDC")] private set
      {
      }
    }

    [Token(Token = "0x1700243F")]
    public int ResponseCode
    {
      [Token(Token = "0x600B31B"), Address(RVA = "0x22E1EE4", Offset = "0x22E1EE4", VA = "0x22E1EE4")] get
      {
        return new int();
      }
      [Token(Token = "0x600B31C"), Address(RVA = "0x22E1EEC", Offset = "0x22E1EEC", VA = "0x22E1EEC")] private set
      {
      }
    }

    [Token(Token = "0x17002440")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B31D"), Address(RVA = "0x22E1EF4", Offset = "0x22E1EF4", VA = "0x22E1EF4")] set
      {
      }
      [Token(Token = "0x600B31E"), Address(RVA = "0x22E1F10", Offset = "0x22E1F10", VA = "0x22E1F10")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B31F")]
    [Address(RVA = "0x22E1F2C", Offset = "0x22E1F2C", VA = "0x22E1F2C")]
    public APIStoryFreeactionChestOpen(string apiPath = "api/v1/story/freeaction/chest/open")
    {
    }

    [Token(Token = "0x600B320")]
    [Address(RVA = "0x22E1FC4", Offset = "0x22E1FC4", VA = "0x22E1FC4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B321")]
    [Address(RVA = "0x22E2054", Offset = "0x22E2054", VA = "0x22E2054")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B322")]
    [Address(RVA = "0x22E2060", Offset = "0x22E2060", VA = "0x22E2060")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B323")]
    [Address(RVA = "0x22E2134", Offset = "0x22E2134", VA = "0x22E2134")]
    private void OnSuccess(string json)
    {
    }
  }
}
