// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipSetEditSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003292")]
  public class EquipSetEditSubScene : SubScene
  {
    [Token(Token = "0x400D886")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private EquipSetEditView equipSetEditView;
    [Token(Token = "0x400D887")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private InOutFaderBase inOutFader;
    [Token(Token = "0x400D888")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D889")]
    protected const string UnitNumberAssetBundleName = "ui_page_partylist";
    [Token(Token = "0x400D88A")]
    [FieldOffset(Offset = "0x70")]
    private List<string> loadedAssetBundleNameList;
    [Token(Token = "0x400D88B")]
    [FieldOffset(Offset = "0x78")]
    private Style style;
    [Token(Token = "0x400D88C")]
    [FieldOffset(Offset = "0x80")]
    private bool isNeedLp;

    [Token(Token = "0x6013B8D")]
    [Address(RVA = "0x185DD68", Offset = "0x185DD68", VA = "0x185DD68")]
    public static void ChangeScene(int styleId, bool isNeedLp)
    {
    }

    [Token(Token = "0x6013B8E")]
    [Address(RVA = "0x185DE18", Offset = "0x185DE18", VA = "0x185DE18")]
    public static void ChangeScene(
      EquipSetEditSubScene.EquipSetEditSubSceneParam param)
    {
    }

    [Token(Token = "0x6013B8F")]
    [Address(RVA = "0x185DEC8", Offset = "0x185DEC8", VA = "0x185DEC8")]
    private void Update()
    {
    }

    [Token(Token = "0x6013B90")]
    [Address(RVA = "0x185DEE4", Offset = "0x185DEE4", VA = "0x185DEE4", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013B91")]
    [Address(RVA = "0x185DFB8", Offset = "0x185DFB8", VA = "0x185DFB8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013B92")]
    [Address(RVA = "0x185E048", Offset = "0x185E048", VA = "0x185E048", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6013B93")]
    [Address(RVA = "0x185E0D8", Offset = "0x185E0D8", VA = "0x185E0D8")]
    private void OnLoadComplete(List<string> succeedList, Dictionary<string, string> failedDic)
    {
    }

    [Token(Token = "0x6013B94")]
    [Address(RVA = "0x185E504", Offset = "0x185E504", VA = "0x185E504", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6013B95")]
    [Address(RVA = "0x185E540", Offset = "0x185E540", VA = "0x185E540", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6013B96")]
    [Address(RVA = "0x185E790", Offset = "0x185E790", VA = "0x185E790")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x6013B97")]
    [Address(RVA = "0x185E950", Offset = "0x185E950", VA = "0x185E950")]
    public EquipSetEditSubScene()
    {
    }

    [Token(Token = "0x2003293")]
    public class EquipSetEditSubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x17004180")]
      public int SelectStyleId
      {
        [Token(Token = "0x6013B99"), Address(RVA = "0x185E974", Offset = "0x185E974", VA = "0x185E974")] get
        {
          return new int();
        }
        [Token(Token = "0x6013B9A"), Address(RVA = "0x185E97C", Offset = "0x185E97C", VA = "0x185E97C")] private set
        {
        }
      }

      [Token(Token = "0x17004181")]
      public bool IsNeedLp
      {
        [Token(Token = "0x6013B9B"), Address(RVA = "0x185E984", Offset = "0x185E984", VA = "0x185E984")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6013B9C")]
      [Address(RVA = "0x185DDE4", Offset = "0x185DDE4", VA = "0x185DDE4")]
      public EquipSetEditSubSceneParam(int selectStyleId, bool isNeedLp)
      {
      }
    }
  }
}
