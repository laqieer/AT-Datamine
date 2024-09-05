// Decompiled with JetBrains decompiler
// Type: StaqData.AreaMapObjectStatusInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200208D")]
  public class AreaMapObjectStatusInfo
  {
    [Token(Token = "0x4008A85")]
    [FieldOffset(Offset = "0x10")]
    private readonly List<Chest> chests;
    [Token(Token = "0x4008A86")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<int, BreakableObjectInfo> breakableObjectInfoDic;

    [Token(Token = "0x600C4E9")]
    [Address(RVA = "0x19FE6C8", Offset = "0x19FE6C8", VA = "0x19FE6C8")]
    public bool IsOpenedCheast(int chestID) => new bool();

    [Token(Token = "0x600C4EA")]
    [Address(RVA = "0x19FE7C0", Offset = "0x19FE7C0", VA = "0x19FE7C0")]
    public bool IsBrokenBreakObject(int breakableObjectID) => new bool();

    [Token(Token = "0x600C4EB")]
    [Address(RVA = "0x19FE860", Offset = "0x19FE860", VA = "0x19FE860")]
    public void Apply(PlayerAreaMapObjectStatus entity)
    {
    }

    [Token(Token = "0x600C4EC")]
    [Address(RVA = "0x19FE874", Offset = "0x19FE874", VA = "0x19FE874")]
    public void Apply(IEnumerable<int> openedChestIDs, IEnumerable<int> breakedObjectIDs)
    {
    }

    [Token(Token = "0x600C4ED")]
    [Address(RVA = "0x19FEFEC", Offset = "0x19FEFEC", VA = "0x19FEFEC")]
    public void ObtainedChest(int targetID)
    {
    }

    [Token(Token = "0x600C4EE")]
    [Address(RVA = "0x19FF1A8", Offset = "0x19FF1A8", VA = "0x19FF1A8")]
    public void BreakableCrushUpdate(int breakableObjectID)
    {
    }

    [Token(Token = "0x600C4EF")]
    [Address(RVA = "0x19FF2A0", Offset = "0x19FF2A0", VA = "0x19FF2A0")]
    public AreaMapObjectStatusInfo()
    {
    }
  }
}
