// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.RegisterListItemPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001FB2")]
  public class RegisterListItemPresenter : IIDPasswordLinkagePresenter, IDataLinkagePresenter
  {
    [Token(Token = "0x4008764")]
    [FieldOffset(Offset = "0x10")]
    private DataLinkageIDPasswordListItem view;
    [Token(Token = "0x4008765")]
    [FieldOffset(Offset = "0x18")]
    private IDPasswordLinkageModel model;
    [Token(Token = "0x4008766")]
    [FieldOffset(Offset = "0x20")]
    private DataLinkageModel dataLinkageModel;
    [Token(Token = "0x4008767")]
    [FieldOffset(Offset = "0x28")]
    private DataLinkageDataModel dataLinkageDataModel;

    [Token(Token = "0x600BC19")]
    [Address(RVA = "0x1E4AC14", Offset = "0x1E4AC14", VA = "0x1E4AC14")]
    public RegisterListItemPresenter(
      DataLinkageIDPasswordListItem view,
      DataLinkageModel dataLinkageModel,
      IDPasswordLinkageModel model,
      DataLinkageDataModel dataLinkageDataModel)
    {
    }

    [Token(Token = "0x600BC1A")]
    [Address(RVA = "0x1E50A94", Offset = "0x1E50A94", VA = "0x1E50A94", Slot = "7")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BC1B")]
    [Address(RVA = "0x1E50C58", Offset = "0x1E50C58", VA = "0x1E50C58", Slot = "8")]
    public void Release()
    {
    }

    [Token(Token = "0x600BC1C")]
    [Address(RVA = "0x1E50DC4", Offset = "0x1E50DC4", VA = "0x1E50DC4")]
    private void OnLinkStatusChanged(bool isLinked)
    {
    }

    [Token(Token = "0x600BC1D")]
    [Address(RVA = "0x1E50DEC", Offset = "0x1E50DEC", VA = "0x1E50DEC")]
    private void OnConnectListReceived(bool isLinked)
    {
    }

    [Token(Token = "0x600BC1E")]
    [Address(RVA = "0x1E50E28", Offset = "0x1E50E28", VA = "0x1E50E28", Slot = "5")]
    public void RequestLinkage()
    {
    }

    [Token(Token = "0x600BC1F")]
    [Address(RVA = "0x1E50F48", Offset = "0x1E50F48", VA = "0x1E50F48", Slot = "6")]
    public void RequestDisconnect()
    {
    }

    [Token(Token = "0x600BC20")]
    [Address(RVA = "0x1E50F4C", Offset = "0x1E50F4C", VA = "0x1E50F4C")]
    private void OnDatalinkageNoteResult(bool isAgree)
    {
    }

    [Token(Token = "0x600BC21")]
    [Address(RVA = "0x1E50EC8", Offset = "0x1E50EC8", VA = "0x1E50EC8")]
    private void Register()
    {
    }

    [Token(Token = "0x600BC22")]
    [Address(RVA = "0x1E51098", Offset = "0x1E51098", VA = "0x1E51098", Slot = "4")]
    public void RequestIDCopy()
    {
    }

    [Token(Token = "0x600BC23")]
    [Address(RVA = "0x1E51140", Offset = "0x1E51140", VA = "0x1E51140", Slot = "9")]
    public void LinkedButtonClicked()
    {
    }
  }
}
