-- このluaスクリプトは、CO_101026_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114051_01","114051_01_h")
Include("content_adv_advsmall_114051_01","Template114051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_003)
	InitializeTemplateRandomCamera114051_01()
	InitializeTemplate114051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114051)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディンドランさん、どこに行ったんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09030002")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,118.5,0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:そもそも義姉さんは<br>なぜひとりでこの森に入ったんだ！？<br>
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030003")

	open_select_window_tag(Actor001,"Normal","CO_101026_09030005","CO_101026_09030006","CO_101026_09030007")
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
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひょっとして<br>例の抜け道の場所がわかったとか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09030009")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:抜け道の場所がわかったというのは<br>考えられない話じゃないが
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:もしそれなら真っ先に<br>ボクに教えてくれるはずだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:詳しくはわからないけれど<br>ひとつだけ確かなことがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09030013")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:ひとつだけ確かなこと？<br>それはなんだい、教えてくれないか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:パーシヴァルのためを思っての行動だろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09030015")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:パーシヴァルの身に危険が及ばないよう<br>ディンドランさんがひとりで動いた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09030016")

	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:………
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "納得")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:そうだろうね。まったく…<br>いつまでも弟離れできない義姉で困るよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:パーシヴァルがわからないなら<br>俺にもわからないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09030020")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:それはそうだろうけどさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:はあ。ボクの見込み違いだったよ<br>キミはなにしについてきたんだい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030022")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:このあいだの地図で行っていなかった場所<br>義姉さんはそこを目指しているはずだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030024")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,230,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Greet_one")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:こっちだノワール<br>ついてきてくれ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09030025")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ9_4")
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
	load_area_scene_preload(114051)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
