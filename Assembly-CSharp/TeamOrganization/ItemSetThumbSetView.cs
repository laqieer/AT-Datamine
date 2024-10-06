// Decompiled with JetBrains decompiler
// Type: TeamOrganization.ItemSetThumbSetView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000788")]
  public class ItemSetThumbSetView : MonoBehaviour
  {
    [Token(Token = "0x40022B9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemSetThumb[] itemSetThumbs;
    [Token(Token = "0x40022BA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject selectFrame;
    [Token(Token = "0x40022BB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] selectIcons;
    [Token(Token = "0x40022BC")]
    [FieldOffset(Offset = "0x30")]
    private ItemSetListPopup itemSetListPopup;
    [Token(Token = "0x40022BD")]
    [FieldOffset(Offset = "0x38")]
    private ItemSetEditView itemSetEditView;
    [Token(Token = "0x40022BE")]
    [FieldOffset(Offset = "0x40")]
    private int setIndex;

    [Token(Token = "0x6002A2A")]
    [Address(RVA = "0x34FE1C0", Offset = "0x34FE1C0", VA = "0x34FE1C0")]
    public void Initialized(ItemSetListPopup itemSetListPopup, int index)
    {
    }

    [Token(Token = "0x6002A2B")]
    [Address(RVA = "0x34FB5A4", Offset = "0x34FB5A4", VA = "0x34FB5A4")]
    public void Initialized(ItemSetEditView itemSetEditView)
    {
    }

    [Token(Token = "0x6002A2C")]
    [Address(RVA = "0x34FC118", Offset = "0x34FC118", VA = "0x34FC118")]
    public void UpdateThumb(IReadOnlyList<Expendable> expendables, bool isSelect)
    {
    }

    [Token(Token = "0x6002A2D")]
    [Address(RVA = "0x34FE350", Offset = "0x34FE350", VA = "0x34FE350")]
    public void ChangeSelect(bool isSelect)
    {
    }

    [Token(Token = "0x6002A2E")]
    [Address(RVA = "0x3500088", Offset = "0x3500088", VA = "0x3500088")]
    public void OnSelectSetButton()
    {
    }

    [Token(Token = "0x6002A2F")]
    [Address(RVA = "0x350010C", Offset = "0x350010C", VA = "0x350010C")]
    public void OnFrameButton(int index)
    {
    }

    [Token(Token = "0x6002A30")]
    [Address(RVA = "0x34FC2BC", Offset = "0x34FC2BC", VA = "0x34FC2BC")]
    public void ChangeSelectIcon(int index)
    {
    }

    [Token(Token = "0x6002A31")]
    [Address(RVA = "0x35001A0", Offset = "0x35001A0", VA = "0x35001A0")]
    public ItemSetThumbSetView()
    {
    }
  }
}
