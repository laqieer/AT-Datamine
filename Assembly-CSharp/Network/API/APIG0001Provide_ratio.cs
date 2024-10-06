// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001Provide_ratio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C8D")]
  public class APIG0001Provide_ratio
  {
    [Token(Token = "0x4007A20")]
    public const string DefaultAPIPath = "api/gacha/G0001/provide_ratio";
    [Token(Token = "0x4007A24")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A25")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0001Provide_ratioResponse> onSuccess;
    [Token(Token = "0x4007A26")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700200C")]
    public APIG0001Provide_ratioRequest Request
    {
      [Token(Token = "0x600A826"), Address(RVA = "0x1910CB8", Offset = "0x1910CB8", VA = "0x1910CB8")] private get
      {
        return (APIG0001Provide_ratioRequest) null;
      }
      [Token(Token = "0x600A827"), Address(RVA = "0x1910CC0", Offset = "0x1910CC0", VA = "0x1910CC0")] set
      {
      }
    }

    [Token(Token = "0x1700200D")]
    public APIG0001Provide_ratioResponse Response
    {
      [Token(Token = "0x600A828"), Address(RVA = "0x1910CC8", Offset = "0x1910CC8", VA = "0x1910CC8")] get
      {
        return (APIG0001Provide_ratioResponse) null;
      }
      [Token(Token = "0x600A829"), Address(RVA = "0x1910CD0", Offset = "0x1910CD0", VA = "0x1910CD0")] private set
      {
      }
    }

    [Token(Token = "0x1700200E")]
    public int ResponseCode
    {
      [Token(Token = "0x600A82A"), Address(RVA = "0x1910CD8", Offset = "0x1910CD8", VA = "0x1910CD8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A82B"), Address(RVA = "0x1910CE0", Offset = "0x1910CE0", VA = "0x1910CE0")] private set
      {
      }
    }

    [Token(Token = "0x1700200F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A82C"), Address(RVA = "0x1910CE8", Offset = "0x1910CE8", VA = "0x1910CE8")] set
      {
      }
      [Token(Token = "0x600A82D"), Address(RVA = "0x1910D04", Offset = "0x1910D04", VA = "0x1910D04")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A82E")]
    [Address(RVA = "0x1910D20", Offset = "0x1910D20", VA = "0x1910D20")]
    public APIG0001Provide_ratio(string apiPath = "api/gacha/G0001/provide_ratio")
    {
    }

    [Token(Token = "0x600A82F")]
    [Address(RVA = "0x1910DB8", Offset = "0x1910DB8", VA = "0x1910DB8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A830")]
    [Address(RVA = "0x1910E48", Offset = "0x1910E48", VA = "0x1910E48")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A831")]
    [Address(RVA = "0x1910E54", Offset = "0x1910E54", VA = "0x1910E54")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A832")]
    [Address(RVA = "0x1910F28", Offset = "0x1910F28", VA = "0x1910F28")]
    private void OnSuccess(string json)
    {
    }
  }
}
