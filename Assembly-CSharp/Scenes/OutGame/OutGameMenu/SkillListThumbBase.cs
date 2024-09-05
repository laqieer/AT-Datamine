// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.SkillListThumbBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Common;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using System.Collections.Generic;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A4D")]
  public class SkillListThumbBase : MonoBehaviour
  {
    [Token(Token = "0x400FF5C")]
    public const int MAX_TAG = 2;
    [Token(Token = "0x400FF5D")]
    public const int MAX_SKILL_ICON_SUB = 8;
    [Token(Token = "0x400FF5E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected CommonButton button;
    [Token(Token = "0x400FF5F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected Image thumbnailImage;
    [Token(Token = "0x400FF60")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected Image rarityBaseImage;
    [Token(Token = "0x400FF61")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected GameObject[] rarityImage;
    [Token(Token = "0x400FF62")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected GameObject equipBadge;
    [Token(Token = "0x400FF63")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected Text nameText;
    [Token(Token = "0x400FF64")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    protected Text levelText;
    [Token(Token = "0x400FF65")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected Text typeText;
    [Token(Token = "0x400FF66")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    protected CustomSkillTypeIcon typeIcon;
    [Token(Token = "0x400FF67")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected GameObject tag1;
    [Token(Token = "0x400FF68")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    protected Text tag1Text;
    [Token(Token = "0x400FF69")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    protected GameObject tag2;
    [Token(Token = "0x400FF6A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    protected Text tag2Text;
    [Token(Token = "0x400FF6B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    protected GameObject latentBadge;
    [Token(Token = "0x400FF6C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    protected Text latentText;
    [Token(Token = "0x400FF6D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    protected GameObject grayoutObj;
    [Token(Token = "0x400FF6E")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    protected Text grayoutText;
    [Token(Token = "0x400FF6F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    protected GameObject lockObj;
    [Token(Token = "0x400FF70")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    protected FavoriteButton favoriteBadge;
    [Token(Token = "0x400FF71")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    protected SkillIconSub skillIconSub;
    [Token(Token = "0x400FF72")]
    [FieldOffset(Offset = "0xB8")]
    protected List<SkillIconSub> skillIconSubList;
    [Token(Token = "0x400FF73")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    protected GameObject emptySubSkillObj;
    [Token(Token = "0x400FF74")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private NewBadge newBadge;
    [Token(Token = "0x400FF75")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private SelectUpper selectUpper;
    [Token(Token = "0x400FF76")]
    [FieldOffset(Offset = "0xD8")]
    protected IAssetProvider assetProvider;

    [Token(Token = "0x6016E8A")]
    [Address(RVA = "0x29BC4C8", Offset = "0x29BC4C8", VA = "0x29BC4C8")]
    protected void Initialize(IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6016E8B")]
    [Address(RVA = "0x29BBD88", Offset = "0x29BBD88", VA = "0x29BBD88")]
    public void SetActiveFavorite(bool isEnabled)
    {
    }

    [Token(Token = "0x6016E8C")]
    [Address(RVA = "0x29BC4D0", Offset = "0x29BC4D0", VA = "0x29BC4D0")]
    public void SetFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x6016E8D")]
    [Address(RVA = "0x29BB204", Offset = "0x29BB204", VA = "0x29BB204")]
    public void SetActiveLatent(bool isEnabled)
    {
    }

    [Token(Token = "0x6016E8E")]
    [Address(RVA = "0x29BB29C", Offset = "0x29BB29C", VA = "0x29BB29C")]
    public void SetLatentText(int latent)
    {
    }

    [Token(Token = "0x6016E8F")]
    [Address(RVA = "0x29BB380", Offset = "0x29BB380", VA = "0x29BB380")]
    public void SetActiveGrayout(bool isEnabled)
    {
    }

    [Token(Token = "0x6016E90")]
    [Address(RVA = "0x29BC564", Offset = "0x29BC564", VA = "0x29BC564")]
    public void SetGrayoutText(string text)
    {
    }

    [Token(Token = "0x6016E91")]
    [Address(RVA = "0x29BB418", Offset = "0x29BB418", VA = "0x29BB418")]
    public void SetActiveLock(bool isEnable)
    {
    }

    [Token(Token = "0x6016E92")]
    [Address(RVA = "0x29BBBDC", Offset = "0x29BBBDC", VA = "0x29BBBDC")]
    protected void SetType(SkillTypeEnum skillType)
    {
    }

    [Token(Token = "0x6016E93")]
    [Address(RVA = "0x29BBD04", Offset = "0x29BBD04", VA = "0x29BBD04")]
    protected void EnableTag(int index, int skillTagType)
    {
    }

    [Token(Token = "0x6016E94")]
    [Address(RVA = "0x29BBCC4", Offset = "0x29BBCC4", VA = "0x29BBCC4")]
    protected void DisableTag(int index)
    {
    }

    [Token(Token = "0x6016E95")]
    [Address(RVA = "0x29BC604", Offset = "0x29BC604", VA = "0x29BC604")]
    private bool GetTagObject(out GameObject o_tag, out Text o_tagText, int index) => new bool();

    [Token(Token = "0x6016E96")]
    [Address(RVA = "0x29BBE1C", Offset = "0x29BBE1C", VA = "0x29BBE1C")]
    protected void InitializeSkillIconSub()
    {
    }

    [Token(Token = "0x6016E97")]
    [Address(RVA = "0x29BC648", Offset = "0x29BC648", VA = "0x29BC648")]
    protected void ResetSkillIconSub()
    {
    }

    [Token(Token = "0x6016E98")]
    [Address(RVA = "0x29BC274", Offset = "0x29BC274", VA = "0x29BC274")]
    protected void SetEmptySubSkillObjActive(bool isActive)
    {
    }

    [Token(Token = "0x6016E99")]
    [Address(RVA = "0x29BC7A8", Offset = "0x29BC7A8", VA = "0x29BC7A8")]
    protected SkillIconSub GetSkillIconSub() => (SkillIconSub) null;

    [Token(Token = "0x6016E9A")]
    [Address(RVA = "0x29BC06C", Offset = "0x29BC06C", VA = "0x29BC06C")]
    protected SkillIconSub GetSkillIconSub(int index) => (SkillIconSub) null;

    [Token(Token = "0x6016E9B")]
    [Address(RVA = "0x29BC930", Offset = "0x29BC930", VA = "0x29BC930")]
    protected void SetRarity(RarityTypeEnum rarityType)
    {
    }

    [Token(Token = "0x6016E9C")]
    [Address(RVA = "0x29BBB78", Offset = "0x29BBB78", VA = "0x29BBB78")]
    protected void DisableRarity()
    {
    }

    [Token(Token = "0x6016E9D")]
    [Address(RVA = "0x29BC984", Offset = "0x29BC984", VA = "0x29BC984")]
    protected void SetNew(bool isNew)
    {
    }

    [Token(Token = "0x6016E9E")]
    [Address(RVA = "0x29BCA18", Offset = "0x29BCA18", VA = "0x29BCA18")]
    public void SetIsSelected(bool isSelected)
    {
    }

    [Token(Token = "0x6016E9F")]
    [Address(RVA = "0x29BC42C", Offset = "0x29BC42C", VA = "0x29BC42C")]
    public SkillListThumbBase()
    {
    }
  }
}
