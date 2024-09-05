// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerEmblemEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D95")]
  public class APIPlayerEmblemEdit
  {
    [Token(Token = "0x4007E48")]
    public const string DefaultAPIPath = "api/v1/player/emblem/edit";
    [Token(Token = "0x4007E4C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E4D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerEmblemEditResponse> onSuccess;
    [Token(Token = "0x4007E4E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002260")]
    public APIPlayerEmblemEditRequest Request
    {
      [Token(Token = "0x600AE9A"), Address(RVA = "0x1A4DB00", Offset = "0x1A4DB00", VA = "0x1A4DB00")] private get
      {
        return (APIPlayerEmblemEditRequest) null;
      }
      [Token(Token = "0x600AE9B"), Address(RVA = "0x1A4DB08", Offset = "0x1A4DB08", VA = "0x1A4DB08")] set
      {
      }
    }

    [Token(Token = "0x17002261")]
    public APIPlayerEmblemEditResponse Response
    {
      [Token(Token = "0x600AE9C"), Address(RVA = "0x1A4DB10", Offset = "0x1A4DB10", VA = "0x1A4DB10")] get
      {
        return (APIPlayerEmblemEditResponse) null;
      }
      [Token(Token = "0x600AE9D"), Address(RVA = "0x1A4DB18", Offset = "0x1A4DB18", VA = "0x1A4DB18")] private set
      {
      }
    }

    [Token(Token = "0x17002262")]
    public int ResponseCode
    {
      [Token(Token = "0x600AE9E"), Address(RVA = "0x1A4DB20", Offset = "0x1A4DB20", VA = "0x1A4DB20")] get
      {
        return new int();
      }
      [Token(Token = "0x600AE9F"), Address(RVA = "0x1A4DB28", Offset = "0x1A4DB28", VA = "0x1A4DB28")] private set
      {
      }
    }

    [Token(Token = "0x17002263")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AEA0"), Address(RVA = "0x1A4DB30", Offset = "0x1A4DB30", VA = "0x1A4DB30")] set
      {
      }
      [Token(Token = "0x600AEA1"), Address(RVA = "0x1A4DB4C", Offset = "0x1A4DB4C", VA = "0x1A4DB4C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AEA2")]
    [Address(RVA = "0x1A4DB68", Offset = "0x1A4DB68", VA = "0x1A4DB68")]
    public APIPlayerEmblemEdit(string apiPath = "api/v1/player/emblem/edit")
    {
    }

    [Token(Token = "0x600AEA3")]
    [Address(RVA = "0x1A4DC00", Offset = "0x1A4DC00", VA = "0x1A4DC00")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AEA4")]
    [Address(RVA = "0x1A4DC90", Offset = "0x1A4DC90", VA = "0x1A4DC90")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AEA5")]
    [Address(RVA = "0x1A4DC9C", Offset = "0x1A4DC9C", VA = "0x1A4DC9C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AEA6")]
    [Address(RVA = "0x1A4DD70", Offset = "0x1A4DD70", VA = "0x1A4DD70")]
    private void OnSuccess(string json)
    {
    }
  }
}
