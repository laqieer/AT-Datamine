// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleSceneManagement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014A1")]
  internal class AssetBundleSceneManagement : SingletonMonoBehaviour<AssetBundleSceneManagement>
  {
    [Token(Token = "0x600743A")]
    [Address(RVA = "0x43EC59C", Offset = "0x43EC59C", VA = "0x43EC59C")]
    public AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
    {
      return (AsyncOperation) null;
    }

    [Token(Token = "0x600743B")]
    [Address(RVA = "0x43EC604", Offset = "0x43EC604", VA = "0x43EC604")]
    public AsyncOperation LoadSceneAsync(string sceneName) => (AsyncOperation) null;

    [Token(Token = "0x600743C")]
    [Address(RVA = "0x43EC63C", Offset = "0x43EC63C", VA = "0x43EC63C")]
    public Scene LoadScene(string sceneName, LoadSceneParameters parameters) => new Scene();

    [Token(Token = "0x600743D")]
    [Address(RVA = "0x43EC6AC", Offset = "0x43EC6AC", VA = "0x43EC6AC")]
    public AssetBundleSceneManagement()
    {
    }
  }
}
