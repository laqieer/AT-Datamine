// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D59")]
  public class APIMind_equipmentEnhance
  {
    [Token(Token = "0x4007D5E")]
    public const string DefaultAPIPath = "api/v1/mind_equipment/enhance";
    [Token(Token = "0x4007D62")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D63")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMind_equipmentEnhanceResponse> onSuccess;
    [Token(Token = "0x4007D64")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021D4")]
    public APIMind_equipmentEnhanceRequest Request
    {
      [Token(Token = "0x600AD1E"), Address(RVA = "0x1A48A0C", Offset = "0x1A48A0C", VA = "0x1A48A0C")] private get
      {
        return (APIMind_equipmentEnhanceRequest) null;
      }
      [Token(Token = "0x600AD1F"), Address(RVA = "0x1A48A14", Offset = "0x1A48A14", VA = "0x1A48A14")] set
      {
      }
    }

    [Token(Token = "0x170021D5")]
    public APIMind_equipmentEnhanceResponse Response
    {
      [Token(Token = "0x600AD20"), Address(RVA = "0x1A48A1C", Offset = "0x1A48A1C", VA = "0x1A48A1C")] get
      {
        return (APIMind_equipmentEnhanceResponse) null;
      }
      [Token(Token = "0x600AD21"), Address(RVA = "0x1A48A24", Offset = "0x1A48A24", VA = "0x1A48A24")] private set
      {
      }
    }

    [Token(Token = "0x170021D6")]
    public int ResponseCode
    {
      [Token(Token = "0x600AD22"), Address(RVA = "0x1A48A2C", Offset = "0x1A48A2C", VA = "0x1A48A2C")] get
      {
        return new int();
      }
      [Token(Token = "0x600AD23"), Address(RVA = "0x1A48A34", Offset = "0x1A48A34", VA = "0x1A48A34")] private set
      {
      }
    }

    [Token(Token = "0x170021D7")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AD24"), Address(RVA = "0x1A48A3C", Offset = "0x1A48A3C", VA = "0x1A48A3C")] set
      {
      }
      [Token(Token = "0x600AD25"), Address(RVA = "0x1A48A58", Offset = "0x1A48A58", VA = "0x1A48A58")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AD26")]
    [Address(RVA = "0x1A48A74", Offset = "0x1A48A74", VA = "0x1A48A74")]
    public APIMind_equipmentEnhance(string apiPath = "api/v1/mind_equipment/enhance")
    {
    }

    [Token(Token = "0x600AD27")]
    [Address(RVA = "0x1A48B0C", Offset = "0x1A48B0C", VA = "0x1A48B0C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AD28")]
    [Address(RVA = "0x1A48B9C", Offset = "0x1A48B9C", VA = "0x1A48B9C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AD29")]
    [Address(RVA = "0x1A48BA8", Offset = "0x1A48BA8", VA = "0x1A48BA8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AD2A")]
    [Address(RVA = "0x1A48C7C", Offset = "0x1A48C7C", VA = "0x1A48C7C")]
    private void OnSuccess(string json)
    {
    }
  }
}
