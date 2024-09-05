// Decompiled with JetBrains decompiler
// Type: TextViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002BD")]
public class TextViewer : GameCore.Scene.Scene
{
  [Token(Token = "0x4001006")]
  [FieldOffset(Offset = "0x58")]
  public Dropdown dropHistory;
  [Token(Token = "0x4001007")]
  [FieldOffset(Offset = "0x60")]
  public Toggle toggleSelectView;
  [Token(Token = "0x4001008")]
  [FieldOffset(Offset = "0x68")]
  public UnityEngine.UI.Text textCurrentID;
  [Token(Token = "0x4001009")]
  [FieldOffset(Offset = "0x70")]
  public InputField textID;
  [Token(Token = "0x400100A")]
  [FieldOffset(Offset = "0x78")]
  public RubyTextMeshProUGUI textJA;
  [Token(Token = "0x400100B")]
  [FieldOffset(Offset = "0x80")]
  public RubyTextMeshProUGUI textEN;
  [Token(Token = "0x400100C")]
  [FieldOffset(Offset = "0x88")]
  public RubyTextMeshProUGUI textZH;
  [Token(Token = "0x400100D")]
  [FieldOffset(Offset = "0x90")]
  public RubyTextMeshProUGUI textJAfull;
  [Token(Token = "0x400100E")]
  [FieldOffset(Offset = "0x98")]
  public RubyTextMeshProUGUI textENfull;
  [Token(Token = "0x400100F")]
  [FieldOffset(Offset = "0xA0")]
  public RubyTextMeshProUGUI textZHfull;
  [Token(Token = "0x4001010")]
  [FieldOffset(Offset = "0xA8")]
  private Dictionary<string, RubyTextMeshProUGUI> textArea;
  [Token(Token = "0x4001011")]
  [FieldOffset(Offset = "0xB0")]
  private Dictionary<string, RubyTextMeshProUGUI> textAreaFull;
  [Token(Token = "0x4001012")]
  [FieldOffset(Offset = "0xB8")]
  public Button buttonInvaliChr;
  [Token(Token = "0x4001013")]
  [FieldOffset(Offset = "0xC0")]
  public GameObject dialog;
  [Token(Token = "0x4001014")]
  [FieldOffset(Offset = "0xC8")]
  public InputField inputDLC;
  [Token(Token = "0x4001015")]
  [FieldOffset(Offset = "0xD0")]
  public Button buttonLoadDLC;
  [Token(Token = "0x4001016")]
  [FieldOffset(Offset = "0xD8")]
  public InputField inputLocalizeTestDLC;
  [Token(Token = "0x4001017")]
  [FieldOffset(Offset = "0xE0")]
  public InputField inputLocalizeTestID;
  [Token(Token = "0x4001018")]
  [FieldOffset(Offset = "0xE8")]
  public UnityEngine.UI.Text textLocalizeTest;
  [Token(Token = "0x4001019")]
  [FieldOffset(Offset = "0xF0")]
  public int historyMax;
  [Token(Token = "0x400101A")]
  [FieldOffset(Offset = "0xF8")]
  private Dictionary<string, Dictionary<string, string>> textlist;
  [Token(Token = "0x400101B")]
  [FieldOffset(Offset = "0x100")]
  private List<string> listTextID;
  [Token(Token = "0x400101C")]
  [FieldOffset(Offset = "0x108")]
  private int current;
  [Token(Token = "0x400101D")]
  [FieldOffset(Offset = "0x110")]
  private string historyFile;
  [Token(Token = "0x400101E")]
  [FieldOffset(Offset = "0x118")]
  private bool buttonNext;
  [Token(Token = "0x400101F")]
  [FieldOffset(Offset = "0x119")]
  private bool buttonPrev;
  [Token(Token = "0x4001020")]
  [FieldOffset(Offset = "0x11C")]
  private int timeNextDown;
  [Token(Token = "0x4001021")]
  [FieldOffset(Offset = "0x120")]
  private int timePrevDown;
  [Token(Token = "0x4001022")]
  [FieldOffset(Offset = "0x124")]
  private bool initialized;
  [Token(Token = "0x4001023")]
  [FieldOffset(Offset = "0x0")]
  private static readonly Regex DotTagRegex;

  [Token(Token = "0x6001115")]
  [Address(RVA = "0x1BED198", Offset = "0x1BED198", VA = "0x1BED198")]
  public void Awake()
  {
  }

  [Token(Token = "0x6001116")]
  [Address(RVA = "0x1BED594", Offset = "0x1BED594", VA = "0x1BED594")]
  private IEnumerator LoadFont() => (IEnumerator) null;

  [Token(Token = "0x6001117")]
  [Address(RVA = "0x1BED624", Offset = "0x1BED624", VA = "0x1BED624")]
  private void SetFontToText(string lang, string dlcName)
  {
  }

