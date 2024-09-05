// Decompiled with JetBrains decompiler
// Type: Network.API.APILimitedEventQuestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D45")]
  public class APILimitedEventQuestBattleEnd
  {
    [Token(Token = "0x4007D05")]
    public const string DefaultAPIPath = "api/v1/battle/limitedeventquest/end";
    [Token(Token = "0x4007D09")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D0A")]
    [FieldOffset(Offset = "0x30")]
    public Action<APILimitedEventQuestBattleEndResponse> onSuccess;
    [Token(Token = "0x4007D0B")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021A0")]
    public APILimitedEventQuestBattleEndRequest Request
    {
      [Token(Token = "0x600AC9A"), Address(RVA = "0x1A46EF0", Offset = "0x1A46EF0", VA = "0x1A46EF0")] private get
      {
        return (APILimitedEventQuestBattleEndRequest) null;
      }
      [Token(Token = "0x600AC9B"), Address(RVA = "0x1A46EF8", Offset = "0x1A46EF8", VA = "0x1A46EF8")] set
      {
      }
    }

    [Token(Token = "0x170021A1")]
    public APILimitedEventQuestBattleEndResponse Response
    {
      [Token(Token = "0x600AC9C"), Address(RVA = "0x1A46F00", Offset = "0x1A46F00", VA = "0x1A46F00")] get
      {
        return (APILimitedEventQuestBattleEndResponse) null;
      }
      [Token(Token = "0x600AC9D"), Address(RVA = "0x1A46F08", Offset = "0x1A46F08", VA = "0x1A46F08")] private set
      {
      }
    }

    [Token(Token = "0x170021A2")]
    public int ResponseCode
    {
      [Token(Token = "0x600AC9E"), Address(RVA = "0x1A46F10", Offset = "0x1A46F10", VA = "0x1A46F10")] get
      {
        return new int();
      }
      [Token(Token = "0x600AC9F"), Address(RVA = "0x1A46F18", Offset = "0x1A46F18", VA = "0x1A46F18")] private set
      {
      }
    }

    [Token(Token = "0x170021A3")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ACA0"), Address(RVA = "0x1A46F20", Offset = "0x1A46F20", VA = "0x1A46F20")] set
      {
      }
      [Token(Token = "0x600ACA1"), Address(RVA = "0x1A46F3C", Offset = "0x1A46F3C", VA = "0x1A46F3C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ACA2")]
    [Address(RVA = "0x1A46F58", Offset = "0x1A46F58", VA = "0x1A46F58")]
    public APILimitedEventQuestBattleEnd(string apiPath = "api/v1/battle/limitedeventquest/end")
    {
    }

    [Token(Token = "0x600ACA3")]
    [Address(RVA = "0x1A46FF0", Offset = "0x1A46FF0", VA = "0x1A46FF0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ACA4")]
    [Address(RVA = "0x1A47080", Offset = "0x1A47080", VA = "0x1A47080")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ACA5")]
    [Address(RVA = "0x1A4708C", Offset = "0x1A4708C", VA = "0x1A4708C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ACA6")]
    [Address(RVA = "0x1A47160", Offset = "0x1A47160", VA = "0x1A47160")]
    private void OnSuccess(string json)
    {
    }
  }
}
