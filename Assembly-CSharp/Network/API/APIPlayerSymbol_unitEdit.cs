// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSymbol_unitEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DB9")]
  public class APIPlayerSymbol_unitEdit
  {
    [Token(Token = "0x4007EFC")]
    public const string DefaultAPIPath = "api/v1/player/symbol_unit/edit";
    [Token(Token = "0x4007F00")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F01")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerSymbol_unitEditResponse> onSuccess;
    [Token(Token = "0x4007F02")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170022DE")]
    public APIPlayerSymbol_unitEditRequest Request
    {
      [Token(Token = "0x600AFA8"), Address(RVA = "0x1A50CDC", Offset = "0x1A50CDC", VA = "0x1A50CDC")] private get
      {
        return (APIPlayerSymbol_unitEditRequest) null;
      }
      [Token(Token = "0x600AFA9"), Address(RVA = "0x1A50CE4", Offset = "0x1A50CE4", VA = "0x1A50CE4")] set
      {
      }
    }

    [Token(Token = "0x170022DF")]
    public APIPlayerSymbol_unitEditResponse Response
    {
      [Token(Token = "0x600AFAA"), Address(RVA = "0x1A50CEC", Offset = "0x1A50CEC", VA = "0x1A50CEC")] get
      {
        return (APIPlayerSymbol_unitEditResponse) null;
      }
      [Token(Token = "0x600AFAB"), Address(RVA = "0x1A50CF4", Offset = "0x1A50CF4", VA = "0x1A50CF4")] private set
      {
      }
    }

    [Token(Token = "0x170022E0")]
    public int ResponseCode
    {
      [Token(Token = "0x600AFAC"), Address(RVA = "0x1A50CFC", Offset = "0x1A50CFC", VA = "0x1A50CFC")] get
      {
        return new int();
      }
      [Token(Token = "0x600AFAD"), Address(RVA = "0x1A50D04", Offset = "0x1A50D04", VA = "0x1A50D04")] private set
      {
      }
    }

    [Token(Token = "0x170022E1")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AFAE"), Address(RVA = "0x1A50D0C", Offset = "0x1A50D0C", VA = "0x1A50D0C")] set
      {
      }
      [Token(Token = "0x600AFAF"), Address(RVA = "0x1A50D28", Offset = "0x1A50D28", VA = "0x1A50D28")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AFB0")]
    [Address(RVA = "0x1A50D44", Offset = "0x1A50D44", VA = "0x1A50D44")]
    public APIPlayerSymbol_unitEdit(string apiPath = "api/v1/player/symbol_unit/edit")
    {
    }

    [Token(Token = "0x600AFB1")]
    [Address(RVA = "0x1A50DDC", Offset = "0x1A50DDC", VA = "0x1A50DDC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AFB2")]
    [Address(RVA = "0x1A50E6C", Offset = "0x1A50E6C", VA = "0x1A50E6C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AFB3")]
    [Address(RVA = "0x1A50E78", Offset = "0x1A50E78", VA = "0x1A50E78")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AFB4")]
    [Address(RVA = "0x1A50F4C", Offset = "0x1A50F4C", VA = "0x1A50F4C")]
    private void OnSuccess(string json)
    {
    }
  }
}
