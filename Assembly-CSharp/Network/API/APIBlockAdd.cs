// Decompiled with JetBrains decompiler
// Type: Network.API.APIBlockAdd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BB5")]
  public class APIBlockAdd
  {
    [Token(Token = "0x40076C4")]
    public const string DefaultAPIPath = "api/v1/block/add";
    [Token(Token = "0x40076C8")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40076C9")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIBlockAddResponse> onSuccess;
    [Token(Token = "0x40076CA")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E19")]
    public APIBlockAddRequest Request
    {
      [Token(Token = "0x600A2D3"), Address(RVA = "0x46CC924", Offset = "0x46CC924", VA = "0x46CC924")] private get
      {
        return (APIBlockAddRequest) null;
      }
      [Token(Token = "0x600A2D4"), Address(RVA = "0x46CC92C", Offset = "0x46CC92C", VA = "0x46CC92C")] set
      {
      }
    }

    [Token(Token = "0x17001E1A")]
    public APIBlockAddResponse Response
    {
      [Token(Token = "0x600A2D5"), Address(RVA = "0x46CC934", Offset = "0x46CC934", VA = "0x46CC934")] get
      {
        return (APIBlockAddResponse) null;
      }
      [Token(Token = "0x600A2D6"), Address(RVA = "0x46CC93C", Offset = "0x46CC93C", VA = "0x46CC93C")] private set
      {
      }
    }

    [Token(Token = "0x17001E1B")]
    public int ResponseCode
    {
      [Token(Token = "0x600A2D7"), Address(RVA = "0x46CC944", Offset = "0x46CC944", VA = "0x46CC944")] get
      {
        return new int();
      }
      [Token(Token = "0x600A2D8"), Address(RVA = "0x46CC94C", Offset = "0x46CC94C", VA = "0x46CC94C")] private set
      {
      }
    }

    [Token(Token = "0x17001E1C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A2D9"), Address(RVA = "0x46CC954", Offset = "0x46CC954", VA = "0x46CC954")] set
      {
      }
      [Token(Token = "0x600A2DA"), Address(RVA = "0x46CC970", Offset = "0x46CC970", VA = "0x46CC970")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A2DB")]
    [Address(RVA = "0x46CC98C", Offset = "0x46CC98C", VA = "0x46CC98C")]
    public APIBlockAdd(string apiPath = "api/v1/block/add")
    {
    }

    [Token(Token = "0x600A2DC")]
    [Address(RVA = "0x46CCA24", Offset = "0x46CCA24", VA = "0x46CCA24")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A2DD")]
    [Address(RVA = "0x46CCAB4", Offset = "0x46CCAB4", VA = "0x46CCAB4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A2DE")]
    [Address(RVA = "0x46CCAC0", Offset = "0x46CCAC0", VA = "0x46CCAC0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A2DF")]
    [Address(RVA = "0x46CCB94", Offset = "0x46CCB94", VA = "0x46CCB94")]
    private void OnSuccess(string json)
    {
    }
  }
}
