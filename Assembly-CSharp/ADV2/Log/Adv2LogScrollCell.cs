// Decompiled with JetBrains decompiler
// Type: ADV2.Log.Adv2LogScrollCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ADV2.Log
{
  [Token(Token = "0x2003E8F")]
  public class Adv2LogScrollCell : UIScrollGridItem
  {
    [Token(Token = "0x4011283")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text CharaNameR;
    [Token(Token = "0x4011284")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text CharaNameL;
    [Token(Token = "0x4011285")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject CharaNameObjR;
    [Token(Token = "0x4011286")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject CharaNameObjL;
    [Token(Token = "0x4011287")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject CharacterPrefabR;
    [Token(Token = "0x4011288")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject CharacterPrefabL;
    [Token(Token = "0x4011289")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image CharacterImageR;
    [Token(Token = "0x401128A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image CharacterImageL;
    [Token(Token = "0x401128B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button VoicePlayButton;
    [Token(Token = "0x401128C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private RubyTextMeshProUGUI Message;
    [Token(Token = "0x401128D")]
    [FieldOffset(Offset = "0x68")]
    private string voiceTag;

    [Token(Token = "0x60192EA")]
    [Address(RVA = "0x2D02550", Offset = "0x2D02550", VA = "0x2D02550")]
    private void Start()
    {
    }

    [Token(Token = "0x60192EB")]
    [Address(RVA = "0x2D02624", Offset = "0x2D02624", VA = "0x2D02624", Slot = "4")]
    public override void Initialize(UIScrollGridPane owner)
    {
    }

    [Token(Token = "0x60192EC")]
    [Address(RVA = "0x2D0262C", Offset = "0x2D0262C", VA = "0x2D0262C")]
    public void UpdateCell(Adv2LogScrollPane.LogData data)
    {
    }

    [Token(Token = "0x60192ED")]
    [Address(RVA = "0x2D02998", Offset = "0x2D02998", VA = "0x2D02998")]
    private void OnPlayVoice()
    {
    }

    [Token(Token = "0x60192EE")]
    [Address(RVA = "0x2D02A80", Offset = "0x2D02A80", VA = "0x2D02A80")]
    public Adv2LogScrollCell()
    {
    }
  }
}
