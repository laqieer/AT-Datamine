// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.SkillWindowBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Skill.UI;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x200369D")]
  public class SkillWindowBase : MonoBehaviour
  {
    [Token(Token = "0x400ED84")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillInfoUI _skillInfo;

    [Token(Token = "0x60157B2")]
    [Address(RVA = "0x1A55B2C", Offset = "0x1A55B2C", VA = "0x1A55B2C", Slot = "4")]
    public virtual void Initialize(SkillModelBase skillModel, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x60157B3")]
    [Address(RVA = "0x1A55BEC", Offset = "0x1A55BEC", VA = "0x1A55BEC")]
    public void Initialize(EquipmentSkill skill, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x60157B4")]
    [Address(RVA = "0x1A55C80", Offset = "0x1A55C80", VA = "0x1A55C80")]
    public void Initialize(SkillDetailData skillDetail, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x60157B5")]
    [Address(RVA = "0x1A55C90", Offset = "0x1A55C90", VA = "0x1A55C90")]
    public void Initialize(
      SkillDetailData skillDetail,
      RarityTypeEnum rare,
      IAssetProvider assetProvider = null,
      Style style = null)
    {
    }

    [Token(Token = "0x60157B6")]
    [Address(RVA = "0x1A55D70", Offset = "0x1A55D70", VA = "0x1A55D70")]
    public void Initialize(
      int skillId,
      int level,
      RarityTypeEnum rare,
      IAssetProvider assetProvider = null,
      Style style = null)
    {
    }

    [Token(Token = "0x60157B7")]
    [Address(RVA = "0x1A55E40", Offset = "0x1A55E40", VA = "0x1A55E40")]
    public void Initialize(Style style, int skillId, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x60157B8")]
    [Address(RVA = "0x1A55F48", Offset = "0x1A55F48", VA = "0x1A55F48")]
    public void Initialize(Weapon weapon, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x60157B9")]
    [Address(RVA = "0x1A55F80", Offset = "0x1A55F80", VA = "0x1A55F80")]
    public void Initialize(Accessory accessory, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x60157BA")]
    [Address(RVA = "0x1A55FB8", Offset = "0x1A55FB8", VA = "0x1A55FB8")]
    public void Initialize(UnitTrust trust, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x60157BB")]
    [Address(RVA = "0x1A55FD0", Offset = "0x1A55FD0", VA = "0x1A55FD0")]
    public void Initialize(MindEquipment mindEquipment, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x60157BC")]
    [Address(RVA = "0x1A56008", Offset = "0x1A56008", VA = "0x1A56008")]
    public SkillWindowBase()
    {
    }
  }
}
