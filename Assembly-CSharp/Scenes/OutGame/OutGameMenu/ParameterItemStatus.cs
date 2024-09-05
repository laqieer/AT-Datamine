// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ParameterItemStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A6D")]
  public class ParameterItemStatus : MonoBehaviour
  {
    [Token(Token = "0x4010015")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text Txt_Title;
    [Token(Token = "0x4010016")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_Total;
    [Token(Token = "0x4010017")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_Initial;
    [Token(Token = "0x4010018")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_Board;
    [Token(Token = "0x4010019")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_Add;
    [Token(Token = "0x401001A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject Icon_Maximum;
    [Token(Token = "0x401001B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_LvUP_Top;
    [Token(Token = "0x401001C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI Txt_Slash;
    [Token(Token = "0x401001D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_LvUP_Bottom;

    [Token(Token = "0x6016F6A")]
    [Address(RVA = "0x29C2F80", Offset = "0x29C2F80", VA = "0x29C2F80")]
    public void SetParam(
      int total,
      int initial,
      int board,
      int add,
      bool isMaximum,
      int levelUp,
      int parara,
      int levelUpMax)
    {
    }

    [Token(Token = "0x6016F6B")]
    [Address(RVA = "0x29C313C", Offset = "0x29C313C", VA = "0x29C313C")]
    private static string ParamToString(int param) => (string) null;

    [Token(Token = "0x6016F6C")]
    [Address(RVA = "0x29C31E4", Offset = "0x29C31E4", VA = "0x29C31E4")]
    public ParameterItemStatus()
    {
    }
  }
}
