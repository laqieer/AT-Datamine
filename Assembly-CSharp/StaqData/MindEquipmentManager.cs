// Decompiled with JetBrains decompiler
// Type: StaqData.MindEquipmentManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002026")]
  public sealed class MindEquipmentManager : Items<System.Collections.Generic.List<PlayerGearMindEquipmentType>, MindEquipment>
  {
    [Token(Token = "0x600C04C")]
    [Address(RVA = "0x200BBB8", Offset = "0x200BBB8", VA = "0x200BBB8", Slot = "6")]
    public override void Apply(System.Collections.Generic.List<PlayerGearMindEquipmentType> entities)
    {
    }

    [Token(Token = "0x600C04D")]
    [Address(RVA = "0x200BCC8", Offset = "0x200BCC8", VA = "0x200BCC8")]
    public MindEquipmentManager()
    {
    }
  }
}
