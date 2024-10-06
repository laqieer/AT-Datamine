-- このluaスクリプトは、CO_101026_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera003 = SetTemplate("Actor003",-58,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
turn_chara(Actor001,132.608,0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, Actor003, "J_Head")
lookat_delay_weight(Actor002,0.8,0.08,0.4,0.2,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力

	--★★パーシヴァル★★:遅れてすまない、ケイ<br>それで要件とはなんだい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020002")

-- ▼直接出力
PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:わざわざすまんな、ふたりとも
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:火急の要件というわけではないのだが<br>聖杯探索の一環としてやっておきたいことがある
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:やっておきたいこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_05020005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:ブリテン島の東部に『果てなき森』と呼ばれる<br>広大な森があることは知っているか？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020006")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:…もちろん
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "納得")
-- ▲直接出力

	--★★ケイ★★:あの森にはかつて<br>妖精たちが隠れ住む里があったとされる
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020009")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:あるときバルバロイに襲われ<br>妖精たちは皆、息絶えてしまったそうなんだが
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020010")


	--★★ケイ★★:実は<br>あの森には妖精だけが知る抜け道があるそうで
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:何人かの妖精はどこか別の場所に逃げ延びている<br>という噂があるんだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020012")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:お前たちふたりで<br>この真相を調べてきてもらえないだろうか
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それは構わないけど<br>どうして俺たちふたりなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_05020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力

	--★★ケイ★★:最近仲が良いと聞いたものでな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_05020018","CO_101026_05020019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:仲が良い…というのかはわからないけど<br>確かに最近一緒にいることは多いな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_05020021")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ノワールはボクの付き人のひとりだからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:なんだかよくわからんが<br>同じ円卓の騎士だ。仲良くやってくれ！ 
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:仲が良いといわれるのは心外だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_05020025")

-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight(Actor002,1.1,0,0.4,0.3,1)
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:なにか言ったかい？付き人クン
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020026")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:やれやれ。同じ円卓の騎士だろう？<br>ケンカなどせずに仲良くやりたまえ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020027")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:仲が良いか悪いかはともかくとして
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:円卓の騎士のなかでも特に優秀なボクに<br>白羽の矢が立つのは当然だね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:うむ。円卓の騎士のなかでも<br>パーシヴァル以上にあの森に詳しい者はいない
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そこまでなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_05020032")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:…ボクはあの森のそばで生まれ、育ったからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020033")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力

	--★★パーシヴァル★★:ただね、ケイ<br>森での調査だけならばボクひとりで十分だ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020035")


	--★★パーシヴァル★★:ノワールと一緒に行動しなければならない<br>理由を教えてくれないか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020036")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ケイ★★:付き人なんだろう？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020038")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:それはまあ、そうなんだが…！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:すまんすまん、冗談だよ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020040")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ケイ★★:ノワールが妖精について調べていると聞いて<br>ついでにと思ってな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そういうことだったのか、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_05020042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:各々の都合もあるだろうが<br>折を見て動いてもらえると助かる
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_05020043")

	open_cutin(1,1)
	on_cutin(1,Actor003,"Normal")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:では、スタンド・バイ・ユア・ラウンド！
	Talk(Actor003,"CHRNAME_KAY","speech","N","CO_101026_05020044")

	close_cutin()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:フォー・ラウンド！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_05020045")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力

	--★★パーシヴァル★★:…フォー・ラウンド
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_05020046")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ5_3")
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
