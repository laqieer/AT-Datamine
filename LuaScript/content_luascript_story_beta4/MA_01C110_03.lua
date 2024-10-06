-- このluaスクリプトは、MA_01C110_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_002)
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
-- ▼直接出力


-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ここは――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030002")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:森…？なんでこんなところに…<br>みんなは…アーサーは、どうしたんだ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:クソッ…早く戻らないと！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力

	--★★ディナタン★★:兄さん、落ち着いて<br>周りを見てみてよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_030005")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:周り…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030006")

-- ▼直接出力
setup_small_camera_start()
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:こんな木、ログレスの周りで見たことない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:うん…<br>もしかして私たち、すごく遠くに来たのかも
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_030009")


	--★★ディナタン★★:そう、誰かに…呼ばれて――
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_030010")


	--★★ノワール★★:呼ばれた…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030011")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰が、どうやって、なんの目的で<br>俺たちをここに呼んだんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030012")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "否定")
-- ▲直接出力

	--★★ディナタン★★:それは、わからないけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_030013")

-- ▼直接出力
setup_small_camera_end()
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…この木、どこかで…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_030015")


	--★★ノワール★★:ディナタン<br>この場所を知っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030016")

	PlayAction(Actor002,"to  Std_No")

	--★★ディナタン★★:来たことはないと思うんだけど…でも…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_030017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:？<br>とりあえず少し休んだら出発しよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030018")


	--★★ノワール★★:みんなを助ける方法を見つけて<br>ログレスに戻らないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_030019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:う、うん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_030020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
