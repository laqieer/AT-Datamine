// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B71")]
  public class APIAreaQuestBattleEnd
  {
    [Token(Token = "0x40075A3")]
    public const string DefaultAPIPath = "api/v1/area_quest/battle/end";
    [Token(Token = "0x40075A7")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40075A8")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAreaQuestBattleEndResponse> onSuccess;
    [Token(Token = "0x40075A9")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D7A")]
    public APIAreaQuestBattleEndRequest Request
    {
      [Token(Token = "0x600A124"), Address(RVA = "0x46C6D50", Offset = "0x46C6D50", VA = "0x46C6D50")] private get
      {
        return (APIAreaQuestBattleEndRequest) null;
      }
      [Token(Token = "0x600A125"), Address(RVA = "0x46C6D58", Offset = "0x46C6D58", VA = "0x46C6D58")] set
      {
      }
    }

    [Token(Token = "0x17001D7B")]
    public APIAreaQuestBattleEndResponse Response
    {
      [Token(Token = "0x600A126"), Address(RVA = "0x46C6D60", Offset = "0x46C6D60", VA = "0x46C6D60")] get
      {
        return (APIAreaQuestBattleEndResponse) null;
      }
      [Token(Token = "0x600A127"), Address(RVA = "0x46C6D68", Offset = "0x46C6D68", VA = "0x46C6D68")] private set
      {
      }
    }

    [Token(Token = "0x17001D7C")]
    public int ResponseCode
    {
      [Token(Token = "0x600A128"), Address(RVA = "0x46C6D70", Offset = "0x46C6D70", VA = "0x46C6D70")] get
      {
        return new int();
      }
      [Token(Token = "0x600A129"), Address(RVA = "0x46C6D78", Offset = "0x46C6D78", VA = "0x46C6D78")] private set
      {
      }
    }

    [Token(Token = "0x17001D7D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A12A"), Address(RVA = "0x46C6D80", Offset = "0x46C6D80", VA = "0x46C6D80")] set
      {
      }
      [Token(Token = "0x600A12B"), Address(RVA = "0x46C6D9C", Offset = "0x46C6D9C", VA = "0x46C6D9C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A12C")]
    [Address(RVA = "0x46C6DB8", Offset = "0x46C6DB8", VA = "0x46C6DB8")]
    public APIAreaQuestBattleEnd(string apiPath = "api/v1/area_quest/battle/end")
    {
    }

    [Token(Token = "0x600A12D")]
    [Address(RVA = "0x46C6E50", Offset = "0x46C6E50", VA = "0x46C6E50")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A12E")]
    [Address(RVA = "0x46C6EE0", Offset = "0x46C6EE0", VA = "0x46C6EE0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A12F")]
    [Address(RVA = "0x46C6EEC", Offset = "0x46C6EEC", VA = "0x46C6EEC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A130")]
    [Address(RVA = "0x46C6FC0", Offset = "0x46C6FC0", VA = "0x46C6FC0")]
    private void OnSuccess(string json)
    {
    }
  }
}
