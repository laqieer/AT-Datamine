// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkageModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DataLinkage.FgGID;
using DataLinkage.IDPassword;
using GameCore.InAppBrowser;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F6F")]
  public class DataLinkageModel
  {
    [Token(Token = "0x400869E")]
    [FieldOffset(Offset = "0x10")]
    public Action<bool> DispatchFgGIDLinkageOnConnectList;
    [Token(Token = "0x400869F")]
    [FieldOffset(Offset = "0x18")]
    public Action<bool> DispatchIDPasswordLinkageOnConnectList;
    [Token(Token = "0x40086A0")]
    [FieldOffset(Offset = "0x20")]
    public Action UserNotCreatedError;
    [Token(Token = "0x40086A4")]
    [FieldOffset(Offset = "0x30")]
    private DataLinkageStatusConnector connector;
    [Token(Token = "0x40086A5")]
    [FieldOffset(Offset = "0x38")]
    private PlayerDataModel playerDataModel;
    [Token(Token = "0x40086A6")]
    [FieldOffset(Offset = "0x40")]
    private FgGIDLinkageModel fgGIDLinkageModel;
    [Token(Token = "0x40086A7")]
    [FieldOffset(Offset = "0x48")]
    private IDPasswordLinkageModel idPasswordLinkageModel;
    [Token(Token = "0x40086A8")]
    [FieldOffset(Offset = "0x50")]
    private DataLinkageDataModel dataLinkageDataModel;
    [Token(Token = "0x40086A9")]
    [FieldOffset(Offset = "0x58")]
    private List<IDisposable> needDisposeInstances;

    [Token(Token = "0x170026B7")]
    public string PlayerShortId
    {
      [Token(Token = "0x600BA9F"), Address(RVA = "0x1E47FFC", Offset = "0x1E47FFC", VA = "0x1E47FFC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170026B8")]
    public bool IsPlayerCreated
    {
      [Token(Token = "0x600BAA0"), Address(RVA = "0x1E48078", Offset = "0x1E48078", VA = "0x1E48078")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170026B9")]
    public bool IsFgGIDLinked
    {
      [Token(Token = "0x600BAA1"), Address(RVA = "0x1E480D0", Offset = "0x1E480D0", VA = "0x1E480D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BAA2"), Address(RVA = "0x1E480D8", Offset = "0x1E480D8", VA = "0x1E480D8")] private set
      {
      }
    }

    [Token(Token = "0x170026BA")]
    public bool IsIDPWLinked
    {
      [Token(Token = "0x600BAA3"), Address(RVA = "0x1E480E4", Offset = "0x1E480E4", VA = "0x1E480E4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BAA4"), Address(RVA = "0x1E480EC", Offset = "0x1E480EC", VA = "0x1E480EC")] private set
      {
      }
    }

    [Token(Token = "0x170026BB")]
    public bool IsDmmLinked
    {
      [Token(Token = "0x600BAA5"), Address(RVA = "0x1E480F8", Offset = "0x1E480F8", VA = "0x1E480F8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BAA6"), Address(RVA = "0x1E48100", Offset = "0x1E48100", VA = "0x1E48100")] private set
      {
      }
    }

    [Token(Token = "0x600BAA7")]
    [Address(RVA = "0x1E4810C", Offset = "0x1E4810C", VA = "0x1E4810C")]
    public DataLinkageDataModel GetDataLinkageDataModel() => (DataLinkageDataModel) null;

    [Token(Token = "0x600BAA8")]
    [Address(RVA = "0x1E48114", Offset = "0x1E48114", VA = "0x1E48114")]
    public FgGIDLinkageModel GetFgGIDLinkageModel() => (FgGIDLinkageModel) null;

    [Token(Token = "0x600BAA9")]
    [Address(RVA = "0x1E4811C", Offset = "0x1E4811C", VA = "0x1E4811C")]
    public IDPasswordLinkageModel GetIDPasswordLinkageModel() => (IDPasswordLinkageModel) null;

    [Token(Token = "0x600BAAA")]
    [Address(RVA = "0x1E48124", Offset = "0x1E48124", VA = "0x1E48124")]
    public DataLinkageModel(
      PlayerDataModel playerDataModel,
      DataLinkageStatusConnector connector,
      MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x600BAAB")]
    [Address(RVA = "0x1E48AC8", Offset = "0x1E48AC8", VA = "0x1E48AC8")]
    public void ApplyFgGIDLinkageChanged(bool isLinked)
    {
    }

    [Token(Token = "0x600BAAC")]
    [Address(RVA = "0x1E48AD4", Offset = "0x1E48AD4", VA = "0x1E48AD4")]
    public void ApplyIDPasswordLinkageChanged(bool isLinked)
    {
    }

    [Token(Token = "0x600BAAD")]
    [Address(RVA = "0x1E48AE0", Offset = "0x1E48AE0", VA = "0x1E48AE0")]
    public void ApplyMddLinkageChanged(bool isLinked)
    {
    }

    [Token(Token = "0x600BAAE")]
    [Address(RVA = "0x1E48AEC", Offset = "0x1E48AEC", VA = "0x1E48AEC")]
    public void ConnectList(DataLinkageModel.OnRequestSuccess onSuccess, Action onError)
    {
    }

    [Token(Token = "0x600BAAF")]
    [Address(RVA = "0x1E48C6C", Offset = "0x1E48C6C", VA = "0x1E48C6C")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600BAB0")]
    [Address(RVA = "0x1E4851C", Offset = "0x1E4851C", VA = "0x1E4851C")]
    private static IInAppBrowser CreateInAppBrowser() => (IInAppBrowser) null;

    [Token(Token = "0x600BAB1")]
    [Address(RVA = "0x1E48524", Offset = "0x1E48524", VA = "0x1E48524")]
    private static AddDeepLinkActivatedHandler GetAddDeepLinkActivatedHandler(
      IInAppBrowser inAppBrowser)
    {
      return (AddDeepLinkActivatedHandler) null;
    }

    [Token(Token = "0x600BAB2")]
    [Address(RVA = "0x1E48660", Offset = "0x1E48660", VA = "0x1E48660")]
    private static SubDeepLinkActivatedHandler GetSubDeepLinkActivatedHandler(
      IInAppBrowser inAppBrowser)
    {
      return (SubDeepLinkActivatedHandler) null;
    }

    [Token(Token = "0x600BAB3")]
    [Address(RVA = "0x1E4879C", Offset = "0x1E4879C", VA = "0x1E4879C")]
    private static OpenUrlHandler GetOpenUrlHandler(IInAppBrowser inAppBrowser)
    {
      return (OpenUrlHandler) null;
    }

    [Token(Token = "0x2001F70")]
    public delegate void OnRequestSuccess();

    [Token(Token = "0x2001F71")]
    public delegate IEnumerator OnRequestError(string errorCode);
  }
}
