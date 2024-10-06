// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindLogParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x2002449")]
  public class BattleRewindLogParts : MonoBehaviour
  {
    [Token(Token = "0x4009B96")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject selectObject;
    [Token(Token = "0x4009B97")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI logText;
    [Token(Token = "0x4009B98")]
    [FieldOffset(Offset = "0x28")]
    private int index;
    [Token(Token = "0x4009B99")]
    [FieldOffset(Offset = "0x30")]
    private UnityAction<int> touchEvent;

    [Token(Token = "0x17002FB2")]
    public GameObject SelectObject
    {
      [Token(Token = "0x600DE5C"), Address(RVA = "0x1E3207C", Offset = "0x1E3207C", VA = "0x1E3207C")] set
      {
      }
    }

    [Token(Token = "0x17002FB3")]
    public string LogText
    {
      [Token(Token = "0x600DE5D"), Address(RVA = "0x1E32084", Offset = "0x1E32084", VA = "0x1E32084")] set
      {
      }
    }

    [Token(Token = "0x17002FB4")]
    public int Index
    {
      [Token(Token = "0x600DE5E"), Address(RVA = "0x1E32090", Offset = "0x1E32090", VA = "0x1E32090")] set
      {
      }
    }

    [Token(Token = "0x17002FB5")]
    public UnityAction<int> TouchEvent
    {
      [Token(Token = "0x600DE5F"), Address(RVA = "0x1E32098", Offset = "0x1E32098", VA = "0x1E32098")] set
      {
      }
    }

    [Token(Token = "0x600DE60")]
    [Address(RVA = "0x1E320A0", Offset = "0x1E320A0", VA = "0x1E320A0")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x600DE61")]
    [Address(RVA = "0x1E320C0", Offset = "0x1E320C0", VA = "0x1E320C0")]
    public void TouchButtonTrigger()
    {
    }

    [Token(Token = "0x600DE62")]
    [Address(RVA = "0x1E320E0", Offset = "0x1E320E0", VA = "0x1E320E0")]
    public BattleRewindLogParts()
    {
    }
  }
}
