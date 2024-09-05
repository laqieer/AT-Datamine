// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.KizunaListSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002E8E")]
  public class KizunaListSubScene : SubScene
  {
    [Token(Token = "0x400C799")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x400C79A")]
    [FieldOffset(Offset = "0x60")]
    private KizunaListView mainView;
    [Token(Token = "0x400C79B")]
    [FieldOffset(Offset = "0x68")]
    private KizunaListChangeSceneParam sceneParam;

    [Token(Token = "0x60122D9")]
    [Address(RVA = "0x45917A8", Offset = "0x45917A8", VA = "0x45917A8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60122DA")]
    [Address(RVA = "0x4591870", Offset = "0x4591870", VA = "0x4591870", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60122DB")]
    [Address(RVA = "0x4591900", Offset = "0x4591900", VA = "0x4591900")]
    private void OnBack()
    {
    }

    [Token(Token = "0x60122DC")]
    [Address(RVA = "0x4591A3C", Offset = "0x4591A3C", VA = "0x4591A3C")]
    private KizunaQuestInfo CreateKizunaQuestInfo() => (KizunaQuestInfo) null;

    [Token(Token = "0x60122DD")]
    [Address(RVA = "0x45929D8", Offset = "0x45929D8", VA = "0x45929D8")]
    private IEnumerator LoadPrefab() => (IEnumerator) null;

    [Token(Token = "0x60122DE")]
    [Address(RVA = "0x4592A68", Offset = "0x4592A68", VA = "0x4592A68", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60122DF")]
    [Address(RVA = "0x4592AF8", Offset = "0x4592AF8", VA = "0x4592AF8", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x60122E0")]
    [Address(RVA = "0x4592AFC", Offset = "0x4592AFC", VA = "0x4592AFC", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60122E1")]
    [Address(RVA = "0x4592BE4", Offset = "0x4592BE4", VA = "0x4592BE4")]
    public KizunaListSubScene()
    {
    }
  }
}
