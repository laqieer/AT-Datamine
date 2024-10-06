// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001Detail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C81")]
  public class APIG0001Detail
  {
    [Token(Token = "0x40079F3")]
    public const string DefaultAPIPath = "api/gacha/G0001/detail";
    [Token(Token = "0x40079F7")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40079F8")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0001DetailResponse> onSuccess;
    [Token(Token = "0x40079F9")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FF2")]
    public APIG0001DetailRequest Request
    {
      [Token(Token = "0x600A7DC"), Address(RVA = "0x190FC94", Offset = "0x190FC94", VA = "0x190FC94")] private get
      {
        return (APIG0001DetailRequest) null;
      }
      [Token(Token = "0x600A7DD"), Address(RVA = "0x190FC9C", Offset = "0x190FC9C", VA = "0x190FC9C")] set
      {
      }
    }

    [Token(Token = "0x17001FF3")]
    public APIG0001DetailResponse Response
    {
      [Token(Token = "0x600A7DE"), Address(RVA = "0x190FCA4", Offset = "0x190FCA4", VA = "0x190FCA4")] get
      {
        return (APIG0001DetailResponse) null;
      }
      [Token(Token = "0x600A7DF"), Address(RVA = "0x190FCAC", Offset = "0x190FCAC", VA = "0x190FCAC")] private set
      {
      }
    }

    [Token(Token = "0x17001FF4")]
    public int ResponseCode
    {
      [Token(Token = "0x600A7E0"), Address(RVA = "0x190FCB4", Offset = "0x190FCB4", VA = "0x190FCB4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7E1"), Address(RVA = "0x190FCBC", Offset = "0x190FCBC", VA = "0x190FCBC")] private set
      {
      }
    }

    [Token(Token = "0x17001FF5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A7E2"), Address(RVA = "0x190FCC4", Offset = "0x190FCC4", VA = "0x190FCC4")] set
      {
      }
      [Token(Token = "0x600A7E3"), Address(RVA = "0x190FCE0", Offset = "0x190FCE0", VA = "0x190FCE0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A7E4")]
    [Address(RVA = "0x190FCFC", Offset = "0x190FCFC", VA = "0x190FCFC")]
    public APIG0001Detail(string apiPath = "api/gacha/G0001/detail")
    {
    }

    [Token(Token = "0x600A7E5")]
    [Address(RVA = "0x190FD94", Offset = "0x190FD94", VA = "0x190FD94")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A7E6")]
    [Address(RVA = "0x190FE24", Offset = "0x190FE24", VA = "0x190FE24")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A7E7")]
    [Address(RVA = "0x190FE30", Offset = "0x190FE30", VA = "0x190FE30")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A7E8")]
    [Address(RVA = "0x190FF04", Offset = "0x190FF04", VA = "0x190FF04")]
    private void OnSuccess(string json)
    {
    }
  }
}
