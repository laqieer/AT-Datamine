// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkageListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F6E")]
  public class DataLinkageListItem : MonoBehaviour
  {
    [Token(Token = "0x4008695")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text textTitle;
    [Token(Token = "0x4008696")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button buttonRelease;
    [Token(Token = "0x4008697")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button buttonLinkedInTitleScene;
    [Token(Token = "0x4008698")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button buttonLinked;
    [Token(Token = "0x4008699")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button buttonLinkage;
    [Token(Token = "0x400869A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ContentDataLinkageIcon contentDataLinkIcon;
    [Token(Token = "0x400869B")]
    [FieldOffset(Offset = "0x48")]
    public Action OnReleaseButtonClickCallback;
    [Token(Token = "0x400869C")]
    [FieldOffset(Offset = "0x50")]
    public Action OnLinkageButtonClickCallback;
    [Token(Token = "0x400869D")]
    [FieldOffset(Offset = "0x58")]
    private IDataLinkagePresenter presenter;

    [Token(Token = "0x170026B6")]
    public IDataLinkagePresenter Presenter
    {
      [Token(Token = "0x600BA8D"), Address(RVA = "0x1E47458", Offset = "0x1E47458", VA = "0x1E47458")] set
      {
      }
    }

    [Token(Token = "0x600BA8E")]
    [Address(RVA = "0x1E47500", Offset = "0x1E47500", VA = "0x1E47500", Slot = "4")]
    public virtual void Initialize(string title)
    {
    }

    [Token(Token = "0x600BA8F")]
    [Address(RVA = "0x1E477E0", Offset = "0x1E477E0", VA = "0x1E477E0", Slot = "5")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x600BA90")]
    [Address(RVA = "0x1E4788C", Offset = "0x1E4788C", VA = "0x1E4788C")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x600BA91")]
    [Address(RVA = "0x1E478B0", Offset = "0x1E478B0", VA = "0x1E478B0")]
    public void SetupForApple()
    {
    }

    [Token(Token = "0x600BA92")]
    [Address(RVA = "0x1E47954", Offset = "0x1E47954", VA = "0x1E47954")]
    public void SetupForGoogle()
    {
    }

    [Token(Token = "0x600BA93")]
    [Address(RVA = "0x1E479F8", Offset = "0x1E479F8", VA = "0x1E479F8")]
    public void SetupForFacebook()
    {
    }

    [Token(Token = "0x600BA94")]
    [Address(RVA = "0x1E47A9C", Offset = "0x1E47A9C", VA = "0x1E47A9C")]
    public void SetupForIDPassword()
    {
    }

    [Token(Token = "0x600BA95")]
    [Address(RVA = "0x1E47B30", Offset = "0x1E47B30", VA = "0x1E47B30")]
    public void SetupForFgGID()
    {
    }

    [Token(Token = "0x600BA96")]
    [Address(RVA = "0x1E47BC4", Offset = "0x1E47BC4", VA = "0x1E47BC4")]
    public void SetIsLinked(bool isLinked, bool isReleasable = true)
    {
    }

    [Token(Token = "0x600BA97")]
    [Address(RVA = "0x1E47C94", Offset = "0x1E47C94", VA = "0x1E47C94")]
    public void SetIsLinkedForTitleScene(bool isLinked)
    {
    }

    [Token(Token = "0x600BA98")]
    [Address(RVA = "0x1E47D34", Offset = "0x1E47D34", VA = "0x1E47D34")]
    private void OnReleaseButtonClicked()
    {
    }

    [Token(Token = "0x600BA99")]
    [Address(RVA = "0x1E47DD8", Offset = "0x1E47DD8", VA = "0x1E47DD8")]
    private void OnLinkageButtonClicked()
    {
    }

    [Token(Token = "0x600BA9A")]
    [Address(RVA = "0x1E47E78", Offset = "0x1E47E78", VA = "0x1E47E78")]
    private void OnLinkedButtonClicked()
    {
    }

    [Token(Token = "0x600BA9B")]
    [Address(RVA = "0x1E47F1C", Offset = "0x1E47F1C", VA = "0x1E47F1C")]
    private void OnLinkedTitleButtonClicked()
    {
    }

    [Token(Token = "0x600BA9C")]
    [Address(RVA = "0x1E47FBC", Offset = "0x1E47FBC", VA = "0x1E47FBC")]
    public DataLinkageListItem()
    {
    }
  }
}
