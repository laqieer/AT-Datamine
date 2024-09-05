// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EnableEquipmentClassificationView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007AB")]
  public class EnableEquipmentClassificationView : MonoBehaviour
  {
    [Token(Token = "0x40023B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject layoutObject;
    [Token(Token = "0x40023B6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private WeaponTypeIcon[] icons;
    [Token(Token = "0x40023B7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject weaponTypeListObject;
    [Token(Token = "0x40023B8")]
    [FieldOffset(Offset = "0x30")]
    private SpriteAtlas spriteAtlas;

    [Token(Token = "0x6002B41")]
    [Address(RVA = "0x386C290", Offset = "0x386C290", VA = "0x386C290")]
    public void SetData(Style selectStyle, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6002B42")]
    [Address(RVA = "0x386C464", Offset = "0x386C464", VA = "0x386C464")]
    private void UpdateIcon(Style selectStyle)
    {
    }

    [Token(Token = "0x6002B43")]
    [Address(RVA = "0x386CA44", Offset = "0x386CA44", VA = "0x386CA44")]
    public void OnOpenWeaponTypeListButton()
    {
    }

    [Token(Token = "0x6002B44")]
    [Address(RVA = "0x386CA64", Offset = "0x386CA64", VA = "0x386CA64")]
    public void CloseWeaponTypeList()
    {
    }

    [Token(Token = "0x6002B45")]
    [Address(RVA = "0x386CA84", Offset = "0x386CA84", VA = "0x386CA84")]
    public EnableEquipmentClassificationView()
    {
    }
  }
}
