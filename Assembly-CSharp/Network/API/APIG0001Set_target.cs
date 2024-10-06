// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001Set_target
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C91")]
  public class APIG0001Set_target
  {
    [Token(Token = "0x4007A2E")]
    public const string DefaultAPIPath = "api/gacha/G0001/set_target";
    [Token(Token = "0x4007A32")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A33")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0001Set_targetResponse> onSuccess;
    [Token(Token = "0x4007A34")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002013")]
    public APIG0001Set_targetRequest Request
    {
      [Token(Token = "0x600A83D"), Address(RVA = "0x191120C", Offset = "0x191120C", VA = "0x191120C")] private get
      {
        return (APIG0001Set_targetRequest) null;
      }
      [Token(Token = "0x600A83E"), Address(RVA = "0x1911214", Offset = "0x1911214", VA = "0x1911214")] set
      {
      }
    }

    [Token(Token = "0x17002014")]
    public APIG0001Set_targetResponse Response
    {
      [Token(Token = "0x600A83F"), Address(RVA = "0x191121C", Offset = "0x191121C", VA = "0x191121C")] get
      {
        return (APIG0001Set_targetResponse) null;
      }
      [Token(Token = "0x600A840"), Address(RVA = "0x1911224", Offset = "0x1911224", VA = "0x1911224")] private set
      {
      }
    }

    [Token(Token = "0x17002015")]
    public int ResponseCode
    {
      [Token(Token = "0x600A841"), Address(RVA = "0x191122C", Offset = "0x191122C", VA = "0x191122C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A842"), Address(RVA = "0x1911234", Offset = "0x1911234", VA = "0x1911234")] private set
      {
      }
    }

    [Token(Token = "0x17002016")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A843"), Address(RVA = "0x191123C", Offset = "0x191123C", VA = "0x191123C")] set
      {
      }
      [Token(Token = "0x600A844"), Address(RVA = "0x1911258", Offset = "0x1911258", VA = "0x1911258")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A845")]
    [Address(RVA = "0x1911274", Offset = "0x1911274", VA = "0x1911274")]
    public APIG0001Set_target(string apiPath = "api/gacha/G0001/set_target")
    {
    }

    [Token(Token = "0x600A846")]
    [Address(RVA = "0x191130C", Offset = "0x191130C", VA = "0x191130C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A847")]
    [Address(RVA = "0x191139C", Offset = "0x191139C", VA = "0x191139C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A848")]
    [Address(RVA = "0x19113A8", Offset = "0x19113A8", VA = "0x19113A8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A849")]
    [Address(RVA = "0x191147C", Offset = "0x191147C", VA = "0x191147C")]
    private void OnSuccess(string json)
    {
    }
  }
}
