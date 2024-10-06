// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographDetailCenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036CF")]
  public class MnemnographDetailCenter : MonoBehaviour
  {
    [Token(Token = "0x400EEED")]
    [FieldOffset(Offset = "0x18")]
    [Header("念装画像")]
    [SerializeField]
    private Image _mnemnographImage;
    [Token(Token = "0x400EEEE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton _imageButton;
    [Token(Token = "0x400EEEF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("0:SR, 1:SSR, 2:UR")]
    private GameObject[] _rarityBgs;
    [Token(Token = "0x400EEF0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("カスタムスキル")]
    private CustomSkillIcon _customSkillIcon;
    [Token(Token = "0x400EEF1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text _customSkillName;
    [Token(Token = "0x400EEF2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject _customSkillAcquiredChecked;
    [Token(Token = "0x400EEF4")]
    [FieldOffset(Offset = "0x50")]
    private AssetCachedSpawner _assetCachedSpawner;

    [Token(Token = "0x17004770")]
    public Transform PopupParent
    {
      [Token(Token = "0x601592A"), Address(RVA = "0x1A64AA8", Offset = "0x1A64AA8", VA = "0x1A64AA8")] private get
      {
        return (Transform) null;
      }
      [Token(Token = "0x601592B"), Address(RVA = "0x1A64AB0", Offset = "0x1A64AB0", VA = "0x1A64AB0")] set
      {
      }
    }

    [Token(Token = "0x601592C")]
    [Address(RVA = "0x1A64AB8", Offset = "0x1A64AB8", VA = "0x1A64AB8")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601592D")]
    [Address(RVA = "0x1A64AC0", Offset = "0x1A64AC0", VA = "0x1A64AC0")]
    public void SetImageButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x601592E")]
    [Address(RVA = "0x1A64B10", Offset = "0x1A64B10", VA = "0x1A64B10")]
    public void SetImageRaycastTarget(bool raycastTarget)
    {
    }

    [Token(Token = "0x601592F")]
    [Address(RVA = "0x1A64B38", Offset = "0x1A64B38", VA = "0x1A64B38")]
    public void SetSkillButtonInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6015930")]
    [Address(RVA = "0x1A64B58", Offset = "0x1A64B58", VA = "0x1A64B58")]
    public void Show(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6015931")]
    [Address(RVA = "0x1A65014", Offset = "0x1A65014", VA = "0x1A65014")]
    public void Show(int masterId, bool isAcquired = false)
    {
    }

    [Token(Token = "0x6015932")]
    [Address(RVA = "0x1A64BE4", Offset = "0x1A64BE4", VA = "0x1A64BE4")]
    private void SetFrameRarity(RarityTypeEnum rarityType)
    {
    }

    [Token(Token = "0x6015933")]
    [Address(RVA = "0x1A64CC8", Offset = "0x1A64CC8", VA = "0x1A64CC8")]
    private void SetImage(int masterId)
    {
    }

    [Token(Token = "0x6015934")]
    [Address(RVA = "0x1A64E04", Offset = "0x1A64E04", VA = "0x1A64E04")]
    private void SetCustomSkill(int customSkillId)
    {
    }

    [Token(Token = "0x6015935")]
    [Address(RVA = "0x1A64FF4", Offset = "0x1A64FF4", VA = "0x1A64FF4")]
    private void SetCustomSkillAcquiredCheck(bool isAcquired)
    {
    }

    [Token(Token = "0x6015936")]
    [Address(RVA = "0x1A65108", Offset = "0x1A65108", VA = "0x1A65108")]
    public MnemnographDetailCenter()
    {
    }
  }
}
