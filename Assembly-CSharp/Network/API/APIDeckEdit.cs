// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BF9")]
  public class APIDeckEdit
  {
    [Token(Token = "0x40077C3")]
    public const string DefaultAPIPath = "api/v1/deck/edit";
    [Token(Token = "0x40077C7")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40077C8")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDeckEditResponse> onSuccess;
    [Token(Token = "0x40077C9")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EA7")]
    public APIDeckEditRequest Request
    {
      [Token(Token = "0x600A471"), Address(RVA = "0x46D2470", Offset = "0x46D2470", VA = "0x46D2470")] private get
      {
        return (APIDeckEditRequest) null;
      }
      [Token(Token = "0x600A472"), Address(RVA = "0x46D2478", Offset = "0x46D2478", VA = "0x46D2478")] set
      {
      }
    }

    [Token(Token = "0x17001EA8")]
    public APIDeckEditResponse Response
    {
      [Token(Token = "0x600A473"), Address(RVA = "0x46D2480", Offset = "0x46D2480", VA = "0x46D2480")] get
      {
        return (APIDeckEditResponse) null;
      }
      [Token(Token = "0x600A474"), Address(RVA = "0x46D2488", Offset = "0x46D2488", VA = "0x46D2488")] private set
      {
      }
    }

    [Token(Token = "0x17001EA9")]
    public int ResponseCode
    {
      [Token(Token = "0x600A475"), Address(RVA = "0x46D2490", Offset = "0x46D2490", VA = "0x46D2490")] get
      {
        return new int();
      }
      [Token(Token = "0x600A476"), Address(RVA = "0x46D2498", Offset = "0x46D2498", VA = "0x46D2498")] private set
      {
      }
    }

    [Token(Token = "0x17001EAA")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A477"), Address(RVA = "0x46D24A0", Offset = "0x46D24A0", VA = "0x46D24A0")] set
      {
      }
      [Token(Token = "0x600A478"), Address(RVA = "0x46D24BC", Offset = "0x46D24BC", VA = "0x46D24BC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A479")]
    [Address(RVA = "0x46D24D8", Offset = "0x46D24D8", VA = "0x46D24D8")]
    public APIDeckEdit(string apiPath = "api/v1/deck/edit")
    {
    }

    [Token(Token = "0x600A47A")]
    [Address(RVA = "0x46D2570", Offset = "0x46D2570", VA = "0x46D2570")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A47B")]
    [Address(RVA = "0x46D2600", Offset = "0x46D2600", VA = "0x46D2600")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A47C")]
    [Address(RVA = "0x46D260C", Offset = "0x46D260C", VA = "0x46D260C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A47D")]
    [Address(RVA = "0x46D26E0", Offset = "0x46D26E0", VA = "0x46D26E0")]
    private void OnSuccess(string json)
    {
    }
  }
}
