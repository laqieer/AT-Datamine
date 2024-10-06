-- このluaスクリプトは、CO_101032_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001,0.8, 0.3, 0.6, 0.3,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
lookat_delay_weight(Actor002,0.8, 0.3, 0.6, 0.3,0.8)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:しっ！ノワール、静かに！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:？どうしたんだ、いきなり
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010009")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor002,0.8)
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:あそこにいる生徒たちの話気にならないか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010010")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？「人生最後に食べたい料理はなに？」…か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:すごく興味深い話題だと思うんだ～♪続きを聞いてみよう！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010012")

	change_face(Actor002,"Normal")

	--★★ガレス★★:ふむふむ…パスタにシチュー、カレーにパンか…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010013")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:なるほど、いろんな意見があるんだな～♪これは食堂のメニューの参考になりそうだ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ガレスはいつでも新しいメニューのことを考えてるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor002, 1.0, 0.3, 0.6, 0.2,0.8)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力

	--★★ガレス★★:まあね～♪皆の胃袋を掴むためには常日頃からの努力が必要不可欠なのだ！！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:ちなみに、ノワールだったらなにを選ぶんだ？人生最後に食べたい料理♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010017")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そうだなぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_00010019","CO_101032_00010020","CO_101032_00010021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ガレスの料理かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010023")

-- ▼直接出力
PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:おおっ！？わたしの料理を選んでくれるのか！？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010024")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:この前食べたハンバーグセットも最高だったガレスの料理は本当に美味しいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:えへへ～♪ありがとなっ♪そう言ってもらえると料理人冥利に尽きるぞ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ…けど人生最後の食事には向かないかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010027")

	change_face(Actor002,"Surprise")

	--★★ガレス★★:なんでだ？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010028")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:きっともう１回食べたくなっちゃうだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:あははっ！<br>じゃあ、これからもわたしの料理を食べて
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010030")

	change_face(Actor002,"Smile")

	--★★ガレス★★:ずっとずっと元気でいてくれ、ノワール♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだなぁ…ディナタンの作った弁当かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010034")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:なるほど～！確かにディナタンの弁当はノワールへの愛情がモリモリだからな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010035")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:あらためてそう言われると恥ずかしいけど……まぁ、そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:うんうんディナタンもきっと喜ぶと思うぞ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010037")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:兄妹が仲良くご飯を食べてるのはわたしも嬉しい！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:そうだ。あとでディナタンにお弁当の献立を考えるコツを教えてもらおう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010039")

	change_face(Actor002,"Smile")

	--★★ガレス★★:『妹が兄さんを喜ばせるランチセット』新メニューができそうだ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:よ～し！さっそく明日作って<br>兄さんに試食してもらおうっと♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:（人生最後に食べる料理の話のはずが明日の昼飯の話にすり替わっている…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101032_00010042")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん…なんでもいいかなぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:ええ～？つまんない答えだな～
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010046")

	change_face(Actor002,"Sad")

	--★★ガレス★★:そういうのが一番困るんだぞ？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010047")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そう言われても<br>本当になにも思いつかないんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:人生最後の食事だったら、なにを食べるかより<br>誰と食べるかのほうが大事な気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_00010049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:なるほど～確かに、それはそうかもしれないな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_00010050")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ガレス")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
