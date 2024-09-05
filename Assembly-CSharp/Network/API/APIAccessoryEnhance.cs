// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B35")]
  public class APIAccessoryEnhance
  {
    [Token(Token = "0x40074B9")]
    public const string DefaultAPIPath = "api/v1/accessory/enhance";
    [Token(Token = "0x40074BD")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40074BE")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAccessoryEnhanceResponse> onSuccess;
    [Token(Token = "0x40074BF")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001CFD")]
    public APIAccessoryEnhanceRequest Request
    {
      [Token(Token = "0x6009FB7"), Address(RVA = "0x46C1CC4", Offset = "0x46C1CC4", VA = "0x46C1CC4")] private get
      {
        return (APIAccessoryEnhanceRequest) null;
      }
      [Token(Token = "0x6009FB8"), Address(RVA = "0x46C1CCC", Offset = "0x46C1CCC", VA = "0x46C1CCC")] set
      {
      }
    }

    [Token(Token = "0x17001CFE")]
    public APIAccessoryEnhanceResponse Response
    {
      [Token(Token = "0x6009FB9"), Address(RVA = "0x46C1CD4", Offset = "0x46C1CD4", VA = "0x46C1CD4")] get
      {
        return (APIAccessoryEnhanceResponse) null;
      }
      [Token(Token = "0x6009FBA"), Address(RVA = "0x46C1CDC", Offset = "0x46C1CDC", VA = "0x46C1CDC")] private set
      {
      }
    }

    [Token(Token = "0x17001CFF")]
    public int ResponseCode
    {
      [Token(Token = "0x6009FBB"), Address(RVA = "0x46C1CE4", Offset = "0x46C1CE4", VA = "0x46C1CE4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009FBC"), Address(RVA = "0x46C1CEC", Offset = "0x46C1CEC", VA = "0x46C1CEC")] private set
      {
      }
    }

    [Token(Token = "0x17001D00")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x6009FBD"), Address(RVA = "0x46C1CF4", Offset = "0x46C1CF4", VA = "0x46C1CF4")] set
      {
      }
      [Token(Token = "0x6009FBE"), Address(RVA = "0x46C1D10", Offset = "0x46C1D10", VA = "0x46C1D10")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x6009FBF")]
    [Address(RVA = "0x46C1D2C", Offset = "0x46C1D2C", VA = "0x46C1D2C")]
    public APIAccessoryEnhance(string apiPath = "api/v1/accessory/enhance")
    {
    }

    [Token(Token = "0x6009FC0")]
    [Address(RVA = "0x46C1DC4", Offset = "0x46C1DC4", VA = "0x46C1DC4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009FC1")]
    [Address(RVA = "0x46C1E54", Offset = "0x46C1E54", VA = "0x46C1E54")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009FC2")]
    [Address(RVA = "0x46C1E60", Offset = "0x46C1E60", VA = "0x46C1E60")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009FC3")]
    [Address(RVA = "0x46C1F34", Offset = "0x46C1F34", VA = "0x46C1F34")]
    private void OnSuccess(string json)
    {
    }
  }
}
