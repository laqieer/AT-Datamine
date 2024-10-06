// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillEditListThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200079F")]
  public class CustomSkillEditListThumb : SkillListThumbBase
  {
    [Token(Token = "0x400237D")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject emptyObject;
    [Token(Token = "0x400237E")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject unlockObject;
    [Token(Token = "0x400237F")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private CanvasGroup equipCanvasGroup;
    [Token(Token = "0x4002380")]
    [FieldOffset(Offset = "0xF8")]
    private Action<int> onSelectAction;
    [Token(Token = "0x4002381")]
    [FieldOffset(Offset = "0x100")]
    public CustomSkill customSkill;
    [Token(Token = "0x4002382")]
    [FieldOffset(Offset = "0x108")]
    private bool isNew;
    [Token(Token = "0x4002383")]
    [FieldOffset(Offset = "0x109")]
    public bool use;
    [Token(Token = "0x4002385")]
    [FieldOffset(Offset = "0x110")]
    private CustomSkillEditListPopup.eCustomSkillListKind itemKind;
    [Token(Token = "0x4002386")]
    [FieldOffset(Offset = "0x118")]
    private CustomSkillEditListPopup customSkillEditListPopup;
    [Token(Token = "0x4002387")]
    [FieldOffset(Offset = "0x120")]
    private CustomSkillEditView customSkillEditView;
    [Token(Token = "0x4002388")]
    [FieldOffset(Offset = "0x128")]
    private Action addLoadRequest;
    [Token(Token = "0x4002389")]
    [FieldOffset(Offset = "0x130")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400238A")]
    [FieldOffset(Offset = "0x138")]
    public bool onDisp;

    [Token(Token = "0x17000672")]
    public CommonButton Button
    {
      [Token(Token = "0x6002AFB"), Address(RVA = "0x3509540", Offset = "0x3509540", VA = "0x3509540")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x17000673")]
    public int itemIndex
    {
      [Token(Token = "0x6002AFC"), Address(RVA = "0x3509548", Offset = "0x3509548", VA = "0x3509548")] get
      {
        return new int();
      }
      [Token(Token = "0x6002AFD"), Address(RVA = "0x3509550", Offset = "0x3509550", VA = "0x3509550")] private set
      {
      }
    }

    [Token(Token = "0x6002AFE")]
    [Address(RVA = "0x3509558", Offset = "0x3509558", VA = "0x3509558")]
    public void Initialize(
      int idx,
      CustomSkillEditListPopup customSkillEditListPopup,
      CustomSkillEditListPopup.eCustomSkillListKind kind,
      CustomSkillEditListPopup.ThumbData thumbData,
      Action<int, CustomSkillEditListPopup.eCustomSkillListKind, bool> onClick,
      Action addLoadRequest,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002AFF")]
    [Address(RVA = "0x3509F84", Offset = "0x3509F84", VA = "0x3509F84")]
    public void Initialize(
      int index,
      CustomSkillEditView skillEditView,
      Action<int> onSelectAction,
      Action addLoadRequest,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002B00")]
    [Address(RVA = "0x350A0B8", Offset = "0x350A0B8", VA = "0x350A0B8")]
    public void OnSelect()
    {
    }

    [Token(Token = "0x6002B01")]
    [Address(RVA = "0x350A0D8", Offset = "0x350A0D8", VA = "0x350A0D8")]
    public void UpdateThumb(CustomSkill customSkill, bool isUnlock)
    {
    }

    [Token(Token = "0x6002B02")]
    [Address(RVA = "0x350A0E8", Offset = "0x350A0E8", VA = "0x350A0E8")]
    public void NonSetCustomSkillThumb(bool isUnlock)
    {
    }

    [Token(Token = "0x6002B03")]
    [Address(RVA = "0x3503E98", Offset = "0x3503E98", VA = "0x3503E98")]
    public void UpdateNew(bool enable)
    {
    }

    [Token(Token = "0x6002B04")]
    [Address(RVA = "0x3509774", Offset = "0x3509774", VA = "0x3509774")]
    private void UpdateView(bool isUnlock)
    {
    }

    [Token(Token = "0x6002B05")]
    [Address(RVA = "0x350A2AC", Offset = "0x350A2AC", VA = "0x350A2AC")]
    public void UpdateEquipUI()
    {
    }

    [Token(Token = "0x6002B06")]
    [Address(RVA = "0x350A4A0", Offset = "0x350A4A0", VA = "0x350A4A0")]
    private List<UniqueID> GetSetUniqueIds() => (List<UniqueID>) null;

    [Token(Token = "0x6002B07")]
    [Address(RVA = "0x350A5D0", Offset = "0x350A5D0", VA = "0x350A5D0")]
    public void OnLockButton()
    {
    }

    [Token(Token = "0x6002B08")]
    [Address(RVA = "0x350A724", Offset = "0x350A724", VA = "0x350A724")]
    public CustomSkillEditListThumb()
    {
    }
  }
}
