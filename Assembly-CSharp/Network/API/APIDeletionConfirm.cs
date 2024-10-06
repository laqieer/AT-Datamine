// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeletionConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C0D")]
  public class APIDeletionConfirm
  {
    [Token(Token = "0x400780A")]
    public const string DefaultAPIPath = "das/pass/deletion/confirm";
    [Token(Token = "0x400780E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400780F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDeletionConfirmResponse> onSuccess;
    [Token(Token = "0x4007810")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EC8")]
    public APIDeletionConfirmRequest Request
    {
      [Token(Token = "0x600A4E2"), Address(RVA = "0x1905F18", Offset = "0x1905F18", VA = "0x1905F18")] private get
      {
        return (APIDeletionConfirmRequest) null;
      }
      [Token(Token = "0x600A4E3"), Address(RVA = "0x1905F20", Offset = "0x1905F20", VA = "0x1905F20")] set
      {
      }
    }

    [Token(Token = "0x17001EC9")]
    public APIDeletionConfirmResponse Response
    {
      [Token(Token = "0x600A4E4"), Address(RVA = "0x1905F28", Offset = "0x1905F28", VA = "0x1905F28")] get
      {
        return (APIDeletionConfirmResponse) null;
      }
      [Token(Token = "0x600A4E5"), Address(RVA = "0x1905F30", Offset = "0x1905F30", VA = "0x1905F30")] private set
      {
      }
    }

    [Token(Token = "0x17001ECA")]
    public int ResponseCode
    {
      [Token(Token = "0x600A4E6"), Address(RVA = "0x1905F38", Offset = "0x1905F38", VA = "0x1905F38")] get
      {
        return new int();
      }
      [Token(Token = "0x600A4E7"), Address(RVA = "0x1905F40", Offset = "0x1905F40", VA = "0x1905F40")] private set
      {
      }
    }

    [Token(Token = "0x17001ECB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A4E8"), Address(RVA = "0x1905F48", Offset = "0x1905F48", VA = "0x1905F48")] set
      {
      }
      [Token(Token = "0x600A4E9"), Address(RVA = "0x1905F64", Offset = "0x1905F64", VA = "0x1905F64")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A4EA")]
    [Address(RVA = "0x1905F80", Offset = "0x1905F80", VA = "0x1905F80")]
    public APIDeletionConfirm(string apiPath = "das/pass/deletion/confirm")
    {
    }

    [Token(Token = "0x600A4EB")]
    [Address(RVA = "0x1906018", Offset = "0x1906018", VA = "0x1906018")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A4EC")]
    [Address(RVA = "0x19060A8", Offset = "0x19060A8", VA = "0x19060A8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A4ED")]
    [Address(RVA = "0x19060B4", Offset = "0x19060B4", VA = "0x19060B4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A4EE")]
    [Address(RVA = "0x1906188", Offset = "0x1906188", VA = "0x1906188")]
    private void OnSuccess(string json)
    {
    }
  }
}
