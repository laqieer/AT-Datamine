// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B7D")]
  public class APIAreaQuestDirection
  {
    [Token(Token = "0x40075E0")]
    public const string DefaultAPIPath = "api/v1/area_quest/direction";
    [Token(Token = "0x40075E4")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40075E5")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAreaQuestDirectionResponse> onSuccess;
    [Token(Token = "0x40075E6")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D98")]
    public APIAreaQuestDirectionRequest Request
    {
      [Token(Token = "0x600A172"), Address(RVA = "0x46C7D94", Offset = "0x46C7D94", VA = "0x46C7D94")] private get
      {
        return (APIAreaQuestDirectionRequest) null;
      }
      [Token(Token = "0x600A173"), Address(RVA = "0x46C7D9C", Offset = "0x46C7D9C", VA = "0x46C7D9C")] set
      {
      }
    }

    [Token(Token = "0x17001D99")]
    public APIAreaQuestDirectionResponse Response
    {
      [Token(Token = "0x600A174"), Address(RVA = "0x46C7DA4", Offset = "0x46C7DA4", VA = "0x46C7DA4")] get
      {
        return (APIAreaQuestDirectionResponse) null;
      }
      [Token(Token = "0x600A175"), Address(RVA = "0x46C7DAC", Offset = "0x46C7DAC", VA = "0x46C7DAC")] private set
      {
      }
    }

    [Token(Token = "0x17001D9A")]
    public int ResponseCode
    {
      [Token(Token = "0x600A176"), Address(RVA = "0x46C7DB4", Offset = "0x46C7DB4", VA = "0x46C7DB4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A177"), Address(RVA = "0x46C7DBC", Offset = "0x46C7DBC", VA = "0x46C7DBC")] private set
      {
      }
    }

    [Token(Token = "0x17001D9B")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A178"), Address(RVA = "0x46C7DC4", Offset = "0x46C7DC4", VA = "0x46C7DC4")] set
      {
      }
      [Token(Token = "0x600A179"), Address(RVA = "0x46C7DE0", Offset = "0x46C7DE0", VA = "0x46C7DE0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A17A")]
    [Address(RVA = "0x46C7DFC", Offset = "0x46C7DFC", VA = "0x46C7DFC")]
    public APIAreaQuestDirection(string apiPath = "api/v1/area_quest/direction")
    {
    }

    [Token(Token = "0x600A17B")]
    [Address(RVA = "0x46C7E94", Offset = "0x46C7E94", VA = "0x46C7E94")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A17C")]
    [Address(RVA = "0x46C7F24", Offset = "0x46C7F24", VA = "0x46C7F24")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A17D")]
    [Address(RVA = "0x46C7F30", Offset = "0x46C7F30", VA = "0x46C7F30")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A17E")]
    [Address(RVA = "0x46C8004", Offset = "0x46C8004", VA = "0x46C8004")]
    private void OnSuccess(string json)
    {
    }
  }
}
