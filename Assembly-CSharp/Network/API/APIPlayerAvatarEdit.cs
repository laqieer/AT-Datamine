// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerAvatarEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D89")]
  public class APIPlayerAvatarEdit
  {
    [Token(Token = "0x4007E1E")]
    public const string DefaultAPIPath = "api/v1/player/avatar/edit";
    [Token(Token = "0x4007E22")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E23")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerAvatarEditResponse> onSuccess;
    [Token(Token = "0x4007E24")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002248")]
    public APIPlayerAvatarEditRequest Request
    {
      [Token(Token = "0x600AE52"), Address(RVA = "0x1A4CAEC", Offset = "0x1A4CAEC", VA = "0x1A4CAEC")] private get
      {
        return (APIPlayerAvatarEditRequest) null;
      }
      [Token(Token = "0x600AE53"), Address(RVA = "0x1A4CAF4", Offset = "0x1A4CAF4", VA = "0x1A4CAF4")] set
      {
      }
    }

    [Token(Token = "0x17002249")]
    public APIPlayerAvatarEditResponse Response
    {
      [Token(Token = "0x600AE54"), Address(RVA = "0x1A4CAFC", Offset = "0x1A4CAFC", VA = "0x1A4CAFC")] get
      {
        return (APIPlayerAvatarEditResponse) null;
      }
      [Token(Token = "0x600AE55"), Address(RVA = "0x1A4CB04", Offset = "0x1A4CB04", VA = "0x1A4CB04")] private set
      {
      }
    }

    [Token(Token = "0x1700224A")]
    public int ResponseCode
    {
      [Token(Token = "0x600AE56"), Address(RVA = "0x1A4CB0C", Offset = "0x1A4CB0C", VA = "0x1A4CB0C")] get
      {
        return new int();
      }
      [Token(Token = "0x600AE57"), Address(RVA = "0x1A4CB14", Offset = "0x1A4CB14", VA = "0x1A4CB14")] private set
      {
      }
    }

    [Token(Token = "0x1700224B")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AE58"), Address(RVA = "0x1A4CB1C", Offset = "0x1A4CB1C", VA = "0x1A4CB1C")] set
      {
      }
      [Token(Token = "0x600AE59"), Address(RVA = "0x1A4CB38", Offset = "0x1A4CB38", VA = "0x1A4CB38")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AE5A")]
    [Address(RVA = "0x1A4CB54", Offset = "0x1A4CB54", VA = "0x1A4CB54")]
    public APIPlayerAvatarEdit(string apiPath = "api/v1/player/avatar/edit")
    {
    }

    [Token(Token = "0x600AE5B")]
    [Address(RVA = "0x1A4CBEC", Offset = "0x1A4CBEC", VA = "0x1A4CBEC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AE5C")]
    [Address(RVA = "0x1A4CC7C", Offset = "0x1A4CC7C", VA = "0x1A4CC7C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AE5D")]
    [Address(RVA = "0x1A4CC88", Offset = "0x1A4CC88", VA = "0x1A4CC88")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AE5E")]
    [Address(RVA = "0x1A4CD5C", Offset = "0x1A4CD5C", VA = "0x1A4CD5C")]
    private void OnSuccess(string json)
    {
    }
  }
}
