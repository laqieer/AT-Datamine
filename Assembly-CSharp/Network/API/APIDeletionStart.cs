// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeletionStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C11")]
  public class APIDeletionStart
  {
    [Token(Token = "0x4007818")]
    public const string DefaultAPIPath = "das/pass/deletion/start";
    [Token(Token = "0x400781C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400781D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDeletionStartResponse> onSuccess;
    [Token(Token = "0x400781E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001ECF")]
    public APIDeletionStartRequest Request
    {
      [Token(Token = "0x600A4F9"), Address(RVA = "0x190646C", Offset = "0x190646C", VA = "0x190646C")] private get
      {
        return (APIDeletionStartRequest) null;
      }
      [Token(Token = "0x600A4FA"), Address(RVA = "0x1906474", Offset = "0x1906474", VA = "0x1906474")] set
      {
      }
    }

    [Token(Token = "0x17001ED0")]
    public APIDeletionStartResponse Response
    {
      [Token(Token = "0x600A4FB"), Address(RVA = "0x190647C", Offset = "0x190647C", VA = "0x190647C")] get
      {
        return (APIDeletionStartResponse) null;
      }
      [Token(Token = "0x600A4FC"), Address(RVA = "0x1906484", Offset = "0x1906484", VA = "0x1906484")] private set
      {
      }
    }

    [Token(Token = "0x17001ED1")]
    public int ResponseCode
    {
      [Token(Token = "0x600A4FD"), Address(RVA = "0x190648C", Offset = "0x190648C", VA = "0x190648C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A4FE"), Address(RVA = "0x1906494", Offset = "0x1906494", VA = "0x1906494")] private set
      {
      }
    }

    [Token(Token = "0x17001ED2")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A4FF"), Address(RVA = "0x190649C", Offset = "0x190649C", VA = "0x190649C")] set
      {
      }
      [Token(Token = "0x600A500"), Address(RVA = "0x19064B8", Offset = "0x19064B8", VA = "0x19064B8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A501")]
    [Address(RVA = "0x19064D4", Offset = "0x19064D4", VA = "0x19064D4")]
    public APIDeletionStart(string apiPath = "das/pass/deletion/start")
    {
    }

    [Token(Token = "0x600A502")]
    [Address(RVA = "0x190656C", Offset = "0x190656C", VA = "0x190656C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A503")]
    [Address(RVA = "0x19065FC", Offset = "0x19065FC", VA = "0x19065FC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A504")]
    [Address(RVA = "0x1906608", Offset = "0x1906608", VA = "0x1906608")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A505")]
    [Address(RVA = "0x19066DC", Offset = "0x19066DC", VA = "0x19066DC")]
    private void OnSuccess(string json)
    {
    }
  }
}
