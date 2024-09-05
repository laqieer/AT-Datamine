// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentPopupViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x2003596")]
  public class EquipmentPopupViewModel
  {
    [Token(Token = "0x400E8EC")]
    [FieldOffset(Offset = "0x18")]
    private EquipmentCommonModelBase commonModel;

    [Token(Token = "0x170045BB")]
    public EquipmentPopupView View
    {
      [Token(Token = "0x60150A0"), Address(RVA = "0x4AA9B18", Offset = "0x4AA9B18", VA = "0x4AA9B18")] private get
      {
        return (EquipmentPopupView) null;
      }
      [Token(Token = "0x60150A1"), Address(RVA = "0x4AA9B20", Offset = "0x4AA9B20", VA = "0x4AA9B20")] set
      {
      }
    }

    [Token(Token = "0x170045BC")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x60150A2"), Address(RVA = "0x4AA9B28", Offset = "0x4AA9B28", VA = "0x4AA9B28")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x60150A3"), Address(RVA = "0x4AA9B30", Offset = "0x4AA9B30", VA = "0x4AA9B30")] set
      {
      }
    }

    [Token(Token = "0x60150A4")]
    [Address(RVA = "0x4AA9B38", Offset = "0x4AA9B38", VA = "0x4AA9B38")]
    public void SetModel(EquipmentCommonModelBase commonModel)
    {
    }

    [Token(Token = "0x60150A5")]
    [Address(RVA = "0x4AA9B40", Offset = "0x4AA9B40", VA = "0x4AA9B40")]
    public void OnChange()
    {
    }

    [Token(Token = "0x60150A6")]
    [Address(RVA = "0x4AA9EE8", Offset = "0x4AA9EE8", VA = "0x4AA9EE8")]
    public EquipmentPopupViewModel()
    {
    }
  }
}
