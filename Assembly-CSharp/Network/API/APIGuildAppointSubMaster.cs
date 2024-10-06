// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAppointSubMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CA1")]
  public class APIGuildAppointSubMaster
  {
    [Token(Token = "0x4007A65")]
    public const string DefaultAPIPath = "api/v1/guild/appoint/submaster";
    [Token(Token = "0x4007A69")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A6A")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildAppointSubMasterResponse> onSuccess;
    [Token(Token = "0x4007A6B")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002032")]
    public APIGuildAppointSubMasterRequest Request
    {
      [Token(Token = "0x600A89C"), Address(RVA = "0x1912774", Offset = "0x1912774", VA = "0x1912774")] private get
      {
        return (APIGuildAppointSubMasterRequest) null;
      }
      [Token(Token = "0x600A89D"), Address(RVA = "0x191277C", Offset = "0x191277C", VA = "0x191277C")] set
      {
      }
    }

    [Token(Token = "0x17002033")]
    public APIGuildAppointSubMasterResponse Response
    {
      [Token(Token = "0x600A89E"), Address(RVA = "0x1912784", Offset = "0x1912784", VA = "0x1912784")] get
      {
        return (APIGuildAppointSubMasterResponse) null;
      }
      [Token(Token = "0x600A89F"), Address(RVA = "0x191278C", Offset = "0x191278C", VA = "0x191278C")] private set
      {
      }
    }

    [Token(Token = "0x17002034")]
    public int ResponseCode
    {
      [Token(Token = "0x600A8A0"), Address(RVA = "0x1912794", Offset = "0x1912794", VA = "0x1912794")] get
      {
        return new int();
      }
      [Token(Token = "0x600A8A1"), Address(RVA = "0x191279C", Offset = "0x191279C", VA = "0x191279C")] private set
      {
      }
    }

    [Token(Token = "0x17002035")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A8A2"), Address(RVA = "0x19127A4", Offset = "0x19127A4", VA = "0x19127A4")] set
      {
      }
      [Token(Token = "0x600A8A3"), Address(RVA = "0x19127C0", Offset = "0x19127C0", VA = "0x19127C0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A8A4")]
    [Address(RVA = "0x19127DC", Offset = "0x19127DC", VA = "0x19127DC")]
    public APIGuildAppointSubMaster(string apiPath = "api/v1/guild/appoint/submaster")
    {
    }

    [Token(Token = "0x600A8A5")]
    [Address(RVA = "0x1912874", Offset = "0x1912874", VA = "0x1912874")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A8A6")]
    [Address(RVA = "0x1912904", Offset = "0x1912904", VA = "0x1912904")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A8A7")]
    [Address(RVA = "0x1912910", Offset = "0x1912910", VA = "0x1912910")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A8A8")]
    [Address(RVA = "0x19129E4", Offset = "0x19129E4", VA = "0x19129E4")]
    private void OnSuccess(string json)
    {
    }
  }
}
