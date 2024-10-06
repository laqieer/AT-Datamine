// Decompiled with JetBrains decompiler
// Type: staq.AdUpdateStatusRequestor
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
  [Token(Token = "0x2003C14")]
  public class AdUpdateStatusRequestor
  {
    [Token(Token = "0x4010A2C")]
    [FieldOffset(Offset = "0x20")]
    private bool _isApiError;
    [Token(Token = "0x4010A2D")]
    [FieldOffset(Offset = "0x24")]
    private int _status;
    [Token(Token = "0x4010A2E")]
    [FieldOffset(Offset = "0x28")]
    private string _advertisementId;
    [Token(Token = "0x4010A2F")]
    [FieldOffset(Offset = "0x30")]
    private int _event_type_id;
    [Token(Token = "0x4010A30")]
    [FieldOffset(Offset = "0x34")]
    private int _target_id;

    [Token(Token = "0x60179D4")]
    [Address(RVA = "0x237FC2C", Offset = "0x237FC2C", VA = "0x237FC2C")]
    public AdUpdateStatusRequestor(
      int status,
      string advertisementId,
      int event_type_id,
      int target_id = 0)
    {
    }

    [Token(Token = "0x17004CBE")]
    public Action<APIAdvertisementIronsourceUpdate_statusResponse> OnSuccess
    {
      [Token(Token = "0x60179D5"), Address(RVA = "0x237FC70", Offset = "0x237FC70", VA = "0x237FC70")] get
      {
        return (Action<APIAdvertisementIronsourceUpdate_statusResponse>) null;
      }
      [Token(Token = "0x60179D6"), Address(RVA = "0x237FC78", Offset = "0x237FC78", VA = "0x237FC78")] set
      {
      }
    }

    [Token(Token = "0x17004CBF")]
    public Action<int> OnError
    {
      [Token(Token = "0x60179D7"), Address(RVA = "0x237FC80", Offset = "0x237FC80", VA = "0x237FC80")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60179D8"), Address(RVA = "0x237FC88", Offset = "0x237FC88", VA = "0x237FC88")] set
      {
      }
    }

    [Token(Token = "0x60179D9")]
    [Address(RVA = "0x237FC90", Offset = "0x237FC90", VA = "0x237FC90")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x60179DA")]
    [Address(RVA = "0x237FD20", Offset = "0x237FD20", VA = "0x237FD20")]
    private IEnumerator ApiError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;
  }
}
