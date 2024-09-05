// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionAccept_progress_rewards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D6D")]
  public class APIMissionAccept_progress_rewards
  {
    [Token(Token = "0x4007DBB")]
    public const string DefaultAPIPath = "api/v1/mission/accept_progress_rewards";
    [Token(Token = "0x4007DBF")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007DC0")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMissionAccept_progress_rewardsResponse> onSuccess;
    [Token(Token = "0x4007DC1")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002210")]
    public APIMissionAccept_progress_rewardsRequest Request
    {
      [Token(Token = "0x600ADAA"), Address(RVA = "0x1A4A578", Offset = "0x1A4A578", VA = "0x1A4A578")] private get
      {
        return (APIMissionAccept_progress_rewardsRequest) null;
      }
      [Token(Token = "0x600ADAB"), Address(RVA = "0x1A4A580", Offset = "0x1A4A580", VA = "0x1A4A580")] set
      {
      }
    }

    [Token(Token = "0x17002211")]
    public APIMissionAccept_progress_rewardsResponse Response
    {
      [Token(Token = "0x600ADAC"), Address(RVA = "0x1A4A588", Offset = "0x1A4A588", VA = "0x1A4A588")] get
      {
        return (APIMissionAccept_progress_rewardsResponse) null;
      }
      [Token(Token = "0x600ADAD"), Address(RVA = "0x1A4A590", Offset = "0x1A4A590", VA = "0x1A4A590")] private set
      {
      }
    }

    [Token(Token = "0x17002212")]
    public int ResponseCode
    {
      [Token(Token = "0x600ADAE"), Address(RVA = "0x1A4A598", Offset = "0x1A4A598", VA = "0x1A4A598")] get
      {
        return new int();
      }
      [Token(Token = "0x600ADAF"), Address(RVA = "0x1A4A5A0", Offset = "0x1A4A5A0", VA = "0x1A4A5A0")] private set
      {
      }
    }

    [Token(Token = "0x17002213")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ADB0"), Address(RVA = "0x1A4A5A8", Offset = "0x1A4A5A8", VA = "0x1A4A5A8")] set
      {
      }
      [Token(Token = "0x600ADB1"), Address(RVA = "0x1A4A5C4", Offset = "0x1A4A5C4", VA = "0x1A4A5C4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ADB2")]
    [Address(RVA = "0x1A4A5E0", Offset = "0x1A4A5E0", VA = "0x1A4A5E0")]
    public APIMissionAccept_progress_rewards(string apiPath = "api/v1/mission/accept_progress_rewards")
    {
    }

    [Token(Token = "0x600ADB3")]
    [Address(RVA = "0x1A4A678", Offset = "0x1A4A678", VA = "0x1A4A678")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ADB4")]
    [Address(RVA = "0x1A4A708", Offset = "0x1A4A708", VA = "0x1A4A708")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ADB5")]
    [Address(RVA = "0x1A4A714", Offset = "0x1A4A714", VA = "0x1A4A714")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ADB6")]
    [Address(RVA = "0x1A4A7E8", Offset = "0x1A4A7E8", VA = "0x1A4A7E8")]
    private void OnSuccess(string json)
    {
    }
  }
}
