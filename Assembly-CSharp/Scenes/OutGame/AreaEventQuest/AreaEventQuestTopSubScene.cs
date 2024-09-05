// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaEventQuestTopSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x200391F")]
  public class AreaEventQuestTopSubScene : SubScene
  {
    [Token(Token = "0x400F9B0")]
    [FieldOffset(Offset = "0x58")]
    private AreaEventQuestTopSubScene.SceneParam sceneParam;
    [Token(Token = "0x400F9B1")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F9B2")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CanvasGroup sceneCG;
    [Token(Token = "0x400F9B3")]
    [FieldOffset(Offset = "0x70")]
    private Sprite medalSprite;
    [Token(Token = "0x400F9B4")]
    [FieldOffset(Offset = "0x78")]
    private AreaQuestEventPageData areaQuestEventData;
    [Token(Token = "0x400F9B5")]
    [FieldOffset(Offset = "0x80")]
    private AreaEventQuestTopUI topUI;
    [Token(Token = "0x400F9B6")]
    [FieldOffset(Offset = "0x88")]
    private bool isHeldCumulativeMission;

    [Token(Token = "0x170049D8")]
    public static string AssetBundleName
    {
      [Token(Token = "0x601673B"), Address(RVA = "0x42E2D14", Offset = "0x42E2D14", VA = "0x42E2D14")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170049D9")]
    public static string AssetName
    {
      [Token(Token = "0x601673C"), Address(RVA = "0x42E2D54", Offset = "0x42E2D54", VA = "0x42E2D54")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601673D")]
    [Address(RVA = "0x42E2D94", Offset = "0x42E2D94", VA = "0x42E2D94")]
    public static void ChangeSubScene(int areaEventQuestId, bool isCreateBack = false)
    {
    }

    [Token(Token = "0x601673E")]
    [Address(RVA = "0x42E2F3C", Offset = "0x42E2F3C", VA = "0x42E2F3C")]
    private static void OutSidePeriod()
    {
    }

    [Token(Token = "0x601673F")]
    [Address(RVA = "0x42E310C", Offset = "0x42E310C", VA = "0x42E310C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6016740")]
    [Address(RVA = "0x42E3264", Offset = "0x42E3264", VA = "0x42E3264", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016741")]
    [Address(RVA = "0x42E32F4", Offset = "0x42E32F4", VA = "0x42E32F4", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6016742")]
    [Address(RVA = "0x42E3384", Offset = "0x42E3384", VA = "0x42E3384", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6016743")]
    [Address(RVA = "0x42E3414", Offset = "0x42E3414", VA = "0x42E3414", Slot = "24")]
    public override void OnBeforeBackScene()
    {
    }

    [Token(Token = "0x6016744")]
    [Address(RVA = "0x42E371C", Offset = "0x42E371C", VA = "0x42E371C", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6016745")]
    [Address(RVA = "0x42E37AC", Offset = "0x42E37AC", VA = "0x42E37AC", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6016746")]
    [Address(RVA = "0x42E3908", Offset = "0x42E3908", VA = "0x42E3908")]
    public void SetOperationPossible(bool state)
    {
    }

    [Token(Token = "0x6016747")]
    [Address(RVA = "0x42E3928", Offset = "0x42E3928", VA = "0x42E3928")]
    private void OnClickBack()
    {
    }

    [Token(Token = "0x6016748")]
    [Address(RVA = "0x42E37D8", Offset = "0x42E37D8", VA = "0x42E37D8")]
    private void OnBack()
    {
    }

    [Token(Token = "0x6016749")]
    [Address(RVA = "0x42E392C", Offset = "0x42E392C", VA = "0x42E392C")]
    private void OnClickAreaQuest()
    {
    }

    [Token(Token = "0x601674A")]
    [Address(RVA = "0x42E397C", Offset = "0x42E397C", VA = "0x42E397C")]
    private void OnClickEventMission()
    {
    }

    [Token(Token = "0x601674B")]
    [Address(RVA = "0x42E3C4C", Offset = "0x42E3C4C", VA = "0x42E3C4C")]
    private void OnClickCumulativeMission()
    {
    }

    [Token(Token = "0x601674C")]
    [Address(RVA = "0x42E3D5C", Offset = "0x42E3D5C", VA = "0x42E3D5C")]
    private void OnClickExchangeShop()
    {
    }

    [Token(Token = "0x601674D")]
    [Address(RVA = "0x42E406C", Offset = "0x42E406C", VA = "0x42E406C")]
    private void LoadMedalIcon()
    {
    }

    [Token(Token = "0x601674E")]
    [Address(RVA = "0x42E35D8", Offset = "0x42E35D8", VA = "0x42E35D8")]
    private void SetExChangeText()
    {
    }

    [Token(Token = "0x601674F")]
    [Address(RVA = "0x42E41C4", Offset = "0x42E41C4", VA = "0x42E41C4")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016750")]
    [Address(RVA = "0x42E342C", Offset = "0x42E342C", VA = "0x42E342C")]
    private void PlayBGM()
    {
    }

    [Token(Token = "0x6016751")]
    [Address(RVA = "0x42E426C", Offset = "0x42E426C", VA = "0x42E426C")]
    public AreaEventQuestTopSubScene()
    {
    }

    [Token(Token = "0x2003920")]
    private class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x170049DA")]
      public int AreaEventQuestId
      {
        [Token(Token = "0x6016754"), Address(RVA = "0x42E429C", Offset = "0x42E429C", VA = "0x42E429C")] get
        {
          return new int();
        }
        [Token(Token = "0x6016755"), Address(RVA = "0x42E42A4", Offset = "0x42E42A4", VA = "0x42E42A4")] set
        {
        }
      }

      [Token(Token = "0x6016756")]
      [Address(RVA = "0x42E30D4", Offset = "0x42E30D4", VA = "0x42E30D4")]
      public SceneParam(int areaEventQuestId, bool isCreatedBack = false)
      {
      }
    }
  }
}
