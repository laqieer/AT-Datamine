// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentOptionEffectListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment.UI;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x20035A6")]
  public class EquipmentOptionEffectListView
  {
    [Token(Token = "0x400E971")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, string> id2type;

    [Token(Token = "0x17004648")]
    public EquipmentOptionEffectListUI OptionEffectListUI
    {
      [Token(Token = "0x60151C8"), Address(RVA = "0x4AAC0A8", Offset = "0x4AAC0A8", VA = "0x4AAC0A8")] private get
      {
        return (EquipmentOptionEffectListUI) null;
      }
      [Token(Token = "0x60151C9"), Address(RVA = "0x4AAC0B0", Offset = "0x4AAC0B0", VA = "0x4AAC0B0")] set
      {
      }
    }

    [Token(Token = "0x17004649")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x60151CA"), Address(RVA = "0x4AAC0B8", Offset = "0x4AAC0B8", VA = "0x4AAC0B8")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x60151CB"), Address(RVA = "0x4AAC0C0", Offset = "0x4AAC0C0", VA = "0x4AAC0C0")] set
      {
      }
    }

    [Token(Token = "0x60151CC")]
    [Address(RVA = "0x4AA8DEC", Offset = "0x4AA8DEC", VA = "0x4AA8DEC")]
    public void SetOptionEffect(int slotMax, IOptionEffect[] options)
    {
    }

    [Token(Token = "0x60151CD")]
    [Address(RVA = "0x4AAC2F8", Offset = "0x4AAC2F8", VA = "0x4AAC2F8")]
    public EquipmentOptionEffectListView()
    {
    }
  }
}
