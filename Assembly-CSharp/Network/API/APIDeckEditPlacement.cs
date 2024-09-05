// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEditPlacement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C01")]
  public class APIDeckEditPlacement
  {
    [Token(Token = "0x40077E0")]
    public const string DefaultAPIPath = "api/v1/deck/edit_placement";
    [Token(Token = "0x40077E4")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40077E5")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDeckEditPlacementResponse> onSuccess;
    [Token(Token = "0x40077E6")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EB5")]
    public APIDeckEditPlacementRequest Request
    {
      [Token(Token = "0x600A49F"), Address(RVA = "0x46D2F18", Offset = "0x46D2F18", VA = "0x46D2F18")] private get
      {
        return (APIDeckEditPlacementRequest) null;
      }
      [Token(Token = "0x600A4A0"), Address(RVA = "0x46D2F20", Offset = "0x46D2F20", VA = "0x46D2F20")] set
      {
      }
    }

    [Token(Token = "0x17001EB6")]
    public APIDeckEditPlacementResponse Response
    {
      [Token(Token = "0x600A4A1"), Address(RVA = "0x46D2F28", Offset = "0x46D2F28", VA = "0x46D2F28")] get
      {
        return (APIDeckEditPlacementResponse) null;
      }
      [Token(Token = "0x600A4A2"), Address(RVA = "0x46D2F30", Offset = "0x46D2F30", VA = "0x46D2F30")] private set
      {
      }
    }

    [Token(Token = "0x17001EB7")]
    public int ResponseCode
    {
      [Token(Token = "0x600A4A3"), Address(RVA = "0x46D2F38", Offset = "0x46D2F38", VA = "0x46D2F38")] get
      {
        return new int();
      }
      [Token(Token = "0x600A4A4"), Address(RVA = "0x46D2F40", Offset = "0x46D2F40", VA = "0x46D2F40")] private set
      {
      }
    }

    [Token(Token = "0x17001EB8")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A4A5"), Address(RVA = "0x46D2F48", Offset = "0x46D2F48", VA = "0x46D2F48")] set
      {
      }
      [Token(Token = "0x600A4A6"), Address(RVA = "0x46D2F64", Offset = "0x46D2F64", VA = "0x46D2F64")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A4A7")]
    [Address(RVA = "0x46D2F80", Offset = "0x46D2F80", VA = "0x46D2F80")]
    public APIDeckEditPlacement(string apiPath = "api/v1/deck/edit_placement")
    {
    }

    [Token(Token = "0x600A4A8")]
    [Address(RVA = "0x46D3018", Offset = "0x46D3018", VA = "0x46D3018")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A4A9")]
    [Address(RVA = "0x46D30A8", Offset = "0x46D30A8", VA = "0x46D30A8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A4AA")]
    [Address(RVA = "0x46D30B4", Offset = "0x46D30B4", VA = "0x46D30B4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A4AB")]
    [Address(RVA = "0x46D3188", Offset = "0x46D3188", VA = "0x46D3188")]
    private void OnSuccess(string json)
    {
    }
  }
}
