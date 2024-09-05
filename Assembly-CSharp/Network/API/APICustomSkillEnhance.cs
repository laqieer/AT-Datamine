// Decompiled with JetBrains decompiler
// Type: Network.API.APICustomSkillEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BE9")]
  public class APICustomSkillEnhance
  {
    [Token(Token = "0x4007784")]
    public const string DefaultAPIPath = "api/v1/unit/custom_skill/skill_enhance";
    [Token(Token = "0x4007788")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007789")]
    [FieldOffset(Offset = "0x30")]
    public Action<APICustomSkillEnhanceResponse> onSuccess;
    [Token(Token = "0x400778A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E82")]
    public APICustomSkillEnhanceRequest Request
    {
      [Token(Token = "0x600A40C"), Address(RVA = "0x46D0ED8", Offset = "0x46D0ED8", VA = "0x46D0ED8")] private get
      {
        return (APICustomSkillEnhanceRequest) null;
      }
      [Token(Token = "0x600A40D"), Address(RVA = "0x46D0EE0", Offset = "0x46D0EE0", VA = "0x46D0EE0")] set
      {
      }
    }

    [Token(Token = "0x17001E83")]
    public APICustomSkillEnhanceResponse Response
    {
      [Token(Token = "0x600A40E"), Address(RVA = "0x46D0EE8", Offset = "0x46D0EE8", VA = "0x46D0EE8")] get
      {
        return (APICustomSkillEnhanceResponse) null;
      }
      [Token(Token = "0x600A40F"), Address(RVA = "0x46D0EF0", Offset = "0x46D0EF0", VA = "0x46D0EF0")] private set
      {
      }
    }

    [Token(Token = "0x17001E84")]
    public int ResponseCode
    {
      [Token(Token = "0x600A410"), Address(RVA = "0x46D0EF8", Offset = "0x46D0EF8", VA = "0x46D0EF8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A411"), Address(RVA = "0x46D0F00", Offset = "0x46D0F00", VA = "0x46D0F00")] private set
      {
      }
    }

    [Token(Token = "0x17001E85")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A412"), Address(RVA = "0x46D0F08", Offset = "0x46D0F08", VA = "0x46D0F08")] set
      {
      }
      [Token(Token = "0x600A413"), Address(RVA = "0x46D0F24", Offset = "0x46D0F24", VA = "0x46D0F24")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A414")]
    [Address(RVA = "0x46D0F40", Offset = "0x46D0F40", VA = "0x46D0F40")]
    public APICustomSkillEnhance(string apiPath = "api/v1/unit/custom_skill/skill_enhance")
    {
    }

    [Token(Token = "0x600A415")]
    [Address(RVA = "0x46D0FD8", Offset = "0x46D0FD8", VA = "0x46D0FD8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A416")]
    [Address(RVA = "0x46D1068", Offset = "0x46D1068", VA = "0x46D1068")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A417")]
    [Address(RVA = "0x46D1074", Offset = "0x46D1074", VA = "0x46D1074")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A418")]
    [Address(RVA = "0x46D1148", Offset = "0x46D1148", VA = "0x46D1148")]
    private void OnSuccess(string json)
    {
    }
  }
}
