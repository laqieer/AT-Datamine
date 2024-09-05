// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.CacheAreaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038F6")]
  internal class CacheAreaData
  {
    [Token(Token = "0x400F90D")]
    [FieldOffset(Offset = "0x10")]
    public readonly AreaQuestAreaData MasterAreaData;

    [Token(Token = "0x1700499F")]
    public bool IsPlayable
    {
      [Token(Token = "0x601663F"), Address(RVA = "0x2081F64", Offset = "0x2081F64", VA = "0x2081F64")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016640"), Address(RVA = "0x2081F6C", Offset = "0x2081F6C", VA = "0x2081F6C")] private set
      {
      }
    }

    [Token(Token = "0x170049A0")]
    public bool IsRequestUnlockAnimation
    {
      [Token(Token = "0x6016641"), Address(RVA = "0x2081F78", Offset = "0x2081F78", VA = "0x2081F78")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016642"), Address(RVA = "0x2081F80", Offset = "0x2081F80", VA = "0x2081F80")] private set
      {
      }
    }

    [Token(Token = "0x170049A1")]
    public int CurrentNodeId
    {
      [Token(Token = "0x6016643"), Address(RVA = "0x2081F8C", Offset = "0x2081F8C", VA = "0x2081F8C")] get
      {
        return new int();
      }
      [Token(Token = "0x6016644"), Address(RVA = "0x2081F94", Offset = "0x2081F94", VA = "0x2081F94")] private set
      {
      }
    }

    [Token(Token = "0x6016645")]
    [Address(RVA = "0x207CFCC", Offset = "0x207CFCC", VA = "0x207CFCC")]
    public CacheAreaData(int currentNodeId, AreaQuestAreaData masterAreaData, bool isPlayable)
    {
    }

    [Token(Token = "0x6016646")]
    [Address(RVA = "0x207DE54", Offset = "0x207DE54", VA = "0x207DE54")]
    public void SetRequestUnlockAnim(bool isRequestUnlockAnimation)
    {
    }

    [Token(Token = "0x6016647")]
    [Address(RVA = "0x207D2D8", Offset = "0x207D2D8", VA = "0x207D2D8")]
    public void UpdateCurrentNodeId(int moveNextNodeId)
    {
    }

    [Token(Token = "0x6016648")]
    [Address(RVA = "0x207D248", Offset = "0x207D248", VA = "0x207D248")]
    public bool ChangePlayableMonitoring() => new bool();

    [Token(Token = "0x6016649")]
    [Address(RVA = "0x207E464", Offset = "0x207E464", VA = "0x207E464")]
    public void SetPlayable()
    {
    }
  }
}
