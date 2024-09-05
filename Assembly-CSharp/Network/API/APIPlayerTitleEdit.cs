// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerTitleEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DBD")]
  public class APIPlayerTitleEdit
  {
    [Token(Token = "0x4007F0B")]
    public const string DefaultAPIPath = "api/v1/player/title/edit";
    [Token(Token = "0x4007F0F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F10")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerTitleEditResponse> onSuccess;
    [Token(Token = "0x4007F11")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170022E5")]
    public APIPlayerTitleEditRequest Request
    {
      [Token(Token = "0x600AFBF"), Address(RVA = "0x1A51230", Offset = "0x1A51230", VA = "0x1A51230")] private get
      {
        return (APIPlayerTitleEditRequest) null;
      }
      [Token(Token = "0x600AFC0"), Address(RVA = "0x1A51238", Offset = "0x1A51238", VA = "0x1A51238")] set
      {
      }
    }

    [Token(Token = "0x170022E6")]
    public APIPlayerTitleEditResponse Response
    {
      [Token(Token = "0x600AFC1"), Address(RVA = "0x1A51240", Offset = "0x1A51240", VA = "0x1A51240")] get
      {
        return (APIPlayerTitleEditResponse) null;
      }
      [Token(Token = "0x600AFC2"), Address(RVA = "0x1A51248", Offset = "0x1A51248", VA = "0x1A51248")] private set
      {
      }
    }

    [Token(Token = "0x170022E7")]
    public int ResponseCode
    {
      [Token(Token = "0x600AFC3"), Address(RVA = "0x1A51250", Offset = "0x1A51250", VA = "0x1A51250")] get
      {
        return new int();
      }
      [Token(Token = "0x600AFC4"), Address(RVA = "0x1A51258", Offset = "0x1A51258", VA = "0x1A51258")] private set
      {
      }
    }

    [Token(Token = "0x170022E8")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AFC5"), Address(RVA = "0x1A51260", Offset = "0x1A51260", VA = "0x1A51260")] set
      {
      }
      [Token(Token = "0x600AFC6"), Address(RVA = "0x1A5127C", Offset = "0x1A5127C", VA = "0x1A5127C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AFC7")]
    [Address(RVA = "0x1A51298", Offset = "0x1A51298", VA = "0x1A51298")]
    public APIPlayerTitleEdit(string apiPath = "api/v1/player/title/edit")
    {
    }

    [Token(Token = "0x600AFC8")]
    [Address(RVA = "0x1A51330", Offset = "0x1A51330", VA = "0x1A51330")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AFC9")]
    [Address(RVA = "0x1A513C0", Offset = "0x1A513C0", VA = "0x1A513C0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AFCA")]
    [Address(RVA = "0x1A513CC", Offset = "0x1A513CC", VA = "0x1A513CC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AFCB")]
    [Address(RVA = "0x1A514A0", Offset = "0x1A514A0", VA = "0x1A514A0")]
    private void OnSuccess(string json)
    {
    }
  }
}
