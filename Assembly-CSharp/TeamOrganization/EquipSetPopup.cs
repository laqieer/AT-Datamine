// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007C3")]
  public class EquipSetPopup : MonoBehaviour
  {
    [Token(Token = "0x4002445")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x4002446")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x4002447")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button setOverrideButton;
    [Token(Token = "0x4002448")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button setLoadButton;
    [Token(Token = "0x4002449")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private EquipSetView equipSetSelectView;
    [Token(Token = "0x400244A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private EquipSetView equipSetSeveView;
    [Token(Token = "0x400244B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button statusButtonDefalutButtonj;
    [Token(Token = "0x400244C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject statusButtonClickObj;
    [Token(Token = "0x400244D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button skillButtonDefalutButton;
    [Token(Token = "0x400244E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject skillButtonClickObj;
    [Token(Token = "0x400244F")]
    private const string InoutTimeLineAssetbundleName = "ui_common_timeline";
    [Token(Token = "0x4002450")]
    private const string TimeLineAssetbundleName = "Com_Popup_Base";
    [Token(Token = "0x4002451")]
    [FieldOffset(Offset = "0x68")]
    private Action<bool, bool> closeAction;
    [Token(Token = "0x4002452")]
    [FieldOffset(Offset = "0x70")]
    private OrganizationPartySlot organizationPartySlot;
    [Token(Token = "0x4002453")]
    [FieldOffset(Offset = "0x78")]
    private OrganizationPartySlot sevePartySlot;
    [Token(Token = "0x4002454")]
    [FieldOffset(Offset = "0x80")]
    private bool isNeedLp;
    [Token(Token = "0x4002455")]
    [FieldOffset(Offset = "0x88")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6002BF2")]
    [Address(RVA = "0x3875D20", Offset = "0x3875D20", VA = "0x3875D20")]
    public void Initialized(bool isNeedLp, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002BF3")]
    [Address(RVA = "0x387634C", Offset = "0x387634C", VA = "0x387634C")]
    public void OnEquipSetEditButton()
    {
    }

    [Token(Token = "0x6002BF4")]
    [Address(RVA = "0x3876568", Offset = "0x3876568", VA = "0x3876568")]
    public void SetCloseAction(Action<bool, bool> closeAction)
    {
    }

    [Token(Token = "0x6002BF5")]
    [Address(RVA = "0x3876570", Offset = "0x3876570", VA = "0x3876570")]
    private void OnStatusButton()
    {
    }

    [Token(Token = "0x6002BF6")]
    [Address(RVA = "0x38766C4", Offset = "0x38766C4", VA = "0x38766C4")]
    private void OnSkillButton()
    {
    }

    [Token(Token = "0x6002BF7")]
    [Address(RVA = "0x387675C", Offset = "0x387675C", VA = "0x387675C")]
    public void Open(OrganizationPartySlot organizationPartySlot)
    {
    }

    [Token(Token = "0x6002BF8")]
    [Address(RVA = "0x38763EC", Offset = "0x38763EC", VA = "0x38763EC")]
    public void Close(bool isOverridePartySlot, bool isOpenEdit)
    {
    }

    [Token(Token = "0x6002BF9")]
    [Address(RVA = "0x3876BCC", Offset = "0x3876BCC", VA = "0x3876BCC")]
    private void OnSetOverrideButton()
    {
    }

    [Token(Token = "0x6002BFA")]
    [Address(RVA = "0x3877288", Offset = "0x3877288", VA = "0x3877288")]
    protected IEnumerator ConnectAPIUnitEquipmentSet(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6002BFB")]
    [Address(RVA = "0x3877324", Offset = "0x3877324", VA = "0x3877324")]
    private void OnFinishConnect()
    {
    }

    [Token(Token = "0x6002BFC")]
    [Address(RVA = "0x3877330", Offset = "0x3877330", VA = "0x3877330")]
    private void OnSetLoadButton()
    {
    }

    [Token(Token = "0x6002BFD")]
    [Address(RVA = "0x387733C", Offset = "0x387733C", VA = "0x387733C")]
    public EquipSetPopup()
    {
    }
  }
}
