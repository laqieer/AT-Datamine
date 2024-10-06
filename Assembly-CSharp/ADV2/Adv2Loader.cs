// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2Loader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.AdvTextAccessNS;
using GameCore;
using GameCore.DLC;
using GameCore.Popup;
using Il2CppDummyDll;
using Lua;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003D8A")]
  public class Adv2Loader : MonoBehaviour
  {
    [Token(Token = "0x4010E43")]
    [FieldOffset(Offset = "0x18")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4010E44")]
    [FieldOffset(Offset = "0x20")]
    public bool PreloadMode;
    [Token(Token = "0x4010E45")]
    [FieldOffset(Offset = "0x28")]
    protected Dictionary<string, List<Adv2Loader.LoadedCallbackParam>> loadingAssetBundleFileList;
    [Token(Token = "0x4010E46")]
    [FieldOffset(Offset = "0x30")]
    private List<string> removeElementTempList;
    [Token(Token = "0x4010E47")]
    [FieldOffset(Offset = "0x38")]
    private List<string> LoadAddAssetBundleNameList;
    [Token(Token = "0x4010E48")]
    [FieldOffset(Offset = "0x40")]
    protected List<Adv2Loader.LoadedCallbackParam> loadrequestList;
    [Token(Token = "0x4010E49")]
    [FieldOffset(Offset = "0x48")]
    protected List<Adv2Loader.LoadedCallbackParam> preloadrequestList;
    [Token(Token = "0x4010E4A")]
    [FieldOffset(Offset = "0x50")]
    protected List<ScriptableObject> InstantiateScriptableObjects;
    [Token(Token = "0x4010E4B")]
    [FieldOffset(Offset = "0x58")]
    protected List<string> rawDataDownloadList;
    [Token(Token = "0x4010E4C")]
    [FieldOffset(Offset = "0x60")]
    private Coroutine loadAssetBundleProcess;
    [Token(Token = "0x4010E4D")]
    [FieldOffset(Offset = "0x68")]
    protected List<string> preLoadResuestAssetbundleList;

    [Token(Token = "0x170050C0")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x6018C0E"), Address(RVA = "0x2649DB8", Offset = "0x2649DB8", VA = "0x2649DB8")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x6018C0F")]
    [Address(RVA = "0x2649E8C", Offset = "0x2649E8C", VA = "0x2649E8C")]
    protected void LoadAssetbundle(Adv2Loader.LoadedCallbackParam loadedCallbackParam)
    {
    }

    [Token(Token = "0x6018C10")]
    [Address(RVA = "0x264A098", Offset = "0x264A098", VA = "0x264A098")]
    private IEnumerator LoadAssetBundleProcessSequence() => (IEnumerator) null;

    [Token(Token = "0x6018C11")]
    [Address(RVA = "0x264A100", Offset = "0x264A100", VA = "0x264A100")]
    public void PreLoadRequest(string assetBundleName)
    {
    }

    [Token(Token = "0x6018C12")]
    [Address(RVA = "0x264A248", Offset = "0x264A248", VA = "0x264A248")]
    public void PreDownloadRequest(string assetBundleName)
    {
    }

    [Token(Token = "0x6018C13")]
    [Address(RVA = "0x264A384", Offset = "0x264A384", VA = "0x264A384")]
    public void PreDownloadMovieRequest(string movieFileName, bool existH265)
    {
    }

    [Token(Token = "0x6018C14")]
    [Address(RVA = "0x264A5F0", Offset = "0x264A5F0", VA = "0x264A5F0")]
    public static string GetMovieUrl(string movieName, bool existH265) => (string) null;

    [Token(Token = "0x6018C15")]
    [Address(RVA = "0x264A7D4", Offset = "0x264A7D4", VA = "0x264A7D4")]
    public IEnumerator RawDataDownloadProcessSequence() => (IEnumerator) null;

    [Token(Token = "0x6018C16")]
    [Address(RVA = "0x264A83C", Offset = "0x264A83C", VA = "0x264A83C")]
    public IEnumerator StartPreloadAssetBundleProcessSequence() => (IEnumerator) null;

    [Token(Token = "0x6018C17")]
    [Address(RVA = "0x264A8A4", Offset = "0x264A8A4", VA = "0x264A8A4")]
    private void UnloadAssetbundleInList()
    {
    }

    [Token(Token = "0x6018C18")]
    [Address(RVA = "0x264AD30", Offset = "0x264AD30", VA = "0x264AD30")]
    private void AssetCachedSpawnerClearCache()
    {
    }

    [Token(Token = "0x6018C19")]
    [Address(RVA = "0x264ADB4", Offset = "0x264ADB4", VA = "0x264ADB4")]
    public void UnloadAssets()
    {
    }

    [Token(Token = "0x6018C1A")]
    [Address(RVA = "0x264ADCC", Offset = "0x264ADCC", VA = "0x264ADCC")]
    protected void OnLoadedAssetbundle(
      List<string> successList,
      Dictionary<string, string> loadErrorAssetBundleDic)
    {
    }

    [Token(Token = "0x6018C1B")]
    [Address(RVA = "0x264B2EC", Offset = "0x264B2EC", VA = "0x264B2EC")]
    public Adv2Loader.LoadedProjectFile LoadProjectFile(string assetbundleName, string fileName)
    {
      return (Adv2Loader.LoadedProjectFile) null;
    }

    [Token(Token = "0x6018C1C")]
    [Address(RVA = "0x264B41C", Offset = "0x264B41C", VA = "0x264B41C")]
    public Adv2Manager.OnProccessSignal LoadIncudeLuaScript(
      Adv2LuaPlayer player,
      string assetbundleName,
      List<string> fileNames)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C1D")]
    [Address(RVA = "0x264B4B0", Offset = "0x264B4B0", VA = "0x264B4B0")]
    public Adv2Manager.OnProccessSignal LoadedVoiceLoadLuaScript(
      Adv2LuaPlayer player,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C1E")]
    [Address(RVA = "0x264B544", Offset = "0x264B544", VA = "0x264B544")]
    public Adv2Manager.OnProccessSignal LoadAdditiveScene(string assetbundleName, string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C1F")]
    [Address(RVA = "0x264B674", Offset = "0x264B674", VA = "0x264B674")]
    public Adv2Manager.OnProccessSignal LoadPlacement(string assetbundleName, string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C20")]
    [Address(RVA = "0x264B7A4", Offset = "0x264B7A4", VA = "0x264B7A4")]
    public Adv2Manager.OnProccessSignal LoadUI(
      Adv2UI target,
      string assetbundleName,
      string fileName,
      int siblingIndex)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C21")]
    [Address(RVA = "0x264B8EC", Offset = "0x264B8EC", VA = "0x264B8EC")]
    public Adv2Manager.OnProccessSignal LoadMovieDirector(
      Adv2MovieDirector target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C22")]
    [Address(RVA = "0x264BA2C", Offset = "0x264BA2C", VA = "0x264BA2C")]
    public Adv2Manager.OnProccessSignal LoadTrust(
      Adv2Trust target,
      string assetbundleName,
      string fileName,
      int siblingIndex)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C23")]
    [Address(RVA = "0x264BB6C", Offset = "0x264BB6C", VA = "0x264BB6C")]
    public Adv2Manager.OnProccessSignal LoadStackObject(
      string stackTag,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C24")]
    [Address(RVA = "0x264BCAC", Offset = "0x264BCAC", VA = "0x264BCAC")]
    public Adv2Manager.OnProccessSignal LoadStackImage(
      string stackTag,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C25")]
    [Address(RVA = "0x264BDEC", Offset = "0x264BDEC", VA = "0x264BDEC")]
    public Adv2Manager.OnProccessSignal LoadObject(
      Adv2Object target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C26")]
    [Address(RVA = "0x264BF2C", Offset = "0x264BF2C", VA = "0x264BF2C")]
    public Adv2Manager.OnProccessSignal LoadTutorialPopup(
      TutorialPopupManager tutorialManager,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C27")]
    [Address(RVA = "0x264C06C", Offset = "0x264C06C", VA = "0x264C06C")]
    public Adv2Manager.OnProccessSignal LoadObjectAnimator(
      Adv2Object target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C28")]
    [Address(RVA = "0x264C1AC", Offset = "0x264C1AC", VA = "0x264C1AC")]
    public Adv2Manager.OnProccessSignal LoadObjectAnimation(
      Adv2Object target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C29")]
    [Address(RVA = "0x264C2EC", Offset = "0x264C2EC", VA = "0x264C2EC")]
    public Adv2Manager.OnProccessSignal LoadHumanAnimation(
      Adv2Human target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C2A")]
    [Address(RVA = "0x264C42C", Offset = "0x264C42C", VA = "0x264C42C")]
    public Adv2Manager.OnProccessSignal LoadCameraAnimationClip(
      Adv2Camera target,
      string assetbundleName,
      string fileName,
      Adv2Object actor = null)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C2B")]
    [Address(RVA = "0x264C574", Offset = "0x264C574", VA = "0x264C574")]
    public Adv2Manager.OnProccessSignal LoadFacialAnimation(
      Adv2Human target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C2C")]
    [Address(RVA = "0x264C6B4", Offset = "0x264C6B4", VA = "0x264C6B4")]
    public Adv2Manager.OnProccessSignal LoadHeadAnimation(
      Adv2Human target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C2D")]
    [Address(RVA = "0x264C7F4", Offset = "0x264C7F4", VA = "0x264C7F4")]
    public void RequestTextPack(string textAbName, TextAttributeData textAt = null)
    {
    }

    [Token(Token = "0x6018C2E")]
    [Address(RVA = "0x264C8AC", Offset = "0x264C8AC", VA = "0x264C8AC")]
    public void RequestTextPackInProject(string textAbName, TextAttributeData textAt = null)
    {
    }

    [Token(Token = "0x6018C2F")]
    [Address(RVA = "0x264C928", Offset = "0x264C928", VA = "0x264C928")]
    public Adv2Manager.OnProccessSignal LoadRequestTextAll() => (Adv2Manager.OnProccessSignal) null;

    [Token(Token = "0x6018C30")]
    [Address(RVA = "0x264C9E4", Offset = "0x264C9E4", VA = "0x264C9E4")]
    private IEnumerator coLoadRequestTextAll(Adv2Manager.OnProccessSignal proccessSignal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018C31")]
    [Address(RVA = "0x264CA4C", Offset = "0x264CA4C", VA = "0x264CA4C")]
    public Adv2Manager.OnProccessSignal LoadTextPack(string textAbName, TextAttributeData textAt)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C32")]
    [Address(RVA = "0x264CACC", Offset = "0x264CACC", VA = "0x264CACC")]
    public Adv2Manager.OnProccessSignal LoadTextPackCommon(string textAbName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C33")]
    [Address(RVA = "0x264CAD4", Offset = "0x264CAD4", VA = "0x264CAD4")]
    public Adv2Manager.OnProccessSignal LoadTextPackInProject(
      string projectAssetbundleName,
      TextAttributeData textAt)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C34")]
    [Address(RVA = "0x264CB50", Offset = "0x264CB50", VA = "0x264CB50")]
    public Adv2Manager.OnProccessSignal LoadPostEffect(
      Adv2EffectPostProcess target,
      string layerName,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C35")]
    public Adv2Manager.OnProccessSignal LoadPlayableDirector<T>(
      T target,
      string assetbundleName,
      string fileName)
      where T : Adv2PlayableDirectorBase
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C36")]
    [Address(RVA = "0x264CC98", Offset = "0x264CC98", VA = "0x264CC98")]
    public Adv2Manager.OnProccessSignal LoadTrustUp(
      Adv2Trust target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C37")]
    [Address(RVA = "0x264CDD8", Offset = "0x264CDD8", VA = "0x264CDD8")]
    public Adv2Manager.OnProccessSignal LoadTrustResult(
      Adv2TrustResultUI target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C38")]
    [Address(RVA = "0x264CF18", Offset = "0x264CF18", VA = "0x264CF18")]
    public Adv2Manager.OnProccessSignal LoadAssetbundleFileOnly(string assetbundleName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C39")]
    [Address(RVA = "0x264CF94", Offset = "0x264CF94", VA = "0x264CF94")]
    public Adv2Manager.OnProccessSignal LoadParameterUpResult(
      Adv2ParameterUpResultUI target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C3A")]
    [Address(RVA = "0x264D0D4", Offset = "0x264D0D4", VA = "0x264D0D4")]
    public Adv2Manager.OnProccessSignal LoadParameterUpResultDialog(
      Adv2ParameterUpResultDialogUI target,
      string assetbundleName,
      string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C3B")]
    [Address(RVA = "0x264D214", Offset = "0x264D214", VA = "0x264D214")]
    public Adv2Manager.OnProccessSignal LoadPsBattleAdvObj(string assetbundleName, string fileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018C3C")]
    [Address(RVA = "0x264D344", Offset = "0x264D344", VA = "0x264D344")]
    public IEnumerator WaitLoading() => (IEnumerator) null;

    [Token(Token = "0x6018C3D")]
    [Address(RVA = "0x264D3AC", Offset = "0x264D3AC", VA = "0x264D3AC")]
    public Adv2Loader()
    {
    }

    [Token(Token = "0x2003D8B")]
    public abstract class LoadedCallbackParam : Adv2Manager.OnProccessSignal
    {
      [Token(Token = "0x170050C1")]
      public string AssetbundleName
      {
        [Token(Token = "0x6018C3E"), Address(RVA = "0x238EF3C", Offset = "0x238EF3C", VA = "0x238EF3C")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6018C3F"), Address(RVA = "0x238EF44", Offset = "0x238EF44", VA = "0x238EF44")] protected set
        {
        }
      }

      [Token(Token = "0x170050C2")]
      public List<string> FileNames
      {
        [Token(Token = "0x6018C40"), Address(RVA = "0x238EF4C", Offset = "0x238EF4C", VA = "0x238EF4C")] get
        {
          return (List<string>) null;
        }
        [Token(Token = "0x6018C41"), Address(RVA = "0x238EF54", Offset = "0x238EF54", VA = "0x238EF54")] protected set
        {
        }
      }

      [Token(Token = "0x170050C3")]
      public bool IsNotUseLoadedObject
      {
        [Token(Token = "0x6018C42"), Address(RVA = "0x238EF5C", Offset = "0x238EF5C", VA = "0x238EF5C")] get
        {
          return new bool();
        }
        [Token(Token = "0x6018C43"), Address(RVA = "0x238EF64", Offset = "0x238EF64", VA = "0x238EF64")] protected set
        {
        }
      }

      [Token(Token = "0x6018C44")]
      [Address(RVA = "0x238EF70", Offset = "0x238EF70", VA = "0x238EF70")]
      public LoadedCallbackParam(string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C45")]
      [Address(RVA = "0x238F02C", Offset = "0x238F02C", VA = "0x238F02C")]
      public void OnLoaded(LoadedAssetBundle loaded)
      {
      }

      [Token(Token = "0x6018C46")]
      [Address(RVA = "0x238F238", Offset = "0x238F238", VA = "0x238F238")]
      private UnityEngine.Object GetRawAsset(LoadedAssetBundle loaded, string fileName)
      {
        return (UnityEngine.Object) null;
      }

      [Token(Token = "0x6018C47")]
      [Address(RVA = "0x238F290", Offset = "0x238F290", VA = "0x238F290", Slot = "5")]
      protected virtual void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D8C")]
    public class LoadedLuaFile : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x6018C48")]
      [Address(RVA = "0x238F294", Offset = "0x238F294", VA = "0x238F294")]
      public LoadedLuaFile(string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C49")]
      [Address(RVA = "0x238F298", Offset = "0x238F298", VA = "0x238F298", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }

      [Token(Token = "0x6018C4A")]
      [Address(RVA = "0x238F37C", Offset = "0x238F37C", VA = "0x238F37C", Slot = "6")]
      protected virtual void OnLoadedObject(LuaScriptableObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D8D")]
    public class LoadedProjectFile : Adv2Loader.LoadedLuaFile
    {
      [Token(Token = "0x6018C4B")]
      [Address(RVA = "0x238F380", Offset = "0x238F380", VA = "0x238F380")]
      public LoadedProjectFile(string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C4C")]
      [Address(RVA = "0x238F384", Offset = "0x238F384", VA = "0x238F384", Slot = "6")]
      protected override void OnLoadedObject(LuaScriptableObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D8E")]
    protected class LoadedIncludeLuaScript : Adv2Loader.LoadedLuaFile
    {
      [Token(Token = "0x4010E51")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2LuaPlayer outputTarget;

      [Token(Token = "0x6018C4D")]
      [Address(RVA = "0x238F400", Offset = "0x238F400", VA = "0x238F400")]
      public LoadedIncludeLuaScript(
        Adv2LuaPlayer target,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C4E")]
      [Address(RVA = "0x238F42C", Offset = "0x238F42C", VA = "0x238F42C", Slot = "6")]
      protected override void OnLoadedObject(LuaScriptableObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D8F")]
    protected class LoadVoiceLoadLuaScript : Adv2Loader.LoadedLuaFile
    {
      [Token(Token = "0x4010E52")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2LuaPlayer outputTarget;

      [Token(Token = "0x6018C4F")]
      [Address(RVA = "0x238F478", Offset = "0x238F478", VA = "0x238F478")]
      public LoadVoiceLoadLuaScript(Adv2LuaPlayer target, string assetbundleName, string fileName)
      {
      }

      [Token(Token = "0x6018C50")]
      [Address(RVA = "0x238F584", Offset = "0x238F584", VA = "0x238F584", Slot = "6")]
      protected override void OnLoadedObject(LuaScriptableObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D90")]
    protected class LoadedAdditiveScene : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x6018C51")]
      [Address(RVA = "0x238F63C", Offset = "0x238F63C", VA = "0x238F63C")]
      public LoadedAdditiveScene(string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C52")]
      [Address(RVA = "0x238F72C", Offset = "0x238F72C", VA = "0x238F72C", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }

      [Token(Token = "0x6018C53")]
      [Address(RVA = "0x238F848", Offset = "0x238F848", VA = "0x238F848")]
      protected IEnumerator CheckSceneLoad(Scene loadingScene) => (IEnumerator) null;
    }

    [Token(Token = "0x2003D92")]
    protected class LoadedPlacement : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x6018C5A")]
      [Address(RVA = "0x239050C", Offset = "0x239050C", VA = "0x239050C")]
      public LoadedPlacement(string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C5B")]
      [Address(RVA = "0x2390510", Offset = "0x2390510", VA = "0x2390510", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D93")]
    protected class LoadedUI : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x4010E57")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2UI bindTarget;
      [Token(Token = "0x4010E58")]
      [FieldOffset(Offset = "0x38")]
      protected int siblingIndex;

      [Token(Token = "0x6018C5C")]
      [Address(RVA = "0x2390770", Offset = "0x2390770", VA = "0x2390770")]
      public LoadedUI(
        Adv2UI target,
        string assetbundleName,
        List<string> fileNames,
        int siblingIndex)
      {
      }

      [Token(Token = "0x6018C5D")]
      [Address(RVA = "0x23907A4", Offset = "0x23907A4", VA = "0x23907A4", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D95")]
    protected class LoadedMovieDirector : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x4010E5D")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2MovieDirector bindTarget;

      [Token(Token = "0x6018C60")]
      [Address(RVA = "0x2390C1C", Offset = "0x2390C1C", VA = "0x2390C1C")]
      public LoadedMovieDirector(
        Adv2MovieDirector target,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C61")]
      [Address(RVA = "0x2390C48", Offset = "0x2390C48", VA = "0x2390C48", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D96")]
    protected class LoadedGameObject : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x6018C62")]
      [Address(RVA = "0x2390D34", Offset = "0x2390D34", VA = "0x2390D34")]
      public LoadedGameObject(string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C63")]
      [Address(RVA = "0x2390D38", Offset = "0x2390D38", VA = "0x2390D38", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }

      [Token(Token = "0x6018C64")]
      [Address(RVA = "0x2390E3C", Offset = "0x2390E3C", VA = "0x2390E3C", Slot = "6")]
      protected virtual void OnLoadedObject(GameObject loaded, string fileName)
      {
      }

      [Token(Token = "0x6018C65")]
      [Address(RVA = "0x2390E40", Offset = "0x2390E40", VA = "0x2390E40", Slot = "7")]
      protected virtual void OnLoadedObject(UnityEngine.Object loaded)
      {
      }
    }

    [Token(Token = "0x2003D97")]
    protected class LoadedStackObject : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x4010E5E")]
      [FieldOffset(Offset = "0x30")]
      protected string stackTag;

      [Token(Token = "0x6018C66")]
      [Address(RVA = "0x2390E44", Offset = "0x2390E44", VA = "0x2390E44")]
      public LoadedStackObject(string tag, string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C67")]
      [Address(RVA = "0x2390E70", Offset = "0x2390E70", VA = "0x2390E70", Slot = "6")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }

      [Token(Token = "0x6018C68")]
      [Address(RVA = "0x2390FB8", Offset = "0x2390FB8", VA = "0x2390FB8", Slot = "7")]
      protected override void OnLoadedObject(UnityEngine.Object loaded)
      {
      }
    }

    [Token(Token = "0x2003D98")]
    protected class LoadedStackImage : Adv2Loader.LoadedStackObject
    {
      [Token(Token = "0x6018C69")]
      [Address(RVA = "0x2391084", Offset = "0x2391084", VA = "0x2391084")]
      public LoadedStackImage(string tag, string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C6A")]
      [Address(RVA = "0x23910B0", Offset = "0x23910B0", VA = "0x23910B0", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D99")]
    protected class LoadedObject : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x4010E5F")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2Object bindTarget;

      [Token(Token = "0x6018C6B")]
      [Address(RVA = "0x23911BC", Offset = "0x23911BC", VA = "0x23911BC")]
      public LoadedObject(Adv2Object target, string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C6C")]
      [Address(RVA = "0x23911E8", Offset = "0x23911E8", VA = "0x23911E8", Slot = "6")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D9A")]
    protected class LoadedTutorialPopup : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x4010E60")]
      [FieldOffset(Offset = "0x30")]
      private TutorialPopupManager tutorialManager;

      [Token(Token = "0x6018C6D")]
      [Address(RVA = "0x23912E4", Offset = "0x23912E4", VA = "0x23912E4")]
      public LoadedTutorialPopup(
        TutorialPopupManager manager,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C6E")]
      [Address(RVA = "0x2391310", Offset = "0x2391310", VA = "0x2391310", Slot = "6")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D9B")]
    protected class LoadedAnimator : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x4010E61")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2Object loadTarget;

      [Token(Token = "0x6018C6F")]
      [Address(RVA = "0x239132C", Offset = "0x239132C", VA = "0x239132C")]
      public LoadedAnimator(Adv2Object target, string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C70")]
      [Address(RVA = "0x2391358", Offset = "0x2391358", VA = "0x2391358", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D9C")]
    protected abstract class LoadedAnimationPack : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x4010E62")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2LinkageAnimation.ReserveLinagePack reserveOutputTarget;

      [Token(Token = "0x6018C71")]
      [Address(RVA = "0x2391418", Offset = "0x2391418", VA = "0x2391418")]
      public LoadedAnimationPack(
        Adv2LinkageAnimation.ReserveLinagePack reserveOutput,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C72")]
      protected abstract Adv2LinkageAnimation GetOutputTarget();

      [Token(Token = "0x6018C73")]
      [Address(RVA = "0x2391444", Offset = "0x2391444", VA = "0x2391444", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D9D")]
    protected class LoadedObjectAnimation : Adv2Loader.LoadedAnimationPack
    {
      [Token(Token = "0x4010E63")]
      [FieldOffset(Offset = "0x38")]
      protected Adv2Object output;

      [Token(Token = "0x6018C74")]
      [Address(RVA = "0x2391628", Offset = "0x2391628", VA = "0x2391628")]
      public LoadedObjectAnimation(
        Adv2Object output,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C75")]
      [Address(RVA = "0x2391660", Offset = "0x2391660", VA = "0x2391660", Slot = "6")]
      protected override Adv2LinkageAnimation GetOutputTarget() => (Adv2LinkageAnimation) null;
    }

    [Token(Token = "0x2003D9E")]
    protected class LoadedCameraAnimationClip : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x4010E64")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2Camera output;
      [Token(Token = "0x4010E65")]
      [FieldOffset(Offset = "0x38")]
      protected Adv2Object actor;
      [Token(Token = "0x4010E66")]
      [FieldOffset(Offset = "0x40")]
      protected float standardHeight;

      [Token(Token = "0x6018C76")]
      [Address(RVA = "0x239167C", Offset = "0x239167C", VA = "0x239167C")]
      public LoadedCameraAnimationClip(
        Adv2Camera output,
        string assetbundleName,
        List<string> fileNames,
        Adv2Object actor)
      {
      }

      [Token(Token = "0x6018C77")]
      [Address(RVA = "0x23916AC", Offset = "0x23916AC", VA = "0x23916AC", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003D9F")]
    protected class LoadedFacialAnimation : Adv2Loader.LoadedAnimationPack
    {
      [Token(Token = "0x4010E67")]
      [FieldOffset(Offset = "0x38")]
      protected Adv2Human output;

      [Token(Token = "0x6018C78")]
      [Address(RVA = "0x23917AC", Offset = "0x23917AC", VA = "0x23917AC")]
      public LoadedFacialAnimation(
        Adv2Human output,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C79")]
      [Address(RVA = "0x23917E4", Offset = "0x23917E4", VA = "0x23917E4", Slot = "6")]
      protected override Adv2LinkageAnimation GetOutputTarget() => (Adv2LinkageAnimation) null;
    }

    [Token(Token = "0x2003DA0")]
    protected class LoadedHeadAnimation : Adv2Loader.LoadedAnimationPack
    {
      [Token(Token = "0x4010E68")]
      [FieldOffset(Offset = "0x38")]
      protected Adv2Human output;

      [Token(Token = "0x6018C7A")]
      [Address(RVA = "0x2391800", Offset = "0x2391800", VA = "0x2391800")]
      public LoadedHeadAnimation(Adv2Human output, string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C7B")]
      [Address(RVA = "0x2391838", Offset = "0x2391838", VA = "0x2391838", Slot = "6")]
      protected override Adv2LinkageAnimation GetOutputTarget() => (Adv2LinkageAnimation) null;
    }

    [Token(Token = "0x2003DA1")]
    protected class TextLoadProsess : Adv2Manager.OnProccessSignal
    {
      [Token(Token = "0x6018C7C")]
      [Address(RVA = "0x2391854", Offset = "0x2391854", VA = "0x2391854")]
      public void UseProcessStart(string abName, TextAttributeData textAt)
      {
      }

      [Token(Token = "0x6018C7D")]
      [Address(RVA = "0x23918F8", Offset = "0x23918F8", VA = "0x23918F8")]
      private IEnumerator UseProcess(string abName, TextAttributeData textAt) => (IEnumerator) null;

      [Token(Token = "0x6018C7E")]
      [Address(RVA = "0x239199C", Offset = "0x239199C", VA = "0x239199C")]
      public TextLoadProsess()
      {
      }
    }

    [Token(Token = "0x2003DA3")]
    protected class LoadedPostEffect : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x4010E6E")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2EffectPostProcess loadTarget;
      [Token(Token = "0x4010E6F")]
      [FieldOffset(Offset = "0x38")]
      protected string layerName;

      [Token(Token = "0x6018C85")]
      [Address(RVA = "0x2391B70", Offset = "0x2391B70", VA = "0x2391B70")]
      public LoadedPostEffect(
        Adv2EffectPostProcess target,
        string layerName,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C86")]
      [Address(RVA = "0x2391BF4", Offset = "0x2391BF4", VA = "0x2391BF4", Slot = "6")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003DA4")]
    protected class LoadedPlayableDirector<T> : Adv2Loader.LoadedGameObject where T : Adv2PlayableDirectorBase
    {
      [Token(Token = "0x4010E70")]
      [FieldOffset(Offset = "0x0")]
      protected T loadTarget;

      [Token(Token = "0x6018C87")]
      public LoadedPlayableDirector(T target, string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C88")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003DA5")]
    protected class LoadedTrust : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x4010E71")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2Trust loadTarget;

      [Token(Token = "0x6018C89")]
      [Address(RVA = "0x2391C74", Offset = "0x2391C74", VA = "0x2391C74")]
      public LoadedTrust(Adv2Trust target, string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C8A")]
      [Address(RVA = "0x2391CA0", Offset = "0x2391CA0", VA = "0x2391CA0", Slot = "6")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003DA6")]
    protected class LoadedTrustResult : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x4010E72")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2TrustResultUI loadTarget;

      [Token(Token = "0x6018C8B")]
      [Address(RVA = "0x2391D1C", Offset = "0x2391D1C", VA = "0x2391D1C")]
      public LoadedTrustResult(
        Adv2TrustResultUI target,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C8C")]
      [Address(RVA = "0x2391D48", Offset = "0x2391D48", VA = "0x2391D48", Slot = "6")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003DA7")]
    protected class LoadedAssetbundleFileOnly : Adv2Loader.LoadedCallbackParam
    {
      [Token(Token = "0x6018C8D")]
      [Address(RVA = "0x2391DC4", Offset = "0x2391DC4", VA = "0x2391DC4")]
      public LoadedAssetbundleFileOnly(string assetbundleName)
      {
      }

      [Token(Token = "0x6018C8E")]
      [Address(RVA = "0x2391E58", Offset = "0x2391E58", VA = "0x2391E58", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003DA8")]
    protected class LoadedParameterUpResult : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x4010E73")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2ParameterUpResultUI loadTarget;

      [Token(Token = "0x6018C8F")]
      [Address(RVA = "0x2391E68", Offset = "0x2391E68", VA = "0x2391E68")]
      public LoadedParameterUpResult(
        Adv2ParameterUpResultUI target,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C90")]
      [Address(RVA = "0x2391E94", Offset = "0x2391E94", VA = "0x2391E94", Slot = "6")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003DA9")]
    protected class LoadedParameterUpResultDialog : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x4010E74")]
      [FieldOffset(Offset = "0x30")]
      protected Adv2ParameterUpResultDialogUI loadTarget;

      [Token(Token = "0x6018C91")]
      [Address(RVA = "0x2391F10", Offset = "0x2391F10", VA = "0x2391F10")]
      public LoadedParameterUpResultDialog(
        Adv2ParameterUpResultDialogUI target,
        string assetbundleName,
        List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C92")]
      [Address(RVA = "0x2391F3C", Offset = "0x2391F3C", VA = "0x2391F3C", Slot = "6")]
      protected override void OnLoadedObject(GameObject loaded, string fileName)
      {
      }
    }

    [Token(Token = "0x2003DAA")]
    protected class LoadedPsBattleAdvObj : Adv2Loader.LoadedGameObject
    {
      [Token(Token = "0x6018C93")]
      [Address(RVA = "0x2391FB8", Offset = "0x2391FB8", VA = "0x2391FB8")]
      public LoadedPsBattleAdvObj(string assetbundleName, List<string> fileNames)
      {
      }

      [Token(Token = "0x6018C94")]
      [Address(RVA = "0x2391FBC", Offset = "0x2391FBC", VA = "0x2391FBC", Slot = "5")]
      protected override void OnLoaded(UnityEngine.Object loadedObject, string fileName)
      {
      }
    }

    [Token(Token = "0x2003DAB")]
    public class AssetCachedSpawnerLoad : Adv2Manager.OnProccessSignal
    {
      [Token(Token = "0x4010E76")]
      [FieldOffset(Offset = "0x20")]
      private Action<UnityEngine.Object> callback;

      [Token(Token = "0x170050C8")]
      public UnityEngine.Object LoadedAsset
      {
        [Token(Token = "0x6018C95"), Address(RVA = "0x2392158", Offset = "0x2392158", VA = "0x2392158")] get
        {
          return (UnityEngine.Object) null;
        }
        [Token(Token = "0x6018C96"), Address(RVA = "0x2392160", Offset = "0x2392160", VA = "0x2392160")] private set
        {
        }
      }

      [Token(Token = "0x6018C97")]
      [Address(RVA = "0x2392168", Offset = "0x2392168", VA = "0x2392168")]
      private void onComplate(UnityEngine.Object loaded)
      {
      }

      [Token(Token = "0x6018C98")]
      [Address(RVA = "0x23921BC", Offset = "0x23921BC", VA = "0x23921BC")]
      public AssetCachedSpawnerLoad(
        string assetbundleName,
        string fileName,
        Action<UnityEngine.Object> callback = null)
      {
      }
    }
  }
}
