// Decompiled with JetBrains decompiler
// Type: staq.AdStatusRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using System;
using System.Collections;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C11")]
  public class AdStatusRequestor
  {
    [Token(Token = "0x4010A20")]
    [FieldOffset(Offset = "0x20")]
    private bool _isApiError;
    [Token(Token = "0x4010A21")]
    [FieldOffset(Offset = "0x24")]
    private int _event_type_id;
    [Token(Token = "0x4010A22")]
    [FieldOffset(Offset = "0x28")]
    private int _target_id;

    [Token(Token = "0x60179C1")]
    [Address(RVA = "0x237F844", Offset = "0x237F844", VA = "0x237F844")]
    public AdStatusRequestor(int event_type_id, int target_id = 0)
    {
    }

    [Token(Token = "0x17004CB8")]
    public Action<APIAdvertisementIronsourceStatusResponse> OnSuccess
    {
      [Token(Token = "0x60179C2"), Address(RVA = "0x237F870", Offset = "0x237F870", VA = "0x237F870")] get
      {
        return (Action<APIAdvertisementIronsourceStatusResponse>) null;
      }
      [Token(Token = "0x60179C3"), Address(RVA = "0x237F878", Offset = "0x237F878", VA = "0x237F878")] set
      {
      }
    }

    [Token(Token = "0x17004CB9")]
    public Action<int> OnError
    {
      [Token(Token = "0x60179C4"), Address(RVA = "0x237F880", Offset = "0x237F880", VA = "0x237F880")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60179C5"), Address(RVA = "0x237F888", Offset = "0x237F888", VA = "0x237F888")] set
      {
      }
    }

    [Token(Token = "0x60179C6")]
    [Address(RVA = "0x237F890", Offset = "0x237F890", VA = "0x237F890")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x60179C7")]
    [Address(RVA = "0x237F920", Offset = "0x237F920", VA = "0x237F920")]
    private IEnumerator ApiError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;
  }
}
