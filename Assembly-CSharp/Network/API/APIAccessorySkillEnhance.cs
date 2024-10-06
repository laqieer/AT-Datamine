// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessorySkillEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B4D")]
  public class APIAccessorySkillEnhance
  {
    [Token(Token = "0x4007514")]
    public const string DefaultAPIPath = "api/v1/accessory/skill_enhance";
    [Token(Token = "0x4007518")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007519")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAccessorySkillEnhanceResponse> onSuccess;
    [Token(Token = "0x400751A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D30")]
    public APIAccessorySkillEnhanceRequest Request
    {
      [Token(Token = "0x600A04A"), Address(RVA = "0x46C3D04", Offset = "0x46C3D04", VA = "0x46C3D04")] private get
      {
        return (APIAccessorySkillEnhanceRequest) null;
      }
      [Token(Token = "0x600A04B"), Address(RVA = "0x46C3D0C", Offset = "0x46C3D0C", VA = "0x46C3D0C")] set
      {
      }
    }

    [Token(Token = "0x17001D31")]
    public APIAccessorySkillEnhanceResponse Response
    {
      [Token(Token = "0x600A04C"), Address(RVA = "0x46C3D14", Offset = "0x46C3D14", VA = "0x46C3D14")] get
      {
        return (APIAccessorySkillEnhanceResponse) null;
      }
      [Token(Token = "0x600A04D"), Address(RVA = "0x46C3D1C", Offset = "0x46C3D1C", VA = "0x46C3D1C")] private set
      {
      }
    }

    [Token(Token = "0x17001D32")]
    public int ResponseCode
    {
      [Token(Token = "0x600A04E"), Address(RVA = "0x46C3D24", Offset = "0x46C3D24", VA = "0x46C3D24")] get
      {
        return new int();
      }
      [Token(Token = "0x600A04F"), Address(RVA = "0x46C3D2C", Offset = "0x46C3D2C", VA = "0x46C3D2C")] private set
      {
      }
    }

    [Token(Token = "0x17001D33")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A050"), Address(RVA = "0x46C3D34", Offset = "0x46C3D34", VA = "0x46C3D34")] set
      {
      }
      [Token(Token = "0x600A051"), Address(RVA = "0x46C3D50", Offset = "0x46C3D50", VA = "0x46C3D50")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A052")]
    [Address(RVA = "0x46C3D6C", Offset = "0x46C3D6C", VA = "0x46C3D6C")]
    public APIAccessorySkillEnhance(string apiPath = "api/v1/accessory/skill_enhance")
    {
    }

    [Token(Token = "0x600A053")]
    [Address(RVA = "0x46C3E04", Offset = "0x46C3E04", VA = "0x46C3E04")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A054")]
    [Address(RVA = "0x46C3E94", Offset = "0x46C3E94", VA = "0x46C3E94")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A055")]
    [Address(RVA = "0x46C3EA0", Offset = "0x46C3EA0", VA = "0x46C3EA0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A056")]
    [Address(RVA = "0x46C3F74", Offset = "0x46C3F74", VA = "0x46C3F74")]
    private void OnSuccess(string json)
    {
    }
  }
}
