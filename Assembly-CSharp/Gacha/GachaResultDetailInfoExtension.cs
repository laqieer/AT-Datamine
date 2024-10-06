// Decompiled with JetBrains decompiler
// Type: Gacha.GachaResultDetailInfoExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001523")]
  public static class GachaResultDetailInfoExtension
  {
    [Token(Token = "0x600778E")]
    [Address(RVA = "0x44F354C", Offset = "0x44F354C", VA = "0x44F354C")]
    public static RarityTypeEnum GetRarity(this GachaResultDetailInfo gachaResultDetailInfo)
    {
      return new RarityTypeEnum();
    }

    [Token(Token = "0x600778F")]
    [Address(RVA = "0x44F3698", Offset = "0x44F3698", VA = "0x44F3698")]
    public static ElementTypeEnum GetElement(this GachaResultDetailInfo gachaResultDetailInfo)
    {
      return new ElementTypeEnum();
    }
  }
}
