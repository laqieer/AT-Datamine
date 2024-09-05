// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.ContainerSkillSideWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x200367B")]
  public class ContainerSkillSideWindow : SkillWindowBase
  {
    [Token(Token = "0x400ED00")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton _enhanceButton;
    [Token(Token = "0x400ED01")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image _noneImg;

    [Token(Token = "0x6015702")]
    [Address(RVA = "0x18E354C", Offset = "0x18E354C", VA = "0x18E354C", Slot = "4")]
    public override void Initialize(SkillModelBase skillModel, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x6015703")]
    [Address(RVA = "0x18E35CC", Offset = "0x18E35CC", VA = "0x18E35CC")]
    public void SetUnusedEnhance()
    {
    }

    [Token(Token = "0x6015704")]
    [Address(RVA = "0x18E361C", Offset = "0x18E361C", VA = "0x18E361C")]
    public void SetBlockRaycasts(bool enabled)
    {
    }

    [Token(Token = "0x6015705")]
    [Address(RVA = "0x18E356C", Offset = "0x18E356C", VA = "0x18E356C")]
    public void SetEnhanceNoneMask(bool none)
    {
    }

    [Token(Token = "0x6015706")]
    [Address(RVA = "0x18E36D8", Offset = "0x18E36D8", VA = "0x18E36D8")]
    public void SetEnhanceEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015707")]
    [Address(RVA = "0x18E3728", Offset = "0x18E3728", VA = "0x18E3728")]
    public void SetDisabledEnhanceButton(bool isDisabled)
    {
    }

    [Token(Token = "0x6015708")]
    [Address(RVA = "0x18E3748", Offset = "0x18E3748", VA = "0x18E3748")]
    public ContainerSkillSideWindow()
    {
    }
  }
}
