// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildBulletinBoardSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CAD")]
  public class APIGuildBulletinBoardSet
  {
    [Token(Token = "0x4007A9D")]
    public const string DefaultAPIPath = "api/v1/guild/bulletin_board/set";
    [Token(Token = "0x4007AA1")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007AA2")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildBulletinBoardSetResponse> onSuccess;
    [Token(Token = "0x4007AA3")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002050")]
    public APIGuildBulletinBoardSetRequest Request
    {
      [Token(Token = "0x600A8EA"), Address(RVA = "0x19137B8", Offset = "0x19137B8", VA = "0x19137B8")] private get
      {
        return (APIGuildBulletinBoardSetRequest) null;
      }
      [Token(Token = "0x600A8EB"), Address(RVA = "0x19137C0", Offset = "0x19137C0", VA = "0x19137C0")] set
      {
      }
    }

    [Token(Token = "0x17002051")]
    public APIGuildBulletinBoardSetResponse Response
    {
      [Token(Token = "0x600A8EC"), Address(RVA = "0x19137C8", Offset = "0x19137C8", VA = "0x19137C8")] get
      {
        return (APIGuildBulletinBoardSetResponse) null;
      }
      [Token(Token = "0x600A8ED"), Address(RVA = "0x19137D0", Offset = "0x19137D0", VA = "0x19137D0")] private set
      {
      }
    }

    [Token(Token = "0x17002052")]
    public int ResponseCode
    {
      [Token(Token = "0x600A8EE"), Address(RVA = "0x19137D8", Offset = "0x19137D8", VA = "0x19137D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A8EF"), Address(RVA = "0x19137E0", Offset = "0x19137E0", VA = "0x19137E0")] private set
      {
      }
    }

    [Token(Token = "0x17002053")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A8F0"), Address(RVA = "0x19137E8", Offset = "0x19137E8", VA = "0x19137E8")] set
      {
      }
      [Token(Token = "0x600A8F1"), Address(RVA = "0x1913804", Offset = "0x1913804", VA = "0x1913804")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A8F2")]
    [Address(RVA = "0x1913820", Offset = "0x1913820", VA = "0x1913820")]
    public APIGuildBulletinBoardSet(string apiPath = "api/v1/guild/bulletin_board/set")
    {
    }

    [Token(Token = "0x600A8F3")]
    [Address(RVA = "0x19138B8", Offset = "0x19138B8", VA = "0x19138B8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A8F4")]
    [Address(RVA = "0x1913948", Offset = "0x1913948", VA = "0x1913948")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A8F5")]
    [Address(RVA = "0x1913954", Offset = "0x1913954", VA = "0x1913954")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A8F6")]
    [Address(RVA = "0x1913A28", Offset = "0x1913A28", VA = "0x1913A28")]
    private void OnSuccess(string json)
    {
    }
  }
}
