// Decompiled with JetBrains decompiler
// Type: Scenes.Information.InformationList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.RawData;
using HTMLViewer;
using Il2CppDummyDll;
using Network.Param;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Information
{
  [Token(Token = "0x2002AB4")]
  public class InformationList : MonoBehaviour
  {
    [Token(Token = "0x400B5B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject nonReadBadge;
    [Token(Token = "0x400B5B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400B5B5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image tagImage;
    [Token(Token = "0x400B5B6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI timeStamp;
    [Token(Token = "0x400B5B7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text text;
    [Token(Token = "0x400B5B8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400B5B9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RawImage bannerImage;
    [Token(Token = "0x400B5BA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private LayoutElement bannerLayoutElement;
    [Token(Token = "0x400B5BB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject tagOther;
    [Token(Token = "0x400B5BC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject tagPrivate;
    [Token(Token = "0x400B5BD")]
    [FieldOffset(Offset = "0x68")]
    [Header("InformationEnumのCategory順に入れること")]
    [SerializeField]
    private GameObject[] otherTags;

    [Token(Token = "0x6010B28")]
    [Address(RVA = "0x4BD3094", Offset = "0x4BD3094", VA = "0x4BD3094")]
    public void Initialize(OfficialInformationArticleType article, bool isRead, Action onClick)
    {
    }

    [Token(Token = "0x6010B29")]
    [Address(RVA = "0x4BD344C", Offset = "0x4BD344C", VA = "0x4BD344C")]
    public void Initialize(OfficialMessageArticleType article, bool isRead, Action onClick)
    {
    }

    [Token(Token = "0x6010B2A")]
    [Address(RVA = "0x4BD37A4", Offset = "0x4BD37A4", VA = "0x4BD37A4")]
    public void SetActive(bool isEnabled)
    {
    }

    [Token(Token = "0x6010B2B")]
    [Address(RVA = "0x4BD338C", Offset = "0x4BD338C", VA = "0x4BD338C")]
    private void UpdateTag(HeaderTypeEnum headerType, bool isMessage)
    {
    }

    [Token(Token = "0x6010B2C")]
    [Address(RVA = "0x4BD37CC", Offset = "0x4BD37CC", VA = "0x4BD37CC")]
    public void SetupBanner(RawTextureHandle texture)
    {
    }

    [Token(Token = "0x6010B2D")]
    [Address(RVA = "0x4BD3884", Offset = "0x4BD3884", VA = "0x4BD3884")]
    public InformationList()
    {
    }
  }
}
