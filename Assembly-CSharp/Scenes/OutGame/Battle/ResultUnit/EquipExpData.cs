// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultUnit.EquipExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Battle.ResultUnit
{
  [Token(Token = "0x20037BA")]
  public class EquipExpData
  {
    [Token(Token = "0x400F3A3")]
    [FieldOffset(Offset = "0x10")]
    public int expTo;
    [Token(Token = "0x400F3A4")]
    [FieldOffset(Offset = "0x14")]
    public int expFrom;
    [Token(Token = "0x400F3A5")]
    [FieldOffset(Offset = "0x18")]
    public int level;

    [Token(Token = "0x6015EF8")]
    [Address(RVA = "0x2322058", Offset = "0x2322058", VA = "0x2322058")]
    public EquipExpData(WeaponExpData expData)
    {
    }

    [Token(Token = "0x6015EF9")]
    [Address(RVA = "0x23223F0", Offset = "0x23223F0", VA = "0x23223F0")]
    public EquipExpData(AccessoriesExpData expData)
    {
    }
  }
}
