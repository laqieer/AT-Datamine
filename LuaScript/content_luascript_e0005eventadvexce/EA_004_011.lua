-- このluaスクリプトは、EA_004_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",265,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera002 = SetTemplate("Actor002",115,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera003 = SetTemplate("Actor003",105,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera004 = SetTemplate("Actor004",200,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_008)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
lookat_weight(Actor004,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{8.14,0.0,-3.68})
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{7.2,0.0,-4.4})
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{9.66,0.0,-4.32})
Hide(Actor007)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101054","005","101054005","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:未曽有の事態だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0110003")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","落胆")
-- ▲直接出力

	--★★ケイ★★:いや、それはもうここ最近ずっとそうだが…<br>もはや未曾有の事態が常態化しているが…
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0110004")


	--★★ケイ★★:実に由々しきことだが…教師一同一丸となって<br>学園体制の再編に取り組んでいるわけだが…
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0110005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:………つまり？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ケイ★★:つまりこの期に及んで学園祭をと言われても<br>人手不足で困るという話だ！
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0110008")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_004_0110009")


	--★★マーリン★★:ランスロット様も円卓の騎士としての務めで<br>授業どころではないでしょうしね
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_004_0110010")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット★★:そうだな…<br>不甲斐ないことだが
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0110011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、さすがにこの状況で<br>不甲斐ないとか思わないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、なんで俺を呼んだんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110013")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！まさか、俺にも教師をやれって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","怒り")
-- ▲直接出力

	--★★ケイ★★:さすがにそこまで血迷ったりはせん！
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0110017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マーリン","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:臨時教師を迎え入れることにしたのです<br>その方をノワール様にご紹介したくて
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_004_0110018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:臨時教師？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110019")

-- ▼直接出力
CloseTalkWindow()
on_active(Actor005)
on_active(Actor006)
on_active(Actor007)
PlayActionDirect(Actor005,"to Wlk")
PlayActionDirect(Actor006,"to Wlk")
PlayActionDirect(Actor007,"to Wlk")
turn_lookat_position(Actor005,CharaPos110051_01_005[1],CharaPos110051_01_005[2],CharaPos110051_01_005[3],0)
turn_lookat_position(Actor006,CharaPos110051_01_006[1],CharaPos110051_01_006[2],CharaPos110051_01_006[3],0)
turn_lookat_position(Actor007,9.5,0,-1.67,0)
slidemove(Actor005,CharaPos110051_01_005[1],CharaPos110051_01_005[2],CharaPos110051_01_005[3],2.0)
slidemove(Actor006,CharaPos110051_01_006[1],CharaPos110051_01_006[2],CharaPos110051_01_006[3],2.2)
slidemove(Actor007,9.5,0,-1.67,2.4)
wait_time(1.5)
if manager ~= nil then
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor005)
DontChangeRandomCamera(true)
end
wait_time(0.5)
turn_chara(Actor005,CharaPos110051_01_005[4],0.3)
turn_chara(Actor005,0,0.3)
wait_time(0.2)
turn_chara(Actor006,CharaPos110051_01_006[4],0.3)

wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
turn_chara(Actor007,320,0.3)
wait_time(0.2)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.1)
PlayActionDirect(Actor007,"to Std_Loop")
set_enable_auto_lookat(Actor006, false)
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
-- ▼直接出力

turn_chara(Actor002,140,0.0)
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_ik_lookat(Actor003,Actor005,"J_Head")
keep_ik_lookat(Actor004,Actor005,"J_Head")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アダン","肯定2")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★アダン★★:
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0110026")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あんたは…<br>臨時教師って、銀卓騎士のことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110027")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:俺からコルベニック城に申し入れた<br>アダン卿なら教師としての資質に不足はない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0110028")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そっちのふたりは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110029")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アダン★★:
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0110030")


	--★★アダン★★:エクセリアとリリアーナにも<br>勉強をさせてやりたいと思い、連れて参りました
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0110031")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アダン","肯定2")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★アダン★★:勝手を申し上げて恐縮ではありますが<br>何卒よろしくお願いいたします
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0110032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:勝手だなんて、そんな<br>こちらこそよろしくお願いします
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110034")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:本来なら試験などスキップして即採用<br>といきたいところだが…
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0110036")

	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
PlayPartVoice("アダン","否定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アダン★★:それはいけない<br>自分の教員としての力量を見ていただかねば
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0110037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:…というのでな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0110038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なるほど。俺にやってほしいことってのは<br>採用試験官役ってわけだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0110039")

-- ▼直接出力
PlayPartVoice("アダン","肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★アダン★★:何卒お手柔らかに
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0110041")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
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
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101054","005","101054005","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
