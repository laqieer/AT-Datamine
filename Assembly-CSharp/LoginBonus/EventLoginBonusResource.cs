// Decompiled with JetBrains decompiler
// Type: LoginBonus.EventLoginBonusResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.ItemDetail;
using UI.MultipleItemDetail;
using UnityEngine;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AC3")]
  public class EventLoginBonusResource
  {
    [Token(Token = "0x400316D")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Container_LoginBonus_Beginner_Event;
    [Token(Token = "0x400316E")]
    [FieldOffset(Offset = "0x18")]
    public GameObject Container_LoginBonusReward_Item;
    [Token(Token = "0x400316F")]
    [FieldOffset(Offset = "0x20")]
    public GameObject Container_LoginBonusReward_Group;
    [Token(Token = "0x4003170")]
    [FieldOffset(Offset = "0x28")]
    public GameObject Container_LoginBonusReward_List_Line;
    [Token(Token = "0x4003171")]
    [FieldOffset(Offset = "0x30")]
    public Sprite[] Img_Num_Day;
    [Token(Token = "0x4003172")]
    [FieldOffset(Offset = "0x38")]
    public GameObject Com_ItemThumb;
    [Token(Token = "0x4003173")]
    [FieldOffset(Offset = "0x40")]
    public ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x4003174")]
    [FieldOffset(Offset = "0x48")]
    public MultipleItemDetailPopupGenerator multipleItemDetailPopupGenerator;

    [Token(Token = "0x6003D44")]
    [Address(RVA = "0x2C0CCD8", Offset = "0x2C0CCD8", VA = "0x2C0CCD8")]
    public EventLoginBonusResource()
    {
    }
  }
}
