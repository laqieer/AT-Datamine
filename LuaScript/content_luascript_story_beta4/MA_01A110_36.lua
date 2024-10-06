-- このluaスクリプトは、MA_01A110_36.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",80,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	Camera002 = SetTemplate("Actor002",-80,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera005 = SetTemplate("Actor005",-64,CharaPos110011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_008)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
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
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "否定")
-- ▲直接出力

	--★★ギネヴィア★★:「死ぬことは禁じます」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_360002")


	--★★ギネヴィア★★:「飾ることなくお願いします<br>悪虐の王を討ち果たす力となってください」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_360003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera004)
turn_chara(Actor001, 0, 0)
turn_chara(Actor002, -5, 0)
 --PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力

	--★★マルディサント★★:…はい、ＯＫ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マルディサント★★:悪かねえぜ王女様！！<br>芝居に血が通ったって感じがする！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ありがとうございます！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_360007")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:いーか！ギネヴィアァッッ！！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360008")


	--★★マルディサント★★:虚飾をリアルに見立てろ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360010")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:相手役が想い人だったらどうか！<br>アンタのハートは動くのか！どう動くのか！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360011")


	--★★マルディサント★★:アンタ自身がもっとも心動く瞬間を見逃すな！<br>そして眼前の相手を動かせ！響かせろ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "気合い")
-- ▲直接出力

	--★★マルディサント★★:アンタのリアルを台詞に換えて！！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360014")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ま、マァル！トバし過ぎ！<br>なに言ってるかちょっとわかんないし！！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_360015")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:やりますッ！！やらせてくださいッ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_360016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:いい返事だッッ！！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:ありがとうございますッッ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_360018")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★エレイン★★:いい作品ができそうですね…！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_360020")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:演技って深いなぁ…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_360022")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力

	--★★マルディサント★★:オニーサンもな！！<br>木の生い立ちから未来への人生設計まで考えろ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_360023")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:木なのに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_360024")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor005)
keep_ik_lookat(Actor005,Actor001,"J_Head")
lookat_weight(Actor005,1.2,0.5,0.6,0.35)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.6)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "激怒")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★エレイン★★:先輩！！<br>役に小さいも大きいもないんですよッッ！！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_360025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	open_cutin(2,2)
	on_cutin(1,Actor002,"Anger")
	on_cutin(2,Actor004,"Anger")

	--★★ギネヴィア／マルディサント★★:演技ナメんなッッ！！！！
	Talk(Actor006,"CHRNAME_GUINEVERE_MALADISANT","speech","N","MA_01A110_360026")

	close_cutin()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:アツいなあ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_360027")

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
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
