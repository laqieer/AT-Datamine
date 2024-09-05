// Decompiled with JetBrains decompiler
// Type: DataLinkage.FgGID.RegisterListItemPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace DataLinkage.FgGID
{
  [Token(Token = "0x2001FD4")]
  internal class RegisterListItemPresenter : IDataLinkagePresenter
  {
    [Token(Token = "0x40087D0")]
    [FieldOffset(Offset = "0x10")]
    private DataLinkageListItem view;
    [Token(Token = "0x40087D1")]
    [FieldOffset(Offset = "0x18")]
    private FgGIDLinkageModel model;
    [Token(Token = "0x40087D2")]
    [FieldOffset(Offset = "0x20")]
    private DataLinkageModel dataLinkageModel;
    [Token(Token = "0x40087D3")]
    [FieldOffset(Offset = "0x28")]
    private DataLinkageDataModel dataLinkageDataModel;

    [Token(Token = "0x600BCDA")]
    [Address(RVA = "0x1E4ADCC", Offset = "0x1E4ADCC", VA = "0x1E4ADCC")]
    public RegisterListItemPresenter(
      DataLinkageListItem view,
      DataLinkageModel dataLinkageModel,
      FgGIDLinkageModel model,
      DataLinkageDataModel dataLinkageDataModel)
    {
    }

    [Token(Token = "0x600BCDB")]
    [Address(RVA = "0x1E55510", Offset = "0x1E55510", VA = "0x1E55510", Slot = "6")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BCDC")]
    [Address(RVA = "0x1E55770", Offset = "0x1E55770", VA = "0x1E55770", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600BCDD")]
    [Address(RVA = "0x1E55964", Offset = "0x1E55964", VA = "0x1E55964")]
    private void OnLinkStatusChanged(bool isLinked)
    {
    }

    [Token(Token = "0x600BCDE")]
    [Address(RVA = "0x1E5598C", Offset = "0x1E5598C", VA = "0x1E5598C")]
    private void OnConnectListReceived(bool isLinked)
    {
    }

    [Token(Token = "0x600BCDF")]
    [Address(RVA = "0x1E559C8", Offset = "0x1E559C8", VA = "0x1E559C8")]
    private void OnLoginStatusChanged(bool isLogined)
    {
    }

    [Token(Token = "0x600BCE0")]
    [Address(RVA = "0x1E559CC", Offset = "0x1E559CC", VA = "0x1E559CC", Slot = "4")]
    public void RequestLinkage()
    {
    }

    [Token(Token = "0x600BCE1")]
    [Address(RVA = "0x1E55B8C", Offset = "0x1E55B8C", VA = "0x1E55B8C", Slot = "5")]
    public void RequestDisconnect()
    {
    }

    [Token(Token = "0x600BCE2")]
    [Address(RVA = "0x1E55A6C", Offset = "0x1E55A6C", VA = "0x1E55A6C")]
    private void Register()
    {
    }

    [Token(Token = "0x600BCE3")]
    [Address(RVA = "0x1E55C2C", Offset = "0x1E55C2C", VA = "0x1E55C2C")]
    private void Disconnect()
    {
    }

    [Token(Token = "0x600BCE4")]
    [Address(RVA = "0x1E55D4C", Offset = "0x1E55D4C", VA = "0x1E55D4C")]
    private void Login(FgGIDLinkageModel.OnRequestSuccess onSuccess)
    {
    }

    [Token(Token = "0x600BCE5")]
    [Address(RVA = "0x1E55DE0", Offset = "0x1E55DE0", VA = "0x1E55DE0")]
    private void OnRegisterSuccess()
    {
    }

    [Token(Token = "0x600BCE6")]
    [Address(RVA = "0x1E55E3C", Offset = "0x1E55E3C", VA = "0x1E55E3C")]
    private void OnDisconnectSuccess()
    {
    }

    [Token(Token = "0x600BCE7")]
    [Address(RVA = "0x1E55EC4", Offset = "0x1E55EC4", VA = "0x1E55EC4")]
    private IEnumerator OnError(string errorCode) => (IEnumerator) null;

    [Token(Token = "0x600BCE8")]
    [Address(RVA = "0x1E55F54", Offset = "0x1E55F54", VA = "0x1E55F54", Slot = "8")]
    public void LinkedButtonClicked()
    {
    }
  }
}
