// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaNodeClear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B69")]
  public class APIAreaNodeClear
  {
    [Token(Token = "0x4007575")]
    public const string DefaultAPIPath = "api/v1/area_quest/area_node/clear";
    [Token(Token = "0x4007579")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400757A")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAreaNodeClearResponse> onSuccess;
    [Token(Token = "0x400757B")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D63")]
    public APIAreaNodeClearRequest Request
    {
      [Token(Token = "0x600A0ED"), Address(RVA = "0x46C6260", Offset = "0x46C6260", VA = "0x46C6260")] private get
      {
        return (APIAreaNodeClearRequest) null;
      }
      [Token(Token = "0x600A0EE"), Address(RVA = "0x46C6268", Offset = "0x46C6268", VA = "0x46C6268")] set
      {
      }
    }

    [Token(Token = "0x17001D64")]
    public APIAreaNodeClearResponse Response
    {
      [Token(Token = "0x600A0EF"), Address(RVA = "0x46C6270", Offset = "0x46C6270", VA = "0x46C6270")] get
      {
        return (APIAreaNodeClearResponse) null;
      }
      [Token(Token = "0x600A0F0"), Address(RVA = "0x46C6278", Offset = "0x46C6278", VA = "0x46C6278")] private set
      {
      }
    }

    [Token(Token = "0x17001D65")]
    public int ResponseCode
    {
      [Token(Token = "0x600A0F1"), Address(RVA = "0x46C6280", Offset = "0x46C6280", VA = "0x46C6280")] get
      {
        return new int();
      }
      [Token(Token = "0x600A0F2"), Address(RVA = "0x46C6288", Offset = "0x46C6288", VA = "0x46C6288")] private set
      {
      }
    }

    [Token(Token = "0x17001D66")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A0F3"), Address(RVA = "0x46C6290", Offset = "0x46C6290", VA = "0x46C6290")] set
      {
      }
      [Token(Token = "0x600A0F4"), Address(RVA = "0x46C62AC", Offset = "0x46C62AC", VA = "0x46C62AC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A0F5")]
    [Address(RVA = "0x46C62C8", Offset = "0x46C62C8", VA = "0x46C62C8")]
    public APIAreaNodeClear(string apiPath = "api/v1/area_quest/area_node/clear")
    {
    }

    [Token(Token = "0x600A0F6")]
    [Address(RVA = "0x46C6360", Offset = "0x46C6360", VA = "0x46C6360")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A0F7")]
    [Address(RVA = "0x46C63F0", Offset = "0x46C63F0", VA = "0x46C63F0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A0F8")]
    [Address(RVA = "0x46C63FC", Offset = "0x46C63FC", VA = "0x46C63FC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A0F9")]
    [Address(RVA = "0x46C64D0", Offset = "0x46C64D0", VA = "0x46C64D0")]
    private void OnSuccess(string json)
    {
    }
  }
}
