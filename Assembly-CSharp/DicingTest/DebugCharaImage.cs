// Decompiled with JetBrains decompiler
// Type: DicingTest.DebugCharaImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing;
using Dicing.Attribute;
using Dicing.Loader;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace DicingTest
{
  [Token(Token = "0x20003AB")]
  public class DebugCharaImage : MonoBehaviour
  {
    [Token(Token = "0x40015DE")]
    [FieldOffset(Offset = "0x18")]
    private readonly string AssetBundleLabelByFace;
    [Token(Token = "0x40015DF")]
    [FieldOffset(Offset = "0x20")]
    private readonly string AssetBundleLabelByCutin;
    [Token(Token = "0x40015E0")]
    private const string UNIT_FACE_NAME = "UnitFace";
    [Token(Token = "0x40015E1")]
    private const string UNIT_CUTIN_NAME = "UnitCutin";
    [Token(Token = "0x40015E2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Dropdown idDropdown;
    [Token(Token = "0x40015E3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Dropdown faceTypeDropDown;
    [Token(Token = "0x40015E4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform dicingObjParent;
    [Token(Token = "0x40015E5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Dropdown unregisteredIdDropDown;
    [Token(Token = "0x40015E6")]
    [FieldOffset(Offset = "0x48")]
    private CharaImage charaImage;
    [Token(Token = "0x40015E7")]
    [FieldOffset(Offset = "0x50")]
    [Header("0未満は標準時間を利用する")]
    [SerializeField]
    private float transitionTime;
    [Token(Token = "0x40015E8")]
    [FieldOffset(Offset = "0x58")]
    [ReadOnly]
    [SerializeField]
    private List<string> targetNameList;
    [Token(Token = "0x40015E9")]
    [FieldOffset(Offset = "0x60")]
    [ReadOnly]
    [SerializeField]
    private List<string> unregisteredCharaIDNameList;
    [Token(Token = "0x40015EA")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [ReadOnly]
    private List<string> targetFacePatternList;
    [Token(Token = "0x40015EB")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject loadingPanel;
    [Token(Token = "0x40015EC")]
    [FieldOffset(Offset = "0x78")]
    private DicingLoader dicingLoader;
    [Token(Token = "0x40015ED")]
    [FieldOffset(Offset = "0x80")]
    private string debugUnitName;
    [Token(Token = "0x40015EE")]
    [FieldOffset(Offset = "0x88")]
    private DebugCharaImage.ViewType viewType;

    [Token(Token = "0x6001549")]
    [Address(RVA = "0x247ECA8", Offset = "0x247ECA8", VA = "0x247ECA8")]
    private string GetLabel(string charaId, string styleId, DebugCharaImage.ViewType viewType)
    {
      return (string) null;
    }

    [Token(Token = "0x600154A")]
    [Address(RVA = "0x247ED50", Offset = "0x247ED50", VA = "0x247ED50")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600154B")]
    [Address(RVA = "0x247EDE0", Offset = "0x247EDE0", VA = "0x247EDE0")]
    private void ResetData()
    {
    }

    [Token(Token = "0x600154C")]
    [Address(RVA = "0x247F07C", Offset = "0x247F07C", VA = "0x247F07C")]
    private IEnumerator SetDropDownByFace() => (IEnumerator) null;

    [Token(Token = "0x600154D")]
    [Address(RVA = "0x247F10C", Offset = "0x247F10C", VA = "0x247F10C")]
    private IEnumerator SetDropDownByCutin() => (IEnumerator) null;

    [Token(Token = "0x600154E")]
    [Address(RVA = "0x247F19C", Offset = "0x247F19C", VA = "0x247F19C")]
    private IEnumerator SetDropDownData(string charaIdText, string styleIdText)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600154F")]
    [Address(RVA = "0x247F240", Offset = "0x247F240", VA = "0x247F240")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001550")]
    [Address(RVA = "0x247F410", Offset = "0x247F410", VA = "0x247F410")]
    public void TestChangeChara(string idText, int dropDownId)
    {
    }

    [Token(Token = "0x6001551")]
    [Address(RVA = "0x247F8C4", Offset = "0x247F8C4", VA = "0x247F8C4")]
    public void OnToggleUnitFace(Toggle toggle)
    {
    }

    [Token(Token = "0x6001552")]
    [Address(RVA = "0x247F944", Offset = "0x247F944", VA = "0x247F944")]
    public void OnTogglrUnitCutin(Toggle toggle)
    {
    }

    [Token(Token = "0x6001553")]
    [Address(RVA = "0x247F9C8", Offset = "0x247F9C8", VA = "0x247F9C8")]
    public void OnSelectOption()
    {
    }

    [Token(Token = "0x6001554")]
    [Address(RVA = "0x247FAD0", Offset = "0x247FAD0", VA = "0x247FAD0")]
    public void OnSelectFaceType()
    {
    }

    [Token(Token = "0x6001555")]
    [Address(RVA = "0x247FB8C", Offset = "0x247FB8C", VA = "0x247FB8C")]
    public void OnClickToEyeClose()
    {
    }

    [Token(Token = "0x6001556")]
    [Address(RVA = "0x247FC14", Offset = "0x247FC14", VA = "0x247FC14")]
    public void OnClickToEyeOpen()
    {
    }

    [Token(Token = "0x6001557")]
    [Address(RVA = "0x247FC9C", Offset = "0x247FC9C", VA = "0x247FC9C")]
    public void OnClickToEyeOnceAnim()
    {
    }

    [Token(Token = "0x6001558")]
    [Address(RVA = "0x247FD28", Offset = "0x247FD28", VA = "0x247FD28")]
    public void OnClickToMouthClose()
    {
    }

    [Token(Token = "0x6001559")]
    [Address(RVA = "0x247FDB0", Offset = "0x247FDB0", VA = "0x247FDB0")]
    public void OnClickToMouthOpen()
    {
    }

    [Token(Token = "0x600155A")]
    [Address(RVA = "0x247FE38", Offset = "0x247FE38", VA = "0x247FE38")]
    public void OnClickToMouthOnceAnim()
    {
    }

    [Token(Token = "0x600155B")]
    [Address(RVA = "0x247FEC4", Offset = "0x247FEC4", VA = "0x247FEC4")]
    public void TestLoopEye()
    {
    }

    [Token(Token = "0x600155C")]
    [Address(RVA = "0x247F308", Offset = "0x247F308", VA = "0x247F308")]
    public void StopLoopEye()
    {
    }

    [Token(Token = "0x600155D")]
    [Address(RVA = "0x247FF48", Offset = "0x247FF48", VA = "0x247FF48")]
    public void TestLoopMouth()
    {
    }

    [Token(Token = "0x600155E")]
    [Address(RVA = "0x247F38C", Offset = "0x247F38C", VA = "0x247F38C")]
    public void StopLoopMouth()
    {
    }

    [Token(Token = "0x600155F")]
    [Address(RVA = "0x247FFCC", Offset = "0x247FFCC", VA = "0x247FFCC")]
    public void SetUnregisteredCharaID(InputField target)
    {
    }

    [Token(Token = "0x6001560")]
    [Address(RVA = "0x248014C", Offset = "0x248014C", VA = "0x248014C")]
    public void OnSelectOptionUnregisteredCharaID()
    {
    }

    [Token(Token = "0x6001561")]
    [Address(RVA = "0x2480254", Offset = "0x2480254", VA = "0x2480254")]
    public void ResetUnregisteredCharaID()
    {
    }

    [Token(Token = "0x6001562")]
    [Address(RVA = "0x2480564", Offset = "0x2480564", VA = "0x2480564")]
    public DebugCharaImage()
    {
    }

    [Token(Token = "0x20003AC")]
    public enum ViewType
    {
      [Token(Token = "0x40015F0")] Face,
      [Token(Token = "0x40015F1")] Cutin,
    }
  }
}
