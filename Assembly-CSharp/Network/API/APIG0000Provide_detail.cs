// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0000Provide_detail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C79")]
  public class APIG0000Provide_detail
  {
    [Token(Token = "0x40079DA")]
    public const string DefaultAPIPath = "api/gacha/G0000/provide_detail";
    [Token(Token = "0x40079DE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40079DF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0000Provide_detailResponse> onSuccess;
    [Token(Token = "0x40079E0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FE4")]
    public APIG0000Provide_detailRequest Request
    {
      [Token(Token = "0x600A7AE"), Address(RVA = "0x190F1EC", Offset = "0x190F1EC", VA = "0x190F1EC")] private get
      {
        return (APIG0000Provide_detailRequest) null;
      }
      [Token(Token = "0x600A7AF"), Address(RVA = "0x190F1F4", Offset = "0x190F1F4", VA = "0x190F1F4")] set
      {
      }
    }

    [Token(Token = "0x17001FE5")]
    public APIG0000Provide_detailResponse Response
    {
      [Token(Token = "0x600A7B0"), Address(RVA = "0x190F1FC", Offset = "0x190F1FC", VA = "0x190F1FC")] get
      {
        return (APIG0000Provide_detailResponse) null;
      }
      [Token(Token = "0x600A7B1"), Address(RVA = "0x190F204", Offset = "0x190F204", VA = "0x190F204")] private set
      {
      }
    }

    [Token(Token = "0x17001FE6")]
    public int ResponseCode
    {
      [Token(Token = "0x600A7B2"), Address(RVA = "0x190F20C", Offset = "0x190F20C", VA = "0x190F20C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7B3"), Address(RVA = "0x190F214", Offset = "0x190F214", VA = "0x190F214")] private set
      {
      }
    }

    [Token(Token = "0x17001FE7")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A7B4"), Address(RVA = "0x190F21C", Offset = "0x190F21C", VA = "0x190F21C")] set
      {
      }
      [Token(Token = "0x600A7B5"), Address(RVA = "0x190F238", Offset = "0x190F238", VA = "0x190F238")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A7B6")]
    [Address(RVA = "0x190F254", Offset = "0x190F254", VA = "0x190F254")]
    public APIG0000Provide_detail(string apiPath = "api/gacha/G0000/provide_detail")
    {
    }

    [Token(Token = "0x600A7B7")]
    [Address(RVA = "0x190F2EC", Offset = "0x190F2EC", VA = "0x190F2EC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A7B8")]
    [Address(RVA = "0x190F37C", Offset = "0x190F37C", VA = "0x190F37C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A7B9")]
    [Address(RVA = "0x190F388", Offset = "0x190F388", VA = "0x190F388")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A7BA")]
    [Address(RVA = "0x190F45C", Offset = "0x190F45C", VA = "0x190F45C")]
    private void OnSuccess(string json)
    {
    }
  }
}
