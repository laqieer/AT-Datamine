// Decompiled with JetBrains decompiler
// Type: TeamOrganization.StyleEquipThumbInfinitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000809")]
  public class StyleEquipThumbInfinitCell : InfiniteCellBase
  {
    [Token(Token = "0x400260A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400260B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject removeObj;
    [Token(Token = "0x400260C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton removeButton;

    [Token(Token = "0x170006DF")]
    private StyleEquipThumbResource Resource
    {
      [Token(Token = "0x6002E22"), Address(RVA = "0x3A8FE64", Offset = "0x3A8FE64", VA = "0x3A8FE64")] get
      {
        return (StyleEquipThumbResource) null;
      }
    }

    [Token(Token = "0x6002E23")]
    [Address(RVA = "0x3A8FEEC", Offset = "0x3A8FEEC", VA = "0x3A8FEEC", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6002E24")]
    [Address(RVA = "0x3A8FF24", Offset = "0x3A8FF24", VA = "0x3A8FF24")]
    private void OrganizedSet(StyleEquipThumbResource resource)
    {
    }

    [Token(Token = "0x6002E25")]
    [Address(RVA = "0x3A90040", Offset = "0x3A90040", VA = "0x3A90040")]
    private void NotOrganizedSet(StyleEquipThumbResource resource, Style style)
    {
    }

    [Token(Token = "0x6002E26")]
    [Address(RVA = "0x3A9048C", Offset = "0x3A9048C", VA = "0x3A9048C")]
    public StyleEquipThumbInfinitCell()
    {
    }
  }
}
