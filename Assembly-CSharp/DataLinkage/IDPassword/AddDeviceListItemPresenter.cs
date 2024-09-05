// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.AddDeviceListItemPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001F94")]
  public class AddDeviceListItemPresenter : IDataLinkagePresenter
  {
    [Token(Token = "0x40086FD")]
    [FieldOffset(Offset = "0x10")]
    private DataLinkageListItem view;
    [Token(Token = "0x40086FE")]
    [FieldOffset(Offset = "0x18")]
    private IDPasswordLinkageModel model;
    [Token(Token = "0x40086FF")]
    [FieldOffset(Offset = "0x20")]
    private DataLinkageModel dataLinkageModel;
    [Token(Token = "0x4008700")]
    [FieldOffset(Offset = "0x28")]
    private DataLinkageDataModel dataLinkageDataModel;

    [Token(Token = "0x600BB6F")]
    [Address(RVA = "0x1E4AD00", Offset = "0x1E4AD00", VA = "0x1E4AD00")]
    public AddDeviceListItemPresenter(
      DataLinkageListItem view,
      DataLinkageModel dataLinkageModel,
      IDPasswordLinkageModel model,
      DataLinkageDataModel dataLinkageDataModel)
    {
    }

    [Token(Token = "0x600BB70")]
    [Address(RVA = "0x1E4D08C", Offset = "0x1E4D08C", VA = "0x1E4D08C", Slot = "6")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BB71")]
    [Address(RVA = "0x1E4D23C", Offset = "0x1E4D23C", VA = "0x1E4D23C", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600BB72")]
    [Address(RVA = "0x1E4D3A8", Offset = "0x1E4D3A8", VA = "0x1E4D3A8")]
    private void OnLinkStatusChanged(bool isLinked)
    {
    }

    [Token(Token = "0x600BB73")]
    [Address(RVA = "0x1E4D3C4", Offset = "0x1E4D3C4", VA = "0x1E4D3C4")]
    private void OnConnectListReceived(bool isLinked)
    {
    }

    [Token(Token = "0x600BB74")]
    [Address(RVA = "0x1E4D424", Offset = "0x1E4D424", VA = "0x1E4D424", Slot = "4")]
    public void RequestLinkage()
    {
    }

    [Token(Token = "0x600BB75")]
    [Address(RVA = "0x1E4D544", Offset = "0x1E4D544", VA = "0x1E4D544", Slot = "5")]
    public void RequestDisconnect()
    {
    }

    [Token(Token = "0x600BB76")]
    [Address(RVA = "0x1E4D548", Offset = "0x1E4D548", VA = "0x1E4D548")]
    private void OnDatalinkageNoteResult(bool isAgree)
    {
    }

    [Token(Token = "0x600BB77")]
    [Address(RVA = "0x1E4D4C4", Offset = "0x1E4D4C4", VA = "0x1E4D4C4")]
    private void AddDevice()
    {
    }

    [Token(Token = "0x600BB78")]
    [Address(RVA = "0x1E4D694", Offset = "0x1E4D694", VA = "0x1E4D694", Slot = "8")]
    public void LinkedButtonClicked()
    {
    }
  }
}
