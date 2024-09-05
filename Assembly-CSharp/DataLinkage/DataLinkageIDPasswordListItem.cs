// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkageIDPasswordListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DataLinkage.IDPassword;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F91")]
  public class DataLinkageIDPasswordListItem : DataLinkageListItem
  {
    [Token(Token = "0x40086F4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text textID;
    [Token(Token = "0x40086F5")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button buttonIDCopy;
    [Token(Token = "0x40086F6")]
    [FieldOffset(Offset = "0x70")]
    public Action OnIDCopyButtonClickCallback;
    [Token(Token = "0x40086F7")]
    [FieldOffset(Offset = "0x78")]
    private IIDPasswordLinkagePresenter presenter;

    [Token(Token = "0x170026CE")]
    public IIDPasswordLinkagePresenter Presenter
    {
      [Token(Token = "0x600BB5C"), Address(RVA = "0x1E4AC54", Offset = "0x1E4AC54", VA = "0x1E4AC54")] set
      {
      }
    }

    [Token(Token = "0x600BB5D")]
    [Address(RVA = "0x1E4CC0C", Offset = "0x1E4CC0C", VA = "0x1E4CC0C")]
    public void Initialize(string title, string id)
    {
    }

    [Token(Token = "0x600BB5E")]
    [Address(RVA = "0x1E4CD20", Offset = "0x1E4CD20", VA = "0x1E4CD20", Slot = "4")]
    public override void Initialize(string title)
    {
    }

    [Token(Token = "0x600BB5F")]
    [Address(RVA = "0x1E4CC60", Offset = "0x1E4CC60", VA = "0x1E4CC60")]
    public void SetID(string id)
    {
    }

    [Token(Token = "0x600BB60")]
    [Address(RVA = "0x1E4CDC4", Offset = "0x1E4CDC4", VA = "0x1E4CDC4")]
    private void OnCopyButtonClick()
    {
    }

    [Token(Token = "0x600BB61")]
    [Address(RVA = "0x1E4CE64", Offset = "0x1E4CE64", VA = "0x1E4CE64")]
    public DataLinkageIDPasswordListItem()
    {
    }
  }
}
