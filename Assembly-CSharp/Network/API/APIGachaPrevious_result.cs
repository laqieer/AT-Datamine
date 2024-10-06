// Decompiled with JetBrains decompiler
// Type: Network.API.APIGachaPrevious_result
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C99")]
  public class APIGachaPrevious_result
  {
    [Token(Token = "0x4007A49")]
    public const string DefaultAPIPath = "api/v1/gacha/previous_result";
    [Token(Token = "0x4007A4D")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A4E")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGachaPrevious_resultResponse> onSuccess;
    [Token(Token = "0x4007A4F")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002024")]
    public APIGachaPrevious_resultRequest Request
    {
      [Token(Token = "0x600A86E"), Address(RVA = "0x1911CCC", Offset = "0x1911CCC", VA = "0x1911CCC")] private get
      {
        return (APIGachaPrevious_resultRequest) null;
      }
      [Token(Token = "0x600A86F"), Address(RVA = "0x1911CD4", Offset = "0x1911CD4", VA = "0x1911CD4")] set
      {
      }
    }

    [Token(Token = "0x17002025")]
    public APIGachaPrevious_resultResponse Response
    {
      [Token(Token = "0x600A870"), Address(RVA = "0x1911CDC", Offset = "0x1911CDC", VA = "0x1911CDC")] get
      {
        return (APIGachaPrevious_resultResponse) null;
      }
      [Token(Token = "0x600A871"), Address(RVA = "0x1911CE4", Offset = "0x1911CE4", VA = "0x1911CE4")] private set
      {
      }
    }

    [Token(Token = "0x17002026")]
    public int ResponseCode
    {
      [Token(Token = "0x600A872"), Address(RVA = "0x1911CEC", Offset = "0x1911CEC", VA = "0x1911CEC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A873"), Address(RVA = "0x1911CF4", Offset = "0x1911CF4", VA = "0x1911CF4")] private set
      {
      }
    }

    [Token(Token = "0x17002027")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A874"), Address(RVA = "0x1911CFC", Offset = "0x1911CFC", VA = "0x1911CFC")] set
      {
      }
      [Token(Token = "0x600A875"), Address(RVA = "0x1911D18", Offset = "0x1911D18", VA = "0x1911D18")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A876")]
    [Address(RVA = "0x1911D34", Offset = "0x1911D34", VA = "0x1911D34")]
    public APIGachaPrevious_result(string apiPath = "api/v1/gacha/previous_result")
    {
    }

    [Token(Token = "0x600A877")]
    [Address(RVA = "0x1911DCC", Offset = "0x1911DCC", VA = "0x1911DCC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A878")]
    [Address(RVA = "0x1911E5C", Offset = "0x1911E5C", VA = "0x1911E5C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A879")]
    [Address(RVA = "0x1911E68", Offset = "0x1911E68", VA = "0x1911E68")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A87A")]
    [Address(RVA = "0x1911F3C", Offset = "0x1911F3C", VA = "0x1911F3C")]
    private void OnSuccess(string json)
    {
    }
  }
}
