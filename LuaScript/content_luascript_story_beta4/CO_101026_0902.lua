-- このluaスクリプトは、CO_101026_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera002 = SetTemplate("Actor002",-160,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:あら、ノワールちゃんにパーシヴァルちゃん<br>今日はどんなご用かしら？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101026_09020002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ディンドランさんをさがしてるんだ<br>どこに行ったかわかるかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09020003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:ディンドランなら今日は休みをとって<br>どこかの森に行くって言ってたわよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101026_09020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★パーシヴァル★★:どこかの森だって…？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_09020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_09020007","CO_101026_09020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_delay_weight(Actor001,1.0,0,0.5,0.35,1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なあ、パーシヴァル<br>なにかイヤな予感がしないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09020010")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "納得")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:…残念ながらその予感はあたっているようだ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_09020011")

	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:マスターのボクはおぼろげに感じる
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_09020012")

-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_delay_weight(Actor003,1.0,0,0.5,0.35,1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:義姉さんはあの森に行っている
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_09020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_delay_weight(Actor001,1.0,0,0.5,0.35,1.0)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディンドランさんはいつ来てもここにいるし<br>たまには休みをとったほうがいいよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09020015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:呆れるね。どうしたら<br>そんな呑気な考えに至るのやら
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_09020016")

-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_delay_weight(Actor003,1.0,0,0.5,0.35,1.0)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:この状況で義姉さんが行く森なんて<br>あそこしかないだろう？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_09020017")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
lookat_delay_weight_reset(Actor003 , 0.6)
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:果てなき森に生息するバルバロイが<br>このあいだ倒したものですべてとは思えない
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_09020019")

-- ▼直接出力
wait_time(0.8)
lookWeight = {0.7, 0, 0.7, 0.35}
lookat_delay_weight(Actor003, lookWeight,1)
keep_ik_lookat(Actor003, Actor001, "J_Head")
-- ▲直接出力

	--★★パーシヴァル★★:…ノワール、ついてきてくれるか？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_09020020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、もちろんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09020021")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ9_3")
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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
