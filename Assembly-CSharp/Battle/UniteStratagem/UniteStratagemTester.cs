// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.UniteStratagemTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Direction.Skill;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TestRenkeiKeiryaku;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Battle.UniteStratagem
{
  [Token(Token = "0x20022B2")]
  public class UniteStratagemTester : MonoBehaviour
  {
    [Token(Token = "0x4009232")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject testerUIObject;
    [Token(Token = "0x4009233")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TMP_Text stratagemSkillDataInformation;
    [Token(Token = "0x4009234")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TMP_InputField stratagemSkillIdInputField;
    [Token(Token = "0x4009235")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform canvasTransform;
    [Token(Token = "0x4009236")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private AlignmentStratagemTesterContainer alignmentStratagemTesterContainer;
    [Token(Token = "0x4009237")]
    [FieldOffset(Offset = "0x40")]
    public GameObject eventSystemObject;
    [Token(Token = "0x4009238")]
    [FieldOffset(Offset = "0x48")]
    public Transform otherRenditionCameraRoot;
    [Token(Token = "0x4009239")]
    [FieldOffset(Offset = "0x50")]
    public RectTransform testUIRoot;
    [Token(Token = "0x400923A")]
    [FieldOffset(Offset = "0x58")]
    public Button testButton;
    [Token(Token = "0x400923B")]
    [FieldOffset(Offset = "0x60")]
    public Button stopButton;
    [Token(Token = "0x400923C")]
    [FieldOffset(Offset = "0x68")]
    public Button backButton;
    [Token(Token = "0x400923D")]
    [FieldOffset(Offset = "0x70")]
    public TextMeshProUGUI text;
    [Token(Token = "0x400923E")]
    [FieldOffset(Offset = "0x78")]
    public TextMeshProUGUI loadTimeText;
    [Token(Token = "0x400923F")]
    [FieldOffset(Offset = "0x80")]
    private Queue<string> logs;
    [Token(Token = "0x4009240")]
    [FieldOffset(Offset = "0x88")]
    private bool logModified;
    [Token(Token = "0x4009241")]
    [FieldOffset(Offset = "0x90")]
    private double minLoadTime;
    [Token(Token = "0x4009242")]
    [FieldOffset(Offset = "0x98")]
    private double maxLoadTime;
    [Token(Token = "0x4009243")]
    [FieldOffset(Offset = "0xA0")]
    private double avgLoadTime;
    [Token(Token = "0x4009244")]
    [FieldOffset(Offset = "0xA8")]
    private double minLoadBundleTime;
    [Token(Token = "0x4009245")]
    [FieldOffset(Offset = "0xB0")]
    private double maxLoadBundleTime;
    [Token(Token = "0x4009246")]
    [FieldOffset(Offset = "0xB8")]
    private double avgLoadBundleTime;
    [Token(Token = "0x4009247")]
    [FieldOffset(Offset = "0xC0")]
    private int loadCharaCount;
    [Token(Token = "0x4009248")]
    [FieldOffset(Offset = "0xC8")]
    private List<double> loadTimes;
    [Token(Token = "0x4009249")]
    [FieldOffset(Offset = "0xD0")]
    private List<double> loadBundleTimes;
    [Token(Token = "0x400924A")]
    [FieldOffset(Offset = "0xD8")]
    private GameObject mnemnographObject;
    [Token(Token = "0x400924B")]
    [FieldOffset(Offset = "0xE0")]
    private Texture mnemnographImage;
    [Token(Token = "0x400924C")]
    [FieldOffset(Offset = "0xE8")]
    private bool initialized;
    [Token(Token = "0x400924D")]
    [FieldOffset(Offset = "0xEC")]
    private int stratagemSkillID;
    [Token(Token = "0x400924E")]
    [FieldOffset(Offset = "0xF0")]
    private bool isActive;
    [Token(Token = "0x400924F")]
    [FieldOffset(Offset = "0xF1")]
    private bool isPlayingMnemnograph;
    [Token(Token = "0x4009250")]
    [FieldOffset(Offset = "0xF8")]
    private SkillData stratagemSkillData;
    [Token(Token = "0x4009251")]
    [FieldOffset(Offset = "0x100")]
    private int stratagemMnemnographEffectType;
    [Token(Token = "0x4009252")]
    [FieldOffset(Offset = "0x108")]
    private AlignmentStratagemDirection alignmentStratagemDirector;
    [Token(Token = "0x4009253")]
    [FieldOffset(Offset = "0x110")]
    private List<string> loadRequestAssetBundleLabels;

    [Token(Token = "0x600D39B")]
    [Address(RVA = "0x19D7AC8", Offset = "0x19D7AC8", VA = "0x19D7AC8")]
    public void Initialize(bool standalone)
    {
    }

    [Token(Token = "0x600D39C")]
    [Address(RVA = "0x19D8398", Offset = "0x19D8398", VA = "0x19D8398")]
    private void UpdateStratagemSkillIdInputFieldEvent(string skillIDString)
    {
    }

    [Token(Token = "0x600D39D")]
    [Address(RVA = "0x19D7DC4", Offset = "0x19D7DC4", VA = "0x19D7DC4")]
    private void LoadStratagemSkillData()
    {
    }

    [Token(Token = "0x600D39E")]
    [Address(RVA = "0x19D84B8", Offset = "0x19D84B8", VA = "0x19D84B8")]
    [ContextMenu("Test")]
    private void Test()
    {
    }

    [Token(Token = "0x600D39F")]
    [Address(RVA = "0x19D85D4", Offset = "0x19D85D4", VA = "0x19D85D4")]
    [ContextMenu("Test", true)]
    private bool EnableTest() => new bool();

    [Token(Token = "0x600D3A0")]
    [Address(RVA = "0x19D8604", Offset = "0x19D8604", VA = "0x19D8604")]
    [ContextMenu("Stop")]
    private void Stop()
    {
    }

    [Token(Token = "0x600D3A1")]
    [Address(RVA = "0x19D86F4", Offset = "0x19D86F4", VA = "0x19D86F4")]
    private void ResetCache()
    {
    }

    [Token(Token = "0x600D3A2")]
    [Address(RVA = "0x19D88A0", Offset = "0x19D88A0", VA = "0x19D88A0")]
    private void BackToDebugMenu()
    {
    }

    [Token(Token = "0x600D3A3")]
    [Address(RVA = "0x19D8964", Offset = "0x19D8964", VA = "0x19D8964")]
    [ContextMenu("Stop", true)]
    private bool EnableStop() => new bool();

    [Token(Token = "0x600D3A4")]
    [Address(RVA = "0x19D8560", Offset = "0x19D8560", VA = "0x19D8560")]
    private IEnumerator LoadAssetBundles(Action callback) => (IEnumerator) null;

    [Token(Token = "0x600D3A5")]
    [Address(RVA = "0x19D8994", Offset = "0x19D8994", VA = "0x19D8994")]
    private void LoadRequestAssetBundle(string label)
    {
    }

    [Token(Token = "0x600D3A6")]
    [Address(RVA = "0x19D8AF8", Offset = "0x19D8AF8", VA = "0x19D8AF8")]
    private IEnumerator LoadAlignmentStratagem() => (IEnumerator) null;

    [Token(Token = "0x600D3A7")]
    [Address(RVA = "0x19D8B88", Offset = "0x19D8B88", VA = "0x19D8B88")]
    private void LoadMnemnographAsset()
    {
    }

    [Token(Token = "0x600D3A8")]
    [Address(RVA = "0x19D8EAC", Offset = "0x19D8EAC", VA = "0x19D8EAC")]
    private void LoadMnemnographImageAsset()
    {
    }

    [Token(Token = "0x600D3A9")]
    [Address(RVA = "0x19D919C", Offset = "0x19D919C", VA = "0x19D919C")]
    private void SetMnemnographImage()
    {
    }

    [Token(Token = "0x600D3AA")]
    [Address(RVA = "0x19D94F8", Offset = "0x19D94F8", VA = "0x19D94F8")]
    private void AddLog(string log)
    {
    }

    [Token(Token = "0x600D3AB")]
    [Address(RVA = "0x19D955C", Offset = "0x19D955C", VA = "0x19D955C")]
    private void AddLoadTime(double time, int loadCount)
    {
    }

    [Token(Token = "0x600D3AC")]
    [Address(RVA = "0x19D9640", Offset = "0x19D9640", VA = "0x19D9640")]
    private void AddLoadBundleTime(double time, int loadCount)
    {
    }

    [Token(Token = "0x600D3AD")]
    [Address(RVA = "0x19D9724", Offset = "0x19D9724", VA = "0x19D9724")]
    private void UpdateLoadTimeText()
    {
    }

    [Token(Token = "0x600D3AE")]
    [Address(RVA = "0x19D9A94", Offset = "0x19D9A94", VA = "0x19D9A94")]
    private void PlayStratagemDirectionEvent(PlayableDirector obj = null)
    {
    }

    [Token(Token = "0x600D3AF")]
    [Address(RVA = "0x19D9CC4", Offset = "0x19D9CC4", VA = "0x19D9CC4")]
    private void ShowAlignmentStratagemDirectionWaitTime(PlayableDirector obj = null)
    {
    }

    [Token(Token = "0x600D3B0")]
    [Address(RVA = "0x19D9DAC", Offset = "0x19D9DAC", VA = "0x19D9DAC")]
    private IEnumerator DelayCoroutine(float time, UnityAction callback) => (IEnumerator) null;

    [Token(Token = "0x600D3B1")]
    [Address(RVA = "0x19D9B90", Offset = "0x19D9B90", VA = "0x19D9B90")]
    private void ShowStratagemDirection(PlayableDirector obj = null)
    {
    }

    [Token(Token = "0x600D3B2")]
    [Address(RVA = "0x19D9E4C", Offset = "0x19D9E4C", VA = "0x19D9E4C")]
    private void FinishDirection(PlayableDirector obj = null)
    {
    }

    [Token(Token = "0x600D3B3")]
    [Address(RVA = "0x19D9E50", Offset = "0x19D9E50", VA = "0x19D9E50")]
    public UniteStratagemTester()
    {
    }
  }
}
