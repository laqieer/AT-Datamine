// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapGroundData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C5")]
  public class MapGroundData
  {
    [Token(Token = "0x400E0E7")]
    [FieldOffset(Offset = "0x10")]
    private float mapRangeWidth;
    [Token(Token = "0x400E0E8")]
    [FieldOffset(Offset = "0x14")]
    private float mapRangeHeight;

    [Token(Token = "0x601458C")]
    [Address(RVA = "0x206FE18", Offset = "0x206FE18", VA = "0x206FE18")]
    public MapGroundData(float mapRangeWidth, float mapRangeHeight)
    {
    }

    [Token(Token = "0x601458D")]
    [Address(RVA = "0x206FE4C", Offset = "0x206FE4C", VA = "0x206FE4C")]
    public float GetMapRangeWidth() => new float();

    [Token(Token = "0x601458E")]
    [Address(RVA = "0x206FE54", Offset = "0x206FE54", VA = "0x206FE54")]
    public float GetMapRangeHeight() => new float();
  }
}
