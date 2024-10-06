// Decompiled with JetBrains decompiler
// Type: GameCore.UnityScene.UnitySceneAdditiveLoadCaller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

#nullable disable
namespace GameCore.UnityScene
{
  [Token(Token = "0x2000BDE")]
  public class UnitySceneAdditiveLoadCaller : Singleton<UnitySceneAdditiveLoadCaller>
  {
    [Token(Token = "0x40035EF")]
    [FieldOffset(Offset = "0x10")]
    private List<UnitySceneAdditiveLoadCaller.SceneData> LoadSceneDataList;

    [Token(Token = "0x60043D3")]
    [Address(RVA = "0x3643F10", Offset = "0x3643F10", VA = "0x3643F10")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60043D4")]
    [Address(RVA = "0x36440A8", Offset = "0x36440A8", VA = "0x36440A8")]
    public UnitySceneAdditiveLoadCaller()
    {
    }

    [Token(Token = "0x60043D5")]
    [Address(RVA = "0x364420C", Offset = "0x364420C", VA = "0x364420C")]
    public void Release()
    {
    }

    [Token(Token = "0x60043D6")]
    [Address(RVA = "0x3644354", Offset = "0x3644354", VA = "0x3644354")]
    public void LoadSceneAsync(string sceneName, Action<Scene> loadedCallback)
    {
    }

    [Token(Token = "0x60043D7")]
    [Address(RVA = "0x3644680", Offset = "0x3644680", VA = "0x3644680")]
    private void OnLoadedSceneInternal(Scene scene, LoadSceneMode mode)
    {
    }

    [Token(Token = "0x60043D8")]
    [Address(RVA = "0x3644834", Offset = "0x3644834", VA = "0x3644834")]
    private void OnUnloadedSceneInternal(Scene scene)
    {
    }

    [Token(Token = "0x2000BDF")]
    private class SceneData
    {
      [Token(Token = "0x170009DB")]
      public string LoadSceneName
      {
        [Token(Token = "0x60043D9"), Address(RVA = "0x36449A8", Offset = "0x36449A8", VA = "0x36449A8")] get
        {
          return (string) null;
        }
        [Token(Token = "0x60043DA"), Address(RVA = "0x36449B0", Offset = "0x36449B0", VA = "0x36449B0")] set
        {
        }
      }

      [Token(Token = "0x170009DC")]
      public Scene Scene
      {
        [Token(Token = "0x60043DB"), Address(RVA = "0x36449B8", Offset = "0x36449B8", VA = "0x36449B8")] get
        {
          return new Scene();
        }
        [Token(Token = "0x60043DC"), Address(RVA = "0x36449C0", Offset = "0x36449C0", VA = "0x36449C0")] set
        {
        }
      }

      [Token(Token = "0x140000F2")]
      public event Action<Scene> Loaded
      {
        [Token(Token = "0x60043DD"), Address(RVA = "0x3644578", Offset = "0x3644578", VA = "0x3644578")] add
        {
        }
        [Token(Token = "0x60043DE"), Address(RVA = "0x36449C8", Offset = "0x36449C8", VA = "0x36449C8")] remove
        {
        }
      }

      [Token(Token = "0x60043DF")]
      [Address(RVA = "0x3644804", Offset = "0x3644804", VA = "0x3644804")]
      public void OnLoadedEvent()
      {
      }

      [Token(Token = "0x60043E0")]
      [Address(RVA = "0x3644628", Offset = "0x3644628", VA = "0x3644628")]
      public SceneData()
      {
      }
    }
  }
}
