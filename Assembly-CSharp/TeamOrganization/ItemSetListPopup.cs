// Decompiled with JetBrains decompiler
// Type: TeamOrganization.ItemSetListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000783")]
  public class ItemSetListPopup : PopupBase
  {
    [Token(Token = "0x4002279")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400227A")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Button setEditButton;
    [Token(Token = "0x400227B")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Button setLoadButton;
    [Token(Token = "0x400227C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private ItemSetThumbSetView[] itemSetThumbs;
    [Token(Token = "0x400227D")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400227E")]
    [FieldOffset(Offset = "0xA8")]
    private readonly string[] thumbBaseAssetName;
    [Token(Token = "0x400227F")]
    [FieldOffset(Offset = "0xB0")]
    private Coroutine loadAssetBundleCoroutine;
    [Token(Token = "0x4002280")]
    [FieldOffset(Offset = "0xB8")]
    private List<Expendable>[] loadWaitList;
    [Token(Token = "0x4002281")]
    [FieldOffset(Offset = "0xC0")]
    private int loadWaitIdOfs;
    [Token(Token = "0x4002282")]
    [FieldOffset(Offset = "0xC8")]
    private Action<bool, int, bool> closeAction;
    [Token(Token = "0x4002283")]
    [FieldOffset(Offset = "0xD0")]
    private int selectSetIndex;
    [Token(Token = "0x4002284")]
    [FieldOffset(Offset = "0xD8")]
    private OrganizationTeam organizationTeam;

    [Token(Token = "0x60029FB")]
    [Address(RVA = "0x34FD874", Offset = "0x34FD874", VA = "0x34FD874")]
    public void Initialized()
    {
    }

    [Token(Token = "0x60029FC")]
    [Address(RVA = "0x34FDAE4", Offset = "0x34FDAE4", VA = "0x34FDAE4")]
    public void OnSetEditButton()
    {
    }

    [Token(Token = "0x60029FD")]
    [Address(RVA = "0x34FDC80", Offset = "0x34FDC80", VA = "0x34FDC80")]
    public void SetCloseAction(Action<bool, int, bool> closeAction)
    {
    }

    [Token(Token = "0x60029FE")]
    [Address(RVA = "0x34FDC88", Offset = "0x34FDC88", VA = "0x34FDC88")]
    public void Open(OrganizationTeam organizationTeam)
    {
    }

    [Token(Token = "0x60029FF")]
    [Address(RVA = "0x34FDC24", Offset = "0x34FDC24", VA = "0x34FDC24")]
    public void Close(bool isOverrideItemSet, bool isOpenItemSetEdit)
    {
    }

    [Token(Token = "0x6002A00")]
    [Address(RVA = "0x34FE294", Offset = "0x34FE294", VA = "0x34FE294")]
    private void OnSetLoadButton()
    {
    }

    [Token(Token = "0x6002A01")]
    [Address(RVA = "0x34FE2A0", Offset = "0x34FE2A0", VA = "0x34FE2A0")]
    public void OnSelect(int index)
    {
    }

    [Token(Token = "0x6002A02")]
    [Address(RVA = "0x34FE370", Offset = "0x34FE370", VA = "0x34FE370")]
    public void AddThumbAssetBundle(Expendable expendable)
    {
    }

    [Token(Token = "0x6002A03")]
    [Address(RVA = "0x34FE22C", Offset = "0x34FE22C", VA = "0x34FE22C")]
    public IEnumerator SetLoadThumbAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6002A04")]
    [Address(RVA = "0x34FE460", Offset = "0x34FE460", VA = "0x34FE460")]
    public string GetAseetBundleName(Expendable expendable) => (string) null;

    [Token(Token = "0x6002A05")]
    [Address(RVA = "0x34FE47C", Offset = "0x34FE47C", VA = "0x34FE47C")]
    public string GetAseetName(Expendable expendable) => (string) null;

    [Token(Token = "0x6002A06")]
    [Address(RVA = "0x34FE498", Offset = "0x34FE498", VA = "0x34FE498")]
    public Sprite GetRarityBaseImage(Expendable expendable) => (Sprite) null;

    [Token(Token = "0x6002A07")]
    [Address(RVA = "0x34FE594", Offset = "0x34FE594", VA = "0x34FE594")]
    public ItemSetListPopup()
    {
    }
  }
}
