// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillEditThumbSetView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007A3")]
  public class CustomSkillEditThumbSetView : MonoBehaviour
  {
    [Token(Token = "0x4002392")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CustomSkillEditListThumb[] skillEditThumbs;
    [Token(Token = "0x4002393")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CustomSkillEditListSelect[] selectIcons;
    [Token(Token = "0x4002394")]
    [FieldOffset(Offset = "0x28")]
    private CustomSkillEditView customSkillEditView;
    [Token(Token = "0x4002395")]
    [FieldOffset(Offset = "0x30")]
    private int selectIndex;
    [Token(Token = "0x4002396")]
    [FieldOffset(Offset = "0x38")]
    private Action addLoadRequest;
    [Token(Token = "0x4002397")]
    [FieldOffset(Offset = "0x40")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6002B18")]
    [Address(RVA = "0x350AAE8", Offset = "0x350AAE8", VA = "0x350AAE8")]
    public void Initialized(
      CustomSkillEditView customSkillEditView,
      Action addLoadRequest,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002B19")]
    [Address(RVA = "0x350ABE0", Offset = "0x350ABE0", VA = "0x350ABE0")]
    public void UpdateThumb(int unlockSlotNum, IReadOnlyList<CustomSkill> customSkills)
    {
    }

    [Token(Token = "0x6002B1A")]
    [Address(RVA = "0x350AE10", Offset = "0x350AE10", VA = "0x350AE10")]
    public void OnFrameButton(int index)
    {
    }

    [Token(Token = "0x6002B1B")]
    [Address(RVA = "0x350AF3C", Offset = "0x350AF3C", VA = "0x350AF3C")]
    public void ChangeSelectIcon(int index)
    {
    }

    [Token(Token = "0x6002B1C")]
    [Address(RVA = "0x350AFC4", Offset = "0x350AFC4", VA = "0x350AFC4")]
    public CustomSkillEditThumbSetView()
    {
    }
  }
}
