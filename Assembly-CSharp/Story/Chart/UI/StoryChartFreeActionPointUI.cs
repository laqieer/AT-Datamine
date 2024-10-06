// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.StoryChartFreeActionPointUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x20006F6")]
  public class StoryChartFreeActionPointUI : MonoBehaviour
  {
    [Token(Token = "0x40020BA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryChartFreeActionPointUI.Icon moon;
    [Token(Token = "0x40020BB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StoryChartFreeActionPointUI.Icon sun;
    [Token(Token = "0x40020BC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject cursol;
    [Token(Token = "0x40020BD")]
    [FieldOffset(Offset = "0x30")]
    private StoryChartFreeActionPointUI.Icon current;

    [Token(Token = "0x600276D")]
    [Address(RVA = "0x366E694", Offset = "0x366E694", VA = "0x366E694")]
    public void Moon()
    {
    }

    [Token(Token = "0x600276E")]
    [Address(RVA = "0x366E720", Offset = "0x366E720", VA = "0x366E720")]
    public void Sun()
    {
    }

    [Token(Token = "0x600276F")]
    [Address(RVA = "0x366E760", Offset = "0x366E760", VA = "0x366E760")]
    public void Highlight(bool highlight)
    {
    }

    [Token(Token = "0x6002770")]
    [Address(RVA = "0x366E7D0", Offset = "0x366E7D0", VA = "0x366E7D0")]
    public void Deactivate()
    {
    }

    [Token(Token = "0x6002771")]
    [Address(RVA = "0x366E810", Offset = "0x366E810", VA = "0x366E810")]
    public void Cursol(bool active)
    {
    }

    [Token(Token = "0x6002772")]
    [Address(RVA = "0x366E830", Offset = "0x366E830", VA = "0x366E830")]
    public StoryChartFreeActionPointUI()
    {
    }

    [Token(Token = "0x20006F7")]
    [Serializable]
    public class Icon
    {
      [Token(Token = "0x40020BE")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject normal;
      [Token(Token = "0x40020BF")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject passed;

      [Token(Token = "0x6002773")]
      [Address(RVA = "0x366E77C", Offset = "0x366E77C", VA = "0x366E77C")]
      public void Highlight(bool highlight)
      {
      }

      [Token(Token = "0x6002774")]
      [Address(RVA = "0x366E6D0", Offset = "0x366E6D0", VA = "0x366E6D0")]
      public void Deactive()
      {
      }

      [Token(Token = "0x6002775")]
      [Address(RVA = "0x366E838", Offset = "0x366E838", VA = "0x366E838")]
      public Icon()
      {
      }
    }
  }
}
