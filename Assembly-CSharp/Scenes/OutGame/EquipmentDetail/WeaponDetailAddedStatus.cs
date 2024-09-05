// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponDetailAddedStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using StaqData;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003676")]
  public class WeaponDetailAddedStatus : MonoBehaviour
  {
    [Token(Token = "0x400ECF2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private WeaponDetailAddedStatusTitle weaponDetailAddedStatusTitle;
    [Token(Token = "0x400ECF3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private WeaponDetailAddedStatusContent weaponDetailAddedStatusContent;
    [Token(Token = "0x400ECF4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400ECF5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x400ECF6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BtnFullScreen bgButton;
    [Token(Token = "0x400ECF7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x60156EE")]
    [Address(RVA = "0x18E0A00", Offset = "0x18E0A00", VA = "0x18E0A00")]
    public void Initialize(Equipment equipmentData, Equipment assumption = null)
    {
    }

    [Token(Token = "0x60156EF")]
    [Address(RVA = "0x18E29A8", Offset = "0x18E29A8", VA = "0x18E29A8")]
    public void Close()
    {
    }

    [Token(Token = "0x60156F0")]
    [Address(RVA = "0x18E2A14", Offset = "0x18E2A14", VA = "0x18E2A14")]
    private void CreateTitle(string displayName)
    {
    }

    [Token(Token = "0x60156F1")]
    [Address(RVA = "0x18E2B00", Offset = "0x18E2B00", VA = "0x18E2B00")]
    private void CreateItem(string displayName, int num, int? assume)
    {
    }

    [Token(Token = "0x60156F2")]
    [Address(RVA = "0x18E2ED8", Offset = "0x18E2ED8", VA = "0x18E2ED8")]
    private void SetIsVisibleNothing(bool isVisible)
    {
    }

    [Token(Token = "0x60156F3")]
    [Address(RVA = "0x18E2EF8", Offset = "0x18E2EF8", VA = "0x18E2EF8")]
    public WeaponDetailAddedStatus()
    {
    }
  }
}
