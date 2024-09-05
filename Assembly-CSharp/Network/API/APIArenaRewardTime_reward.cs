// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaRewardTime_reward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B9D")]
  public class APIArenaRewardTime_reward
  {
    [Token(Token = "0x4007665")]
    public const string DefaultAPIPath = "api/v1/arena/reward/time_reward";
    [Token(Token = "0x4007669")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400766A")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIArenaRewardTime_rewardResponse> onSuccess;
    [Token(Token = "0x400766B")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DE8")]
    public APIArenaRewardTime_rewardRequest Request
    {
      [Token(Token = "0x600A242"), Address(RVA = "0x46CA8F4", Offset = "0x46CA8F4", VA = "0x46CA8F4")] private get
      {
        return (APIArenaRewardTime_rewardRequest) null;
      }
      [Token(Token = "0x600A243"), Address(RVA = "0x46CA8FC", Offset = "0x46CA8FC", VA = "0x46CA8FC")] set
      {
      }
    }

    [Token(Token = "0x17001DE9")]
    public APIArenaRewardTime_rewardResponse Response
    {
      [Token(Token = "0x600A244"), Address(RVA = "0x46CA904", Offset = "0x46CA904", VA = "0x46CA904")] get
      {
        return (APIArenaRewardTime_rewardResponse) null;
      }
      [Token(Token = "0x600A245"), Address(RVA = "0x46CA90C", Offset = "0x46CA90C", VA = "0x46CA90C")] private set
      {
      }
    }

    [Token(Token = "0x17001DEA")]
    public int ResponseCode
    {
      [Token(Token = "0x600A246"), Address(RVA = "0x46CA914", Offset = "0x46CA914", VA = "0x46CA914")] get
      {
        return new int();
      }
      [Token(Token = "0x600A247"), Address(RVA = "0x46CA91C", Offset = "0x46CA91C", VA = "0x46CA91C")] private set
      {
      }
    }

    [Token(Token = "0x17001DEB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A248"), Address(RVA = "0x46CA924", Offset = "0x46CA924", VA = "0x46CA924")] set
      {
      }
      [Token(Token = "0x600A249"), Address(RVA = "0x46CA940", Offset = "0x46CA940", VA = "0x46CA940")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A24A")]
    [Address(RVA = "0x46CA95C", Offset = "0x46CA95C", VA = "0x46CA95C")]
    public APIArenaRewardTime_reward(string apiPath = "api/v1/arena/reward/time_reward")
    {
    }

    [Token(Token = "0x600A24B")]
    [Address(RVA = "0x46CA9F4", Offset = "0x46CA9F4", VA = "0x46CA9F4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A24C")]
    [Address(RVA = "0x46CAA84", Offset = "0x46CAA84", VA = "0x46CAA84")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A24D")]
    [Address(RVA = "0x46CAA90", Offset = "0x46CAA90", VA = "0x46CAA90")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A24E")]
    [Address(RVA = "0x46CAB64", Offset = "0x46CAB64", VA = "0x46CAB64")]
    private void OnSuccess(string json)
    {
    }
  }
}
