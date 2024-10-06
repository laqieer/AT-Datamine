-- このluaスクリプトは、MA_01A111_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor002,Camera002,EntryData110021_01_07,CameraAssetBundleName110021_01,CameraPos110021_01_107)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.5)
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力

	--★★アーサー★★:まずいことになったぞ、ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170002")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:この入りは見たことがあるぞ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:未曽有の危機だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170004")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:モルガン先生がボイコットしたという…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170005")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:耳が早いな！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:それで説得に向かうところか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:把握が早いな！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170008")

	open_select_window_tag(Actor001,"Normal","MA_01A111_170010","MA_01A111_170011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:がんばってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170013")

-- ▼直接出力
 --PlayPartVoice("アーサー", "苦しみ")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Surprise")
	change_face(Actor002,"Surprise")

	--★★アーサー★★:待って待って待ってくれノワール！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","N","MA_01A111_170014")

	on_cutin(1,Actor002,"Surprise")
	change_face(Actor002,"Normal")

	--★★アーサー★★:継承者！頼む継承者！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","N","MA_01A111_170015")

	open_cutin(1,1)
	on_cutin(1,Actor001,"Normal")
	change_face(Actor001,"Normal")

	--★★ノワール★★:都合よく継承者持ち出すな！！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01A111_170016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ついていこうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170018")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("アーサー", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:いや、悪いよノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、いってらっしゃい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170020")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("アーサー", "苦しみ")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Surprise")
	change_face(Actor002,"Surprise")

	--★★アーサー★★:いやいや違う違う！１回断っておいて<br>「遠慮するなよ」の言葉を待ってたんだよ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","N","MA_01A111_170021")

	on_cutin(1,Actor002,"Surprise")
	change_face(Actor002,"Normal")

	--★★アーサー★★:今のは俺が悪かった！<br>俺の駆け引きベタがあらわになった！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","N","MA_01A111_170022")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	close_cutin()
	change_face(Actor002,"Normal")

	--★★アーサー★★:どうにも義姉さんとは<br>最近うまくいかなくてな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170024")


	--★★アーサー★★:良ければ、助けて欲しい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:行くよ、もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170026")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:アーサー、あんたには助けられてばかりだ<br>モルガン先生にはディナタンが世話になってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170027")


	--★★ノワール★★:俺にも、助けさせて欲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_170028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:…ありがとう。ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170029")

	change_face(Actor002,"Normal")

	--★★アーサー★★:公務をケイ卿に押し付け次第すぐに出よう<br>５日後に、頼むよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170030")


	--★★アーサー★★:面倒をかけるな、いつも
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_170032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
