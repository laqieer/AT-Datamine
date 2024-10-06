// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ParameterItemBattleStatus
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
  [Token(Token = "0x2003A6C")]
  public class ParameterItemBattleStatus : MonoBehaviour
  {
    [Token(Token = "0x4010011")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text Txt_Title;
    [Token(Token = "0x4010012")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_Total;
    [Token(Token = "0x4010013")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_Status;
    [Token(Token = "0x4010014")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI Txt_Value_Add;

    [Token(Token = "0x6016F67")]
    [Address(RVA = "0x29C2E30", Offset = "0x29C2E30", VA = "0x29C2E30")]
    public void SetParam(int total, int status, int add)
    {
    }

    [Token(Token = "0x6016F68")]
    [Address(RVA = "0x29C2ED0", Offset = "0x29C2ED0", VA = "0x29C2ED0")]
    private static string ParamToString(int param) => (string) null;

    [Token(Token = "0x6016F69")]
    [Address(RVA = "0x29C2F78", Offset = "0x29C2F78", VA = "0x29C2F78")]
    public ParameterItemBattleStatus()
    {
    }
  }
}
