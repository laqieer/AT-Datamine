// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapStoryShopBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018D4")]
  public class FreeMapStoryShopBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006BAC")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;
    [Token(Token = "0x4006BAD")]
    [FieldOffset(Offset = "0x18")]
    private ShopTypeEnum shopType;
    [Token(Token = "0x4006BAE")]
    [FieldOffset(Offset = "0x1C")]
    protected readonly int sequenceID;

    [Token(Token = "0x6008D15")]
    [Address(RVA = "0x45327B0", Offset = "0x45327B0", VA = "0x45327B0")]
    public FreeMapStoryShopBuildCondition(int objectId, ShopTypeEnum shopType, int sequenceID)
    {
    }

    [Token(Token = "0x6008D16")]
    [Address(RVA = "0x4532858", Offset = "0x4532858", VA = "0x4532858", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}
