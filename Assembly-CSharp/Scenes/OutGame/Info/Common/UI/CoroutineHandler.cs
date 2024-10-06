// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.CoroutineHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035D6")]
  public class CoroutineHandler
  {
    [Token(Token = "0x400EA58")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour owner;
    [Token(Token = "0x400EA59")]
    [FieldOffset(Offset = "0x18")]
    private Coroutine working;
    [Token(Token = "0x400EA5A")]
    [FieldOffset(Offset = "0x20")]
    private List<ICoroutineTask> advancedTask;
    [Token(Token = "0x400EA5B")]
    [FieldOffset(Offset = "0x28")]
    private List<ICoroutineTask> tasks;

    [Token(Token = "0x6015357")]
    [Address(RVA = "0x4D8B164", Offset = "0x4D8B164", VA = "0x4D8B164")]
    public CoroutineHandler(MonoBehaviour owner)
    {
    }

    [Token(Token = "0x6015358")]
    [Address(RVA = "0x4D8B210", Offset = "0x4D8B210", VA = "0x4D8B210")]
    public IAssetProvider SubScribeAssetProvider() => (IAssetProvider) null;

    [Token(Token = "0x6015359")]
    [Address(RVA = "0x4D8B2DC", Offset = "0x4D8B2DC", VA = "0x4D8B2DC")]
    public ITimelinePlayer SubScribeTimelinePlayer(UITimelineController timelineController)
    {
      return (ITimelinePlayer) null;
    }

    [Token(Token = "0x601535A")]
    [Address(RVA = "0x4D8B48C", Offset = "0x4D8B48C", VA = "0x4D8B48C")]
    public void Update()
    {
    }

    [Token(Token = "0x601535B")]
    [Address(RVA = "0x4D8B688", Offset = "0x4D8B688", VA = "0x4D8B688")]
    private void Update(ICoroutineTask task)
    {
    }

    [Token(Token = "0x601535C")]
    [Address(RVA = "0x4D8B7D4", Offset = "0x4D8B7D4", VA = "0x4D8B7D4")]
    public void Release()
    {
    }
  }
}
