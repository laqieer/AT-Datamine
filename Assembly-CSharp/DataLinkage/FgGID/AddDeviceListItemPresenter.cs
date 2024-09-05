// Decompiled with JetBrains decompiler
// Type: DataLinkage.FgGID.AddDeviceListItemPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace DataLinkage.FgGID
{
  [Token(Token = "0x2001FB8")]
  internal class AddDeviceListItemPresenter : IDataLinkagePresenter
  {
    [Token(Token = "0x400877C")]
    [FieldOffset(Offset = "0x10")]
    private DataLinkageListItem view;
    [Token(Token = "0x400877D")]
    [FieldOffset(Offset = "0x18")]
    private FgGIDLinkageModel model;
    [Token(Token = "0x400877E")]
    [FieldOffset(Offset = "0x20")]
    private DataLinkageModel dataLinkageModel;
    [Token(Token = "0x400877F")]
    [FieldOffset(Offset = "0x28")]
    private DataLinkageDataModel dataLinkageDataModel;

    [Token(Token = "0x600BC4A")]
    [Address(RVA = "0x1E4AE98", Offset = "0x1E4AE98", VA = "0x1E4AE98")]
    public AddDeviceListItemPresenter(
      DataLinkageListItem view,
      DataLinkageModel dataLinkageModel,
      FgGIDLinkageModel model,
      DataLinkageDataModel dataLinkageDataModel)
    {
    }

    [Token(Token = "0x600BC4B")]
    [Address(RVA = "0x1E51FF8", Offset = "0x1E51FF8", VA = "0x1E51FF8", Slot = "6")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BC4C")]
    [Address(RVA = "0x1E52254", Offset = "0x1E52254", VA = "0x1E52254", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600BC4D")]
    [Address(RVA = "0x1E52448", Offset = "0x1E52448", VA = "0x1E52448")]
    private void OnLinkStatusChanged(bool isLinked)
    {
    }

    [Token(Token = "0x600BC4E")]
    [Address(RVA = "0x1E5246C", Offset = "0x1E5246C", VA = "0x1E5246C")]
    private void OnConnectListReceived(bool isLinked)
    {
    }

    [Token(Token = "0x600BC4F")]
    [Address(RVA = "0x1E524CC", Offset = "0x1E524CC", VA = "0x1E524CC")]
    private void OnLoginStatusChanged(bool isLogined)
    {
    }

    [Token(Token = "0x600BC50")]
    [Address(RVA = "0x1E524D0", Offset = "0x1E524D0", VA = "0x1E524D0", Slot = "4")]
    public void RequestLinkage()
    {
    }

    [Token(Token = "0x600BC51")]
    [Address(RVA = "0x1E52690", Offset = "0x1E52690", VA = "0x1E52690", Slot = "5")]
    public void RequestDisconnect()
    {
    }

    [Token(Token = "0x600BC52")]
    [Address(RVA = "0x1E52694", Offset = "0x1E52694", VA = "0x1E52694")]
    private void OnDatalinkageNoteResult(bool isAgree)
    {
    }

    [Token(Token = "0x600BC53")]
    [Address(RVA = "0x1E52570", Offset = "0x1E52570", VA = "0x1E52570")]
    private void AddDevice()
    {
    }

    [Token(Token = "0x600BC54")]
    [Address(RVA = "0x1E5275C", Offset = "0x1E5275C", VA = "0x1E5275C")]
    private void Login(FgGIDLinkageModel.OnRequestSuccess onSuccess)
    {
    }

    [Token(Token = "0x600BC55")]
    [Address(RVA = "0x1E52AC4", Offset = "0x1E52AC4", VA = "0x1E52AC4")]
    private void OnAddDeviceSuccess()
    {
    }

    [Token(Token = "0x600BC56")]
    [Address(RVA = "0x1E52B20", Offset = "0x1E52B20", VA = "0x1E52B20")]
    private IEnumerator OnAddDeviceError(string errorCode) => (IEnumerator) null;

    [Token(Token = "0x600BC57")]
    [Address(RVA = "0x1E52BB0", Offset = "0x1E52BB0", VA = "0x1E52BB0", Slot = "8")]
    public void LinkedButtonClicked()
    {
    }
  }
}
