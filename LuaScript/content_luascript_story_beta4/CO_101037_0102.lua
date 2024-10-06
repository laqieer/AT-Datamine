-- このluaスクリプトは、CO_101037_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookAtWeight = {1.0, 0.08, 0.7, 0.6}
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	open_select_window_tag(Actor001,"Normal","CO_101037_01020002","CO_101037_01020003","CO_101037_01020004")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:見つけた<br>おーい、ラシア！落とし物！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020006")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:…あっ、私の靴！<br>持ってきてくれたんですか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020008")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:はい<br>次は脱げないように気を付けてな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:ありがとう…<br>うう…恥ずかしい…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お姫様<br>お忘れになった靴をお持ちいたしましたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020013")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:えっ！？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020014")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれ？<br>俺、なんか変なこと言ったかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020015")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:う、ううん<br>こっちのことです、こっちのこと
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ラシア★★:それよりも<br>授業中だったのにわざわざありがとう
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020017")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ヴェルナルス先生に<br>すぐ届けて来いって言われたからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020018")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:えっ？そうなんですか<br>ヴェルナルス様にもお礼を言っておかないと
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はいこれ、忘れ物<br>意外にそそっかしいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020021")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:あ、ありがとう…<br>だっていつもは、その…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020022")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020023")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:い、いえ！<br>なんでもありません
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020024")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:靴が脱げたのに気づかないなんて…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020026")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ラシア★★:ああ、もう！<br>自分のそそっかしさが本当にイヤになります
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020027")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:靴を忘れて行っちゃう女の子の物語が<br>あったよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:その女の子は遅刻したり<br>教室を間違えたりします？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020031")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、さすがにそこまではしないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020032")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ラシア★★:…そろそろ教室に行かないと<br>靴、ありがとうございました！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01020034")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、それじゃまた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020035")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor002)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの女の子の物語<br>どんな内容だったっけ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01020037")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ1_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
lookAtWeight = {1.0, 0.08, 0.7, 0.6}
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
