// Decompiled with JetBrains decompiler
// Type: Story.StoryFreeMapSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.Story.Header;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005A1")]
  public class StoryFreeMapSubScene : SubScene
  {
    [Token(Token = "0x4001C5C")]
    [FieldOffset(Offset = "0x58")]
    private StoryFreeMapSubScene.SceneParam sceneParam;
    [Token(Token = "0x4001C5D")]
    [FieldOffset(Offset = "0x60")]
    private HeaderManager headerManager;
    [Token(Token = "0x4001C5E")]
    [FieldOffset(Offset = "0x68")]
    private List<GameObject> enableObjects;
    [Token(Token = "0x4001C5F")]
    [FieldOffset(Offset = "0x70")]
    private List<DynamicBonesController> dynamicBonesControllerList;

    [Token(Token = "0x6002070")]
    [Address(RVA = "0x2A0836C", Offset = "0x2A0836C", VA = "0x2A0836C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6002071")]
    [Address(RVA = "0x2A084A4", Offset = "0x2A084A4", VA = "0x2A084A4", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6002072")]
    [Address(RVA = "0x2A08534", Offset = "0x2A08534", VA = "0x2A08534", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6002073")]
    [Address(RVA = "0x2A085C4", Offset = "0x2A085C4", VA = "0x2A085C4", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6002074")]
    [Address(RVA = "0x2A085E8", Offset = "0x2A085E8", VA = "0x2A085E8", Slot = "24")]
    public override void OnBeforeBackScene()
    {
    }

    [Token(Token = "0x6002075")]
    [Address(RVA = "0x2A08B74", Offset = "0x2A08B74", VA = "0x2A08B74", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6002076")]
    [Address(RVA = "0x2A08C9C", Offset = "0x2A08C9C", VA = "0x2A08C9C", Slot = "27")]
    public override void OnNextScene()
    {
    }

    [Token(Token = "0x6002077")]
    [Address(RVA = "0x2A08D50", Offset = "0x2A08D50", VA = "0x2A08D50", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6002078")]
    [Address(RVA = "0x2A085F0", Offset = "0x2A085F0", VA = "0x2A085F0")]
    private void SetEnableObjects(bool isEnable)
    {
    }

    [Token(Token = "0x6002079")]
    [Address(RVA = "0x29FE69C", Offset = "0x29FE69C", VA = "0x29FE69C")]
    public static void ChangeSubScene(StoryFreeMapSubScene.SceneParam param)
    {
    }

    [Token(Token = "0x600207A")]
    [Address(RVA = "0x2A08DC8", Offset = "0x2A08DC8", VA = "0x2A08DC8")]
    public StoryFreeMapSubScene()
    {
    }

    [Token(Token = "0x20005A2")]
    public class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x4001C60")]
      [FieldOffset(Offset = "0x18")]
      public Action OnEnable;
      [Token(Token = "0x4001C61")]
      [FieldOffset(Offset = "0x20")]
      public Action OnDisable;
      [Token(Token = "0x4001C62")]
      [FieldOffset(Offset = "0x28")]
      public FreeMapStateManager FreeMapStateManager;

      [Token(Token = "0x600207C")]
      [Address(RVA = "0x29FE670", Offset = "0x29FE670", VA = "0x29FE670")]
      public SceneParam(FreeMapStateManager entity)
      {
      }
    }
  }
}
