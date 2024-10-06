// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.SkillDetailWindowPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x200369C")]
  public class SkillDetailWindowPresenter : MonoBehaviour
  {
    [Token(Token = "0x400ED80")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillDetailWindow _view;
    [Token(Token = "0x400ED82")]
    [FieldOffset(Offset = "0x28")]
    private SkillDetailWindowModel _model;
    [Token(Token = "0x400ED83")]
    [FieldOffset(Offset = "0x30")]
    private IAssetProvider _assetProvider;

    [Token(Token = "0x1700473E")]
    public Action OnClose
    {
      [Token(Token = "0x60157A7"), Address(RVA = "0x18E9404", Offset = "0x18E9404", VA = "0x18E9404")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60157A8"), Address(RVA = "0x18E940C", Offset = "0x18E940C", VA = "0x18E940C")] set
      {
      }
    }

    [Token(Token = "0x60157A9")]
    [Address(RVA = "0x18E8B90", Offset = "0x18E8B90", VA = "0x18E8B90")]
    public void InitializeAsDetail(EquipmentSkill skill, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x60157AA")]
    [Address(RVA = "0x18E8D08", Offset = "0x18E8D08", VA = "0x18E8D08")]
    public void InitializeAsDetail(
      int skillID,
      int level,
      RarityTypeEnum rare,
      IAssetProvider assetProvider,
      Style style = null)
    {
    }

    [Token(Token = "0x60157AB")]
    [Address(RVA = "0x18E8E88", Offset = "0x18E8E88", VA = "0x18E8E88")]
    public void InitializeAsDetail(Style style, int skillID, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x60157AC")]
    [Address(RVA = "0x18E8FE8", Offset = "0x18E8FE8", VA = "0x18E8FE8")]
    public void InitilizeAsLvChangeInfo(EquipmentSkill skill, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x60157AD")]
    [Address(RVA = "0x18E9414", Offset = "0x18E9414", VA = "0x18E9414")]
    private void UpdateViewLvChangeInfo()
    {
    }

    [Token(Token = "0x60157AE")]
    [Address(RVA = "0x18E94E8", Offset = "0x18E94E8", VA = "0x18E94E8")]
    private void Close()
    {
    }

    [Token(Token = "0x60157AF")]
    [Address(RVA = "0x18E9504", Offset = "0x18E9504", VA = "0x18E9504")]
    public SkillDetailWindowPresenter()
    {
    }
  }
}
