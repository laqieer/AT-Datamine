// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.ExpeditionStatus.ExpeditionEquipmentRaw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.ExpeditionStatus
{
  [Token(Token = "0x2002CF7")]
  public class ExpeditionEquipmentRaw : MonoBehaviour
  {
    [Token(Token = "0x400C078")]
    [FieldOffset(Offset = "0x18")]
    private Scenes.Expedition.ExpeditionStatus.ExpeditionStatus expeditionStatus;
    [Token(Token = "0x400C079")]
    [FieldOffset(Offset = "0x20")]
    private Equipment equipment;
    [Token(Token = "0x400C07A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image equipmentImage;
    [Token(Token = "0x400C07B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text equipmentNameText;

    [Token(Token = "0x601199B")]
    [Address(RVA = "0x46A4580", Offset = "0x46A4580", VA = "0x46A4580")]
    public void Init(Equipment inputEquipment, Scenes.Expedition.ExpeditionStatus.ExpeditionStatus inputExpeditionStatus)
    {
    }

    [Token(Token = "0x601199C")]
    [Address(RVA = "0x46A45C8", Offset = "0x46A45C8", VA = "0x46A45C8")]
    public void Init(AccessoriesData inputAccessories, Scenes.Expedition.ExpeditionStatus.ExpeditionStatus inputExpeditionStatus)
    {
    }

    [Token(Token = "0x601199D")]
    [Address(RVA = "0x46A4610", Offset = "0x46A4610", VA = "0x46A4610")]
    public void OnClickIcon()
    {
    }

    [Token(Token = "0x601199E")]
    [Address(RVA = "0x46A4658", Offset = "0x46A4658", VA = "0x46A4658")]
    public ExpeditionEquipmentRaw()
    {
    }
  }
}
