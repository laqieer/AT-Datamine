// Decompiled with JetBrains decompiler
// Type: Story.ContentBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x200054B")]
  public sealed class ContentBattle : Content, ContentBattle.ISceneObserveAndReturnHome
  {
    [Token(Token = "0x4001BAD")]
    [FieldOffset(Offset = "0x20")]
    private IBattleDirection direction;
    [Token(Token = "0x4001BAE")]
    [FieldOffset(Offset = "0x28")]
    private WeakReference<SceneHandler> sceneHandlerWeakReference;
    [Token(Token = "0x4001BAF")]
    [FieldOffset(Offset = "0x30")]
    private ContentBattle.ISceneObserveAndReturnHome sceneObserveAndReturnHome;

    [Token(Token = "0x6001EA9")]
    [Address(RVA = "0x29FEC38", Offset = "0x29FEC38", VA = "0x29FEC38")]
    public ContentBattle(IBattleDirection direction)
    {
    }

    [Token(Token = "0x6001EAA")]
    [Address(RVA = "0x29FEC60", Offset = "0x29FEC60", VA = "0x29FEC60", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001EAB")]
    [Address(RVA = "0x29FED74", Offset = "0x29FED74", VA = "0x29FED74")]
    private IEnumerator SetupAndOpenQuestSelectSubSceneSequence() => (IEnumerator) null;

    [Token(Token = "0x6001EAC")]
    [Address(RVA = "0x29FEE04", Offset = "0x29FEE04", VA = "0x29FEE04", Slot = "5")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x6001EAD")]
    [Address(RVA = "0x29FEEAC", Offset = "0x29FEEAC", VA = "0x29FEEAC", Slot = "9")]
    private void Story\u002EContentBattle\u002EISceneObserveAndReturnHome\u002EUpdate()
    {
    }

    [Token(Token = "0x200054C")]
    public interface ISceneObserveAndReturnHome
    {
      [Token(Token = "0x6001EAE")]
      void Update();
    }
  }
}
