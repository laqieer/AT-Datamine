// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.UI.SkillInfoPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using Scenes.OutGame.Info.Common.UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Skill.UI
{
  [Token(Token = "0x2003588")]
  public class SkillInfoPopup : PopupBase
  {
    [Token(Token = "0x400E8AE")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private SkillDetailWindow skillDetail;
    [Token(Token = "0x400E8AF")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400E8B0")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400E8B1")]
    [FieldOffset(Offset = "0xA0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400E8B2")]
    [FieldOffset(Offset = "0xA8")]
    private IAssetProvider assetProvider;

    [Token(Token = "0x601504C")]
    [Address(RVA = "0x4AA689C", Offset = "0x4AA689C", VA = "0x4AA689C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601504D")]
    [Address(RVA = "0x4AA6D78", Offset = "0x4AA6D78", VA = "0x4AA6D78")]
    public void SetSkill(SkillModelBase model)
    {
    }

    [Token(Token = "0x601504E")]
    [Address(RVA = "0x4AA6DA0", Offset = "0x4AA6DA0", VA = "0x4AA6DA0")]
    private void Update()
    {
    }

    [Token(Token = "0x601504F")]
    [Address(RVA = "0x4AA6DBC", Offset = "0x4AA6DBC", VA = "0x4AA6DBC", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6015050")]
    [Address(RVA = "0x4AA6DC8", Offset = "0x4AA6DC8", VA = "0x4AA6DC8")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015051")]
    [Address(RVA = "0x4AA6DCC", Offset = "0x4AA6DCC", VA = "0x4AA6DCC")]
    public SkillInfoPopup()
    {
    }
  }
}
