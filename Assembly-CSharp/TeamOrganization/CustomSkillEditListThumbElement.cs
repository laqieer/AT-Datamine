// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillEditListThumbElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007A2")]
  public class CustomSkillEditListThumbElement : MonoBehaviour
  {
    [Token(Token = "0x400238F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CustomSkillEditListThumb[] thumbList;
    [Token(Token = "0x4002390")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject removeButtonParent;
    [Token(Token = "0x4002391")]
    [FieldOffset(Offset = "0x28")]
    private CustomSkillEditListPopup customSkillEditListPopup;

    [Token(Token = "0x6002B10")]
    [Address(RVA = "0x3505438", Offset = "0x3505438", VA = "0x3505438")]
    public void Initialize(
      int idx,
      CustomSkillEditListPopup.eCustomSkillListKind kind,
      CustomSkillEditListPopup customSkillEditListPopup,
      Action<int, CustomSkillEditListPopup.eCustomSkillListKind, bool> onClick,
      Action addLoadRequest,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002B11")]
    [Address(RVA = "0x3505378", Offset = "0x3505378", VA = "0x3505378")]
    public void SetActive(bool requestActive)
    {
    }

    [Token(Token = "0x6002B12")]
    [Address(RVA = "0x350A978", Offset = "0x350A978", VA = "0x350A978")]
    public void OnRemoveButton()
    {
    }

    [Token(Token = "0x6002B13")]
    [Address(RVA = "0x3504D60", Offset = "0x3504D60", VA = "0x3504D60")]
    public void SetThumbButtonOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6002B14")]
    [Address(RVA = "0x350347C", Offset = "0x350347C", VA = "0x350347C")]
    public void UpdateEquipUI()
    {
    }

    [Token(Token = "0x6002B15")]
    [Address(RVA = "0x350A990", Offset = "0x350A990", VA = "0x350A990")]
    private void Update()
    {
    }

    [Token(Token = "0x6002B16")]
    [Address(RVA = "0x3506E50", Offset = "0x3506E50", VA = "0x3506E50")]
    public CustomSkillEditListThumb GetSelectThumb(int idx) => (CustomSkillEditListThumb) null;

    [Token(Token = "0x6002B17")]
    [Address(RVA = "0x350AAE0", Offset = "0x350AAE0", VA = "0x350AAE0")]
    public CustomSkillEditListThumbElement()
    {
    }
  }
}
