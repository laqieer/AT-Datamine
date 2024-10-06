-- このluaスクリプトは、CO_101014_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_007)
	Camera002 = SetTemplate("Actor002",-70,CharaPos110061_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_006)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001, "J_Head")
keep_ik_lookat(Actor001,Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10103004)
-- ▲直接出力
-- ▼直接出力
prop001_offset = {-0.06, 0.01, 0,0,-0.6,-172}
-- ▲直接出力
-- ▼直接出力
on_parent(prop001,Actor002, "Loc_weapon_constrint_L", prop001_offset)
-- ▲直接出力
-- ▼直接出力
prop002 = setup_prop_object(10103005)
-- ▲直接出力
-- ▼直接出力
prop002_offset = {0.03,0.01,0,-171.7,-6.6,16.9}
-- ▲直接出力
-- ▼直接出力
off_active(prop002)
-- ▲直接出力
-- ▼直接出力
off_parent(prop002,Actor002, "Loc_weapon_constrint_L", prop002_offset)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:なんだ、用事って大図書院かちょっと前にも一緒に来たよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020002")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:好きにしたらいいって言ったボクが言うことじゃないけどさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020004")


	--★★トリスタン★★:なんでキミここまでついて来たの？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020005")

	open_select_window_tag(Actor001,"Normal","CO_101014_07020007","CO_101014_07020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:暇だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020010")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:へえ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★トリスタン★★:へええ～、そうそうなんだ～～～
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:じょ、冗談だよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だって俺たち友達だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020015")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:は？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020016")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:「なんで着いてきたの？」「友達だから」その理屈、ボクにはまったく理解できないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020018")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:いいよね、キミはいつも能天気でさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020019")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:本気で迷惑そうなら無理に着いてったりはしないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:さっきは好きにしろって言われたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020022")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクに着いて来るのそんなに楽しい？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:割と
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020024")


	--★★トリスタン★★:あ、そ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:いちいち気にしてるボクが馬鹿らしくなってきたよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020028")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:で、今日はなにしに来たんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:調べもの大図書院なんだから当たり前でしょ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020032")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:調べもの？なんの？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020033")


	--★★トリスタン★★:『ドラゴンと人の交わり』についてさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020034")

-- ▼直接出力
wait_time(0.5)
lookat_delay_weight_reset(Actor002 , 0.6)
prop001_offset = {-0.01, 0.01, 0.01,-3,-0.6,-173}
on_parent(prop001,Actor002, "Loc_weapon_constrint_L", prop001_offset)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to ReadLetter")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、その本！彼女たちも見つけられたのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:たぶんね。民俗学についての棚にあった<br>返却されてきたんだと思う
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020037")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
off_active(prop001)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
turn_chara(Actor002, -25,0)
setup_small_camera_start()
on_active(prop002)
off_parent(prop001,Actor002, "Loc_weapon_constrint_L", prop001_offset)
on_parent(prop002,Actor002, "Loc_weapon_constrint_L", prop002_offset)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力

	--★★トリスタン★★:これか。「今から昔。この世界には山ほどの大きさの巨大なドラゴンが棲息していた」
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020039")


	--★★トリスタン★★:「しかし、人間とそのドラゴンが共存していたという確証はない」
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020040")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:…だってさ<br>やっぱりね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020041")


	--★★トリスタン★★:あの大臣が言っていたような生贄の風習についてもあやしいもんだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020042")

	PlayAction(Actor002,"to Std_Loop")
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-70,0.2)
wait_time(0.2)
off_active(prop002)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
off_parent(prop002,Actor002, "Loc_weapon_constrint_L", prop002_offset)
wait_time(0.2)
prop001_offset = {-0.06, 0.01, 0, 0,-0.6,-172}
on_parent(prop001,Actor002, "Loc_weapon_constrint_L", prop001_offset)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ねえ、せっかくだしさ<br>もう１カ所付き合ってよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07020044")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:え？ああ、別にいいけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07020045")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ7_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10103004)
prop001_offset = {-0.06, 0.01, 0,0,-0.6,-172}
setup_prop_object_preload(10103005)
prop002_offset = {0.03,0.01,0,-171.7,-6.6,16.9}
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
