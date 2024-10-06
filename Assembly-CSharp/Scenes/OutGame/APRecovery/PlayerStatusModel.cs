// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.PlayerStatusModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x200396A")]
  public readonly struct PlayerStatusModel
  {
    [Token(Token = "0x400FAF6")]
    [FieldOffset(Offset = "0x0")]
    private readonly int _ap;
    [Token(Token = "0x400FAF7")]
    [FieldOffset(Offset = "0x4")]
    private readonly int _itemRecoveryRemainingCount;
    [Token(Token = "0x400FAF8")]
    [FieldOffset(Offset = "0x8")]
    private readonly int _coinRecoveryRemainingCount;

    [Token(Token = "0x17004A51")]
    public static PlayerStatusModel Now
    {
      [Token(Token = "0x6016923"), Address(RVA = "0x42ED2A8", Offset = "0x42ED2A8", VA = "0x42ED2A8")] get
      {
        return new PlayerStatusModel();
      }
    }

    [Token(Token = "0x6016924")]
    [Address(RVA = "0x42F1014", Offset = "0x42F1014", VA = "0x42F1014")]
    public PlayerStatusModel(Player player)
    {
    }

    [Token(Token = "0x17004A52")]
    public int Ap
    {
      [Token(Token = "0x6016925"), Address(RVA = "0x42F10F8", Offset = "0x42F10F8", VA = "0x42F10F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A53")]
    public bool IsApMax
    {
      [Token(Token = "0x6016926"), Address(RVA = "0x42EDCF0", Offset = "0x42EDCF0", VA = "0x42EDCF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004A54")]
    public int ItemRecoveryRemainingCount
    {
      [Token(Token = "0x6016927"), Address(RVA = "0x42F1100", Offset = "0x42F1100", VA = "0x42F1100")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A55")]
    public int CoinRecoveryRemainingCount
    {
      [Token(Token = "0x6016928"), Address(RVA = "0x42F1108", Offset = "0x42F1108", VA = "0x42F1108")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A56")]
    public int RecoveryRemainingCount
    {
      [Token(Token = "0x6016929"), Address(RVA = "0x42EDE10", Offset = "0x42EDE10", VA = "0x42EDE10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A57")]
    public bool IsRecoveryRemaining
    {
      [Token(Token = "0x601692A"), Address(RVA = "0x42EF9A8", Offset = "0x42EF9A8", VA = "0x42EF9A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004A58")]
    private static PlayerConstData PlayerConst
    {
      [Token(Token = "0x601692B"), Address(RVA = "0x42F1078", Offset = "0x42F1078", VA = "0x42F1078")] get
      {
        return (PlayerConstData) null;
      }
    }
  }
}
