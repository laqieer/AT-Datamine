// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D5D")]
  public class APIMind_equipmentFavorite
  {
    [Token(Token = "0x4007D6C")]
    public const string DefaultAPIPath = "api/v1/mind_equipment/favorite";
    [Token(Token = "0x4007D70")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D71")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMind_equipmentFavoriteResponse> onSuccess;
    [Token(Token = "0x4007D72")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021DB")]
    public APIMind_equipmentFavoriteRequest Request
    {
      [Token(Token = "0x600AD35"), Address(RVA = "0x1A48F60", Offset = "0x1A48F60", VA = "0x1A48F60")] private get
      {
        return (APIMind_equipmentFavoriteRequest) null;
      }
      [Token(Token = "0x600AD36"), Address(RVA = "0x1A48F68", Offset = "0x1A48F68", VA = "0x1A48F68")] set
      {
      }
    }

    [Token(Token = "0x170021DC")]
    public APIMind_equipmentFavoriteResponse Response
    {
      [Token(Token = "0x600AD37"), Address(RVA = "0x1A48F70", Offset = "0x1A48F70", VA = "0x1A48F70")] get
      {
        return (APIMind_equipmentFavoriteResponse) null;
      }
      [Token(Token = "0x600AD38"), Address(RVA = "0x1A48F78", Offset = "0x1A48F78", VA = "0x1A48F78")] private set
      {
      }
    }

    [Token(Token = "0x170021DD")]
    public int ResponseCode
    {
      [Token(Token = "0x600AD39"), Address(RVA = "0x1A48F80", Offset = "0x1A48F80", VA = "0x1A48F80")] get
      {
        return new int();
      }
      [Token(Token = "0x600AD3A"), Address(RVA = "0x1A48F88", Offset = "0x1A48F88", VA = "0x1A48F88")] private set
      {
      }
    }

    [Token(Token = "0x170021DE")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AD3B"), Address(RVA = "0x1A48F90", Offset = "0x1A48F90", VA = "0x1A48F90")] set
      {
      }
      [Token(Token = "0x600AD3C"), Address(RVA = "0x1A48FAC", Offset = "0x1A48FAC", VA = "0x1A48FAC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AD3D")]
    [Address(RVA = "0x1A48FC8", Offset = "0x1A48FC8", VA = "0x1A48FC8")]
    public APIMind_equipmentFavorite(string apiPath = "api/v1/mind_equipment/favorite")
    {
    }

    [Token(Token = "0x600AD3E")]
    [Address(RVA = "0x1A49060", Offset = "0x1A49060", VA = "0x1A49060")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AD3F")]
    [Address(RVA = "0x1A490F0", Offset = "0x1A490F0", VA = "0x1A490F0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AD40")]
    [Address(RVA = "0x1A490FC", Offset = "0x1A490FC", VA = "0x1A490FC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AD41")]
    [Address(RVA = "0x1A491D0", Offset = "0x1A491D0", VA = "0x1A491D0")]
    private void OnSuccess(string json)
    {
    }
  }
}
