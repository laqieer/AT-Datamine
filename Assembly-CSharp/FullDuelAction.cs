// Decompiled with JetBrains decompiler
// Type: FullDuelAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data.Board;
using Battle.DuelScene;
using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200019A")]
public sealed class FullDuelAction : IDuelAction
{
  [Token(Token = "0x4000A5D")]
  [FieldOffset(Offset = "0x20")]
  public IDirector mainDirector;
  [Token(Token = "0x4000A5E")]
  [FieldOffset(Offset = "0x28")]
  private DuelData duelData;
  [Token(Token = "0x4000A5F")]
  [FieldOffset(Offset = "0x30")]
  private DuelStage duelStage;
  [Token(Token = "0x4000A60")]
  [FieldOffset(Offset = "0x38")]
  private BoardData board;

  [Token(Token = "0x170000D3")]
  public float TimeScale
  {
    [Token(Token = "0x6000AE3"), Address(RVA = "0x4BBC50C", Offset = "0x4BBC50C", VA = "0x4BBC50C", Slot = "6")] get
    {
      return new float();
    }
    [Token(Token = "0x6000AE4"), Address(RVA = "0x4BBC514", Offset = "0x4BBC514", VA = "0x4BBC514", Slot = "7")] set
    {
    }
  }

  [Token(Token = "0x140000DF")]
  public event OnCompletedAction OnComplete
  {
    [Token(Token = "0x6000AE5"), Address(RVA = "0x4BBC51C", Offset = "0x4BBC51C", VA = "0x4BBC51C", Slot = "4")] add
    {
    }
    [Token(Token = "0x6000AE6"), Address(RVA = "0x4BBC5B8", Offset = "0x4BBC5B8", VA = "0x4BBC5B8", Slot = "5")] remove
    {
    }
  }

  [Token(Token = "0x6000AE7")]
  [Address(RVA = "0x4BBC654", Offset = "0x4BBC654", VA = "0x4BBC654", Slot = "8")]
  public void Initialize(DuelData data, ActionData targetActionData, IDirector mainDirector)
  {
  }

  [Token(Token = "0x6000AE8")]
  [Address(RVA = "0x4BBC6A8", Offset = "0x4BBC6A8", VA = "0x4BBC6A8", Slot = "9")]
  public void RequestStaging()
  {
  }

  [Token(Token = "0x6000AE9")]
  [Address(RVA = "0x4BBC930", Offset = "0x4BBC930", VA = "0x4BBC930")]
  public FullDuelAction()
  {
  }
}
