// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentMedal_exchange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D65")]
  public class APIMind_equipmentMedal_exchange
  {
    [Token(Token = "0x4007D8E")]
    public const string DefaultAPIPath = "api/v1/mind_equipment/medal_exchange";
    [Token(Token = "0x4007D92")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D93")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMind_equipmentMedal_exchangeResponse> onSuccess;
    [Token(Token = "0x4007D94")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021F0")]
    public APIMind_equipmentMedal_exchangeRequest Request
    {
      [Token(Token = "0x600AD6A"), Address(RVA = "0x1A49A40", Offset = "0x1A49A40", VA = "0x1A49A40")] private get
      {
        return (APIMind_equipmentMedal_exchangeRequest) null;
      }
      [Token(Token = "0x600AD6B"), Address(RVA = "0x1A49A48", Offset = "0x1A49A48", VA = "0x1A49A48")] set
      {
      }
    }

    [Token(Token = "0x170021F1")]
    public APIMind_equipmentMedal_exchangeResponse Response
    {
      [Token(Token = "0x600AD6C"), Address(RVA = "0x1A49A50", Offset = "0x1A49A50", VA = "0x1A49A50")] get
      {
        return (APIMind_equipmentMedal_exchangeResponse) null;
      }
      [Token(Token = "0x600AD6D"), Address(RVA = "0x1A49A58", Offset = "0x1A49A58", VA = "0x1A49A58")] private set
      {
      }
    }

    [Token(Token = "0x170021F2")]
    public int ResponseCode
    {
      [Token(Token = "0x600AD6E"), Address(RVA = "0x1A49A60", Offset = "0x1A49A60", VA = "0x1A49A60")] get
      {
        return new int();
      }
      [Token(Token = "0x600AD6F"), Address(RVA = "0x1A49A68", Offset = "0x1A49A68", VA = "0x1A49A68")] private set
      {
      }
    }

    [Token(Token = "0x170021F3")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AD70"), Address(RVA = "0x1A49A70", Offset = "0x1A49A70", VA = "0x1A49A70")] set
      {
      }
      [Token(Token = "0x600AD71"), Address(RVA = "0x1A49A8C", Offset = "0x1A49A8C", VA = "0x1A49A8C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AD72")]
    [Address(RVA = "0x1A49AA8", Offset = "0x1A49AA8", VA = "0x1A49AA8")]
    public APIMind_equipmentMedal_exchange(string apiPath = "api/v1/mind_equipment/medal_exchange")
    {
    }

    [Token(Token = "0x600AD73")]
    [Address(RVA = "0x1A49B40", Offset = "0x1A49B40", VA = "0x1A49B40")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AD74")]
    [Address(RVA = "0x1A49BD0", Offset = "0x1A49BD0", VA = "0x1A49BD0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AD75")]
    [Address(RVA = "0x1A49BDC", Offset = "0x1A49BDC", VA = "0x1A49BDC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AD76")]
    [Address(RVA = "0x1A49CB0", Offset = "0x1A49CB0", VA = "0x1A49CB0")]
    private void OnSuccess(string json)
    {
    }
  }
}
