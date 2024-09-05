// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentWeaponStatusViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x2003598")]
  public class EquipmentWeaponStatusViewModel
  {
    [Token(Token = "0x400E8F0")]
    [FieldOffset(Offset = "0x10")]
    private EquipmentWeaponModelBase model;
    [Token(Token = "0x400E8F1")]
    [FieldOffset(Offset = "0x18")]
    private EquipmentWeaponStatusView view;

    [Token(Token = "0x170045BD")]
    public bool IsForExpedition
    {
      [Token(Token = "0x60150AB"), Address(RVA = "0x4AA9FA8", Offset = "0x4AA9FA8", VA = "0x4AA9FA8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60150AC"), Address(RVA = "0x4AA9FB0", Offset = "0x4AA9FB0", VA = "0x4AA9FB0")] set
      {
      }
    }

    [Token(Token = "0x60150AD")]
    [Address(RVA = "0x4AA9FBC", Offset = "0x4AA9FBC", VA = "0x4AA9FBC")]
    public void SetModel(EquipmentWeaponModelBase model)
    {
    }

    [Token(Token = "0x60150AE")]
    [Address(RVA = "0x4AA9FC4", Offset = "0x4AA9FC4", VA = "0x4AA9FC4")]
    public void SetView(EquipmentWeaponStatusView view)
    {
    }

    [Token(Token = "0x60150AF")]
    [Address(RVA = "0x4AA9FCC", Offset = "0x4AA9FCC", VA = "0x4AA9FCC")]
    public void OnChange()
    {
    }

    [Token(Token = "0x60150B0")]
    [Address(RVA = "0x4AAA37C", Offset = "0x4AAA37C", VA = "0x4AAA37C")]
    public EquipmentWeaponStatusViewModel()
    {
    }
  }
}
