// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.HomeSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using StaqDebug;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003182")]
  internal class HomeSubScene : SubScene
  {
    [Token(Token = "0x400D2C3")]
    private const float ScreenHeight = 360f;
    [Token(Token = "0x400D2C4")]
    [FieldOffset(Offset = "0x8")]
    private static readonly HomeSubScene.NextSceneInfo[] NextSceneInfomations;
    [Token(Token = "0x400D2C5")]
    [FieldOffset(Offset = "0x58")]
    private bool loadedAsset;
    [Token(Token = "0x400D2C6")]
    [FieldOffset(Offset = "0x60")]
    private HomeSubScene.MenuLayout menuLayout;
    [Token(Token = "0x400D2C7")]
    [FieldOffset(Offset = "0x68")]
    private DebugAnimatedTreeView debugAnimatedTreeView;

    [Token(Token = "0x1700408C")]
    private static HomeSubScene CurrentInstance
    {
      [Token(Token = "0x6013508"), Address(RVA = "0x4A2EEC8", Offset = "0x4A2EEC8", VA = "0x4A2EEC8")] get
      {
        return (HomeSubScene) null;
      }
      [Token(Token = "0x6013509"), Address(RVA = "0x4A2EF20", Offset = "0x4A2EF20", VA = "0x4A2EF20")] set
      {
      }
    }

    [Token(Token = "0x1700408D")]
    private float AspectRatio
    {
      [Token(Token = "0x601350A"), Address(RVA = "0x4A2EF7C", Offset = "0x4A2EF7C", VA = "0x4A2EF7C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x601350B")]
    [Address(RVA = "0x4A2EFA8", Offset = "0x4A2EFA8", VA = "0x4A2EFA8")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x601350C")]
    [Address(RVA = "0x4A2F038", Offset = "0x4A2F038", VA = "0x4A2F038", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601350D")]
    [Address(RVA = "0x4A2F040", Offset = "0x4A2F040", VA = "0x4A2F040")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x601350E")]
    [Address(RVA = "0x4A2F0B4", Offset = "0x4A2F0B4", VA = "0x4A2F0B4")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601350F")]
    [Address(RVA = "0x4A2F178", Offset = "0x4A2F178", VA = "0x4A2F178")]
    private void ChangeScene(ref HomeSubScene.NextSceneInfo info)
    {
    }

    [Token(Token = "0x6013510")]
    [Address(RVA = "0x4A2F440", Offset = "0x4A2F440", VA = "0x4A2F440")]
    private void InitializeLayoutSetting()
    {
    }

    [Token(Token = "0x6013511")]
    [Address(RVA = "0x4A2F614", Offset = "0x4A2F614", VA = "0x4A2F614")]
    private void InitializeTreeView()
    {
    }

    [Token(Token = "0x6013512")]
    [Address(RVA = "0x4A2F7E0", Offset = "0x4A2F7E0", VA = "0x4A2F7E0")]
    public HomeSubScene()
    {
    }

    [Token(Token = "0x6013513")]
    [Address(RVA = "0x4A2F7E8", Offset = "0x4A2F7E8", VA = "0x4A2F7E8")]
    static HomeSubScene()
    {
    }

    [Token(Token = "0x2003183")]
    private struct NextSceneInfo
    {
      [Token(Token = "0x6013515")]
      [Address(RVA = "0x4A30298", Offset = "0x4A30298", VA = "0x4A30298")]
      public static HomeSubScene.NextSceneInfo MainSceneInfo(
        string buttonText,
        string mainSceneName,
        string subSceneAssetBundleName,
        string subSceneName)
      {
        return new HomeSubScene.NextSceneInfo();
      }

      [Token(Token = "0x6013516")]
      [Address(RVA = "0x4A30368", Offset = "0x4A30368", VA = "0x4A30368")]
      public static HomeSubScene.NextSceneInfo SubSceneInfo(
        string buttonText,
        string subSceneAssetBundleName,
        string subSceneName)
      {
        return new HomeSubScene.NextSceneInfo();
      }

      [Token(Token = "0x6013517")]
      [Address(RVA = "0x4A30378", Offset = "0x4A30378", VA = "0x4A30378")]
      public static HomeSubScene.NextSceneInfo SetCallback(
        string buttonText,
        Action<DebugTreeNode<DebugTreeExtraData>> callback)
      {
        return new HomeSubScene.NextSceneInfo();
      }

      [Token(Token = "0x1700408E")]
      public string ButtonText
      {
        [Token(Token = "0x6013518"), Address(RVA = "0x4A30454", Offset = "0x4A30454", VA = "0x4A30454")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6013519"), Address(RVA = "0x4A3045C", Offset = "0x4A3045C", VA = "0x4A3045C")] private set
        {
        }
      }

      [Token(Token = "0x1700408F")]
      public string MainSceneName
      {
        [Token(Token = "0x601351A"), Address(RVA = "0x4A30464", Offset = "0x4A30464", VA = "0x4A30464")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x601351B"), Address(RVA = "0x4A3046C", Offset = "0x4A3046C", VA = "0x4A3046C")] private set
        {
        }
      }

      [Token(Token = "0x17004090")]
      public string SubSceneAssetBundleName
      {
        [Token(Token = "0x601351C"), Address(RVA = "0x4A30474", Offset = "0x4A30474", VA = "0x4A30474")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x601351D"), Address(RVA = "0x4A3047C", Offset = "0x4A3047C", VA = "0x4A3047C")] private set
        {
        }
      }

      [Token(Token = "0x17004091")]
      public string SubSceneName
      {
        [Token(Token = "0x601351E"), Address(RVA = "0x4A30484", Offset = "0x4A30484", VA = "0x4A30484")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x601351F"), Address(RVA = "0x4A3048C", Offset = "0x4A3048C", VA = "0x4A3048C")] private set
        {
        }
      }

      [Token(Token = "0x17004092")]
      public bool IsSubScene
      {
        [Token(Token = "0x6013520"), Address(RVA = "0x4A2F434", Offset = "0x4A2F434", VA = "0x4A2F434")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17004093")]
      public Action<DebugTreeNode<DebugTreeExtraData>> Callback
      {
        [Token(Token = "0x6013521"), Address(RVA = "0x4A30494", Offset = "0x4A30494", VA = "0x4A30494")] readonly get
        {
          return (Action<DebugTreeNode<DebugTreeExtraData>>) null;
        }
        [Token(Token = "0x6013522"), Address(RVA = "0x4A3049C", Offset = "0x4A3049C", VA = "0x4A3049C")] private set
        {
        }
      }
    }

    [Token(Token = "0x2003184")]
    private class MenuLayout
    {
      [Token(Token = "0x400D2CD")]
      [FieldOffset(Offset = "0x10")]
      private HomeSubScene.MenuLayout.Setting setting;

      [Token(Token = "0x17004094")]
      public HomeSubScene.MenuLayout.ScreenInfo Screen
      {
        [Token(Token = "0x6013523"), Address(RVA = "0x4A2F094", Offset = "0x4A2F094", VA = "0x4A2F094")] get
        {
          return new HomeSubScene.MenuLayout.ScreenInfo();
        }
      }

      [Token(Token = "0x17004095")]
      public Rect MenuRect
      {
        [Token(Token = "0x6013524"), Address(RVA = "0x4A2F0A8", Offset = "0x4A2F0A8", VA = "0x4A2F0A8")] get
        {
          return new Rect();
        }
      }

      [Token(Token = "0x6013525")]
      [Address(RVA = "0x4A2F5E0", Offset = "0x4A2F5E0", VA = "0x4A2F5E0")]
      public MenuLayout(HomeSubScene.MenuLayout.Setting setting)
      {
      }

      [Token(Token = "0x2003185")]
      public struct ScreenInfo
      {
        [Token(Token = "0x17004096")]
        public int Width
        {
          [Token(Token = "0x6013526"), Address(RVA = "0x4A304A4", Offset = "0x4A304A4", VA = "0x4A304A4")] readonly get
          {
            return new int();
          }
          [Token(Token = "0x6013527"), Address(RVA = "0x4A304AC", Offset = "0x4A304AC", VA = "0x4A304AC")] set
          {
          }
        }

        [Token(Token = "0x17004097")]
        public int Height
        {
          [Token(Token = "0x6013528"), Address(RVA = "0x4A304B4", Offset = "0x4A304B4", VA = "0x4A304B4")] readonly get
          {
            return new int();
          }
          [Token(Token = "0x6013529"), Address(RVA = "0x4A304BC", Offset = "0x4A304BC", VA = "0x4A304BC")] set
          {
          }
        }

        [Token(Token = "0x17004098")]
        public int MarginedWidth
        {
          [Token(Token = "0x601352A"), Address(RVA = "0x4A2F5B0", Offset = "0x4A2F5B0", VA = "0x4A2F5B0")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17004099")]
        public int MarginedHeight
        {
          [Token(Token = "0x601352B"), Address(RVA = "0x4A2F5C8", Offset = "0x4A2F5C8", VA = "0x4A2F5C8")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x1700409A")]
        public (int left, int top, int right, int bottom) Margin
        {
          [Token(Token = "0x601352C"), Address(RVA = "0x4A304C4", Offset = "0x4A304C4", VA = "0x4A304C4")] readonly get
          {
            return ();
          }
          [Token(Token = "0x601352D"), Address(RVA = "0x4A304D0", Offset = "0x4A304D0", VA = "0x4A304D0")] set
          {
          }
        }
      }

      [Token(Token = "0x2003186")]
      public struct Setting
      {
        [Token(Token = "0x1700409B")]
        public HomeSubScene.MenuLayout.ScreenInfo Screen
        {
          [Token(Token = "0x601352E"), Address(RVA = "0x4A304D8", Offset = "0x4A304D8", VA = "0x4A304D8")] readonly get
          {
            return new HomeSubScene.MenuLayout.ScreenInfo();
          }
          [Token(Token = "0x601352F"), Address(RVA = "0x4A304EC", Offset = "0x4A304EC", VA = "0x4A304EC")] set
          {
          }
        }

        [Token(Token = "0x1700409C")]
        public Rect MenuRect
        {
          [Token(Token = "0x6013530"), Address(RVA = "0x4A30500", Offset = "0x4A30500", VA = "0x4A30500")] readonly get
          {
            return new Rect();
          }
          [Token(Token = "0x6013531"), Address(RVA = "0x4A3050C", Offset = "0x4A3050C", VA = "0x4A3050C")] set
          {
          }
        }
      }
    }
  }
}
