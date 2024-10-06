// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentLimit_break
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D61")]
  public class APIMind_equipmentLimit_break
  {
    [Token(Token = "0x4007D7D")]
    public const string DefaultAPIPath = "api/v1/mind_equipment/limit_break";
    [Token(Token = "0x4007D81")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D82")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMind_equipmentLimit_breakResponse> onSuccess;
    [Token(Token = "0x4007D83")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021E5")]
    public APIMind_equipmentLimit_breakRequest Request
    {
      [Token(Token = "0x600AD4F"), Address(RVA = "0x1A494CC", Offset = "0x1A494CC", VA = "0x1A494CC")] private get
      {
        return (APIMind_equipmentLimit_breakRequest) null;
      }
      [Token(Token = "0x600AD50"), Address(RVA = "0x1A494D4", Offset = "0x1A494D4", VA = "0x1A494D4")] set
      {
      }
    }

    [Token(Token = "0x170021E6")]
    public APIMind_equipmentLimit_breakResponse Response
    {
      [Token(Token = "0x600AD51"), Address(RVA = "0x1A494DC", Offset = "0x1A494DC", VA = "0x1A494DC")] get
      {
        return (APIMind_equipmentLimit_breakResponse) null;
      }
      [Token(Token = "0x600AD52"), Address(RVA = "0x1A494E4", Offset = "0x1A494E4", VA = "0x1A494E4")] private set
      {
      }
    }

    [Token(Token = "0x170021E7")]
    public int ResponseCode
    {
      [Token(Token = "0x600AD53"), Address(RVA = "0x1A494EC", Offset = "0x1A494EC", VA = "0x1A494EC")] get
      {
        return new int();
      }
      [Token(Token = "0x600AD54"), Address(RVA = "0x1A494F4", Offset = "0x1A494F4", VA = "0x1A494F4")] private set
      {
      }
    }

    [Token(Token = "0x170021E8")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AD55"), Address(RVA = "0x1A494FC", Offset = "0x1A494FC", VA = "0x1A494FC")] set
      {
      }
      [Token(Token = "0x600AD56"), Address(RVA = "0x1A49518", Offset = "0x1A49518", VA = "0x1A49518")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AD57")]
    [Address(RVA = "0x1A49534", Offset = "0x1A49534", VA = "0x1A49534")]
    public APIMind_equipmentLimit_break(string apiPath = "api/v1/mind_equipment/limit_break")
    {
    }

    [Token(Token = "0x600AD58")]
    [Address(RVA = "0x1A495CC", Offset = "0x1A495CC", VA = "0x1A495CC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AD59")]
    [Address(RVA = "0x1A4965C", Offset = "0x1A4965C", VA = "0x1A4965C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AD5A")]
    [Address(RVA = "0x1A49668", Offset = "0x1A49668", VA = "0x1A49668")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AD5B")]
    [Address(RVA = "0x1A4973C", Offset = "0x1A4973C", VA = "0x1A4973C")]
    private void OnSuccess(string json)
    {
    }
  }
}
