-- このluaスクリプトは、MA_01A110_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",80,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera005 = SetTemplate("Actor005",-50,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, Actor005, "J_Head")
lookat_delay_weight(Actor002, {1.0, 0.08, 0.5, 0.6} , 1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★エレイン★★:「死ぬことは禁じます」
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_410002")


	--★★エレイン★★:「飾ることなくお願いします<br>悪虐の王を討ち果たす力となってください」
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_410003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera004)
turn_chara(Actor001, 0, 0)
turn_chara(Actor005, 12, 0)
 --PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力

	--★★マルディサント★★:…はい、ＯＫ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:全ッ然面白くはねえが<br>見ごたえはあるぜ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410006")

-- ▼直接出力
keep_ik_lookat(Actor003,Actor004,"J_Head")
lookat_delay_weight(Actor003, {1.0,0.08,0.5,0.6} , 1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ディナタン★★:ま、マァル～～～っ…！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_410007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 0.6)
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:いえ、一理あるわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_410008")

-- ▼直接出力
lookat_delay_weight_reset(Actor003 , 0.6)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ギネヴィアさん中途半端に感化されないで！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_410009")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:いーか、エレイン
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410010")


	--★★マルディサント★★:アンタの恥を舞台にさらせ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:物理的なもんじゃねえぞ<br>脱げとかトラウマさらせとかそーゆーんじゃねえ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410013")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力

	--★★マルディサント★★:相手役が想い人だったらどうか<br>アンタの内側はどう反応するのか、見極めろ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410014")


	--★★マルディサント★★:アンタ自身がもっとも心動く瞬間を見逃すな<br>そして眼前の相手を動かせ、響かせろ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:アンタの恥を台詞に換えろ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410017")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:ま、マァル…<br>なに言ってるかちょっとわかんない…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_410018")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定3")
-- ▲直接出力

	--★★エレイン★★:頑張ります！<br>頑張らせていただきます！！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_410019")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:いい返事だッッ！！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410020")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:ありがとうございますッッ！！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_410021")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:フッ<br>楽しみね、本番が
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_410023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:演技って深いなぁ…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_410025")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力

	--★★マルディサント★★:オニーサンもな！！<br>木の生い立ちから未来への人生設計まで考えろ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_410026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:木なのに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_410027")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,-85,0.5)
wait_time(0.5)
PlayActionDirect(Actor005,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "激怒")
-- ▲直接出力

	--★★エレイン★★:先輩！！<br>役に小さいも大きいもないんですよッッ！！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_410028")

	open_cutin(2,2)
	on_cutin(1,Actor002,"Anger")
	on_cutin(2,Actor004,"Anger")

	--★★ギネヴィア／マルディサント★★:演技ナメんなッッ！！！！
	Talk(Actor006,"CHRNAME_GUINEVERE_MALADISANT","speech","N","MA_01A110_410029")

	close_cutin()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:アツいなあ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_410030")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
