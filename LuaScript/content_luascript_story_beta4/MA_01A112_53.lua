-- このluaスクリプトは、MA_01A112_53.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{-10,0,10})
DontChangeRandomCamera(true)
set_pos(Actor001,{-3,0,-3})
set_rot(Actor002,{0,60,0})
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
-- 背景移動回転スケール
local bg = get_object("BG")
set_pos(bg,{-10,0,10})

-- 固定モブ移動回転スケール
local pro = get_object("Pro_1101_45")
set_pos(pro,{-10,0,10})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115113)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("子供_男1", "肯定")
-- ▲直接出力

	--★★子供（男）★★:さびしいけどね<br>もう大丈夫なんだ
	Talk(Actor003,"NPCNAME_0140","speech","N","MA_01A112_530002")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("子供_女1", "笑い")
-- ▲直接出力

	--★★子供（女）★★:お祭りで大騒ぎしたり<br>お友達とお話してたらね、へーきなの！
	Talk(Actor004,"NPCNAME_0141","speech","N","MA_01A112_530003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:お祭り…できてよかったですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530004")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）②★★:でも、いいのかな
	Talk(Actor005,"NPCNAME_0142","speech","N","MA_01A112_530005")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:なにがです？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530006")


	--★★子供（男）②★★:楽しんで、いいのかな
	Talk(Actor005,"NPCNAME_0142","speech","N","MA_01A112_530007")

	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）②★★:つらいこと…<br>忘れて笑って、いいのかな
	Talk(Actor005,"NPCNAME_0142","speech","N","MA_01A112_530008")

	change_face(Actor002,"Normal")

	--★★エレイン★★:楽しまなきゃ、いけません
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530010")

	PlayAction(Actor002,"to  Std_No")

	--★★エレイン★★:生きている人たちが<br>自分の生を否定してはいけない
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:生きているからこそ口を開き<br>楽しいと叫び、喜びを分かち合うことができる
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:きっと、いなくなってしまった人たちも<br>そんなあなたたちの平和だけを願っているはずです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530013")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:そうかな
	Talk(Actor005,"NPCNAME_0142","speech","N","MA_01A112_530014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:そう…信じましょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★エレイン★★:自分を育ててくれた誰かは<br>必ず自分を想ってくれているはずだと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530016")


	--★★エレイン★★:そんな素敵な人がいたんだと<br>目いっぱい寂しさみしがって、思い出し続けましょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530017")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…どうしました？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530019")

-- ▼直接出力
 --PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）②★★:おねえさん、カオのキズ──…
	Talk(Actor005,"NPCNAME_0142","speech","N","MA_01A112_530020")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("エレイン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:あっ、ああっ、ごめんなさい忘れてた<br>怖がらせてしまいましたね、ごめんなさい
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530022")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("子供_男2", "否定")
-- ▲直接出力

	--★★子供（男）②★★:ううん、ぜんぜんこわくないよ<br>だってずーっとやさしいもん
	Talk(Actor005,"NPCNAME_0142","speech","N","MA_01A112_530024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★子供（男）②★★:ぜんぜん、変わんないもん
	Talk(Actor005,"NPCNAME_0142","speech","N","MA_01A112_530026")

	change_face(Actor002,"Surprise")

	--★★エレイン★★:………っ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530027")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:…そこが、おねえさんのイイところなんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530029")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Greet_one")
PlayActionDirect(Actor004,"to Greet_one")
PlayActionDirect(Actor005,"to  Std_Joy")
-- ▲直接出力

	--★★子供たち★★:またね、おねえさん！！
	Talk(Actor006,"NPCNAME_0144","speech","N","MA_01A112_530031")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Greet_one")
fadeout(0,0,0,1.0,2)
wait_time(4)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Appear(Actor001)
PlayActionDirect(Actor002,"to Std_Loop")
change_face(Actor002,"Normal")
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0,0,0,0)
setup_small_camera_start(RndCamera001)
fadein(CHARA_IN_OUT)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{-1.8,0,0},2)
wait_time(1.7)
turn_chara(Actor001,-40,0.5)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:…『おねえさん』ですって、私
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002,0.5,0.03,0.7,0,0.7)
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:『おにいさん』の<br>ご指導のおかげでしょうか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_530035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102012)
	InitializeLoad_Preload()
	load_area_scene_preload(115113)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
