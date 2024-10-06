// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkageNotePopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F76")]
  public class DataLinkageNotePopupPresenter : IDataLinkageNotePopupPresenter
  {
    [Token(Token = "0x40086B3")]
    [FieldOffset(Offset = "0x10")]
    private DataLinkageDataModel model;
    [Token(Token = "0x40086B4")]
    [FieldOffset(Offset = "0x18")]
    private DataLinkageNotePopup view;
    [Token(Token = "0x40086B5")]
    [FieldOffset(Offset = "0x20")]
    public Action<bool> NotifyAgree;

    [Token(Token = "0x600BACC")]
    [Address(RVA = "0x1E49670", Offset = "0x1E49670", VA = "0x1E49670")]
    public DataLinkageNotePopupPresenter(
      DataLinkageDataModel model,
      DataLinkageNotePopup view,
      Action<bool> notifyAgree = null)
    {
    }

    [Token(Token = "0x600BACD")]
    [Address(RVA = "0x1E496AC", Offset = "0x1E496AC", VA = "0x1E496AC", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BACE")]
    [Address(RVA = "0x1E496B0", Offset = "0x1E496B0", VA = "0x1E496B0", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x600BACF")]
    [Address(RVA = "0x1E496B4", Offset = "0x1E496B4", VA = "0x1E496B4", Slot = "6")]
    public void Agree()
    {
    }

    [Token(Token = "0x600BAD0")]
    [Address(RVA = "0x1E497BC", Offset = "0x1E497BC", VA = "0x1E497BC", Slot = "8")]
    public void Cancel()
    {
    }

    [Token(Token = "0x600BAD1")]
    [Address(RVA = "0x1E497D4", Offset = "0x1E497D4", VA = "0x1E497D4", Slot = "7")]
    public void NotAgree()
    {
    }
  }
}
