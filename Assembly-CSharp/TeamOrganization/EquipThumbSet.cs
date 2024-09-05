// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipThumbSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007DC")]
  public class EquipThumbSet : InfiniteCellBase
  {
    [Token(Token = "0x40024C8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EquipThumb equipThumb;
    [Token(Token = "0x40024C9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button removeButton;
    [Token(Token = "0x40024CA")]
    [FieldOffset(Offset = "0x38")]
    private EquipEditPopup equipEditPopup;
    [Token(Token = "0x40024CB")]
    [FieldOffset(Offset = "0x40")]
    private EquipEditPopup.ThumbData equipment;

    [Token(Token = "0x6002C72")]
    [Address(RVA = "0x387DBD0", Offset = "0x387DBD0", VA = "0x387DBD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6002C73")]
    [Address(RVA = "0x387DC64", Offset = "0x387DC64", VA = "0x387DC64")]
    public void OnRemoveButton()
    {
    }

    [Token(Token = "0x6002C74")]
    [Address(RVA = "0x387DC7C", Offset = "0x387DC7C", VA = "0x387DC7C", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6002C75")]
    [Address(RVA = "0x387DF28", Offset = "0x387DF28", VA = "0x387DF28")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6002C76")]
    [Address(RVA = "0x387DFDC", Offset = "0x387DFDC", VA = "0x387DFDC")]
    public EquipThumbSet()
    {
    }
  }
}
