-- このluaスクリプトは、CO_101030_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {-0.48,0.12,24})
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,175,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101030","001","101030001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101031_sp_0001_1")
-- ▲直接出力

	--★★ラヴェイン★★:ノワール君キミをさがしていました
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:俺に話？エレインがいなくていいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07020003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:ええひとまず妹はいないほうがよいかと
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラヴェイン★★:トビーの父親のことがわかったんです
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020006")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:残念ながら…亡くなっていました
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020008")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to  Std_Surp")
change_face(Actor001,"Surprise")
wait_time(2)
setup_small_camera_end(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ラヴェイン★★:トビーの父親はローマ軍の兵士としてあのときの戦いに参加していたものの
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020010")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "落胆")
-- ▲直接出力

	--★★ラヴェイン★★:市民を守るべくバルバロイに立ち向かい命を落としたとのことです
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_07020013","CO_101030_07020014","CO_101030_07020015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:バルバロイに喰われたわけじゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07020017")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:目撃者がトビーの父親だったと証言しています忘れられてはいません
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020018")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:バルバロイにやられたものの喰われるまでには至らなかったようですね
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんな…！確かな情報なのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07020022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:はい目撃者からの証言です
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020023")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:誰かを守るために異形の化け物に立ち向かう…なかなかできることじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07020024")

	change_face(Actor001,"Sad")

	--★★ノワール★★:勇敢な兵士だったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07020025")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:このこと、エレインに聞かせたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07020027")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:いえ、まだです
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020028")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:知ったら自分のことのように悲しむだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07020029")

	change_face(Actor001,"Sad")

	--★★ノワール★★:できれば知らせたくはないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07020030")

	goto Block1end

::Block1end::
-- ▼直接出力
Appear(Actor002)
PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★エレイン2★★:本当なの、お兄ちゃん…？
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","CO_101030_07020032")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor001,0.5,0.1,0.8,0.2,1.0)
lookat_delay_weight(Actor003,0.5,0.1,0.8,0.2,1.0)
setup_small_camera_start(RndCamera090)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{-0.48,0.12,22},1.3)
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:本当です
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020034")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:トビーくんのお父さんが兵士って聞いたときから薄々予感はしていたの
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07020035")

-- ▼直接出力
setup_small_camera_start()
wait_time(0.5)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-85,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★エレイン★★:トビーくんに、伝えましょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07020037")


	--★★エレイン★★:どんなに辛く悲しいことがあっても乗り越えていかなきゃいけない
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07020038")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:強い自分に変わらなきゃ、って
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07020039")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101031_sp_0002_1")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラヴェイン★★:エレイン雰囲気が少し変わりましたね
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020041")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.5, 0.08, 0.8, 0.6} , 1) 
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:えっ？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07020042")

	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:人の目をまっすぐ見られるようになった
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力

	--★★ラヴェイン★★:ノワール君のおかげでしょうか
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020045")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:ちょ、ちょっとお兄ちゃん！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07020046")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
wait_time(1.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:先輩！遅くならないうちに出発しましょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07020047")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
se_play("SE_ADV_CO_101030_0303_Foot_2_Peaple")
turn_chara(Actor003,180,0.2)
wait_time(1.1)

Hide(Actor002)
Hide(Actor001)
lookat_weight_reset(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:行ってらっしゃい気を付けて、ふたりとも
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_07020049")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ7_3")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101030","001","101030001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
