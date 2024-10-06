// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustomaLottery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E8D")]
  public class APIUnitAbilityboardCustomaLottery
  {
    [Token(Token = "0x4008348")]
    public const string DefaultAPIPath = "api/v1/unit/abilityboard/customa/lottery";
    [Token(Token = "0x400834C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400834D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitAbilityboardCustomaLotteryResponse> onSuccess;
    [Token(Token = "0x400834E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700253B")]
    public APIUnitAbilityboardCustomaLotteryRequest Request
    {
      [Token(Token = "0x600B555"), Address(RVA = "0x22E8CE4", Offset = "0x22E8CE4", VA = "0x22E8CE4")] private get
      {
        return (APIUnitAbilityboardCustomaLotteryRequest) null;
      }
      [Token(Token = "0x600B556"), Address(RVA = "0x22E8CEC", Offset = "0x22E8CEC", VA = "0x22E8CEC")] set
      {
      }
    }

    [Token(Token = "0x1700253C")]
    public APIUnitAbilityboardCustomaLotteryResponse Response
    {
      [Token(Token = "0x600B557"), Address(RVA = "0x22E8CF4", Offset = "0x22E8CF4", VA = "0x22E8CF4")] get
      {
        return (APIUnitAbilityboardCustomaLotteryResponse) null;
      }
      [Token(Token = "0x600B558"), Address(RVA = "0x22E8CFC", Offset = "0x22E8CFC", VA = "0x22E8CFC")] private set
      {
      }
    }

    [Token(Token = "0x1700253D")]
    public int ResponseCode
    {
      [Token(Token = "0x600B559"), Address(RVA = "0x22E8D04", Offset = "0x22E8D04", VA = "0x22E8D04")] get
      {
        return new int();
      }
      [Token(Token = "0x600B55A"), Address(RVA = "0x22E8D0C", Offset = "0x22E8D0C", VA = "0x22E8D0C")] private set
      {
      }
    }

    [Token(Token = "0x1700253E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B55B"), Address(RVA = "0x22E8D14", Offset = "0x22E8D14", VA = "0x22E8D14")] set
      {
      }
      [Token(Token = "0x600B55C"), Address(RVA = "0x22E8D30", Offset = "0x22E8D30", VA = "0x22E8D30")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B55D")]
    [Address(RVA = "0x22E8D4C", Offset = "0x22E8D4C", VA = "0x22E8D4C")]
    public APIUnitAbilityboardCustomaLottery(string apiPath = "api/v1/unit/abilityboard/customa/lottery")
    {
    }

    [Token(Token = "0x600B55E")]
    [Address(RVA = "0x22E8DE4", Offset = "0x22E8DE4", VA = "0x22E8DE4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B55F")]
    [Address(RVA = "0x22E8E74", Offset = "0x22E8E74", VA = "0x22E8E74")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B560")]
    [Address(RVA = "0x22E8E80", Offset = "0x22E8E80", VA = "0x22E8E80")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B561")]
    [Address(RVA = "0x22E8F54", Offset = "0x22E8F54", VA = "0x22E8F54")]
    private void OnSuccess(string json)
    {
    }
  }
}
