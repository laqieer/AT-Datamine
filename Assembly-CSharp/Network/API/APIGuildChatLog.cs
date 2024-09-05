// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildChatLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CB1")]
  public class APIGuildChatLog
  {
    [Token(Token = "0x4007AAE")]
    public const string DefaultAPIPath = "api/v1/guild/chat/log";
    [Token(Token = "0x4007AB2")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007AB3")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildChatLogResponse> onSuccess;
    [Token(Token = "0x4007AB4")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700205A")]
    public APIGuildChatLogRequest Request
    {
      [Token(Token = "0x600A904"), Address(RVA = "0x1913D24", Offset = "0x1913D24", VA = "0x1913D24")] private get
      {
        return (APIGuildChatLogRequest) null;
      }
      [Token(Token = "0x600A905"), Address(RVA = "0x1913D2C", Offset = "0x1913D2C", VA = "0x1913D2C")] set
      {
      }
    }

    [Token(Token = "0x1700205B")]
    public APIGuildChatLogResponse Response
    {
      [Token(Token = "0x600A906"), Address(RVA = "0x1913D34", Offset = "0x1913D34", VA = "0x1913D34")] get
      {
        return (APIGuildChatLogResponse) null;
      }
      [Token(Token = "0x600A907"), Address(RVA = "0x1913D3C", Offset = "0x1913D3C", VA = "0x1913D3C")] private set
      {
      }
    }

    [Token(Token = "0x1700205C")]
    public int ResponseCode
    {
      [Token(Token = "0x600A908"), Address(RVA = "0x1913D44", Offset = "0x1913D44", VA = "0x1913D44")] get
      {
        return new int();
      }
      [Token(Token = "0x600A909"), Address(RVA = "0x1913D4C", Offset = "0x1913D4C", VA = "0x1913D4C")] private set
      {
      }
    }

    [Token(Token = "0x1700205D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A90A"), Address(RVA = "0x1913D54", Offset = "0x1913D54", VA = "0x1913D54")] set
      {
      }
      [Token(Token = "0x600A90B"), Address(RVA = "0x1913D70", Offset = "0x1913D70", VA = "0x1913D70")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A90C")]
    [Address(RVA = "0x1913D8C", Offset = "0x1913D8C", VA = "0x1913D8C")]
    public APIGuildChatLog(string apiPath = "api/v1/guild/chat/log")
    {
    }

    [Token(Token = "0x600A90D")]
    [Address(RVA = "0x1913E24", Offset = "0x1913E24", VA = "0x1913E24")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A90E")]
    [Address(RVA = "0x1913EB4", Offset = "0x1913EB4", VA = "0x1913EB4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A90F")]
    [Address(RVA = "0x1913EC0", Offset = "0x1913EC0", VA = "0x1913EC0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A910")]
    [Address(RVA = "0x1913F94", Offset = "0x1913F94", VA = "0x1913F94")]
    private void OnSuccess(string json)
    {
    }
  }
}