  [Token(Token = "0x6001118")]
  [Address(RVA = "0x1BED7E8", Offset = "0x1BED7E8", VA = "0x1BED7E8", Slot = "22")]
  protected override void Update()
  {
  }

  [Token(Token = "0x6001119")]
  [Address(RVA = "0x1BEE2C0", Offset = "0x1BEE2C0", VA = "0x1BEE2C0")]
  private void ReadHistory()
  {
  }

  [Token(Token = "0x600111A")]
  [Address(RVA = "0x1BEE580", Offset = "0x1BEE580", VA = "0x1BEE580")]
  private void UpdateHistory(string newFile)
  {
  }

  [Token(Token = "0x600111B")]
  [Address(RVA = "0x1BED338", Offset = "0x1BED338", VA = "0x1BED338")]
  private void Reset()
  {
  }

  [Token(Token = "0x600111C")]
  [Address(RVA = "0x1BEEC08", Offset = "0x1BEEC08", VA = "0x1BEEC08")]
  public void OnClickOpenDialog()
  {
  }

  [Token(Token = "0x600111D")]
  [Address(RVA = "0x1BEEC28", Offset = "0x1BEEC28", VA = "0x1BEEC28")]
  private bool CheckInvalidCharacters() => new bool();

  [Token(Token = "0x600111E")]
  [Address(RVA = "0x1BEEFF4", Offset = "0x1BEEFF4", VA = "0x1BEEFF4")]
  public void ExportInvalidCharacterList()
  {
  }

  [Token(Token = "0x600111F")]
  [Address(RVA = "0x1BEEFF8", Offset = "0x1BEEFF8", VA = "0x1BEEFF8")]
  public void OnClickLoadDLC()
  {
  }

  [Token(Token = "0x6001120")]
  [Address(RVA = "0x1BEF198", Offset = "0x1BEF198", VA = "0x1BEF198")]
  private void LoadTextResources()
  {
  }

  [Token(Token = "0x6001121")]
  [Address(RVA = "0x1BEF7A8", Offset = "0x1BEF7A8", VA = "0x1BEF7A8")]
  private IEnumerator loadTextDLC(string label) => (IEnumerator) null;

  [Token(Token = "0x6001122")]
  [Address(RVA = "0x1BEF844", Offset = "0x1BEF844", VA = "0x1BEF844")]
  public void OnClickCloseDialog()
  {
  }

  [Token(Token = "0x6001123")]
  [Address(RVA = "0x1BEF864", Offset = "0x1BEF864", VA = "0x1BEF864")]
  public void OnValueChange(int value)
  {
  }

  [Token(Token = "0x6001124")]
  [Address(RVA = "0x1BEF8DC", Offset = "0x1BEF8DC", VA = "0x1BEF8DC")]
  private void LoadText(string path)
  {
  }

  [Token(Token = "0x6001125")]
  [Address(RVA = "0x1BEF9B4", Offset = "0x1BEF9B4", VA = "0x1BEF9B4")]
  private void LoadTextData(string path)
  {
  }

  [Token(Token = "0x6001126")]
  [Address(RVA = "0x1BF00D4", Offset = "0x1BF00D4", VA = "0x1BF00D4")]
  public static string DotTextFormatting(string text) => (string) null;

  [Token(Token = "0x6001127")]
  [Address(RVA = "0x1BF0528", Offset = "0x1BF0528", VA = "0x1BF0528")]
  private static string CreateDotReplaceValue(string baseText) => (string) null;

  [Token(Token = "0x6001128")]
  [Address(RVA = "0x1BED8E8", Offset = "0x1BED8E8", VA = "0x1BED8E8")]
  private void ShowText()
  {
  }

  [Token(Token = "0x6001129")]
  [Address(RVA = "0x1BF0638", Offset = "0x1BF0638", VA = "0x1BF0638")]
  public void OnButtonNextDown(int value)
  {
  }

  [Token(Token = "0x600112A")]
  [Address(RVA = "0x1BF0660", Offset = "0x1BF0660", VA = "0x1BF0660")]
  public void OnButtonNextUp(int value)
  {
  }

  [Token(Token = "0x600112B")]
  [Address(RVA = "0x1BF0680", Offset = "0x1BF0680", VA = "0x1BF0680")]
  public void OnEndEditTextID()
  {
  }

  [Token(Token = "0x600112C")]
  [Address(RVA = "0x1BF0858", Offset = "0x1BF0858", VA = "0x1BF0858")]
  public void OnChangeSelectView(bool a)
  {
  }

  [Token(Token = "0x600112D")]
  [Address(RVA = "0x1BF09DC", Offset = "0x1BF09DC", VA = "0x1BF09DC")]
  public TextViewer()
  {
  }

  [Token(Token = "0x600112E")]
  [Address(RVA = "0x1BF0A7C", Offset = "0x1BF0A7C", VA = "0x1BF0A7C")]
  static TextViewer()
  {
  }
}
