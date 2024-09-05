// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeletionApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C09")]
  public class APIDeletionApply
  {
    [Token(Token = "0x40077FC")]
    public const string DefaultAPIPath = "das/pass/deletion/apply";
    [Token(Token = "0x4007800")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007801")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDeletionApplyResponse> onSuccess;
    [Token(Token = "0x4007802")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EC2")]
    public APIDeletionApplyRequest Request
    {
      [Token(Token = "0x600A4CC"), Address(RVA = "0x46D39B8", Offset = "0x46D39B8", VA = "0x46D39B8")] private get
      {
        return (APIDeletionApplyRequest) null;
      }
      [Token(Token = "0x600A4CD"), Address(RVA = "0x46D39C0", Offset = "0x46D39C0", VA = "0x46D39C0")] set
      {
      }
    }

    [Token(Token = "0x17001EC3")]
    public APIDeletionApplyResponse Response
    {
      [Token(Token = "0x600A4CE"), Address(RVA = "0x46D39C8", Offset = "0x46D39C8", VA = "0x46D39C8")] get
      {
        return (APIDeletionApplyResponse) null;
      }
      [Token(Token = "0x600A4CF"), Address(RVA = "0x46D39D0", Offset = "0x46D39D0", VA = "0x46D39D0")] private set
      {
      }
    }

    [Token(Token = "0x17001EC4")]
    public int ResponseCode
    {
      [Token(Token = "0x600A4D0"), Address(RVA = "0x46D39D8", Offset = "0x46D39D8", VA = "0x46D39D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A4D1"), Address(RVA = "0x46D39E0", Offset = "0x46D39E0", VA = "0x46D39E0")] private set
      {
      }
    }

    [Token(Token = "0x17001EC5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A4D2"), Address(RVA = "0x46D39E8", Offset = "0x46D39E8", VA = "0x46D39E8")] set
      {
      }
      [Token(Token = "0x600A4D3"), Address(RVA = "0x46D3A04", Offset = "0x46D3A04", VA = "0x46D3A04")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A4D4")]
    [Address(RVA = "0x46D3A20", Offset = "0x46D3A20", VA = "0x46D3A20")]
    public APIDeletionApply(string apiPath = "das/pass/deletion/apply")
    {
    }

    [Token(Token = "0x600A4D5")]
    [Address(RVA = "0x46D3AB8", Offset = "0x46D3AB8", VA = "0x46D3AB8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A4D6")]
    [Address(RVA = "0x46D3B20", Offset = "0x46D3B20", VA = "0x46D3B20")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A4D7")]
    [Address(RVA = "0x46D3B2C", Offset = "0x46D3B2C", VA = "0x46D3B2C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A4D8")]
    [Address(RVA = "0x46D3C00", Offset = "0x46D3C00", VA = "0x46D3C00")]
    private void OnSuccess(string json)
    {
    }
  }
}
