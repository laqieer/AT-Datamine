// Decompiled with JetBrains decompiler
// Type: Battle.Data.ArenaPlaceConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026E1")]
  public class ArenaPlaceConfig : ArenaBattleConfig
  {
    [Token(Token = "0x400A657")]
    [FieldOffset(Offset = "0x6C")]
    public int UserPlayerId;

    [Token(Token = "0x600F095")]
    [Address(RVA = "0x41A85B4", Offset = "0x41A85B4", VA = "0x41A85B4")]
    protected ArenaPlaceConfig()
    {
    }

    [Token(Token = "0x600F096")]
    [Address(RVA = "0x41A8744", Offset = "0x41A8744", VA = "0x41A8744")]
    public ArenaPlaceConfig(PvEBattle.ArenaPlaceSceneParameter parameter)
    {
    }

    [Token(Token = "0x600F097")]
    [Address(RVA = "0x41A8790", Offset = "0x41A8790", VA = "0x41A8790", Slot = "46")]
    protected override void SetupSortieInformation()
    {
    }
  }
}
