// Decompiled with JetBrains decompiler
// Type: Battle.Data.DropData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F2")]
  public class DropData
  {
    [Token(Token = "0x400A6A1")]
    [FieldOffset(Offset = "0x10")]
    public int UnitId;
    [Token(Token = "0x400A6A2")]
    [FieldOffset(Offset = "0x14")]
    public BattleDropRewardTypeEnum DropRewardType;

    [Token(Token = "0x600F11D")]
    [Address(RVA = "0x41AC018", Offset = "0x41AC018", VA = "0x41AC018")]
    public DropData(int unitId, int battleDropRewardTypeId)
    {
    }
  }
}
