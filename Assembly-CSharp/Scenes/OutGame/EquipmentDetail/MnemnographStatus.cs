// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.Utility;
using StaqData;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036F1")]
  public class MnemnographStatus : MonoBehaviour
  {
    [Token(Token = "0x400EFC7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] limitBreakGems;
    [Token(Token = "0x400EFC8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text lvNumText;
    [Token(Token = "0x400EFC9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text lvMaxText;
    [Token(Token = "0x400EFCA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GaugeScale expSlider;
    [Token(Token = "0x400EFCB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text combatPoserText;
    [Token(Token = "0x400EFCC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text hpText;
    [Token(Token = "0x400EFCD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text phyAttackText;
    [Token(Token = "0x400EFCE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text magicAttackText;
    [Token(Token = "0x400EFCF")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text phyDefText;
    [Token(Token = "0x400EFD0")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text magicDefText;
    [Token(Token = "0x400EFD1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text hitText;
    [Token(Token = "0x400EFD2")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text avoidText;
    [Token(Token = "0x400EFD3")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text criticalText;
    [Token(Token = "0x400EFD4")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text criticalAvoidText;
    [Token(Token = "0x400EFD5")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private DetailSkillListThumb partySkill;
    [Token(Token = "0x400EFD6")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text partySkillDescription;
    [Token(Token = "0x400EFD7")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400EFD9")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400EFDA")]
    [FieldOffset(Offset = "0xA8")]
    private MindEquipment mindEquipment;

    [Token(Token = "0x17004795")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x6015A32"), Address(RVA = "0x1D802DC", Offset = "0x1D802DC", VA = "0x1D802DC")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x6015A33"), Address(RVA = "0x1D802E4", Offset = "0x1D802E4", VA = "0x1D802E4")] set
      {
      }
    }

    [Token(Token = "0x17004796")]
    public IMnemnographStatusMediator Mediator
    {
      [Token(Token = "0x6015A34"), Address(RVA = "0x1D802EC", Offset = "0x1D802EC", VA = "0x1D802EC")] private get
      {
        return (IMnemnographStatusMediator) null;
      }
      [Token(Token = "0x6015A35"), Address(RVA = "0x1D802F4", Offset = "0x1D802F4", VA = "0x1D802F4")] set
      {
      }
    }

    [Token(Token = "0x6015A36")]
    [Address(RVA = "0x1D7BA64", Offset = "0x1D7BA64", VA = "0x1D7BA64")]
    public void Initialized(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6015A37")]
    [Address(RVA = "0x1D7D4BC", Offset = "0x1D7D4BC", VA = "0x1D7D4BC")]
    public void UpdateStatus(MindEquipment mindEquipment, int level)
    {
    }

    [Token(Token = "0x6015A38")]
    [Address(RVA = "0x1D80304", Offset = "0x1D80304", VA = "0x1D80304")]
    public void UpdateStatus(MindEquipment mindEquipment, MindStandardStatus assumption = null)
    {
    }

    [Token(Token = "0x6015A39")]
    [Address(RVA = "0x1D808D8", Offset = "0x1D808D8", VA = "0x1D808D8")]
    private static int CalcCombatPower(MindEquipment mindEquipment, MindStandardStatus assumption)
    {
      return new int();
    }

    [Token(Token = "0x6015A3A")]
    [Address(RVA = "0x1D808B8", Offset = "0x1D808B8", VA = "0x1D808B8")]
    public static int CalcCombatPower(MindEquipment mindEquipment) => new int();

    [Token(Token = "0x6015A3B")]
    [Address(RVA = "0x1D808EC", Offset = "0x1D808EC", VA = "0x1D808EC")]
    public void OnClickToOpenAddedStauts()
    {
    }

    [Token(Token = "0x6015A3C")]
    [Address(RVA = "0x1D809D4", Offset = "0x1D809D4", VA = "0x1D809D4")]
    public MnemnographStatus()
    {
    }
  }
}
