// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.GetCustomSkillViewCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036C9")]
  public class GetCustomSkillViewCell : MonoBehaviour
  {
    [Token(Token = "0x400EEC9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text customSkillNameText;
    [Token(Token = "0x400EECA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400EECB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject equipmentImage;
    [Token(Token = "0x400EECC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x400EECD")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400EECE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image[] rarityImage;
    [Token(Token = "0x400EECF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private LongPressButton customSkillButton;
    [Token(Token = "0x400EED0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GetCustomSkillViewCellMindequipmentThumb mindequipmentThumb;
    [Token(Token = "0x400EED1")]
    [FieldOffset(Offset = "0x50")]
    private bool isInitialized;
    [Token(Token = "0x400EED2")]
    [FieldOffset(Offset = "0x54")]
    private int skillId;

    [Token(Token = "0x601590F")]
    [Address(RVA = "0x1A62DA4", Offset = "0x1A62DA4", VA = "0x1A62DA4")]
    public void Initialize(int mindequipID, int customSkillID)
    {
    }

    [Token(Token = "0x6015910")]
    [Address(RVA = "0x1A642B0", Offset = "0x1A642B0", VA = "0x1A642B0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6015911")]
    [Address(RVA = "0x1A642E0", Offset = "0x1A642E0", VA = "0x1A642E0")]
    private IEnumerator LoadWaitthumb() => (IEnumerator) null;

    [Token(Token = "0x6015912")]
    [Address(RVA = "0x1A64370", Offset = "0x1A64370", VA = "0x1A64370")]
    public GetCustomSkillViewCell()
    {
    }
  }
}
