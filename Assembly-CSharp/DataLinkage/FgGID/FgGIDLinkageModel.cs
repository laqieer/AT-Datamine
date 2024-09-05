// Decompiled with JetBrains decompiler
// Type: DataLinkage.FgGID.FgGIDLinkageModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using System;
using System.Collections;

#nullable disable
namespace DataLinkage.FgGID
{
  [Il2CppDummyDll.Token(Token = "0x2001FC7")]
  public class FgGIDLinkageModel
  {
    [Il2CppDummyDll.Token(Token = "0x40087B0")]
    [FieldOffset(Offset = "0x10")]
    private DataLinkConnector linkConnector;
    [Il2CppDummyDll.Token(Token = "0x40087B1")]
    [FieldOffset(Offset = "0x18")]
    private PlayerDataModel playerDataModel;
    [Il2CppDummyDll.Token(Token = "0x40087B2")]
    [FieldOffset(Offset = "0x20")]
    private APIDascFgGIDConnectInfo token;
    [Il2CppDummyDll.Token(Token = "0x40087B5")]
    [FieldOffset(Offset = "0x30")]
    public Action<bool> LinkStatusChanged;
    [Il2CppDummyDll.Token(Token = "0x40087B6")]
    [FieldOffset(Offset = "0x38")]
    public Action<bool> LoginStatusChanged;

    [Il2CppDummyDll.Token(Token = "0x17002702")]
    public bool IsLinked
    {
      [Il2CppDummyDll.Token(Token = "0x600BCA3"), Address(RVA = "0x1E5435C", Offset = "0x1E5435C", VA = "0x1E5435C")] get
      {
        return new bool();
      }
      [Il2CppDummyDll.Token(Token = "0x600BCA4"), Address(RVA = "0x1E54364", Offset = "0x1E54364", VA = "0x1E54364")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x17002703")]
    public bool IsLogined
    {
      [Il2CppDummyDll.Token(Token = "0x600BCA5"), Address(RVA = "0x1E54370", Offset = "0x1E54370", VA = "0x1E54370")] get
      {
        return new bool();
      }
      [Il2CppDummyDll.Token(Token = "0x600BCA6"), Address(RVA = "0x1E54378", Offset = "0x1E54378", VA = "0x1E54378")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x600BCA7")]
    [Address(RVA = "0x1E48A20", Offset = "0x1E48A20", VA = "0x1E48A20")]
    public FgGIDLinkageModel(
      bool isLinked,
      PlayerDataModel playerDataModel,
      DataLinkConnector linkConnector)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCA8")]
    [Address(RVA = "0x1E524A8", Offset = "0x1E524A8", VA = "0x1E524A8")]
    public void ApplyAndNotifyLinkStatusChange(bool isLinked)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCA9")]
    [Address(RVA = "0x1E54384", Offset = "0x1E54384", VA = "0x1E54384")]
    public void ApplyAndNotifyLoginStatusChange(bool isLogined)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCAA")]
    [Address(RVA = "0x1E529F8", Offset = "0x1E529F8", VA = "0x1E529F8")]
    public void Login(
      FgGIDLinkageModel.OnRequestSuccess onSuccess,
      FgGIDLinkageModel.OnRequestError onError)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCAB")]
    [Address(RVA = "0x1E543B0", Offset = "0x1E543B0", VA = "0x1E543B0")]
    public void Token(
      string code,
      string state,
      FgGIDLinkageModel.OnRequestSuccess onSuccess,
      FgGIDLinkageModel.OnRequestError onError)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCAC")]
    [Address(RVA = "0x1E544E4", Offset = "0x1E544E4", VA = "0x1E544E4")]
    public void Connect(
      FgGIDLinkageModel.OnRequestSuccess onSuccess,
      FgGIDLinkageModel.OnRequestError onError)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCAD")]
    [Address(RVA = "0x1E54624", Offset = "0x1E54624", VA = "0x1E54624")]
    public void Disconnect(
      FgGIDLinkageModel.OnRequestSuccess onSuccess,
      FgGIDLinkageModel.OnRequestError onError)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCAE")]
    [Address(RVA = "0x1E528C4", Offset = "0x1E528C4", VA = "0x1E528C4")]
    public void AddDevice(
      FgGIDLinkageModel.OnRequestSuccess onSuccess,
      FgGIDLinkageModel.OnRequestError onError)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCAF")]
    [Address(RVA = "0x1E5476C", Offset = "0x1E5476C", VA = "0x1E5476C")]
    public void NotifyCompleteMissionDatalink()
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600BCB0")]
    [Address(RVA = "0x1E54854", Offset = "0x1E54854", VA = "0x1E54854")]
    public void ClearLoginData()
    {
    }

    [Il2CppDummyDll.Token(Token = "0x2001FC8")]
    public delegate void OnRequestSuccess();

    [Il2CppDummyDll.Token(Token = "0x2001FC9")]
    public delegate IEnumerator OnRequestError(string errorCode);
  }
}
