-- このluaスクリプトは、EA_014_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_02","110901_02_h")
Include("content_adv_advsmall_110901_02","Template110901_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110901_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110901_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110901_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110901_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110901_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_003)
	InitializeTemplateRandomCamera110901_02()
	InitializeTemplate110901_02()
-- ▼直接出力
poster = setup_prop_object(10130034)
set_pos(poster, {-6.44,2.034,1.171})
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
INIT_CHRPOS(Actor002,{-3.261,0,-3.11,0},false)
INIT_CHRPOS(Actor001,{-2.781,0,-3.94,0},false)
load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005, {-5.417,0,0.1})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ディナタン★★:これは私と兄さんが<br>学園に入学して間もない頃に起きた
	Talk(Actor001,"CHRNAME_DINATAN","narration","N","EA_014_0010002")


	--★★ディナタン★★:ひとりのアイドルとの<br>とても素敵でちょっぴり不思議な邂逅のお話
	Talk(Actor001,"CHRNAME_DINATAN","narration","N","EA_014_0010004")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_EA_004_052_Crowds_Loop")
setup_small_camera_start(RndCamera002)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.8)
setup_small_camera_start()
wait_time(0.2)
PlayActionDirect(Actor005,"to  Std_Joy")
wait_time(0.5)
PlayActionDirect(Actor008,"to  Std_Surp")
play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
wait_time(0.3)
PlayActionDirect(Actor004,"to  Std_Worry")
PlayActionDirect(Actor007,"to  Std_Joy")
IN_WALK_2P(Actor002,CharaPos110901_02_007,Actor001,CharaPos110901_02_008)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_Loop_Stop")
turn_lookat( Actor002,Actor003, 0.3)
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor008,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:みんな、なにしてるんだ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_014_0010011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_lookat( Actor003,Actor002, 0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to Finger")
PlayPartVoiceDirect("ウレリー","0045")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ウレリー★★:ああ、ノワールくんにディナタンちゃん<br>教えてあげに行かなきゃと思ってたんだよ！
	Talk(Actor003,"CHRNAME_URRIE","speech","L","EA_014_0010012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:い、いつもありがとうございます
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_014_0010014")

	change_face(Actor002,"Normal")

	--★★ノワール★★:それで？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_014_0010016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0036")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ウレリー★★:あのね。これからの戦いに向けて<br><ruby=みんな>ログレス軍</ruby>の士気を高めるべく
	Talk(Actor003,"CHRNAME_URRIE","speech","L","EA_014_0010018")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ウレリー★★:<ruby=ライヴ>野外音楽会</ruby>が開かれるんだって<br>主催はアーサー様！協賛はローマ大帝国！
	Talk(Actor003,"CHRNAME_URRIE","speech","L","EA_014_0010020")

-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0037")
-- ▲直接出力

	--★★ウレリー★★:<ruby=このまち>ログレス王国</ruby>だけじゃなく海の向こうからも<br>たくさんのアーティストがやってきて
	Talk(Actor003,"CHRNAME_URRIE","speech","L","EA_014_0010022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0006")
-- ▲直接出力

	--★★ウレリー★★:<ruby=きょうしんどうはく>驚心動魄</ruby>な歌や<br><ruby=かんかんこうき>観感興起</ruby>な踊りを披露してくれるそうだよ！
	Talk(Actor003,"CHRNAME_URRIE","speech","L","EA_014_0010024")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:驚心どう…？<br>ええっと…？？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_014_0010027")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0024")
-- ▲直接出力

	--★★ウレリー★★:<ruby=アート>芸術</ruby>は<ruby=エモーション>心に刺激</ruby>をくれるからね！<br>くゥ～、このニュースを聞くだけで士気アガる！
	Talk(Actor003,"CHRNAME_URRIE","speech","L","EA_014_0010028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:落ち着け<br>落ち着いてくれ、ウレリー
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_014_0010031")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:野外音楽会…<br>歌…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_014_0010032")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0002")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:あの、ウレリーさん<br>その野外演奏会って私も参加していいんですか？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_014_0010034")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor003, {1.0, 0.08, 0.5, 0.3} , 1.0)
PlayPartVoiceDirect("ウレリー","0005")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ウレリー★★:もちろん！<br>ログレスに暮らす者なら入場料無料の大歓迎！
	Talk(Actor003,"CHRNAME_URRIE","speech","L","EA_014_0010035")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_lookat( Actor001,Actor002, 0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to  Std_Joy")
PlayPartVoiceDirect("ディナタン","0012")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:やった！いっしょに行こうよ<br>兄さん、ウレリーさん！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_014_0010036")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor003,"Smile")
play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
lookat_delay_weight(Actor002, {1.2, 0.03, 0.4, 0.3} , 1.0)
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
wait_time(1.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130034)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
