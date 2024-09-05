// Decompiled with JetBrains decompiler
// Type: staq_3DModel_Viewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000303")]
public class staq_3DModel_Viewer : MonoBehaviour
{
  [Token(Token = "0x40011D3")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string InitialModelAssetBundleName;
  [Token(Token = "0x40011D4")]
  [FieldOffset(Offset = "0x18")]
  public float maxAngle;
  [Token(Token = "0x40011D5")]
  [FieldOffset(Offset = "0x1C")]
  public float minAngle;
  [Token(Token = "0x40011D6")]
  [FieldOffset(Offset = "0x20")]
  public float rotateSpeed;
  [Token(Token = "0x40011D7")]
  [FieldOffset(Offset = "0x24")]
  public float moveSpeed;
  [Token(Token = "0x40011D8")]
  [FieldOffset(Offset = "0x28")]
  public float pinchSpeed;
  [Token(Token = "0x40011D9")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Camera camera;
  [Token(Token = "0x40011DA")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private GameObject light;
  [Token(Token = "0x40011DB")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private RuntimeAnimatorController animatorController;
  [Token(Token = "0x40011DC")]
  [FieldOffset(Offset = "0x48")]
  [HideInInspector]
  [SerializeField]
  private List<staq_3DModel_Viewer.AssetBundleData> modelAssetBundleDataList;
  [Token(Token = "0x40011DD")]
  [FieldOffset(Offset = "0x50")]
  [HideInInspector]
  [SerializeField]
  private List<staq_3DModel_Viewer.AssetBundleData> motionAssetBundleDataList;
  [Token(Token = "0x40011DE")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  [HideInInspector]
  private List<staq_3DModel_Viewer.AssetBundleData> faceAssetBundleDataList;
  [Token(Token = "0x40011DF")]
  [FieldOffset(Offset = "0x60")]
  [HideInInspector]
  [SerializeField]
  private List<string> modelAssetBundleRegexPatterns;
  [Token(Token = "0x40011E0")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private List<string> modelAssetBundleDirectories;
  [Token(Token = "0x40011E1")]
  [FieldOffset(Offset = "0x70")]
  [HideInInspector]
  [SerializeField]
  private List<string> motionAssetBundleRegexPatterns;
  [Token(Token = "0x40011E2")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private List<string> motionAssetBundleDirectories;
  [Token(Token = "0x40011E3")]
  [FieldOffset(Offset = "0x80")]
  [HideInInspector]
  [SerializeField]
  private List<string> faceAssetBundleRegexPatterns;
  [Token(Token = "0x40011E4")]
  [FieldOffset(Offset = "0x88")]
  [HideInInspector]
  [SerializeField]
  private List<GameObject> modelPrefabList;
  [Token(Token = "0x40011E5")]
  [FieldOffset(Offset = "0x90")]
  [HideInInspector]
  [SerializeField]
  private List<AnimationClip> motionClipbList;
  [Token(Token = "0x40011E6")]
  [FieldOffset(Offset = "0x98")]
  [HideInInspector]
  [SerializeField]
  private List<AnimationClip> faceClipbList;
  [Token(Token = "0x40011E7")]
  [FieldOffset(Offset = "0xA0")]
  private Vector2[] beforePoint;
  [Token(Token = "0x40011E8")]
  [FieldOffset(Offset = "0xA8")]
  private Vector2[] nowPoint;
  [Token(Token = "0x40011E9")]
  [FieldOffset(Offset = "0xB0")]
  private Vector2[] diffPoint;
  [Token(Token = "0x40011EA")]
  [FieldOffset(Offset = "0xB8")]
  private Vector2 difference;
  [Token(Token = "0x40011EB")]
  [FieldOffset(Offset = "0xC0")]
  private float horizontalAngle;
  [Token(Token = "0x40011EC")]
  [FieldOffset(Offset = "0xC4")]
  private float varticalAngle;
  [Token(Token = "0x40011ED")]
  [FieldOffset(Offset = "0xC8")]
  private float horizontalPosition;
  [Token(Token = "0x40011EE")]
  [FieldOffset(Offset = "0xCC")]
  private float varticalPosition;
  [Token(Token = "0x40011EF")]
  [FieldOffset(Offset = "0xD0")]
  private float operationXLimit;
  [Token(Token = "0x40011F0")]
  [FieldOffset(Offset = "0xD8")]
  private Transform cameraParent;
  [Token(Token = "0x40011F1")]
  [FieldOffset(Offset = "0xE0")]
  private GameObject chara;
  [Token(Token = "0x40011F2")]
  [FieldOffset(Offset = "0xE8")]
  private AnimatorOverrideController overrideController;
  [Token(Token = "0x40011F3")]
  [FieldOffset(Offset = "0xF0")]
  private staq_3DModel_Viewer.State nowState;
  [Token(Token = "0x40011F4")]
  [FieldOffset(Offset = "0xF8")]
  private List<int> missingModelAssetBundleDataIndices;
  [Token(Token = "0x40011F5")]
  [FieldOffset(Offset = "0x100")]
  private int modelProgressMax;
  [Token(Token = "0x40011F6")]
  [FieldOffset(Offset = "0x104")]
  private int modelProgressCnt;
  [Token(Token = "0x40011F7")]
  [FieldOffset(Offset = "0x108")]
  private List<int> missingMotionAssetBundleDataIndices;
  [Token(Token = "0x40011F8")]
  [FieldOffset(Offset = "0x110")]
  private int motionProgressMax;
  [Token(Token = "0x40011F9")]
  [FieldOffset(Offset = "0x114")]
  private int motionProgressCnt;
  [Token(Token = "0x40011FA")]
  [FieldOffset(Offset = "0x118")]
  private List<int> missingFaceAssetBundleDataIndices;
  [Token(Token = "0x40011FB")]
  [FieldOffset(Offset = "0x120")]
  private float fov;
  [Token(Token = "0x40011FC")]
  [FieldOffset(Offset = "0x124")]
  private float rotLight;
  [Token(Token = "0x40011FD")]
  [FieldOffset(Offset = "0x8")]
  private static readonly float ButtonHeight;
  [Token(Token = "0x40011FE")]
  [FieldOffset(Offset = "0xC")]
  private static readonly float Margin;
  [Token(Token = "0x40011FF")]
  [FieldOffset(Offset = "0x10")]
  private static readonly Color BoxColor;
  [Token(Token = "0x4001200")]
  [FieldOffset(Offset = "0x20")]
  private static readonly string EmptyLabel;
  [Token(Token = "0x4001201")]
  [FieldOffset(Offset = "0x128")]
  private staq_3DModel_Viewer.DisplayMode dismode;
  [Token(Token = "0x4001202")]
  [FieldOffset(Offset = "0x12C")]
  private Vector2 posModelScrl;
  [Token(Token = "0x4001203")]
  [FieldOffset(Offset = "0x134")]
  private Vector2 posMotionScrl;
  [Token(Token = "0x4001204")]
  [FieldOffset(Offset = "0x13C")]
  private Vector2 posFaceScrl;
  [Token(Token = "0x4001205")]
  [FieldOffset(Offset = "0x144")]
  private int selectModelIdx;
  [Token(Token = "0x4001206")]
  [FieldOffset(Offset = "0x148")]
  private int selectMotionIdx;
  [Token(Token = "0x4001207")]
  [FieldOffset(Offset = "0x14C")]
  private int selectFaceIdx;
  [Token(Token = "0x4001208")]
  [FieldOffset(Offset = "0x150")]
  private string selectModelLabel;
  [Token(Token = "0x4001209")]
  [FieldOffset(Offset = "0x158")]
  private string selectMotionLabel;
  [Token(Token = "0x400120A")]
  [FieldOffset(Offset = "0x160")]
  private string selectFaceLabel;

  [Token(Token = "0x6001264")]
  [Address(RVA = "0x27E0CC8", Offset = "0x27E0CC8", VA = "0x27E0CC8")]
  private IEnumerator Start() => (IEnumerator) null;

  [Token(Token = "0x6001265")]
  [Address(RVA = "0x27E0D58", Offset = "0x27E0D58", VA = "0x27E0D58")]
  private void Update()
  {
  }

  [Token(Token = "0x6001266")]
  [Address(RVA = "0x27E1C0C", Offset = "0x27E1C0C", VA = "0x27E1C0C")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6001267")]
  [Address(RVA = "0x27E0D80", Offset = "0x27E0D80", VA = "0x27E0D80")]
  private void OneFingerOperation()
  {
  }

  [Token(Token = "0x6001268")]
  [Address(RVA = "0x27E1228", Offset = "0x27E1228", VA = "0x27E1228")]
  private void TwoFingerOperation()
  {
  }

  [Token(Token = "0x6001269")]
  [Address(RVA = "0x27E1CE4", Offset = "0x27E1CE4", VA = "0x27E1CE4")]
  private void MouseOperation()
  {
  }

  [Token(Token = "0x600126A")]
  [Address(RVA = "0x27E20DC", Offset = "0x27E20DC", VA = "0x27E20DC")]
  private IEnumerator InitChara() => (IEnumerator) null;

  [Token(Token = "0x600126B")]
  [Address(RVA = "0x27E216C", Offset = "0x27E216C", VA = "0x27E216C")]
  private IEnumerator SetCharacter(int idx) => (IEnumerator) null;

  [Token(Token = "0x600126C")]
  [Address(RVA = "0x27E220C", Offset = "0x27E220C", VA = "0x27E220C")]
  private IEnumerator SetMotion(int idx, bool isBase) => (IEnumerator) null;

  [Token(Token = "0x600126D")]
  [Address(RVA = "0x27E22B8", Offset = "0x27E22B8", VA = "0x27E22B8")]
  public void ResetCamera()
  {
  }

  [Token(Token = "0x600126E")]
  [Address(RVA = "0x27E1BB0", Offset = "0x27E1BB0", VA = "0x27E1BB0")]
  public void RotationLight()
  {
  }

  [Token(Token = "0x600126F")]
  [Address(RVA = "0x27E1BE8", Offset = "0x27E1BE8", VA = "0x27E1BE8")]
  public void SetCameraFov()
  {
  }

  [Token(Token = "0x6001270")]
  [Address(RVA = "0x27E2358", Offset = "0x27E2358", VA = "0x27E2358")]
  private void InitGUI()
  {
  }

  [Token(Token = "0x6001271")]
  [Address(RVA = "0x27E24A4", Offset = "0x27E24A4", VA = "0x27E24A4")]
  private Rect ScaleRect(Rect rect, float scale) => new Rect();

  [Token(Token = "0x6001272")]
  [Address(RVA = "0x27E23C8", Offset = "0x27E23C8", VA = "0x27E23C8")]
  private string GetModelLabelFromAssetBundleName(string assetBundleName) => (string) null;

  [Token(Token = "0x6001273")]
  [Address(RVA = "0x27E2524", Offset = "0x27E2524", VA = "0x27E2524")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x6001274")]
  [Address(RVA = "0x27E4300", Offset = "0x27E4300", VA = "0x27E4300")]
  public staq_3DModel_Viewer()
  {
  }

  [Token(Token = "0x6001275")]
  [Address(RVA = "0x27E4B88", Offset = "0x27E4B88", VA = "0x27E4B88")]
  static staq_3DModel_Viewer()
  {
  }

  [Token(Token = "0x2000304")]
  [Serializable]
  public class AssetBundleData
  {
    [Token(Token = "0x400120B")]
    [FieldOffset(Offset = "0x10")]
    public string assetBundleName;
    [Token(Token = "0x400120C")]
    [FieldOffset(Offset = "0x18")]
    public string assetName;

    [Token(Token = "0x6001276")]
    [Address(RVA = "0x27E4C30", Offset = "0x27E4C30", VA = "0x27E4C30")]
    public AssetBundleData()
    {
    }
  }

  [Token(Token = "0x2000305")]
  private enum State
  {
    [Token(Token = "0x400120E")] DEFAULT,
    [Token(Token = "0x400120F")] SWIPE,
    [Token(Token = "0x4001210")] PINCH,
  }

  [Token(Token = "0x2000306")]
  private static class ModelViewerGUIStyles
  {
    [Token(Token = "0x4001211")]
    [FieldOffset(Offset = "0x0")]
    public static GUIStyle styleLbl;
    [Token(Token = "0x4001212")]
    [FieldOffset(Offset = "0x8")]
    public static GUIStyle styleBtn;
    [Token(Token = "0x4001213")]
    [FieldOffset(Offset = "0x10")]
    public static GUIStyle styleMiniBtn;
    [Token(Token = "0x4001214")]
    [FieldOffset(Offset = "0x18")]
    public static GUIStyle styleBox;
    [Token(Token = "0x4001215")]
    [FieldOffset(Offset = "0x20")]
    private static readonly float VScrollbarFixedWidth;
    [Token(Token = "0x4001216")]
    [FieldOffset(Offset = "0x24")]
    private static readonly float VScrollbarThumbFixedWidth;
    [Token(Token = "0x4001217")]
    [FieldOffset(Offset = "0x28")]
    private static readonly float VScrollWidthScale;

    [Token(Token = "0x6001277")]
    [Address(RVA = "0x27E4C38", Offset = "0x27E4C38", VA = "0x27E4C38")]
    static ModelViewerGUIStyles()
    {
    }
  }

  [Token(Token = "0x2000307")]
  private enum DisplayMode
  {
    [Token(Token = "0x4001219")] Loading,
    [Token(Token = "0x400121A")] Menu,
    [Token(Token = "0x400121B")] Camera,
    [Token(Token = "0x400121C")] Model,
    [Token(Token = "0x400121D")] Motion,
    [Token(Token = "0x400121E")] Face,
  }
}
