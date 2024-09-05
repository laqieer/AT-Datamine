// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.IDPasswordLinkageModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001FA7")]
  public class IDPasswordLinkageModel
  {
    [Token(Token = "0x400874B")]
    [FieldOffset(Offset = "0x10")]
    private DataLinkConnector connector;
    [Token(Token = "0x400874C")]
    [FieldOffset(Offset = "0x18")]
    private PlayerDataModel playerData;
    [Token(Token = "0x400874E")]
    [FieldOffset(Offset = "0x28")]
    public Action<bool> LinkStatusChanged;

    [Token(Token = "0x170026ED")]
    public bool IsLinked
    {
      [Token(Token = "0x600BBEE"), Address(RVA = "0x1E4FF40", Offset = "0x1E4FF40", VA = "0x1E4FF40")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BBEF"), Address(RVA = "0x1E4FF48", Offset = "0x1E4FF48", VA = "0x1E4FF48")] private set
      {
      }
    }

    [Token(Token = "0x600BBF0")]
    [Address(RVA = "0x1E48A88", Offset = "0x1E48A88", VA = "0x1E48A88")]
    public IDPasswordLinkageModel(
      bool isLinked,
      PlayerDataModel playerDataModel,
      DataLinkConnector connector)
    {
    }

    [Token(Token = "0x600BBF1")]
    [Address(RVA = "0x1E4D400", Offset = "0x1E4D400", VA = "0x1E4D400")]
    public void ApplyAndNotifyLinkStatusChange(bool isLinked)
    {
    }

    [Token(Token = "0x600BBF2")]
    [Address(RVA = "0x1E4FF54", Offset = "0x1E4FF54", VA = "0x1E4FF54")]
    public void Connect(
      IDPasswordData passwordModel,
      IDPasswordLinkageModel.OnRequestSuccess onSuccess,
      IDPasswordLinkageModel.OnRequestError onError)
    {
    }

    [Token(Token = "0x600BBF3")]
    [Address(RVA = "0x1E500CC", Offset = "0x1E500CC", VA = "0x1E500CC")]
    public void Disconnect(
      IDPasswordData passwordModel,
      IDPasswordLinkageModel.OnRequestSuccess onSuccess,
      IDPasswordLinkageModel.OnRequestError onError)
    {
    }

    [Token(Token = "0x600BBF4")]
    [Address(RVA = "0x1E4E73C", Offset = "0x1E4E73C", VA = "0x1E4E73C")]
    public void AddDevice(
      IDPasswordData passwordModel,
      IDPasswordLinkageModel.OnRequestSuccess onSuccess,
      IDPasswordLinkageModel.OnRequestError onError,
      Action onFinished = null)
    {
    }

    [Token(Token = "0x600BBF5")]
    [Address(RVA = "0x1E5024C", Offset = "0x1E5024C", VA = "0x1E5024C")]
    public void Register(
      IDPasswordData idPasswordData,
      IDPasswordLinkageModel.OnRequestSuccess onSuccess,
      IDPasswordLinkageModel.OnRequestError onError)
    {
    }

    [Token(Token = "0x600BBF6")]
    [Address(RVA = "0x1E50388", Offset = "0x1E50388", VA = "0x1E50388")]
    public void DeleteUser(
      IDPasswordData idPasswordData,
      IDPasswordLinkageModel.OnRequestSuccess onSuccess,
      IDPasswordLinkageModel.OnRequestError onError)
    {
    }

    [Token(Token = "0x600BBF7")]
    [Address(RVA = "0x1E504C4", Offset = "0x1E504C4", VA = "0x1E504C4")]
    private void NotifyCompleteMissionDatalink()
    {
    }

    [Token(Token = "0x2001FA8")]
    public delegate void OnRequestSuccess();

    [Token(Token = "0x2001FA9")]
    public delegate IEnumerator OnRequestError(string errorCode);
  }
}
