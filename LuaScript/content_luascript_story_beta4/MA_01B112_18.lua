-- このluaスクリプトは、MA_01B112_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111021_01","111021_01_h")
Include("content_adv_advsmall_111021_01","Template111021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111021_01,CameraPos111021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111021_01,CameraPos111021_01_005)
	InitializeTemplateRandomCamera111021_01()
	InitializeTemplate111021_01()
-- ▼直接出力
set_enable_auto_lookat_all(enable)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:ペレス王は<br>釣りをしている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180002")


	--★★ランスロット★★:ギネヴィア殿下とマーリン様を餌に<br>俺たちを釣ろうとしているんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…聖杯は手に入れた<br>だけどぺレスは悠長に聖杯城で籠城している
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180004")


	--★★ノワール★★:聖杯による奇跡が起これば<br>自身を含めたバルバロイは一掃されるというのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:聖杯を奪いに来る素振りもないな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180007")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まるで今のままじゃ<br>奇跡は起きないことを知ってるかのように
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180008")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯の力を解放するには<br>………妖精の命が必要なんだな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")

	--★★ノワール★★:父さんはそのために──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180012")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺を継承者にするために<br>『妖精殺し』の咎を被った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180013")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")

	--★★ノワール★★:父さんの想いがどうであれ<br>継承者が聖杯で奇跡を起こすには妖精が必要…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_180016","MA_01B112_180017","MA_01B112_180018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺も妖精を殺す必要があるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:奇跡には代償が必要だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180021")

	change_face(Actor001,"Sad")

	--★★ノワール★★:父さんもそうやって<br>『妖精殺し』になった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな妖精はどこにいる…？<br>妖精ニニアンがいない今、どこに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:すぐにわかる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180025")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ほかに…いるのか、妖精が…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:聖杯を解放するためには妖精殺しが必要…<br>という真実は誰も知らないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:広く知られれば妖精が狙われる<br>妖精と深く接した者以外は知らない真実だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180029")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…父さんもあんたも<br>口を閉ざして言わないわけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_180030")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが妖精は、いる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:…王のもとで護られてきた妖精が
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:だから我らは<br>餌に喰いつかざるを得ない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_180035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
