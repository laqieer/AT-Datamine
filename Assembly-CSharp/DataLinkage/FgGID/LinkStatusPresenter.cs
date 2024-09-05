// Decompiled with JetBrains decompiler
// Type: DataLinkage.FgGID.LinkStatusPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace DataLinkage.FgGID
{
  [Token(Token = "0x2001FD2")]
  internal class LinkStatusPresenter : ILinkStatusPresenter
  {
    [Token(Token = "0x40087CA")]
    [FieldOffset(Offset = "0x10")]
    private ILinkStatusView view;
    [Token(Token = "0x40087CB")]
    [FieldOffset(Offset = "0x18")]
    private FgGIDLinkageModel model;
    [Token(Token = "0x40087CC")]
    [FieldOffset(Offset = "0x20")]
    private DataLinkageModel dataLinkageModel;
    [Token(Token = "0x40087CD")]
    [FieldOffset(Offset = "0x28")]
    private Action<bool> onStatusButtonClick;

    [Token(Token = "0x600BCD2")]
    [Address(RVA = "0x1E4AFC8", Offset = "0x1E4AFC8", VA = "0x1E4AFC8")]
    public LinkStatusPresenter(
      ILinkStatusView view,
      DataLinkageModel dataLinkageModel,
      FgGIDLinkageModel model,
      Action<bool> onStatusButtonClick)
    {
    }

    [Token(Token = "0x600BCD3")]
    [Address(RVA = "0x1E54EE0", Offset = "0x1E54EE0", VA = "0x1E54EE0", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BCD4")]
    [Address(RVA = "0x1E550DC", Offset = "0x1E550DC", VA = "0x1E550DC", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x600BCD5")]
    [Address(RVA = "0x1E552D8", Offset = "0x1E552D8", VA = "0x1E552D8")]
    private void OnUserNotCreatedError()
    {
    }

    [Token(Token = "0x600BCD6")]
    [Address(RVA = "0x1E55380", Offset = "0x1E55380", VA = "0x1E55380")]
    private void OnLinkStatusChanged(bool isLinked)
    {
    }

    [Token(Token = "0x600BCD7")]
    [Address(RVA = "0x1E5549C", Offset = "0x1E5549C", VA = "0x1E5549C")]
    private void OnConnectListReceived(bool isLinked)
    {
    }

    [Token(Token = "0x600BCD8")]
    [Address(RVA = "0x1E554D8", Offset = "0x1E554D8", VA = "0x1E554D8", Slot = "6")]
    public void StatusButtonClicked()
    {
    }
  }
}
